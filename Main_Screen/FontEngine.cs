using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace Brevi.Application
{
    public static class FontEngine
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static Font InterBase;
        public static FontFamily MaterialFamily;
        public static FontFamily InterFamily;

        public static void LoadFonts()
        {
            LoadFontFromResource(Properties.Resources.MaterialSymbolsOutlined);
            LoadFontFromResource(Properties.Resources.InterRegular);

            MaterialFamily = _pfc.Families.FirstOrDefault(f => f.Name.Contains("Material"))
                             ?? _pfc.Families[0];
            InterFamily = _pfc.Families.FirstOrDefault(f => f.Name.Contains("Inter"))
                          ?? _pfc.Families[0];

            InterBase = new Font(InterFamily, 10f, FontStyle.Regular);
        }

        private static void LoadFontFromResource(byte[] fontData)
        {
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            _pfc.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        public static void RetargetAllFonts(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                FixFont(c);

                if (c is Krypton.Toolkit.VisualControlBase kControl)
                {
                    var content = GetPropertyValue(kControl, "StateCommon")?.GetPropertyValue("Content");
                    if (content != null)
                    {
                        FixKryptonFont(content.GetPropertyValue("ShortText"));
                        FixKryptonFont(content.GetPropertyValue("LongText"));
                    }
                }

                if (c.HasChildren) RetargetAllFonts(c);
            }
        }

        private static void FixFont(Control c)
        {
            if (c.Font.Name.Contains("Material") || c.Font.Name.Contains("Symbols"))
                c.Font = new Font(MaterialFamily, c.Font.Size, c.Font.Style);
            else if (c.Font.Name.Contains("Inter"))
                c.Font = new Font(InterFamily, c.Font.Size, c.Font.Style);
        }

        private static void FixKryptonFont(object textPart)
        {
            if (textPart == null) return;
            var font = (Font)textPart.GetPropertyValue("Font");
            if (font == null) return;

            if (font.Name.Contains("Material") || font.Name.Contains("Symbols"))
                textPart.SetPropertyValue("Font", new Font(MaterialFamily, font.Size, font.Style));
            else if (font.Name.Contains("Inter"))
                textPart.SetPropertyValue("Font", new Font(InterFamily, font.Size, font.Style));
        }
        public static void RetargetPalette(Krypton.Toolkit.KryptonCustomPaletteBase palette)
        {
            var content = palette.ButtonStyles.ButtonStandalone.StateCommon.Content;

            if (content.ShortText.Font.Name.Contains("Material") || content.ShortText.Font.Name.Contains("Symbols"))
            {
                content.ShortText.Font = new Font(MaterialFamily, content.ShortText.Font.Size, content.ShortText.Font.Style);
            }

            content.LongText.Font = new Font(InterFamily, content.LongText.Font.Size, content.LongText.Font.Style);
        }
        private static object GetPropertyValue(this object obj, string propName) =>
            obj?.GetType().GetProperty(propName)?.GetValue(obj, null);

        private static void SetPropertyValue(this object obj, string propName, object value) =>
            obj?.GetType().GetProperty(propName)?.SetValue(obj, value, null);
    }
}
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace AE.Application
{
    public static class FontEngine
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static Font MaterialOutlined;
        public static Font InterBase;

        public static void LoadFonts()
        {
            LoadFontFromResource(Properties.Resources.MaterialSymbolsOutlined);
            LoadFontFromResource(Properties.Resources.InterRegular);

            MaterialOutlined = new Font(_pfc.Families.First(f => f.Name.Contains("Material")), 16f, FontStyle.Regular);
            InterBase = new Font(_pfc.Families.First(f => f.Name.Contains("Inter")), 10f, FontStyle.Regular);
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
    }
}
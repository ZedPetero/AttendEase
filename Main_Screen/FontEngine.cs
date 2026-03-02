using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace AE.Application
{
    public static class FontEngine
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static Font MaterialOutlined;

        public static void LoadFonts()
        {
            byte[] fontData = Properties.Resources.MaterialSymbolsOutlined;

            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            _pfc.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            MaterialOutlined = new Font(_pfc.Families[0], 16f, FontStyle.Regular);
        }
    }
}

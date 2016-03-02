using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CSharpBombDefuser
{
    //Method to imbed a custom font into application
    // Found at https://www.youtube.com/watch?v=F6lKrkVottE

    class FontTool
    {
        // imports dll and sets up font needs
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbfont, uint cbfont, IntPtr pdv, [In] ref uint pcFonts);

        private static FontFamily _fontFamily;
        public static Font Digital7Font;


        //creates a font in the system
        public static void LoadFont()
        {
            // Load data from font binary into a byte array
            byte[] fontArray = Properties.Resources.digital_7;
            // int to hold datalength of font binary
            int dataLength = Properties.Resources.digital_7.Length;
            // Allocate memory to hold font byte array
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            //copy byte array into memory
            Marshal.Copy(fontArray, 0, ptrData, dataLength);

            uint cFonts = 0;
            //turn data in memory into a font
            AddFontMemResourceEx(ptrData, (uint) fontArray.Length, IntPtr.Zero, ref cFonts);
            //create a font collection
            PrivateFontCollection pfc = new PrivateFontCollection();
            //create the font within the collection
            pfc.AddMemoryFont(ptrData, dataLength);
            //free the memory
            Marshal.FreeCoTaskMem(ptrData);
            //name font family
            _fontFamily = pfc.Families[0];
            //name the new font
            Digital7Font = new Font(_fontFamily, 15f, FontStyle.Regular);
        }

        //method to call to allocate a font to a form object
        public static void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;
            c.Font = new Font(_fontFamily, size, fontStyle);
        }

    }
}

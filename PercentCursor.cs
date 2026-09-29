using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PercentCursor
{
    public class PercentCursor
    {
        #region External defines
        private struct IconInfo
        {
            public bool fIcon;
            public Int32 xHotspot;
            public Int32 yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        [DllImport("user32.dll", EntryPoint = "CreateIconIndirect")]
        private static extern IntPtr CreateIconIndirect(IntPtr iconInfo);

        #endregion

        #region Private members
        private int percent = 0;
        private Color color = Color.DarkBlue;
        private Cursor[] cursors = new Cursor[101];
        private Font font = new Font(FontFamily.GenericSerif, 10);
        #endregion

        public PercentCursor()
        {
            PrepareCursors();
        }

        #region Public methods & properties
        /// <summary>
        /// Cursor text color
        /// </summary>
        public Color Color
        {
            get { return color; }
            set 
            {
                if(color != value)
                {
                    color = value;
                    PrepareCursors();
                }
            }
        }
        /// <summary>
        /// Cursor text font
        /// </summary>
        public Font Font
        {
            get { return font; }
            set 
            { 
                if (font != value)
                {
                    font = value; 
                    PrepareCursors();
                }
            }
        }
	
        /// <summary>
        /// Percentage of completion
        /// </summary>
        public int Value
        {
            get { return percent; }
            set 
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();
                percent = value; 
            }
        }

        /// <summary>
        /// Return prepared cursor for setted value
        /// </summary>
        /// <returns>Cursor for setted value</returns>
        public Cursor GetCursor()
        {
            if (cursors[percent] != null)
                return cursors[percent];
            return System.Windows.Forms.Cursors.Default;
        }
        #endregion

        #region Private functions
        /// <summary>
        /// Generate 101 cursors for 0%-100% region
        /// </summary>
        private void PrepareCursors()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (cursors[i] == null)
                    cursors[i] = GenerateCursor(i);
            }
        }

        /// <summary>
        /// Generate cursor with the percentage of completion
        /// </summary>
        /// <param name="percent">Percentage of completion</param>
        /// <returns></returns>
        private Cursor GenerateCursor(int percent)
        {
            Bitmap imgColor = new Bitmap(32, 32, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
           
            SolidBrush brush = new SolidBrush(color);
            SolidBrush brushMask = new SolidBrush(Color.White);
            string s = string.Format("{0}%", percent);
            using (Graphics g = Graphics.FromImage(imgColor))
            {
                SizeF size = g.MeasureString(s, font);
                if (size.Width > 32) size.Width = 32;
                if (size.Height > 32) size.Height = 32;
                g.FillRectangle(brushMask, 0, 0, 32, 32);
                g.DrawString(s, font, brush, (32 - size.Width) / 2, (32-size.Height)/2);
                g.Flush();
            }
            imgColor.MakeTransparent(Color.White);
            IconInfo ii = new IconInfo();
            ii.fIcon = false;
            ii.xHotspot = 16;
            ii.yHotspot = 16;
            ii.hbmMask = imgColor.GetHbitmap();
            ii.hbmColor = imgColor.GetHbitmap();
            unsafe
            {
                IntPtr iiPtr = new IntPtr(&ii);
                IntPtr curPtr = CreateIconIndirect(iiPtr);
                return new Cursor(curPtr);
            }
        }
        #endregion
    }
}

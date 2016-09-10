using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Usecase_Program
{
    class Usecase
    {
        // Public variables
        public int x;
        public int y;


        // propperties

        public string Name { get; private set; }
        public string Samenvatting { get; private set; }
        public string Actoren { get; private set; }
        public string Aannamen { get; private set; }
        public string Beschrijving { get; private set; }
        public string Uitzonderingen { get; private set; }
        public string Resultaat { get; private set; }

        //variables

        private Pen _pen;
        private Brush _brush;
        private Font drawFont;
        
        // static variables
        private static Color _penColor = Color.Black;
        private static int _penWidth = 1;

        private static Color _brushColor = Color.Black;

        private static int _fontsize = 16;
        private static string _fonttype = "Arial";

        private static int _elipseHeight = 70;
        private static int _epipseWeidth = _elipseHeight * 3;

        public Usecase(int x, int y, string name)
        {
            this.x = x;
            this.y = y;

            Name = name;

            this._pen = new Pen(_penColor, _penWidth);
            this._brush = new SolidBrush(_brushColor);
            this.drawFont = new Font(_fonttype, _fontsize);
        }

        public void PaintElipse(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(_pen, x, y, _epipseWeidth, _elipseHeight);
            e.Graphics.DrawString(Name, drawFont, _brush, x+35, y+20);
        }

    }
}

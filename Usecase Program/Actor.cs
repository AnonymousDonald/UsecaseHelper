using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Usecase_Program
{
    class Actor
    {
        // Public variables
        public int x;
        public int y;

        //propperties
        public string Name { get; private set; }

        // Private variables
        private Rectangle _head;
        private Pen _pen;
        private Point _bodyPoint1;
        private Point _bodyPoint2;
        private Point _armsPoint1;
        private Point _armsPoint2;
        private Point _legPoint1;
        private Point _legPoint2;
        private Point _labelPosition;

        // Static variables
        private static Color _penColor = Color.Black;
        private static int _penWidth = 1;

        private static int _headWidth = 26;
        private static int _headHeight = _headWidth;
        private static int _bodyLength = 40;
        private static int _armLength = 20;
        private static int _armHeight = 20;
        private static int _legWidth = 10;
        private static int _legHeight = 40;
        

        public Actor(int x, int y, string name)
        {
            this.x = x;
            this.y = y;

            Name = name;

            this._pen = new Pen(_penColor, _penWidth);

            this._head = new Rectangle(x, y, _headWidth, _headHeight);
            this._bodyPoint1 = new Point(x + (_headWidth / 2), y + _headHeight);
            this._bodyPoint2 = new Point(this._bodyPoint1.X, this._bodyPoint1.Y + _bodyLength);
            this._armsPoint1 = new Point(this._bodyPoint1.X - _armLength, this._bodyPoint1.Y + _armHeight);
            this._armsPoint2 = new Point(this._armsPoint1.X + (_armLength*2), this._armsPoint1.Y);
            this._legPoint1 = new Point(this._bodyPoint2.X - _legWidth, this._bodyPoint2.Y + _legHeight);
            this._legPoint2 = new Point(this._bodyPoint2.X + _legWidth, this._bodyPoint2.Y + _legHeight);

        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(this._pen, this._head);
            e.Graphics.DrawLine(this._pen, this._bodyPoint1, this._bodyPoint2);
            e.Graphics.DrawLine(this._pen, this._armsPoint1, this._armsPoint2);
            e.Graphics.DrawLine(this._pen, this._bodyPoint2, this._legPoint1);
            e.Graphics.DrawLine(this._pen, this._bodyPoint2, this._legPoint2);
            e.Graphics.DrawString(Name, _pen, _labelPosition);


        }
    }
}

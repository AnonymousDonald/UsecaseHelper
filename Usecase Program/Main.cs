using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usecase_Program
{
    public partial class Main : Form
    {
        private List<Actor> _actorList;

        public Main()
        {
            InitializeComponent();
            _actorList = new List<Actor>();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach(Actor actor in _actorList)
            {
                actor.Paint(sender, e);
            }
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            
            if (me != null)
            {
                if (rbActoren.Checked && rbCreate.Checked)
                {
                    Actor n = new Actor(me.X, me.Y);
                    _actorList.Add(n);
                    Canvas.Refresh();
                }
            }
        }
    }
}

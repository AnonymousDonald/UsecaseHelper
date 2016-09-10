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
        private List<Usecase> _usecaseList;

        public Main()
        {
            InitializeComponent();
            _actorList = new List<Actor>();
            _usecaseList = new List<Usecase>();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            foreach(Actor actor in _actorList)
            {
                actor.Paint(sender, e);
            }
            foreach(Usecase usecase in _usecaseList)
            {
                usecase.PaintElipse(sender, e);
            }
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            
            if (me != null)
            {
                if (rbActoren.Checked && rbCreate.Checked) // create actor
                {
                    string name = tbName.Text;
                    Actor n = new Actor(me.X, me.Y, name);
                    _actorList.Add(n);
                    Canvas.Refresh();
                }
                if (rbCreate.Checked && rbUsecase.Checked) // create usecase
                {
                    string name = tbName.Text;
                    Usecase u = new Usecase(me.X, me.Y, name);
                    _usecaseList.Add(u);
                    Canvas.Refresh();
                }
                if (rbSelect.Checked) // selected
                {
                    foreach(Actor n in _actorList)
                    {
                        n.ActorSelected(me);
                        if (n.selected)
                        {
                            n.RedrawActor(sender, me);
                        }
                    }
                }
            }
        }
    }
}

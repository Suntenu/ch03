using System;
using System.Drawing;
using System.Windows.Forms;

namespace ch03.Examples
{
    public partial class InheritExample : Form
    {
        DrawClass d = null;
        public InheritExample()
        {
            InitializeComponent();
            panel1.BorderStyle = BorderStyle.FixedSingle;
            radioButton1.Checked = true;
            this.panel1.Paint += pane1_Paint;
            this.buttonDraw.Click += buttonDraw_Click;
            this.buttonClear.Click += buttonClear_Click;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) d = new DrawEllipse();
            else d = new DrawRectangle();
            panel1.Refresh();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            d = null;
            panel1.Refresh();
        }
        private void pane1_Paint(object sender, PaintEventArgs e)
        {
            if (d == null)
            {
                e.Graphics.Clear(panel1.BackColor);
            }
            else
            {
                Rectangle r1 = panel1.ClientRectangle;
                Rectangle r2 = new Rectangle(2, 2, r1.Width - 5, r1.Height - 5);
                d.Draw(e.Graphics, r2);
            }
        }

        private void InheritExample_Load(object sender, EventArgs e)
        {

        }
    }
}

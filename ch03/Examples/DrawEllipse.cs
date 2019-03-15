using System.Drawing;

namespace ch03.Examples
{
    class DrawEllipse:DrawClass
    {
        public DrawEllipse()
        {
            pen = new Pen(Brushes.Red, 5);
        }

        public override void Draw(Graphics g, Rectangle rect)
        {
            g.DrawEllipse(pen,rect);
        }
    }
}

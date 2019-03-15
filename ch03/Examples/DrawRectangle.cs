using System.Drawing;

namespace ch03.Examples
{
    class DrawRectangle : DrawClass
    {
        public DrawRectangle()
        {
            pen = new Pen(Brushes.Blue, 5);
        }
        public override void Draw(Graphics g, Rectangle rect)
        {
            g.DrawRectangle(pen, rect);
        }
    }
}

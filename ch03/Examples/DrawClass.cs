using System.Drawing;

namespace ch03.Examples
{
    public abstract class DrawClass
    {
        protected Pen pen;
        public DrawClass()
        {
            pen = Pens.Yellow;
        }
        public abstract void Draw(Graphics g, Rectangle rect);
    }
}

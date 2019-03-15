using System.Text;

namespace ch03.Examples
{
    class StructExample
    {
        public StructExample()
        {
            StringBuilder sb = new StringBuilder();
            Point1[] p1 = new Point1[10];
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i] = new Point1(i, i);
                sb.AppendFormat("{0},{1}", p1[i].x, p1[i].y);
            }
            sb.AppendLine();
            Point2[] p2 = new Point2[10];
            for(int i=0;i<p2.Length;i++)
            {
                sb.AppendFormat("({0},{1})", p2[i].x, p2[i].y);
            }
            sb.AppendLine();
            System.Windows.Forms.MessageBox.Show(sb.ToString());
        }
        class Point1
        {
            public int x, y;
            public Point1(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Point2
        {
            public int x, y;
            public Point2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}

using System;
using System.Text;

namespace ch03.Examples
{
    class MethodExample1
    {
        StringBuilder sb = new StringBuilder();
        public int Add(int x,int y=10)
        {
            return x + y;
        }
        public String GetOutPut()
        {
            int a = 20,b=30,c = 0;
            PrintInfo(a, b, c);
            sb.AppendFormat("传递一个参数结果为{0}，传递两个参数结果为{1}\n", Add(a), Add(b));
            PrintInfo(a, b, c);
            c = Add(a, b);
            sb.AppendLine(string.Format("c的结果为{0}", c));
            return sb.ToString();
        }
        public void PrintInfo(int a,int b,int c)
        {
            sb.AppendFormat("a={0},b={1},c={2}", a, b, c);
            sb.AppendLine();
        }
    }
}

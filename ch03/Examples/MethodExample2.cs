
namespace ch03.Examples
{
    class MethodExample2
    {
        public static void AddOne(ref int a)
        {
            a++;
        }
        public string GetOutPut()
        {
            int x = 0;
            string s = "调用前x的值为" + x + "\n";
            AddOne(ref x);
            s += "调用后x的值为" +x;
            return s;
        }
    }
}

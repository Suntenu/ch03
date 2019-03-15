
namespace ch03.Examples
{
    class MethodExample3
    {
        public static void Div(int x,int y,out int result ,out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }
    }
}


namespace ch03.Examples
{
    class MethodExample4
    {
        public static double Average(params int[] v)
        {
            double total = 0;
            for (int i = 0; i < v.Length; i++) total += v[i];
            return total / v.Length;
        }
    }
}

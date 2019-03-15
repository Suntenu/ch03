
namespace ch03.Examples
{
    public partial class Student
    {
        public void PrintInfo()
        {
            sb.AppendLine(string.Format("{0}已经{1}岁了！", this.Name, this.Age));
        }
    }
}

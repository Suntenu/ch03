using System.Text;

namespace ch03.Examples
{
    public partial class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Output { get { return sb.ToString(); } }
        private StringBuilder sb = new StringBuilder();
        public Student()
        {
            Name = "我";
            Age = "20";
            sb.AppendLine(string.Format("{0}已经{1}岁了！", this.Name, this.Age));
        }
    }
}

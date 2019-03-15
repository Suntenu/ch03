using ch03.Examples;
using System;
using System.Windows.Forms;

namespace ch03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach(var v in this.Controls)
            {
                Button button = v as Button;
                button.Click += button_Click;
            }
        }
        void button_Click(object sender,EventArgs e)
        {
            string s = (sender as Button).Text;
            switch (s)
            {
                case "例1":
                    Student student = new Student();
                    student.Name = "张三";
                    student.Age = "21";
                    student.PrintInfo();
                    MessageBox.Show(student.Output);
                    break;
                case "例2":
                    StructExample p = new StructExample();
                    break;
                case "例3":
                    MethodExample1 q = new MethodExample1();
                    MessageBox.Show(q.GetOutPut());
                    break;
                case "例4":
                    MethodExample2 r = new MethodExample2();
                    MessageBox.Show(r.GetOutPut());
                    break;
                case "例5":
                    int x = 13, y = 3;
                    int result, rem;
                    MethodExample3.Div(x, y, out result, out rem);
                    string s1 = string.Format("x={0},y={1}\n商={2},余数={3}", x, y, result, rem);
                    MessageBox.Show(s1);
                    break;
                case "例6":
                    string r1 = string.Format("1,2,3,5的平均值为{0}", MethodExample4.Average(1,2,3,5));
                    string r2 = string.Format("4,5,6的平均值为{0}", MethodExample4.Average(4,5,6));
                    MessageBox.Show(r1 + "\n" + r2);
                    break;
                case "例7":
                    InheritExample m7 = new InheritExample();
                    m7.ShowDialog();
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

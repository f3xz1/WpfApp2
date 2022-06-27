using Examen;

namespace MVP_Example_WF
{
    public partial class Form1 : Form, IGradeView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler<ShowGradeEventArgs> ShowGradeCalled;

        public void ShowGrade(Lessons[] lessons)
        {
           if(lessons.Length == 0)
            {
                listBox1.DataSource = new List<string>() { "Id is not found" };
            }
            else
            {
                listBox1.DataSource = lessons.Select(l => $"{l.Subject} - {l.Grade}");
            }
        }
    }
}
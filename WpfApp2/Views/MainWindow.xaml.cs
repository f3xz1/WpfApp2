using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Examen;
namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IGradeView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public event EventHandler<ShowGradeEventArgs> ShowGradeCalled;

        public void ShowGrade(Lessons[] lessons)
        {
            if (lessons.Length == 0)
            {
                lessonListBox.ItemsSource = new string[] { "Id is not found" };
            }
            else
            {
                lessonListBox.ItemsSource = lessons.Select(l => $"{l.Subject} - {l.Grade}");
            }
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(idTextBox.Text);
            ShowGradeCalled?.Invoke(this, new ShowGradeEventArgs(id));
        }
    }
}

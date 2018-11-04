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

namespace WPFDemoProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> students = new List<Student>();
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();

            students.Add(new Student { FirstName = "Nath", LastName = "Dortie" });
            students.Add(new Student { FirstName = "James", LastName = "Connolly" });
            students.Add(new Student { FirstName = "Joe", LastName = "Smith" });
            students.Add(new Student { FirstName = "Jane", LastName = "Jones" });

            cboStudentNames.ItemsSource = students;
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            string firstname = tbxFirstName.Text.Trim();
            MessageBox.Show($"Your first name is {firstname}");
        }

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string FullName
            {   
                get
                {
                    return $"{FirstName} { LastName }";
                }
            }
        }
    }
}

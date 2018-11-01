using System;
using System.Windows.Forms;
using SMS.Database;
using SMS.Models;

namespace SMS
{
    public partial class CourseMapping : Form
    {
        //public CourseMapping(Student student)
        public CourseMapping()
        {
            InitializeComponent();

            if (Db.Student != null)
            {
                _Student = Db.Student;
            }
            else
            {
                _Student = new Student();
            }
        }

        public Student _Student;

        private void CourseMapping_Load(object sender, EventArgs e)
        {
            textBox1.Text = _Student.Name;
        }

    }
}

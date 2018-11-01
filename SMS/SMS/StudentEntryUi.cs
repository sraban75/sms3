using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL;
using SMS.Database;
using SMS.Models;

namespace SMS
{
    public partial class StudentEntryUi : Form
    {
        StudentManager _studentManager = new StudentManager();
        CityManager _cityManager = new CityManager();
        public StudentEntryUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(); 
                student.Name = nameTextBox.Text;
                student.CityId = Convert.ToInt32(cityComboBox.SelectedValue);
                bool isSaved = _studentManager.Save(student);
                if (isSaved)
                {
                    MessageBox.Show("Saved"); 
                    return;
                }
                MessageBox.Show("Failed");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void StudentEntryUi_Load(object sender, EventArgs e)
        {
            DataTable dt = _cityManager.GetCityBindingDataSource();
            cityBindingSource.DataSource = dt;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            DataTable dt = _studentManager.GetAll();
            StudentGridView.DataSource = dt;
        }

        private void OpenCourseButton_Click(object sender, EventArgs e)
        {
            
            Student student= new Student();
            student.Name = "Arman";
            //student.Name


            Db.Student = student;

            //new CourseMapping(student).Show();
            new CourseMapping().Show();

        }
    }
}

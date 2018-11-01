using System.Data;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class StudentManager
    {

        StudentRepository _studentRepository= new StudentRepository();
        public bool Save(Student student)
        {
            //logic
            bool isSaved = _studentRepository.Save(student);
            return isSaved;
        }

        public DataTable GetAll()
        {
            DataTable dt = _studentRepository.GetAll();
            return dt;
        }
    }
}
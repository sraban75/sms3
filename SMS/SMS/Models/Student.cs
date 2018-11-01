using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
    }
}

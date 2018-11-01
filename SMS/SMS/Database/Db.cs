using System.Collections.Generic;
using SMS.Models;

namespace SMS.Database
{
    public static class Db
    {
        public static Student Student { get; set; }
        public static List<Student> Students { get; set; }
    }
}
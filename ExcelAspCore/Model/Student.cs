using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelAspCore.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string PhoneNo { get; set; }
        public string YearOfStudy { get; set; }
        public string Email { get; set; }
    }
}

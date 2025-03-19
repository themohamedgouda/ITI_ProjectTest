using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Entity
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
}   

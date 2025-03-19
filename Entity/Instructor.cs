using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Entity
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public decimal HourRate { get; set; }
        public string Address { get; set; } = string.Empty;
        public int Dep_Id { get; set; }
        public Department? Department { get; set; } 
    }
}

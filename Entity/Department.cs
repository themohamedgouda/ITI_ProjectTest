using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Entity
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public int Manager_Id { get; set; }
        public Instructor Dept_Manager { get; set; } = null!;
    }
}

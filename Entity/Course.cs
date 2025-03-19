using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Entity
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Duration { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Top_ID { get; set; } 
    }
}

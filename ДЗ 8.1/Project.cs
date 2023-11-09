using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8._1
{
    internal class Project
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Person Initiator { get; set; }
        public Person TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public ProjectStatus Status { get; set; }
    }
}

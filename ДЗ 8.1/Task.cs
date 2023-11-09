using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8._1
{
    internal class Task
    {
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Person Initiator { get; set; }
        public Person Assignee { get; set; }
        public TaskStatus Status { get; set; }
        public Report Report { get; set; }
    }
}

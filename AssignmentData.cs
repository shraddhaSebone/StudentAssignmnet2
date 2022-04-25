using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AssignmentData
    {
       public int id { get; set; }
       public string name { get; set; }
       public string subject { get; set; }
       public int duration { get; set; }
       public string status { get; set; }

        public AssignmentData() { }

        public AssignmentData(int id,string name,string subject,int duration,string status)
        {
            this.id = id;
            this.name = name;
            this.subject = subject;
            this.duration = duration;
            this.status = status;
        }
    }
}

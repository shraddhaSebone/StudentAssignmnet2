using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AssigmentByStatusAndTime
    {
        public int id { get; set; }
        public string name { get; set; }
        public int noOfCompletedCourse { get; set; }
        public int timeTaken { get; set; }

        public AssigmentByStatusAndTime() { }

        public AssigmentByStatusAndTime(int id,string name,int noOfCompletedCourse,int timeTaken)
        {
            this.id = id;
            this.name = name;
            this.noOfCompletedCourse = noOfCompletedCourse;
            this.timeTaken = timeTaken;
        }

    }
}

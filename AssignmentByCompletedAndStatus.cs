using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AssignmentByCompletedAndStatus
    {
        public string subjectName { get; set; }
        public int noOfStudentCompleted { get; set; }
        public int noOfStudentProgress { get; set; }

        public AssignmentByCompletedAndStatus() { }
        public AssignmentByCompletedAndStatus(string subjectName,int noOfStudentCompleted,int noOfStudentProgress)
        {
            this.subjectName = subjectName;
            this.noOfStudentCompleted = noOfStudentCompleted;
            this.noOfStudentProgress = noOfStudentProgress;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class AssignmentOperations
    {
        public List<AssigmentByStatusAndTime> getNumberOfCourseCompleted(List<AssignmentData> list)
        {
            Dictionary<int, AssigmentByStatusAndTime> key = new Dictionary<int, AssigmentByStatusAndTime>();
            List<AssigmentByStatusAndTime> assignment = new List<AssigmentByStatusAndTime>();
            foreach (AssignmentData data in list)
            {
                if (key.ContainsKey(data.id))
                { 
                    if (data.status == "Completed")
                    {
                        key[data.id].noOfCompletedCourse++;
                        key[data.id].timeTaken += data.duration;
                    }
                }
                else
                {
                    if (data.status == "Completed")
                    {
                        key.Add(data.id, new AssigmentByStatusAndTime());
                        key[data.id].id = data.id;
                        key[data.id].name = data.name;
                        key[data.id].noOfCompletedCourse = 1;
                        key[data.id].timeTaken = data.duration;
                    }
                }
            }
            foreach(AssigmentByStatusAndTime data in key.Values)
            {
                assignment.Add(data);
            }
            return assignment;
        }


        public List<AssignmentByCompletedAndStatus> GetAssignmentByCompletedAndStatus(List<AssignmentData> list)
        {
            Dictionary<string, AssignmentByCompletedAndStatus> key = new Dictionary<string, AssignmentByCompletedAndStatus>();
            List< AssignmentByCompletedAndStatus> assignment = new List<AssignmentByCompletedAndStatus>();
            foreach(AssignmentData data in list)
            {
                if (key.ContainsKey(data.subject))
                {
                    if (data.status == "Completed")
                    {
                        key[data.subject].noOfStudentCompleted++;
                    }
                    else
                    {
                        key[data.subject].noOfStudentProgress++;
                    }
                }
                else
                {
                    if (data.status == "Completed")
                    {
                        key.Add(data.subject, new AssignmentByCompletedAndStatus());
                        key[data.subject].subjectName = data.subject;
                        key[data.subject].noOfStudentCompleted = 1;
                        key[data.subject].noOfStudentProgress = 0;
                    }
                    else
                    {
                        key.Add(data.subject, new AssignmentByCompletedAndStatus());
                        key[data.subject].subjectName = data.subject;
                        key[data.subject].noOfStudentProgress = 1;
                        key[data.subject].noOfStudentCompleted = 0;
                    }
                }
            }
            foreach(AssignmentByCompletedAndStatus data in key.Values)
            {
                assignment.Add(data);
            }
            return assignment;  
           // return key.Values.ToList();
        }
    }
}

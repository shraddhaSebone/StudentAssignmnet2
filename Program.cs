using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AssignmentData> list = new List<AssignmentData>();
            AssignmentData assignmentData1 = new AssignmentData(101, "Shubham", "WPF",8,"Completed");
            list.Add(assignmentData1);
            AssignmentData assignmentData2 = new AssignmentData(102, "Sanju", "Java" ,4, "Completed");
            list.Add(assignmentData2);
            AssignmentData assignmentData3 = new AssignmentData(101, "Shubham", "Java", 6, "Completed");
            list.Add(assignmentData3);
            AssignmentData assignmentData4 = new AssignmentData(103, "Ravi", "Web", 4, "Progess");
            list.Add(assignmentData4);
            AssignmentData assignmentData5 = new AssignmentData(104, "Akash", "AWS", 4, "Progress");
            list.Add(assignmentData5);
            AssignmentData assignmentData6 = new AssignmentData(105, "Rama", "Java", 4, "Progress");
            list.Add(assignmentData6);
            AssignmentData assignmentData7 = new AssignmentData(102, "Sanju", "Oops", 8, "Completed");
            list.Add(assignmentData7);
            AssignmentData assignmentData8 = new AssignmentData(106, "Aman", "WPF", 6, "Completed");
            list.Add(assignmentData8);
            foreach(AssignmentData data in list)
            {
                Console.WriteLine($"{data.id},{data.name},{data.subject},{data.duration},{data.status}");    
            }

            Console.WriteLine($"********************************************************************************");

            AssignmentOperations assignmentOperations = new AssignmentOperations();
            List<AssigmentByStatusAndTime> list1 = assignmentOperations.getNumberOfCourseCompleted(list);

            foreach (AssigmentByStatusAndTime assigment in list1)
            {
                Console.WriteLine($"{assigment.id},{assigment.name},{assigment.noOfCompletedCourse},{assigment.timeTaken}");
            }

            Console.WriteLine($"********************************************************************************");




            List<AssignmentByCompletedAndStatus> list2 = assignmentOperations.GetAssignmentByCompletedAndStatus(list);
            foreach(AssignmentByCompletedAndStatus assigment in list2)
            {
                Console.WriteLine($"{assigment.subjectName},{assigment.noOfStudentCompleted},{assigment.noOfStudentProgress}");
            }
        }
    }
}

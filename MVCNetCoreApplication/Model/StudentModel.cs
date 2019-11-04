using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCNetCoreApplication.Model
{
    public class StudentModel
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public string Standard { get; set; }

        public string Address { get; set; }

        public static IEnumerable<StudentModel> GetStudents()
        {
            return new List<StudentModel>()
            {
                new StudentModel
                {
                    StudentID = 1,
                    StudentName = "Test Controller 1",
                    Standard = "1",
                     Address  = "Test Controller Address 1"
                },
                new StudentModel
                {
                    StudentID = 2,
                    StudentName = "Test Controller 2",
                     Standard = "2",
                     Address  = "Test Controller Address 2"
                },
                new StudentModel
                {
                    StudentID = 3,
                    StudentName = "Test Controller 3",
                     Standard = "3",
                      Address  = "Test Controller Address 3"
                },
                new StudentModel
                {
                    StudentID = 4,
                    StudentName = "Test Controller 4",
                     Standard = "4",
                      Address  = "Test Controller Address 4"
                },
                new StudentModel
                {
                    StudentID = 5,
                    StudentName = "Test Controller 5",
                     Standard = "5",
                     Address  = "Test Controller Address 5"
                },
            };
        }

        public static StudentModel FindStudent(int studentId)
        {
            return GetStudents().FirstOrDefault(S => S.StudentID == studentId);
        }
    }
}

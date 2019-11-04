using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCNetCoreApplication.Model;

namespace MVCNetCoreApplication.Controllers
{
    
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("student/get")]
        public IEnumerable<StudentModel> Get()
        {
            return StudentModel.GetStudents();
        }

        [Route("student/studentDetail/{studentId:int}")]
        public StudentModel StudentDetail(int studentId)
        {
            return StudentModel.FindStudent(studentId);
        }
    }
}
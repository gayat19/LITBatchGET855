using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstAPIExampleProject.Models;

namespace FirstAPIExampleProject.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(101,"Ramu"),
            new Student(102,"Somu"),
            new Student(103,"Somu")
        };
        //[HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            Student student = students.Find(s => s.Id == id);
            return student;
        }
        public void PostStudent(Student student)
        {
            students.Add(student);
        }

        public Student PutStudent(int id,Student student)
        {
            int idx = students.FindIndex(s => s.Id == id);
            if (idx >= 0)
            {
                students[idx] = student;
                return students[idx];
            }
            else
                return null;
        }
        public void DeleteStudent([FromBody]int id)
        {
            int idx = students.FindIndex(s => s.Id == id);
            if (idx >= 0)
            {
                students.RemoveAt(idx);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OtherAPITopicsProject.Models;
using System.Web.Http.Cors;

namespace OtherAPITopicsProject.Controllers
{
    [EnableCors(origins: "http://localhost:26606",headers:"*",methods:"*")]
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>() {
            new Student(101,"Ramu",89),
            new Student(102,"Somu",78),
            new Student(103,"Bimu",90)
        };
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}

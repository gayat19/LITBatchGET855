using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FirstAPIExampleProject.Models;

namespace FirstAPIExampleProject.Controllers
{
    public class SampleController : ApiController
    {
        //[HttpGet]
        //public string SayHello()
        //{
        //    return "Hello World";
        //}
        [HttpGet]
        public string SayHelloAnother(int id)
        {
            id = 100;
            return "Hello World Another "+id;
        }
        [HttpGet]
        public string SayHelloAnother(int id,int age)
        {
          return "Hello World Another " + id+" "+age;
        }
        //[HttpGet]
        //public User SayHelloAnother(int id,int age,string name)
        //{
        //    User user = new User();
        //    user.Id = id;
        //    user.Name = name;
        //    user.Age = age;
        //    return user;
        //}
        //[HttpGet]
        //public List<User> SayHelloAnother()
        //{
        //    List<User> users = new List<User>()
        //    {
        //        new User()
        //        {
        //            Id = 101,
        //            Name = "Ramu",
        //            Age = 21
        //        },
        //        new User()
        //        {
        //            Id =102,
        //            Name = "Somu",
        //            Age = 31
        //        },
        //    };
            
        //    return users;
        //}
        [HttpPut]
        public string Hello()
        {
            return "This is put";
        }
        [HttpPost]
        public string HelloPost()
        {
            return "This is Post";
        }
        [HttpDelete]
        public string HelloDelete()
        {
            return "This is Delete";
        }

    }
}

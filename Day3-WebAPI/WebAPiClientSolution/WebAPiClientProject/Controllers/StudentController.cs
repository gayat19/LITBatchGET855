﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPiClientProject.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPiClientProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public async  Task<ActionResult> Index()
        {
            List<Student> students = new List<Student>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:17685/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("api/Student");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Student>>(result);
            }
            return View(students);
        }
    }
}
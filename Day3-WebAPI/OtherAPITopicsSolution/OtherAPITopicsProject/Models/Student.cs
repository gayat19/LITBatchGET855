using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OtherAPITopicsProject.Models
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
       [DataMember]
        public int TestScore { get; set; }

        public Student() { }
        public Student(int id,string name,int score)
        {
            Id = id;
            Name = name;
            TestScore = score;
        }
    }
}
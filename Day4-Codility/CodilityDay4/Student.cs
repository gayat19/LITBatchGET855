using System;
using System.Collections.Generic;
namespace CodilityDay4
{
    internal class Student  : IComparable<Student>
    {
        int id;
        string name;
        float score;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Score { get => score; set => score = value; }

        public Student()
        {

        }
        public Student(int id,string name,float score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public int CompareTo(Student other)
        {
            //if (this.id == other.id)
            //    return 0;
            //else if (this.id > other.id)
            //    return 1;
            //else
            //    return -1;
            return this.id.CompareTo(other.id);
        }
        public override string ToString()
        {
            return id + " " + name + " " + score;
        }
    }
}
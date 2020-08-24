using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay4
{
    class Program
    {
        void UnderstandingTuples()
        {
            Tuple<int, string, Student> tuple = new Tuple<int, string, Student>(101, "Ramu", new Student());
     
        }
        void UnderstandingArraySort(int[] Arr)
        {
            Console.WriteLine("before sort");
            foreach (int item in Arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Sort");
            Array.Sort(Arr);
            foreach (int item in Arr)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingListSort(List<float> Arr)
        {
            Console.WriteLine("before sort");
            foreach (float item in Arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Sort");
            Arr.Sort();
            foreach (float item in Arr)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingSetSort(SortedSet<Student> students)
        {
            Console.WriteLine("Sorted Set");
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Sort");
           // SortedSet<Student> sortedStudents = students;
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingDictionarySort(Dictionary<int,Student> pairs)
        {
            Console.WriteLine("Before sort data");
            foreach (int item in pairs.Keys)
            {
                Console.WriteLine(pairs[item]);
            }
            Console.WriteLine("After Sort");
            List<int> sortedKeys = pairs.Keys.ToList();
            sortedKeys.Sort();
            
            foreach (int item in sortedKeys)
            {
                Console.WriteLine(pairs[item]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 12, 32, 45, 65, 11, 9, 5, 80, 102, 87 };
            List<float> list = new List<float>();
            list.Add(12.7f);
            list.Add(344.3f);
            list.Add(45.7f);
            list.Add(0.3f);
            list.Add(76f);
            list.Add(45.8f);
            //new Program().UnderstandingArraySort(arr);
            //new Program().UnderstandingListSort(list);
            //SortedSet<Student> students = new SortedSet<Student>()
            //{
            //    new Student(101,"Ramu",23.5f),
            //    new Student(104,"Somu",87.9f),
            //    new Student(103,"Bimu",92.1f),
            //    new Student(102,"Lomu",56.9f)
            //};
            //new Program().UnderstandingSetSort(students);
            Dictionary<int, Student> stu = new Dictionary<int, Student>();
            stu.Add(101, new Student(101, "Ramu", 23.5f));
            stu.Add(104, new Student(104, "Somu", 87.9f));
            stu.Add(103, new Student(103, "Bimu", 92.1f));
            stu.Add(102, new Student(102, "Lomu", 56.9f));
            new Program().UnderstandingDictionarySort(stu);
            Console.ReadKey();
        }
    }
}

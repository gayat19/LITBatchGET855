using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlayerScore> players = new List<PlayerScore>
            {
                new PlayerScore(5,30),
                new PlayerScore(4,20),
                new PlayerScore(1,30),
                new PlayerScore(2,10)
            };
            new Program().UnderstandingOrderOfPlusM();
            Console.ReadKey();
        }
        //O(1) or o(n log n) or O(n) or O(n+m)
        private void UnderstandingOrderOfPlusM()
        {
            int num = 10;
            int sum = 0, prod = 1;
            //O(n+m)
            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;
            }
            for (int i = 0; i <= num; i++)
            {
                prod = prod * i;
            }
        }

        private void UnderstandingOrderOfLogN()
        {
            int[] nums = { 2, 5, 6, 9, 3, 0, 1 };
            int myNum = 6;
            int flag = 0;
            //O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]==myNum)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
                Console.WriteLine("Number present");
            else
                Console.WriteLine("Number is not in t he given array");
            flag = 0;
            //O(log n)
            List<int> list = nums.ToList();
            list.Sort();
            int min = 0;
            int max = list.Count - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (myNum == list[mid])
                {
                    flag = 1;
                    break;
                }
                else if (myNum < list[mid])
                {
                    max = mid - 1;
                }
                else
                    min = mid + 1;
            }
            if (flag == 1)
                Console.WriteLine("Number present");
            else
                Console.WriteLine("Number is not in t he given array");

        }

        //O(N)
        private void UnderstandingOrderOfN()
        {
            Console.WriteLine("Please enter a number");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }


        //O(1)
        private void UnderstandingOrderOfOne()
        {
            Console.WriteLine("Please enter a number");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            if(num>20)
                Console.WriteLine("20");
            else
                Console.WriteLine(num);
        }
        void SortArray(List<PlayerScore> scoreBoard)
        {
            //select * from score order by score,id
            //LINQ - Language Integrated Query
            var res = scoreBoard.OrderBy(s => s.Score).ThenBy(s => s.Id);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
    class PlayerScore
    {
        int id;
        int score;
        public int Id { get => id; set => id = value; }
        public int Score { get => score; set => score = value; }
        public PlayerScore() {}
        public PlayerScore(int id,int score)
        {
            this.id = id;
            this.score = score;
        }
        public override string ToString()
        {
            return "Id " + id + " score " + score;
        }
    }
}

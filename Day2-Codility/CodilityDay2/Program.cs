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
            //List<PlayerScore> players = new List<PlayerScore>
            //{
            //    new PlayerScore(5,30),
            //    new PlayerScore(4,20),
            //    new PlayerScore(1,30),
            //    new PlayerScore(2,10)
            //};
            //new Program().UnderstandingOrderOfPlusM();
            //int[] myArr = { 0, 0, 4, 2, 4, 5 };
            //int[] res = new Program().CountElements(myArr);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            int[] A = {4,1,1,2,1,2 };
            int[] B = { 6,2,3,4};
            bool res = new Program().CheckSwapArray(A, B, 10);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        int[] CountElements(int[] arr)
        {
            //List<int> result = new List<int>();
            int max = arr.Max();
            int[] result = new int[max+1];
            for (int i = 0; i < arr.Length; i++)
            {
                int idx = arr[i];
                result[idx]++;
            }
            return result;
        }
         bool CheckSwapArray(int[] A,int[] B,int m)
        {
            bool result = false;
            int sumA = A.Sum();
            int sumB = B.Sum();
            Console.WriteLine(sumA+" "+sumB);
            int diff = sumA - sumB;
            if (diff % 2 != 0)
                return result;
            Array.Sort(A);
            Array.Sort(B);
            diff = diff / 2;
            int i = 0, j = 0;
            while(i<A.Length&&j<B.Length)
            {
                Console.WriteLine(A[i] + " " + B[j]+" "+i+" "+j);
                int arrDiff = A[i] - B[j];
                Console.WriteLine("Diff "+arrDiff+" "+diff);
                if (arrDiff == diff)
                {
                    Console.WriteLine(A[i] + " " + B[j]);
                    result = true;
                    break;
                }
                else if (arrDiff < diff)
                    i++;
                else
                    j++;
                  
            }
            return result;
        }

        bool AnotherSwapCheck(int[] A, int[] B, int m)
        {
            bool result = false;
            int sumA = A.Sum();
            int sumB = B.Sum();
            Console.WriteLine(sumA + " " + sumB);
            int select = 1;
            HashSet<int> nums = new HashSet<int>();
            if(sumA > sumB)
            {
                for (int i = 0; i < B.Length; i++)
                {
                    nums.Add(B[i]);
                }
                select = 2;
            }
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    nums.Add(A[i]);
                }
            }
            int diff = (sumA - sumB)/2;
            if (select == 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (nums.Contains(A[i] + diff))
                    {
                        result = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < B.Length; i++)
                {
                    if (nums.Contains(B[i] + diff))
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        bool SwapAnotherCodility(int[] A, int[] B, int m)
        {
            bool result = false;
            int sumA = A.Sum();
            int sumB = B.Sum();
            Console.WriteLine(sumA + " " + sumB);
            int diff = sumA - sumB;
            if (diff % 2 != 0)
                return result;
            diff = diff / 2;
            int[] count = CountElements(A);
            for (int i = 0; i < A.Length; i++)
            {
                if(0<=B[i]-diff && B[i]-diff < m && count[B[i]-diff]>0)
                {
                    result = true;
                    break;
                }
            }
            return result;
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

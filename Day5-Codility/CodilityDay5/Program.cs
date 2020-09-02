using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay5
{
    class Program
    {
        void UnderstandingStack()
        {
            Stack<int> numStack = new Stack<int>();
            numStack.Push(30);
            numStack.Push(40);
            numStack.Push(46);
            numStack.Push(25);
            numStack.Push(90);
            foreach (var item in numStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element poped "+ numStack.Pop());
            Console.WriteLine("Element peeked " + numStack.Peek());
            Console.WriteLine("The number of elements in the stack now "+numStack.Count);
        }
        void UnderstandingQueue()
        {
            Queue<string> strQueue = new Queue<string>();
            strQueue.Enqueue("Ramu");
            strQueue.Enqueue("Bimu");
            strQueue.Enqueue("Komu");
            strQueue.Enqueue("Somu");
            strQueue.Enqueue("Lomu");
            foreach (var item in strQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Element removed from queue " + strQueue.Dequeue());
            Console.WriteLine("Element peeked " + strQueue.Peek());
            Console.WriteLine("The number of elements in the Queue now " + strQueue.Count);
        }
        public int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            char[] chararr = S.ToCharArray();
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                if ('{' == S[i] || '(' == S[i] || '[' == S[i])
                {
                    stk.Push(S[i]);
                }
                else
                {
                    string pair = (Convert.ToString(stk.Pop()) + Convert.ToString(S[i]));
                    if (pair != "{}" || pair != "[]" || pair != "()")
                    {
                        return 0;
                    }
                }
            }
            if (stk.Count>0)
            {
                return 0;
            }
            
            
            return 1;
        }
        int FixBug(int[] nums,int key)
        {
            int result = -1;
            int size = nums.Length;
            if(size == 0)
            {
                return result;
            }
            int left = 0;
            int right = size;
            while (left<= right)//1
            {
                int mid = (left + right) / 2;

                if(nums[mid]>= key)//2
                {
                    right = mid-1;
                }
                else
                {
                    left = mid+1;//3
                }
            }
            if (nums[left] == key)
                result = left;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            int[] arr = { 2, 3, 4, 10,11,67,90,100};
            int i = new Program().FixBug(arr, 10);
            Console.WriteLine(i);
            //int i = new Program().solution("{[()()]}");
           
            
            Console.ReadKey();
        }
    }
}

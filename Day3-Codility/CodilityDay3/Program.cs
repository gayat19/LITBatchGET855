using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityDay3
{
    //    def mushrooms(A, k, m):
    //2 n = len(A)
    //3 result = 0
    //4 pref = prefix_sums(A)
    //5 for p in xrange(min(m, k) + 1) :
    //6 left_pos = k - p
    //7 right_pos = min(n - 1, max(k, k + m - 2 * p))
    //8 result = max(result, count_total(pref, left_pos, right_pos))
    //9 for p in xrange(min(m + 1, n - k)):
    //10 right_pos = k + p
    //11 left_pos = max(0, min(k, k - (m - 2 * p)))
    //12 result = max(result, count_total(pref, left_pos, right_pos))
    //13 return result
//    def count_total(P, x, y):
//2 return P[y + 1] - P[x]
    class Program
    {
        Dictionary<string, int> list = new Dictionary<string, int>();
       
      
        string type;
        public string Type { get => type; set => type = value; }
        static void Main(string[] args)
        {
        }

        int count_total(int[] P,int x, int y)
        {

            return (P[y + 1] - P[x]);
        }

        int mushrroms(int[] A,int k,int m)
        {
            int n = A.Length;
            int result = 0;
            int left_pos,right_pos;
            int[] prefix = PrefixSum(A);
            for (int i = 0; i < (Math.Min(m, k) + 1); i++)
            {
                left_pos = k - i;
                right_pos = Math.Min(n - 1, Math.Max(k, (k + m - 2 * i)));
                result = Math.Max(result, count_total(prefix,left_pos,right_pos));
            }
            for (int i = 0; i < Math.Min(m+1,n-k); i++)
            {
                right_pos = k + i;
                left_pos = Math.Max(0, Math.Min(k, k - (m - 2 * i)));
                left_pos = Math.Max(result, count_total(prefix, left_pos, right_pos));
            }
            return result;
        }
        int[] PrefixSum(int[] A)
        {
            int[] result = new int[A.Length + 1];
            result[0] = 0;
            for (int i = 0; i < A.Length; i++)
            {
                result[i + 1] = result[i] + A[i];
            }
            return result;
        }
        public int[] solution(string S, int[] P, int[] Q)
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("A", 1);
            list.Add("C", 2);
            list.Add("G", 3);
            list.Add("T", 4);
            int[] result = new int[P.Length];
            int[] sumArr = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                sumArr[i] = list[S[i].ToString()];
            }
            //int[] sum = PrefixSum(sumArr);
            Console.WriteLine(sumArr.Length);
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i] == Q[i])
                    result[i] = list[S[P[i]].ToString()];
                else if (P[i] > Q[i])
                {
                    //int[] temp = sumArr.Co
                    //result[i] = 
                }
                else
                {
                    //result[i] = count_total(sumArr,P[i],Q[i]);
                }
            }
            return result;
        }
    }
}

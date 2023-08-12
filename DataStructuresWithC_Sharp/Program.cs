using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresWithC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 3, 4, 5, 6, 7, 8, 9, 1, 2, };
           int kko = Numbers.Length;
            int? result = Numbers.Min();
            List<string> list = new List<string>();
            list.Add("Sau");
            list.Add("kak");
            list.Add("dad");
            list.Add("pap");

            string kk = list.Aggregate((a,b) => a + "," + b);
            string k = list.Where(x => x.Contains("rk")).First();
            string p = list.Where(x => x.Contains("a")).FirstOrDefault();
            foreach (int i in Numbers)
            {
                if (!result.HasValue || i < result)
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int LongestConsecutive(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            HashSet<int> arrSet = new HashSet<int>(arr);
            int longestSubSeq = 0;

            foreach (int number in arrSet)
            {
                if (!arrSet.Contains(number - 1))
                {
                    int currentNum = number;
                    int currentSubSeq = 1;
                    while (arrSet.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentSubSeq++;
                    }
                    longestSubSeq = Math.Max(longestSubSeq, currentSubSeq);
                }
            }
            // code goes here  
            return longestSubSeq;

        }
    }
}

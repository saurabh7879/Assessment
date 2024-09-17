using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] a = { 1, 4, 7, 2, 3 };
            int[] b = { 2, 11, 7, 4, 15, 20, 24 };
            int n = a.Length;
            int m = b.Length;

            int[] arr = InterSect(a, b);
            arr.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            Console.Read();
        }
        public static int[] InterSect(int[] nums1, int[] nums2)
        {

            Dictionary<int, int> di = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j] && !di.ContainsKey(j))
                    {
                        di.Add(j, nums2[j]);
                        break;
                    }

                }
            }
            int[] result = new int[di.Count];
            result = di.Values.ToArray();
            return result;

            // Time Complexity: O(m*log(m) + n*log(n)), where ‘m’ and ‘n’ are the size of the arrays
        }

    }
}

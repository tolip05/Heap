using System;

namespace InterPolationSearch
{
    class Program
    {
       static int[] arr = new int[]{10, 12, 13, 16, 18,
                                 19, 20, 21, 22, 23,
                                 24, 33, 35, 42, 47};
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(InterpolationSearch(x));
            
        }

        private static int InterpolationSearch(int x)
        {
            int first = 0, last = arr.Length - 1;
            while (first < last &&
                x >= arr[first] && 
                x <= arr[last])
            {
                int pos = first +
                    (((last - first) / (arr[last] - arr[first]))
                    * (x - arr[first]));
                if (arr[pos] == x)
                {
                    return pos;
                }
                if (arr[pos] < x)
                {
                    first = pos + 1;
                }
                else
                {
                    last = pos - 1;
                }
            }
            return -1;
        }
    }
}

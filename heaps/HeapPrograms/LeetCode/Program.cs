using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //CallKthLargestNbrInStream();
            CallKthLargestNbrInArray();


            // CallReverserString();
            // CallSingleNonDuplicate();
            Console.ReadLine();
        }

        private static void CallKthLargestNbrInArray()
        {
            KthLargestElementInStreamSolution solution = new KthLargestElementInStreamSolution();
            Console.WriteLine(solution.FindKthLargest(new int[] { 9, 4, 2, 5, 77, 2, 0 }, 2));
        }

        private static void CallKthLargestNbrInStream()
        {
            // https://leetcode.com/problems/kth-largest-element-in-a-stream/
            // https://www.geeksforgeeks.org/kth-largest-element-in-a-stream/

            int k = 3;
            int[] arr = new int[] { 4, 5, 8, 2 };
            KthLargest kthLargest = new KthLargest(k, arr);
            Console.WriteLine(kthLargest.Add(3));
            Console.WriteLine(kthLargest.Add(5));
            Console.WriteLine(kthLargest.Add(10));
            Console.WriteLine(kthLargest.Add(9));
            Console.WriteLine(kthLargest.Add(4));

        }

        private static void CallReverserString()
        {
            // https://leetcode.com/problems/reverse-string/
            string testString = "Hello";
            Console.WriteLine(ReverseStringSolution.ReverseString(testString));

            testString = "A man, a plan, a canal: Panama";
            Console.WriteLine(ReverseStringSolution.ReverseString(testString));
        }
        private static void CallSingleNonDuplicate()
        {
            var t = new[] { 3, 3, 7, 7, 10, 11, 11 };

            SingleNonDuplicateSolution.SingleNonDuplicate(t, 0, t.Length - 1);
            Console.ReadLine();
        }
    }
}

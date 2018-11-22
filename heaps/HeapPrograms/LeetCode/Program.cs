using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // CallKthLargestNbrInStream();
            // CallKthLargestNbrInArray();
            // CallIsLucky();
            // CallIsPrime();
            // CallCountPrime();
            // CallReverserString();
            // CallSingleNonDuplicate();
            // CallPrintStack();
            // CallStackUsingQueue();
            // CallSelfDividingNumber();

            CallNaryTraversal();

            Console.ReadLine();
        }

        private static void CallNaryTraversal()
        {
            NaryTraversal traversal = new NaryTraversal();
            var secondLevelChildren = new List<Node>();
            secondLevelChildren.Add(new Node(5, null));
            secondLevelChildren.Add(new Node(6, null));

            var rootchildren = new List<Node>();
            rootchildren.Add(new Node(3, secondLevelChildren));
            rootchildren.Add(new Node(2, null));
            rootchildren.Add(new Node(4, null));

            Node root = new Node(1, rootchildren);
            var t = traversal.Postorder(root);

            var t2 = traversal.Postorder2(root);
            var preorder = traversal.PreOrder(root);

            var maxD = traversal.MaxDepth(root);
            var maxD2 = traversal.MaxDepth2(root);
        }

        private static void CallSelfDividingNumber()
        {
            SelfDividingNumber s = new SelfDividingNumber();
            var res = s.SelfDividingNumbers(1, 22);

            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
        }

        private static void CallStackUsingQueue()
        {
            StackUsingQueue st = new StackUsingQueue();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            Console.WriteLine(st.Top());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Top());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Top());

            Console.WriteLine(st.Empty());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

        }
        private static void CallPrintStack()
        {
            Stack<int> st = new Stack<int>();
            st.Push(12);
            st.Push(15);
            st.Push(30);
            st.Push(40);

            PrintStackInReverse s = new PrintStackInReverse();
            s.PrintStack(st);
        }
        private static void CallIsPrime()
        {
            var p = new IsPrimeChecker();

            Console.WriteLine($"p.IsPrime(7): {p.IsPrime(7)}");
            Console.WriteLine($"p.IsPrime(733): {p.IsPrime(733)}");
            Console.WriteLine($"p.IsPrime(863): {p.IsPrime(863)}");
            Console.WriteLine($"p.IsPrime(881): {p.IsPrime(881)}");
            Console.WriteLine($"p.IsPrime(997): {p.IsPrime(997)}");
            Console.WriteLine($"p.IsPrime(885): {p.IsPrime(885)}");
            Console.WriteLine($"p.IsPrime(7853): {p.IsPrime(7853)}");

            Console.WriteLine($"p.IsPrimeSqRoot(733): {p.IsPrimeSqRoot(733)}");
            Console.WriteLine($"p.IsPrimeSqRoot(863): {p.IsPrimeSqRoot(863)}");
            Console.WriteLine($"p.IsPrimeSqRoot(881): {p.IsPrimeSqRoot(881)}");
            Console.WriteLine($"p.IsPrimeSqRoot(997): {p.IsPrimeSqRoot(997)}");
            Console.WriteLine($"p.IsPrimeSqRoot(885): {p.IsPrimeSqRoot(885)}");
            Console.WriteLine($"p.IsPrimeSqRoot(7853): {p.IsPrimeSqRoot(7853)}");

        }

        private static void CallCountPrime()
        {
            CountPrime p = new CountPrime();
            Console.WriteLine($"p.CountPrimesFast(10): {p.CountPrimesFast(10)}");
            Console.WriteLine($"p.CountPrimes(10): {p.CountPrimes(10)}");
        }

        private static void CallIsLucky()
        {
            LuckyNumber l = new LuckyNumber();

            // By default always pass 2 as 1 is always lucky
            Console.WriteLine($"l.IsLucky(5){l.IsLucky(5)}");
            Console.WriteLine($"l.IsLucky(11){l.IsLucky(11)}");
            Console.WriteLine($"l.IsLucky(19){l.IsLucky(19)}");
            Console.WriteLine($"l.IsLucky(23){l.IsLucky(23)}");

            // By default always pass 2 as 1 is always lucky
            Console.WriteLine($"l.IsLuckyRec(5, 2){l.IsLuckyRec(5, 2)}");
            Console.WriteLine($"l.IsLuckyRec(11, 2){l.IsLuckyRec(11, 2)}");
            Console.WriteLine($"l.IsLuckyRec(19, 2){l.IsLuckyRec(19, 2)}");
            Console.WriteLine($"l.IsLuckyRec(23, 2){l.IsLuckyRec(23, 2)}");
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

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
            // CallNaryTraversal();
            // CallLevelOrderTraversal();
            // CallValidateParenthesis();
            // CallStringFunctions();
            //CallArrayAlgos();
            //CallArrayAlgos2();
            CallTreeOperations();
            // CallBitAlgos();

            // CallDPAlgos();

            //CallLinkedListAlgos();

            // CallDynamicPrograms();
            // CallMathAlgos();
            // CallKthSamllestInBinTree();
            // CallBinSrchAlgos();
            // CallTwoPointerAlgos();
            // CallDeletecolumnsToMakeSorted();

            Console.ReadLine();
        }

        private static void CallDeletecolumnsToMakeSorted()
        {
            DeleteColumnstoMakeSorted sorted = new DeleteColumnstoMakeSorted();
            // string[] arr = new string[] { "zyx", "wvu", "tsr" };
            string[] arr = new string[] { "cba", "daf", "ghi" };

            sorted.MinDeletionSize(arr);
        }

        private static void CallDynamicPrograms()
        {
            int count = 30;
            DynamicProgAlgos dynamicProg = new DynamicProgAlgos();
            Console.WriteLine($"No of ways to climb steps {count} are: {dynamicProg.ClimbStairs(count)}");
            Console.WriteLine($"No of ways to climb steps 1,100, 1, 1, 1, 100, 1, 1, 100, 1 are: {dynamicProg.MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 })}");
            Console.WriteLine($"Max profit on robbing 6, 7, 1, 3, 8, 2, 4 are: {dynamicProg.Rob(new int[] { 6, 7, 1, 3, 8, 2, 4 })}");

        }

        private static void CallMathAlgos()
        {
            MathAlgos mathAlgos = new MathAlgos();
            Console.WriteLine(mathAlgos.ArrangeCoins(1));

        }
        private static void CallTwoPointerAlgos()
        {
            TwoPointerAlgos twoPointerAlgos = new TwoPointerAlgos();
            //string named = "pyplrz";
            //string typed = "ppyypllr";

            string named = "xywrrmp";
            string typed = "xywrrm#p";

            // Console.WriteLine($"Two pointer: {named} vs {typed}" + twoPointerAlgos.IsLongPressedName(named, typed));

            // Console.WriteLine($"Backspace: {named} vs {typed}" + twoPointerAlgos.BackspaceCompare(named, typed));
            // Console.WriteLine($"Backspace using Stack: {named} vs {typed}" + twoPointerAlgos.BackspaceCompareUsingStk(named, typed));
            // Console.WriteLine($"Find duplicate" + twoPointerAlgos.FindDuplicate(new int[] { 1, 3, 2, 4, 2 }));
            Console.WriteLine($"Find duplicate" + twoPointerAlgos.FindDuplicateUsingArrayIndices(new int[] { 1, 3, 4, 2, 2 }));

        }
        private static void CallBinSrchAlgos()
        {
            BinsrchAlgos binsrchAlgos = new BinsrchAlgos();
            //var arr = new int[] { 0, 2,1, 0 };
            // var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 5, 4, 3, 1, 0 };
            var arr = new int[] { 0, 2, 7, 9, 11, 12, 89, 78, 67, 54, 33, 22, 11, 9, 1, 0 };

            Console.WriteLine(binsrchAlgos.PeakIndexInMountainArray(arr));
        }
        private static void CallKthSamllestInBinTree()
        {
            TreeNode node = new TreeNode { Data = 5 };
            node.LeftNode = new TreeNode { Data = 3 };
            node.RightNode = new TreeNode { Data = 6 };
            node.LeftNode.LeftNode = new TreeNode { Data = 2 };
            //node.LeftNode.RightNode = new TreeNode { Data = 3 };
            //node.RightNode.LeftNode = new TreeNode { Data = 6 };
            //node.RightNode.RightNode = new TreeNode { Data = 7 };
            node.LeftNode.LeftNode.LeftNode = new TreeNode { Data = 1 };
            //node.LeftNode.LeftNode.RightNode = new TreeNode { Data = 9 };
            //node.LeftNode.RightNode.LeftNode = new TreeNode { Data = 10 };
            //node.LeftNode.RightNode.RightNode = new TreeNode { Data = 11 };

            var algos = new KthSmallestInBinTree();
            // algos.KthSmallest(node,4);
            var res = algos.KthSmallest2(node, 3);
        }
        private static void CallLinkedListAlgos()
        {
            LinkedListAlgos algos = new LinkedListAlgos();
            ListNode node10 = new ListNode(10);
            ListNode node9 = new ListNode(9);
            ListNode node8 = new ListNode(8);
            ListNode node7 = new ListNode(7);
            ListNode node6 = new ListNode(6);
            ListNode node5 = new ListNode(5);
            ListNode node3 = new ListNode(3);
            ListNode node1 = new ListNode(1);

            ListNode node4 = new ListNode(4);
            ListNode node2 = new ListNode(2);

            node2.next = node4;
            node4.next = node6;

            node1.next = node3;
            node3.next = node5;
            node5.next = node6;
            node6.next = node7;
            node7.next = node8;
            node8.next = node9;
            node9.next = node10;

            // algos.MiddleNodeAp2(node1);
            //algos.RemoveNthFromEnd(node1, 2);
            //var isP = algos.IsPalindrome(node1);
            //algos.ReverseListRecursive(null, node1);

            algos.GetIntersectionNode(node1, node2);
        }
        private static void CallDPAlgos()
        {
            DPAlgos algos = new DPAlgos();
            int num = 14;
            Console.WriteLine($"Number {num} is ugly: {algos.IsUgly(num)}");

            int k = 20;
            Console.WriteLine($"Kth Ugly Number where k={k} is {algos.kthUglyNbr(k)}");

            int ksuperUgly = 12;
            Console.WriteLine($"Kth Super Ugly Number where k={ksuperUgly} is {algos.SuperUgly(ksuperUgly, new int[] { 2, 7, 13, 19 })}");
        }

        private static void CallArrayAlgos2()
        {

            ArrayAlgos2 algos = new ArrayAlgos2();
            //Console.WriteLine(algos.NextGreaterElementPart1(new int []{ 4, 1, 2 }, new int[] { 1, 3, 4, 2 }));
            Console.WriteLine(algos.NextGreaterElementPart1(new int[] { 1, 3, 5, 2, 4 }, new int[] { 6, 5, 4, 3, 2, 1, 7 }));
            Console.WriteLine(algos.NextGreaterElement(7686553));
            Console.WriteLine(algos.NextGreaterElement(1234));
            Console.WriteLine(algos.NextGreaterElement(12));

            Console.WriteLine($"Third Max for {algos.ThirdMaxNumber(new int[] { 1, 2 })}");

        }
        private static void CallArrayAlgos()
        {
            ArrayAlgos algos = new ArrayAlgos();
            // int[] arr = new int[] { 1, 2, 3, 6, 12, 90, 6, 5 };
            int[] arr = new int[] { 3, 2, 4 };
            algos.FindAPairWhoseSumIsX(arr, 6);
            algos.FindAPairWhoseSumIsXWithoutSorting(arr, 6);
            var threeSum = algos.ThreeSum(new int[] { 0, 0, 0, 0 });
            threeSum = algos.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            algos.FindMajorityElementMoore(new int[] { 3, 2, 3 });
            algos.FindMajorityElementMoore(new int[] { 2, 2, 1, 1, 1, 2, 2 });
            //algos.FindMajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });

            algos.MaxSumSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            algos.MaxSumSubArray(new int[] { 1, 2 });

            var consecutiveOnes = algos.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            var noOfSubarrays = algos.SubarraySumFromLeetCodeSols(new int[] { 8, 5, -2, 3, 4, -5, 7, -2, -4, -3, 2 }, 10);
            noOfSubarrays = algos.SubarraySumGeneric(new int[] { 1, -1, 1 }, 0);

            noOfSubarrays = algos.SubarraySumGeneric(new int[] { 1, 2, 1, 2, 1 }, 3);

            algos.FindLargestSubArrary(new int[] { 0, 1, 1, 0, 1, 0, 1 });

            var maxProfit = algos.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            maxProfit = algos.MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }

        private static void CallTreeOperations()
        {

            TreeNode node = new TreeNode { Data = 1 };
            node.LeftNode = new TreeNode { Data = 2 };

            node.RightNode = new TreeNode { Data = 3 };
            node.LeftNode.LeftNode = new TreeNode { Data = 4 };
            node.LeftNode.RightNode = new TreeNode { Data = 5 };
            node.RightNode.LeftNode = new TreeNode { Data = 6 };
            node.RightNode.RightNode = new TreeNode { Data = 7 };
            node.LeftNode.LeftNode.LeftNode = new TreeNode { Data = 8 };
            node.LeftNode.LeftNode.RightNode = new TreeNode { Data = 9 };
            node.LeftNode.RightNode.LeftNode = new TreeNode { Data = 10 };
            node.LeftNode.RightNode.RightNode = new TreeNode { Data = 11 };

            node.LeftNode.RightNode.RightNode.RightNode = new TreeNode { Data = 12 };
            node.LeftNode.RightNode.RightNode.RightNode.RightNode = new TreeNode { Data = 13 };



            TreePrograms tp = new TreePrograms();

            var st = "1,2,3,#,#,4,5,#,#,6,7";

            var n = tp.deserialize(st);
            var str = tp.serialize(n);

            var str2 = tp.serialize(n);

            Console.WriteLine($"Strings were: {str == str2}");

            TreeTraversal trv = new TreeTraversal();
            var t = trv.BuildTree(new int[] { 8, 4, 2, 5, 1, 6, 3, 7 }, new int[] { 8, 4, 5, 2, 6, 7, 3, 1 });

            trv.HasPathSum(node, 1);

            TreePrograms treePrograms = new TreePrograms();

            var mirrorTree = treePrograms.MirrorTree(node);

            Console.WriteLine(treePrograms.Height(node));
            Console.WriteLine(treePrograms.diameter(node, 0));
        }
        private static void CallBitAlgos()
        {
            BitAlgos algos = new BitAlgos();

            Console.WriteLine("128 is power of 2" + algos.isPowerOf2(128));
            Console.WriteLine("256 is power of 2" + algos.isPowerOf2(256));
            Console.WriteLine("1023 is power of 2" + algos.isPowerOf2(1023));


            Console.WriteLine("Number of Bits 31" + algos.CountNumberOfBitsSetApp1(31));
            Console.WriteLine("Number of Bits 255" + algos.CountNumberOfBitsSetApp1(255));
            Console.WriteLine("Number of Bits 1023" + algos.CountNumberOfBitsSetApp1(1023));

            Console.WriteLine("Number of Bits 31" + algos.CountNumberOfBitsSetApp2(31));
            Console.WriteLine("Number of Bits 255" + algos.CountNumberOfBitsSetApp2(255));
            Console.WriteLine("Number of Bits 1023" + algos.CountNumberOfBitsSetApp2(1023));


            Console.WriteLine("KthBitSetOrnot" + algos.KthBitSetOrnot(32, 2));


            Console.WriteLine("Next power of 2 for 6 " + algos.getNextPowerOf2NumberLogApproach(6));
            Console.WriteLine("Next power of 2 for 9 " + algos.getNextPowerOf2NumberLogApproach(9));
            Console.WriteLine("Next power of 2 for 17" + algos.getNextPowerOf2Number(17));
            Console.WriteLine("Next power of 2 for 32" + algos.getNextPowerOf2NumberLogApproach(32));

        }

        private static void CallStringFunctions()
        {
            string s = "Hello";

            StringAlgos str = new StringAlgos();
            var test = str.ToLowerCase(s);
        }

        private static void CallValidateParenthesis()
        {
            ValidateParenthesis parenthesis = new ValidateParenthesis();

            Console.WriteLine("(((((())))))" + parenthesis.IsValid("(((((())))))"));
            Console.WriteLine("()()()()" + parenthesis.IsValid("()()()()"));
            Console.WriteLine("(((((((()" + parenthesis.IsValid("(((((((()"));
            Console.WriteLine("((()(())))" + parenthesis.IsValid("((()(())))"));
            Console.WriteLine("){ " + parenthesis.IsValid("){"));
            Console.WriteLine("() " + parenthesis.IsValid("()"));
            Console.WriteLine("(] " + parenthesis.IsValid("(]"));
        }

        private static void CallLevelOrderTraversal()
        {
            TreeNode node = new TreeNode { Data = 1 };
            node.LeftNode = new TreeNode { Data = 2 };
            node.RightNode = new TreeNode { Data = 3 };
            node.LeftNode.LeftNode = new TreeNode { Data = 4 };
            node.LeftNode.RightNode = new TreeNode { Data = 5 };
            node.RightNode.LeftNode = new TreeNode { Data = 6 };
            node.RightNode.RightNode = new TreeNode { Data = 7 };
            node.LeftNode.LeftNode.LeftNode = new TreeNode { Data = 8 };
            node.LeftNode.LeftNode.RightNode = new TreeNode { Data = 9 };
            node.LeftNode.RightNode.LeftNode = new TreeNode { Data = 10 };
            node.LeftNode.RightNode.RightNode = new TreeNode { Data = 11 };

            TreeTraversal treeTraversal = new TreeTraversal();
            treeTraversal.LevelOrderTraversal(node);

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

            traversal.LevelOrderTraversal(root);
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
            ReverseStringSolution solution = new ReverseStringSolution();

            // https://leetcode.com/problems/reverse-string/
            string testString = "Hello";
            Console.WriteLine(ReverseStringSolution.ReverseString(testString));

            testString = "A man, a plan, a canal: Panama";
            Console.WriteLine(ReverseStringSolution.ReverseString(testString));

            StringAlgos algos = new StringAlgos();

            Console.WriteLine($"ReverseOnlyLetters:{algos.ReverseOnlyLetters("AaW;c?[")}");

        }
        private static void CallSingleNonDuplicate()
        {
            var t = new[] { 3, 3, 7, 7, 10, 11, 11 };

            SingleNonDuplicateSolution.SingleNonDuplicate(t, 0, t.Length - 1);
            Console.ReadLine();
        }
    }
}

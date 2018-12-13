using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class LinkedListAlgos
    {

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode curA = headA;
            ListNode curB = headB;

            int sizeofL1 = CountLinkedListSize(curA);
            int sizeofL2 = CountLinkedListSize(curB);

            int size = 0;
            if (sizeofL1 > sizeofL2)
            {
                size = sizeofL2;
                for (int i = 0; i < sizeofL1 - sizeofL2; i++)
                {
                    headA = headA.next;
                }
            }
            else
            {
                size = sizeofL1;

                for (int i = 0; i < sizeofL2 - sizeofL1; i++)
                {
                    headB = headB.next;
                }
            }

            int j = size;
            while (j >= 0)
            {
                if (headA == headB) return headA;
                headA = headA.next;
                headB = headB.next;
                 j--;
            }

            return null;
        }

        private int CountLinkedListSize(ListNode head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slowPointer = head, fastPointer = head;

            while (fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }

            return slowPointer;
        }

        public ListNode MiddleNodeAp2(ListNode head)
        {
            int count = 0;
            ListNode midNode = head;
            ListNode movingPtr = head;
            while (movingPtr != null)
            {
                if (count % 2 == 0)
                    midNode = midNode.next;
                movingPtr = movingPtr.next;
                count++;
            }

            return midNode;
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode leftPtr = dummy;
            ListNode rightPtr = dummy;

            // Move one forward than needed
            for (int i = 0; i <= n; i++)
            {
                rightPtr = rightPtr.next;
            }

            while (rightPtr != null)
            {
                leftPtr = leftPtr.next;
                rightPtr = rightPtr.next;
            }

            // Now delete

            leftPtr.next = leftPtr.next.next;
            return dummy.next;
        }

        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stk = new Stack<int>();
            ListNode temp = head;
            int count = 0;
            while (temp != null)
            {
                stk.Push(temp.val);
                temp = temp.next;
                count++;
            }

            for (int i = 0; i <= count / 2; i++)
            {
                if (head.val != stk.Pop()) return false;
                head = head.next;
            }

            return true;
        }

        public void DeleteNode(ListNode nodetoDelete)
        {
            nodetoDelete.val = nodetoDelete.next.val;

            nodetoDelete.next = nodetoDelete.next.next;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;
            ListNode nextNode = null;

            while (head != null)
            {
                nextNode = head.next;
                head.next = previous;
                previous = head;
                head = nextNode;
            }

            return previous;
        }

        public void ReverseListRecursive(ListNode previous, ListNode head)
        {
            if (head != null)
            {
                ReverseListRecursive(head, head.next);
                head.next = previous;
            }
            else
            {
                head = previous;
            }
        }

        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode fastPtr = head;
            ListNode slowPtr = head;

            while (fastPtr != null)
            {
                slowPtr = slowPtr.next;

                if (fastPtr.next == null) return false;
                fastPtr = fastPtr.next.next;

                if (fastPtr == slowPtr) return true;
            }

            return false;
        }

        public ListNode DetectCycle(ListNode head)
        {

            if (head == null) return null;
            ListNode fastPtr = head;
            ListNode slowPtr = head;

            bool hasLoop = false;
            while (fastPtr != null)
            {
                slowPtr = slowPtr.next;

                if (fastPtr.next == null) return null;
                fastPtr = fastPtr.next.next;

                if (fastPtr == slowPtr)
                {
                    hasLoop = true;
                    break;
                }
            }

            if (hasLoop)
            {
                slowPtr = head;
                while (slowPtr != fastPtr)
                {
                    slowPtr = slowPtr.next;
                    fastPtr = fastPtr.next;
                }
            }
            return slowPtr;
        }
    }
}

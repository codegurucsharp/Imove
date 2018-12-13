using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LeetCode
{
    class BinsrchAlgos
    {
        public int PeakIndexInMountainArrayiterative(int[] A)
        {
            int i = 0;
            while (A[i] < A[i + 1]) i++;

            return i;
        }
        public int PeakIndexInMountainArray(int[] A)
        {
            return PeakIndexInMountainArray(A, 0, A.Length - 1);
        }
        public int PeakIndexInMountainArray(int[] A, int lo, int hi)
        {
            if (lo == hi) return lo;
            if (lo > hi) return -1;
            int mid = lo + (hi - lo) / 2;

            // found the number
            if (A[mid - 1] < A[mid] && A[mid] > A[mid + 1])
            {
                return mid;
            }
            else if (A[mid - 1] < A[mid])
            {
                return PeakIndexInMountainArray(A, mid+1, hi);
            }
            else return PeakIndexInMountainArray(A, lo, mid);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DeleteColumnstoMakeSorted
    {
        public int MinDeletionSize(string[] A)
        {
            int max = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i][j] > A[i][j + 1])
                    {
                        max++; break;
                    }
                }
            }
            return max;
        }
    }
}

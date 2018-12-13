using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RobotReturnToOrigin
    {
        public bool JudgeCircle(string moves)
        {
            if (moves == null) return true;

            int x = 0;
            int y = 0;
            foreach (var item in moves)
            {
                if (item.ToString().ToLower() == "l") x--;
                if (item.ToString().ToLower() == "r") x++;
                if (item.ToString().ToLower() == "u") y++;
                if (item.ToString().ToLower() == "d") y--;
            }

            return x == 0 && y == 0;
        }
    }
}

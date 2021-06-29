using System;
using System.Collections.Generic;
using System.Text;

namespace TestClassLib
{
   public class LargestRectangleInHistoSolution
    {   
        public int largestRectangleArea (int[] heights)
        {// { 2, 1, 5, 6, 2, 3 }
            int len = heights.Length;
            Stack<int> s = new Stack<int>();
            int maxArea = 0;
            for (int i = 0; i <= len; i++)
            {
                int h = (i == len ? 0 : heights[i]);
                if (s.Count == 0 || h >= heights[s.Peek()])
                {
                    s.Push(i);
                }
                else
                {
                    int tp = s.Pop();
                    maxArea = Math.Max(maxArea, heights[tp] * (s.Count == 0 ? i : i - 1 - s.Peek()));
                    i--;
                }
            }

                return maxArea;
        }
    }
}

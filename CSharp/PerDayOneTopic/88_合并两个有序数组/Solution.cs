using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerDayOneTopic._88_合并两个有序数组
{
    public class Solution
    {
        #region 示例1
        public static List<int> Input1 = new List<int>()
        {
            1,2,3,0,0,0
        };

        public static List<int> Input2 = new List<int>()
        {
            2,5,6
        };

        public static List<int> Out = new List<int>()
        {
            1,2,2,3,5,6
        };
        #endregion

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] merge = new int[m + n];
            int p1 = 0;
            int p2 = 0;
            int cur = 0;

            while (p1<m || p2<n) 
            {
                if(p1 == m)
                {
                    cur = nums2[p2];
                    p2++;
                }
                else if( p2 == n) 
                {
                    cur = nums1[p1];
                    p1++;
                }
                else if (nums1[p1] < nums2[p2])
                {
                    cur = nums1[p1];
                    p1++;
                }
                else
                {
                    cur = nums2[p2];
                    p2++;
                }

                merge[p1 + p2 - 1] = cur;
            }
            for (int i = 0; i < m+n; i++)
            {
                nums1[i] = merge[i];
            }
        }
    }
}

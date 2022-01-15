using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotenet_leetCode.数组类算法
{
    internal class 删除排序数组中的重复项2
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (len < 2 || nums[i] != nums[len - 2])
                    nums[len++] = nums[i];
            }
            return len;
        }
    }
}

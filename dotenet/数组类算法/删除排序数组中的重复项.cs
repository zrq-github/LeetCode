using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotenet_leetCode.数组类算法
{
    internal class 删除排序数组中的重复项
    {
        /// <summary>
        /// 给你一个有序数组 nums ，请你 原地 删除重复出现的元素，使每个元素 只出现一次 ，返回删除后数组的新长度。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            int valIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[valIndex] < nums[i])
                {
                    valIndex++;
                    nums[valIndex] = nums[i];
                }
            }
            return valIndex + 1;
        }
    }
}

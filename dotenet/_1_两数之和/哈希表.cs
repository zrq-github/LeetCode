﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotenet_leetCode._1_两数之和
{
    /// <summary>
    /// 
    /// </summary>
    internal class 哈希表
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // key->值
            // value->数组下标
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int keyValue = target - nums[i];
                if (result.TryGetValue(keyValue, out int value))
                {
                    return new int[] { i, value };
                }
                else
                {
                    result[nums[i]] = i;
                }
            }
            return nums;
        }
    }
}

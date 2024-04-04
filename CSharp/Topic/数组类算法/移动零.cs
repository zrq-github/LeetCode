﻿namespace Topic.数组类算法
{
    //给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
    //示例:
    //输入: [0,1,0,3,12]
    //    输出: [1,3,12,0,0]
    //    说明:
    //必须在原数组上操作，不能拷贝额外的数组。
    //尽量减少操作次数。
    internal class 移动零
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 双链思路，很像链表倒叙
        /// </remarks>
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
                return;

            int zeroIndex = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    // 初始化零的位置
                    if (zeroIndex == int.MinValue)
                    {
                        zeroIndex = i;
                    }
                    continue;
                }
                else
                {
                    if (zeroIndex == int.MinValue) continue;
                    nums[zeroIndex] = nums[i];
                    nums[i] = 0;
                    zeroIndex++;
                }
            }
        }
    }
}

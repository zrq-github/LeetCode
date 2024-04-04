using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Topic;

public class Topic_27_移除元素
{
    private static readonly int[] t_nums = new int[4] { 3, 2, 2, 3 };

    public static int RemoveElement(int[] nums, int val)
    {
        nums = new int[t_nums.Length];
        nums = t_nums;

        // 双指针
        // 左指针遇val就跟右指针对换
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            if (nums[left] == val)
            {
                nums[left] = nums[right - 1];
                right--;
            }
            else
            {
                left++;
            }
        }

        return left;
    }
}
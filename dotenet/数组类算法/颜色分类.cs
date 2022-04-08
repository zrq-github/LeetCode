using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotenet_leetCode.数组类算法
{
    internal class 颜色分类
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 你可以不使用代码库中的排序函数来解决这道题吗？
        /// 你能想出一个仅使用常数空间的一趟扫描算法吗？
        /// </remarks>
        public void SortColors(int[] nums)
        {
            int front = 0;
            int mid = 0;
            int later = nums.Length - 1;

            while (mid <= later)
            {
                if (nums[mid] == 0)
                {
                    if (nums[front] != 0)
                        Swap(ref nums, ref front, ref mid);
                    front++;
                }

                if (nums[mid] == 2)
                {
                    if (nums[later] != 2)
                        Swap(ref nums, ref mid, ref later);
                    later--;
                }
                else
                {
                    mid++;
                }
            }

            void Swap(ref int[] nums, ref int a, ref int b)
            {
                int t = nums[a];
                nums[a] = nums[b];
                nums[b] = t;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 因为0,1,2
        /// 0在数组前，2在数组后，1在中间
        /// 类式于建立双链表，在首位各建立一个标识。 front later
        /// 如果遇到2就和 later 交换 遇到1就和front交换
        /// </remarks>
        public static void SortColors_QuickRow(int[] nums)
        {
            int front = 0;
            int mid = 0;
            int later = nums.Length - 1;

            while (mid <= later)
            {
                if (nums[mid] == 0)
                {
                    Swap(ref nums, front, mid);
                    front++;
                }

                if (nums[mid] == 2)
                {
                    Swap(ref nums, mid, later);
                    later--;
                }
                else
                {
                    mid++;
                }
            }

            static void Swap(ref int[] nums, int a, int b)
            {
                int t = nums[a];
                nums[a] = nums[b];
                nums[b] = t;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 最简答的一种解法
        /// 遍历一次数组，记录0,1,2各有多少个。
        /// 然后重写nums
        /// 这种算是分治？
        /// </remarks>
        public static void SortColors_Dic(int[] nums)
        {
            Dictionary<int, int> colors = new Dictionary<int, int>();
            colors.Add(0, 0);
            colors.Add(1, 0);
            colors.Add(2, 0);
            for (int j = 0; j < nums.Length; j++)
            {
                colors[nums[j]]++;
            }
            int i = 0;
            int num = 0;
            foreach (var keypair in colors)
            {
                for (int j = 0; j < keypair.Value; j++)
                {
                    nums[num] = i;
                    num++;
                }
                i++;
            }
        }
    }
}

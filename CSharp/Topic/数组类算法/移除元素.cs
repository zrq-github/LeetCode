namespace Topic.数组类算法
{
    internal class 移除元素
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int valIndex = 0;
            int valCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    if (valCount == 0)
                    {
                        valIndex = i;
                    }
                    valCount++;
                }
                else
                {
                    if (valCount == 0) continue;
                    nums[valIndex] = nums[i];
                    nums[i] = val;
                    valIndex++;
                }
            }
            return nums.Count() - valCount;
        }
    }
}

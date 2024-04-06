namespace Topic;

public class Solution
{
    /// <summary>
    /// 26. 删除有序数组中的重复项
    /// </summary>
    public int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 1)
        {
            return 1;
        }

        var p1 = 0;
        var p2 = 1;
        var total = 1;

        while (p2 < nums.Length)
        {
            if (nums[p1] != nums[p2])
            {
                p1++;
                nums[p1] = nums[p2];
                total++;
            }
            else
            {
                p2++;
            }
        }

        return total;
    }
}

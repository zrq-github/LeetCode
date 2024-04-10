namespace Topic;

public class Topic_80_删除有序数组中的重复项_II
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        var p1 = 2;
        var p2 = 2;

        while (p2 < nums.Length)
        {
            if (nums[p1-2] != nums[p2])
            {
                nums[p1] = nums[p2];
                p1++;
            }
            p2++;
        }
        return p1;
    }
}

namespace Topic;

public class Topic_189_轮转数组
{
    public void Rotate(int[] nums, int k)
    {
        var temp = new List<int>();
        var len = nums.Length;

        if(k == nums.Length)
        {
            return;
        }

        var startIndex = len - k;
        while (startIndex <len ) 
        {
            temp.Add(nums[startIndex]);
            startIndex++;
        }
        startIndex = 0;
        while (startIndex <= k)
        {
            temp.Add(nums[startIndex]);
            startIndex++;
        }

        if(temp.Count == 0)
        {
            return;
        }
        for(int i = 0; i < len; i++)
        {
            nums[i] = temp[i];
        }
    }
}

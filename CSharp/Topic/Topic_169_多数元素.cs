namespace Topic;

public class Topic_169_多数元素
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            dic.TryAdd(num, 0);
            dic[num]++;
        }

        foreach (var item in dic)
        {
            if(item.Value > nums.Length/2) 
            {
                return item.Key;
            }
        }
        return 0;
    }
}

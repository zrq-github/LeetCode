namespace Topic.每日一题;

public class Topic_1742_盒子中小球的最大数量 
{
    public class Solution {
        public int CountBalls(int lowLimit, int highLimit)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();
            int res = 0;

            for (int i = lowLimit; i <= highLimit; i++)
            {
                int box = 0;
                int x = i;
                
                // 计算int数字和
                while (x !=0 )
                {
                    box += x % 10;
                    x /= 10;
                }
                
                map.TryAdd(box, 0);
                map[box]++;
                res = Math.Max(res, map[box]);
            }
            return res;

            return 0;
        }
    }
}
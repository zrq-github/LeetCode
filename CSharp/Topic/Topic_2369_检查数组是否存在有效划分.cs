namespace Topic;

public class Topic_2369_检查数组是否存在有效划分
{

    // nums = [4,4,4,5,6]
    public static int[] GetTestCase()
    {
        return new[] { 211069, 211070, 211071, 211072, 211073, 211074, 211075, 211076, 211077, 103728, 103728, 103728, 70201, 70201, 70201, 377477, 377477, 377477, 74627, 74627, 653023, 653023, 458636, 458637, 458638, 458639, 458640, 458641, 458642, 458643, 458644 };
    }

    public static int[] GetTestCase2()
    {
        return new[] { 10, 20, 30 };
    }

    static bool CanSplitToSumOf2And3(int num)
    {
        if (num % 3 == 0) return true;
        if (num % 2 == 0) return true;
        if (num % 3 % 2 == 0) return true;

        return false;
    }

    static bool CanSplit3(int num1, int num2, int num3)
    {
        return num1 == num2 && num1 == num3 || num1 + 1 == num2 && num2 + 1 == num3;
    }

    static bool CanSplit2(int num1, int num2)
    {
        return num1 == num2;
    }

    // public static bool ValidPartition(int[] nums)
    // {
    //     int n = nums.Length;
    //     bool[] dp = new bool[n + 1];
    //     dp[0] = true;
    //     for (int i = 1; i <= n; i++) {
    //         if (i >= 2) {
    //             dp[i] = dp[i - 2] && CanSplit2(nums[i - 2], nums[i - 1]);
    //         }
    //         if (i >= 3) {
    //             dp[i] = dp[i] || (dp[i - 3] && CanSplit3(nums[i - 3], nums[i - 2], nums[i - 1]));
    //         }
    //     }
    //     return dp[n];
    // }

    public static bool ValidPartition(int[] nums)
    {
        var numsSize = nums.Length;
        bool[] dp = new bool[numsSize + 1];
        dp[0] = true;
        for (int i = 1; i <= numsSize; i++)
        {
            if (i >= 2)
            {
                dp[i] = dp[i - 2] && CanSplit2(nums[i - 2], nums[i - 1]);
            }
            if (i >= 3)
            {
                dp[i] = dp[i] || dp[i - 3] && CanSplit3(nums[i - 3], nums[i - 2], nums[i - 1]);
            }
        }
        return dp[numsSize];
    }
}
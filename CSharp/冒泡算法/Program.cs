namespace 冒泡算法;

internal class Program
{
    private static void BubbleSort(int[] arr)
    {
        var n = arr.Length;
        for (var i = 0; i < n - 1; i++)
        {
            var swapped = false;
            // 注意这里n-i-1，因为每次外层循环后最大的元素都会被放到正确的位置
            for (var j = 0; j < n - 1 - i; j++) 
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }

            // 如果在某次内层循环中没有发生交换，则说明数组已经是有序的了
            if (!swapped)
                break;
        }
    }

    private static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(array);
        Console.WriteLine("Sorted array is:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}

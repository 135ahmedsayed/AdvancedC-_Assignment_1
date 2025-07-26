namespace AdvancedC__Assignment_01;
#region Q1
public static class BubbleSort
{
    public static void BubbleSortAlgorithm<T>(T[] arr)
        where T : IComparable<T>
    {
        if (arr is null)
            throw new ArgumentNullException(nameof(arr));
        T other;
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j].CompareTo(arr[j + 1]) == 1)
                {
                    other = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = other;
                }
    }
    public static void Result<T>(T[] values)
    {
        foreach (var item in values)
        {
            Console.Write(item + " ");
        }
    }
}
#endregion

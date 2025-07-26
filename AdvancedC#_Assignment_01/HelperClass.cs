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

#region Q2
public class Range<T>
    where T : IComparable<T>
{
    public T? Minimum { get; set; }
    public T? Maximum { get; set; }
    public T? difference { get; set; }

    //constructor
    public Range(T min, T max)
    {
        Minimum = min;
        Maximum = max;
    }
    //check if the value is in range
    public bool IsInRange(T value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));
        Console.Write($"Is {value} is within the range ? ");
        return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
    }
    //calculate the length of the range
    public void Length()
    {
        if (Minimum is null && Maximum is null)
            Console.WriteLine("Minmum And Maxmum are Null");
        difference = (dynamic)Maximum - (dynamic)Minimum;
        Console.WriteLine($"The Length of the Range is : {Maximum} - {Minimum} = {difference}");
    }
}
#endregion

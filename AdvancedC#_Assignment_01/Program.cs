namespace AdvancedC__Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] Numbers = { 21, 10, 1, 2, 3, 12, 90, 9 };
            Console.Write("Before Sorting : ");
            BubbleSort.Result(Numbers);
            Console.Write("\nAfter Sorting : ");
            BubbleSort.BubbleSortAlgorithm(Numbers);
            BubbleSort.Result(Numbers);
            Console.WriteLine("\n");
            #endregion
            Console.ReadKey();
        }
    }
}

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

            #region Q2
            Range<double> range = new Range<double>(90.20, 99.22);
            Console.WriteLine($"Maximum = {range.Maximum} && Minimum = {range.Minimum}");
            Console.WriteLine(range.IsInRange(91));
            range.Length();
            #endregion
            Console.ReadKey();
        }
    }
}

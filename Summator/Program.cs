namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The average is : " + Summator.Average(new int[] { 4, 5, 7 }));
            Console.WriteLine(Summator.Multiply(new double[] { 4, 8}));
        }
    }
}
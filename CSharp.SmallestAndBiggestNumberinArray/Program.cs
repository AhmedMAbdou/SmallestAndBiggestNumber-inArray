namespace CSharp.SmallestAndBiggestNumberinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the num of items: ");
            int items = int.Parse(Console.ReadLine());

            double[] arr = new double[items];
            for (int i = 0; i < items; i++)
            {
                Console.Write($"Enter the num {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }


            double sum = 0, smallest = double.MaxValue, greatest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                    smallest = arr[i];
                if (arr[i] > greatest)
                    greatest = arr[i];

                sum += arr[i];
            }
            double Avg = sum / items;
            Console.WriteLine($"small={smallest},big={greatest},Avg= {Avg}");
        }
    }
}

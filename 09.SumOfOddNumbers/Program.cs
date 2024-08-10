namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            int countOddNumbers = int.Parse(Console.ReadLine());

            int sumOddNumbers = 0;
            int oddNumber = 1;
            
            for (int i = 1; i <= countOddNumbers; i++)
            {
                    Console.WriteLine(oddNumber);
                    sumOddNumbers += oddNumber;
                    oddNumber += 2;

                             
            }

            Console.WriteLine($"Sum: {sumOddNumbers}");

        }
    }
}
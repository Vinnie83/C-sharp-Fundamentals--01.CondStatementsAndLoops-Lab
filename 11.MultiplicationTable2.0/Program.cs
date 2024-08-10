namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());


            if (multiplier > 10)
            {
                int result = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {result}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int result = n * i;

                    Console.WriteLine($"{n} X {i} = {result}");

                }
            }
                      
        }
    }
}
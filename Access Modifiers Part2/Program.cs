using Access_Modifiers_Part_2.Service;

namespace Access_Modifiers_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new();

            Console.WriteLine(calculation.Calc(12, 2, '/'));
        }
    }
}

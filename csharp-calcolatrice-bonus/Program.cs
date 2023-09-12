namespace csharp_calcolatrice_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interoA = 5;
            int interoB = 30;
            int interoZero = 0;

            Console.WriteLine($"Il numero {interoA} alla potenza di {interoB} è: {CalcoliHelper.Exponent(interoA, interoB)}");
            Console.WriteLine($"Il numero {interoZero} alla potenza di {interoZero} è: {CalcoliHelper.Exponent(interoZero, interoZero)}");
            Console.WriteLine($"Il numero {interoA} alla potenza di {interoZero} è: {CalcoliHelper.Exponent(interoA, interoZero)}");


        }
    }
}
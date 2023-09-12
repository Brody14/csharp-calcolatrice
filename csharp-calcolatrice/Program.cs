using System.Security.Cryptography.X509Certificates;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int interoA = 5;
            int interoB = 30;
            int interoNeg = -8;
            double doubleA = 5.2;
            double doubleB = 99.8;
            double doubleNeg = -58.65;

            //Somma di due numeri interi
            Console.WriteLine($"La somma tra {interoA} e {interoB} è: {CalcoliHelper.IntSum(interoA, interoB)}");

            //Somma di due numeri double

            Console.WriteLine($"La somma tra {doubleA} e {doubleB} è: {CalcoliHelper.DoubleSum(doubleA, doubleB)}");

            //Differenza tra due numeri interi

            Console.WriteLine($"La differenza tra {interoA} e {interoB} è: {CalcoliHelper.IntSubtraction(interoA, interoB)}");


            //Differenza tra due numeri double

            Console.WriteLine($"La differenza tra {doubleA} e {doubleB} è: {CalcoliHelper.DoubleSubtraction(doubleA, doubleB)}");

            //Moltiplicazione di due numeri interi

            Console.WriteLine($"La moltiplicazione tra {interoA} e {interoB} è: {CalcoliHelper.IntMultiplication(interoA, interoB)}");


            //Moltiplicazione di due numeri double

            Console.WriteLine($"La moltiplicazione tra {doubleA} e {doubleB} è: {CalcoliHelper.DoubleMultiplication(doubleA, doubleB)}");


            //Valore assoluto di un numero intero

            Console.WriteLine($"Il valore assoluto di {interoNeg} è {CalcoliHelper.IntAbsoluteValue(interoNeg)}");


            //Valore assoluto di un numero double

            Console.WriteLine($"Il valore assoluto di {doubleNeg} è {CalcoliHelper.DoubleAbsoluteValue(doubleNeg)}");

            //Minimo tra due numeri interi

            Console.WriteLine($"Il valore minimo tra {interoA} e {interoB} è: {CalcoliHelper.IntMin(interoA, interoB)}");


            //Minimo tra due numeri double

            Console.WriteLine($"Il valore minimo tra {doubleA} e {doubleB} è: {CalcoliHelper.DoubleMin(doubleA, doubleB)}");


            //Massimo tra due numeri interi

            Console.WriteLine($"Il valore massimo tra {interoA} e {interoB} è: {CalcoliHelper.IntMax(interoA, interoB)}");


            //Massimo tra due numeri double

            Console.WriteLine($"Il valore massimo tra {doubleA} e {doubleB} è: {CalcoliHelper.DoubleMax(doubleA, doubleB)}");


        }
    }
}
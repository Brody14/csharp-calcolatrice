using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice_bonus
{
    public static class CalcoliHelper
    {
        //METODI STATICI

        //Somma di due numeri interi
        public static int IntSum(int a, int b)
        {
            return a + b;
        }

        //Somma di due numeri double
        public static double DoubleSum(double a, double b)
        {
            return a + b;
        }

        //Differenza tra due numeri interi

        public static int IntSubtraction(int a, int b)
        {
            return a - b;
        }

        //Differenza tra due numeri double

        public static double DoubleSubtraction(double a, double b)
        {
            return a - b;
        }

        //Moltiplicazione di due numeri interi

        public static int IntMultiplication(int a, int b)
        {
            return a * b;
        }

        //Moltiplicazione di due numeri double

        public static double DoubleMultiplication(double a, double b)
        {
            return a * b;
        }

        //Valore assoluto di un numero intero

        public static int IntAbsoluteValue(int a)
        {
            return Math.Abs(a);
        }

        //Valore assoluto di un numero double

        public static double DoubleAbsoluteValue(double a)
        {
            return Math.Abs(a);
        }

        //Minimo tra due numeri interi

        public static int IntMin(int a, int b)
        {
            return Math.Min(a, b);
        }

        //Minimo tra due numeri double

        public static double DoubleMin(double a, double b)
        {
            return Math.Min(a, b);
        }

        //Massimo tra due numeri interi

        public static int IntMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        //Massimo tra due numeri double

        public static double DoubleMax(double a, double b)
        {
            return Math.Max(a, b);
        }

        /*Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e 
         * ritorna la base elevata all’esponente.
        Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi! (caso esponente = 0 e base = 0 
        anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)*/
        public static double Exponent(int baseNumber, int exponentNumber)
        {
            if(baseNumber == 0 && exponentNumber == 0)
            {
                return 1;
            }

            return Math.Pow(baseNumber, exponentNumber);
        }

    }
}

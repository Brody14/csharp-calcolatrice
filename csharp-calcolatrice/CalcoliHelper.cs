using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    /*Creare una classe di helper CalcoliHelper.
    Come visto a lezione, strutturare la classe in modo che non possa essere istanziata*/
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
           if(a < 0)
            {
                return (-1) * a;
            }else
            {
                return a;
            }
        }

        //Valore assoluto di un numero double

        public static double DoubleAbsoluteValue(double a)
        {
            if (a < 0)
            {
                return (-1) * a;
            }
            else
            {
                return a;
            }
        }

        //Minimo tra due numeri interi

        public static int IntMin(int a, int b)
        {
            if(a > b)
            {
                return b;
            }else
            {
                return a;
            }
        }

        //Minimo tra due numeri double

        public static double DoubleMin(double a, double b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        //Massimo tra due numeri interi

        public static int IntMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //Massimo tra due numeri double

        public static double DoubleMax(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        /*Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi 
         * di programmazione ad oggetti che abbiamo visto...Quale? Overload*/
    }
}

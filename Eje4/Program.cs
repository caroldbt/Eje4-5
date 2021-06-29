using System;

namespace Eje4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("+---------Ejercicio 4--------+");
            int N = 1;
            int incrementa = (int)(N + 77);
            int decrementa = incrementa - 3;
            int duplica = decrementa * 2;

            System.Console.WriteLine("Incrementar en 77: " + incrementa);
            System.Console.WriteLine("Decrementar en 3: " + decrementa);
            System.Console.WriteLine("Duplicar su valor: " + duplica);

        }
    }
}

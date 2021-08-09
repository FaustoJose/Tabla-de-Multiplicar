using System;

namespace Tabla_de_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            tablaMultiplicar(5);
        }
        public static void tablaMultiplicar(int num)
        {
            int rus;
            for (int i=0;i<=10;i++) 
            {
                rus = num * i;
                Console.WriteLine(num+" x "+i+" = "+rus);
            }
        }
    }
}

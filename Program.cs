using System;

namespace Ucgen_Cizim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin kenar uzunluğu ne olsun?: ");
            int kenarUzunluk = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= kenarUzunluk; i++)
            {
                for (int j = 0; j < kenarUzunluk - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
        }
    }
}
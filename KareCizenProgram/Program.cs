using System;

namespace KareCizenProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kare oluşturmak için kenar uzunluğu için sayı girmelisiniz.");

            Console.WriteLine("Kenar uzunluğu : ");
            int kenarUzunlugu = int.Parse(Console.ReadLine());

            for (int i = 0; i < kenarUzunlugu; i++)
            {
                for (int j = 0; j < kenarUzunlugu; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

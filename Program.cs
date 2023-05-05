using System;

namespace Math.Pow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sonuc = UsAl(2, 3);
            Console.WriteLine(sonuc);

        }

        public static int UsAl(int tabanSayi, int us)

        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= tabanSayi;
            }
            return sonuc;
        }

    }
}


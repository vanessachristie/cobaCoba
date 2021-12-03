using System;

namespace cobaCoba
{
    class Program
    {
        static void Main(string[] args)
        {
            int statusProgram = 1;
            while (statusProgram == 1)
            {
                int HasilBagi = 0;
                Console.Write("Masukkan angka: ");
                int input = Convert.ToInt32(Console.ReadLine());
                int m = input / 2;
                for (int i = 2; i <= m; i++)
                {
                    if (input % i == 0)
                    {
                        HasilBagi += 1;
                    }
                }
                if (HasilBagi == 0)
                    Console.WriteLine("Angka prima");
                else
                    Console.WriteLine("Bukan angka prima");
            }   
        }
    }
}

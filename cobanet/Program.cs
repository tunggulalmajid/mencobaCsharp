using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobanet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan kata >> ");
            string tanya = Console.ReadLine();
            Console.WriteLine($"kata yang anda masukkan adalah {tanya}");
            if (tanya.Length > 5) 
            {
                Console.WriteLine("kata yang anda masukkan lebih dari 5 karakter");
            }
            else
            {
                Console.WriteLine("kata yang anda masukkan kurang dari 5 karakter");
            }
            Console.Write("Masukkan angka >> ");
            int angka = Convert.ToInt32(Console.ReadLine());
            if (angka < tanya.Length)
            {
                Console.WriteLine($"{angka} lebih kecil daripada {tanya.Length}");
            }
            else if (angka == tanya.Length)
            {
                Console.WriteLine($"{angka} sama dengan {tanya.Length}");
            }
            else
            {
                Console.WriteLine($"{angka} lebih besar daripada {tanya.Length}");
            }

            Console.ReadLine();

            // do while (checking di awal )
            int c = 0;
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c < 5);
            Console.ReadLine();

            // for 
            // rumus untuk for : for (inisialisasi;kondisi;increment)
            string batas = "abcde";
            for (int i = 0; i < batas.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //foreach i in batas
            //{
            //    Console.WriteLine(i);
            //}
            







        }
    }
}

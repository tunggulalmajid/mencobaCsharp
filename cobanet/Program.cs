﻿using System;
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
            // inputan
            string tanya = Console.ReadLine();
            Console.WriteLine($"kata yang anda masukkan adalah {tanya}");
            
            // perkondisian
            if (tanya.Length > 5) 
            {
                Console.WriteLine("kata yang anda masukkan lebih dari 5 karakter");
            }
            else
            {
                Console.WriteLine("kata yang anda masukkan kurang dari 5 karakter");
            }
            Console.Write("Masukkan angka >> ");

            //casting ke int
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

            angka += 25;
            Console.WriteLine(angka);

            //increment dan degrement
            angka++;
            Console.WriteLine(angka);
            angka--;
            Console.WriteLine(angka);

            // prefiks dan postfiks
            // ++x dan x++
            Console.ReadLine();

            //pengulangan 
            //while statement
            int x = 1;
            while (x < 5)
            {
                if (x == 4)
                {
                    x++;
                    continue;
                }
                else
                {
                    Console.WriteLine(x);
                    x++;
                }
            }

            Console.ReadLine();
        }
    }
}

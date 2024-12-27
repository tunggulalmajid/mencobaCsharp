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
            Console.WriteLine("masukkan kata >> ");
            string tanya = Console.ReadLine();
            Console.WriteLine($"kata yang anda masukkan adalah {tanya}");
        }
    }
}

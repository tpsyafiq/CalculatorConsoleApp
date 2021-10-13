using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine());

            // membuat objek Calculator menggunakan keyword var
            var cal = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, cal.Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, cal.Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} x {1} = {2}", a, b, cal.Perkalian(a, b));
            
            // khusus method pembagian diapnggil langsung dari class calculator
            // karena merupakan method static
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Pembagian(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, cal.Pangkat(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Calculator.Modulo(a, b));

            Console.ReadKey();
        }
    }
}

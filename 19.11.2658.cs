using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
  class Program
  {
    static void Main(string[]args)
    {
      Console.WriteLine("Pilih Menu Kalkulator");
      Console.WriteLine();
      Console.WriteLine("1. Penambahan");
      Console.WriteLine("2. Pengurangan");
      Console.WriteLine("3. Perkalian");
      Console.WriteLine("4. Pembagian");
      Console.WriteLine();

      Console.WriteLine("Input Menu [1...4] : ");
      int menu =int.Parse(Console.ReadLine());
      Console.WriteLine();

    }
  }
}

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

      if(menu > 0 && menu < 5){
        Console.Write("Input Nilai A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input Nilai B = ");
        int b = Convert.ToInt32(Console.ReadLine());

        switch(menu){
          case 1:
            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan " + a + "+" + b + " = " + Penambahan(a, b));
            break;
          case 2:
            Console.WriteLine();
            Console.WriteLine("Hasil Pengurangan : {0} - {1} = {2}", a, b, Pengurangan(a, b));
            break;
          case 3:
            Console.WriteLine();
            Console.WriteLine("Hasil Perkalian : {0} * {1} = {2}", a, b, Perkalian(a, b));
            break;
          case 4:
            Console.WriteLine();
            Console.WriteLine("Hasil Pembagian : {0} / {1} = {2}", a, b, Pembagian(a, b));
            break;
        }
      }else{
        Console.WriteLine("\nMaaf menu yang anda pilih tidak tersedia");
      }
      Console.WriteLine();
      Console.WriteLine("\nTekan key apapun untuk keluar");
      Console.ReadKey();
    }
    static int Penambahan(int a, int b){
      return a + b;
    }
    static int Pengurangan(int a, int b){
      return a - b;
    }
    static int Perkalian(int a, int b){
      return a * b;
    }
    static int Pembagian(int a, int b){
      return a / b;
    }
  }
}

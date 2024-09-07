using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lab1 {
    
    class Program{
        static void Main(){
            Console.Clear();
            Console.WriteLine("\tВведите первую дробь: ");
            NumFraction chislo1 = new NumFraction();
            Console.WriteLine("\n\tВведите вторую дробь: ");
            NumFraction chislo2 = new NumFraction(), chislo3;
            Console.WriteLine(chislo1);
           //int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
           //nums3.GetUpperBound();
          // NumFraction chislo1 = new NumFraction(7, 9), chislo2 = new NumFraction(8,4), chislo3;
            
            Console.Write("\n\tВыполненные операции с числами ");
            chislo3 = chislo1 + chislo2;
            string Str;
            Str = chislo3.ToString();
            Console.WriteLine("\nРезультат сложения: "+ Str);

            chislo3 = chislo1 - chislo2;
            Str = chislo3.ToString();
            Console.WriteLine("\nРезультат вычитания: " + Str);

            chislo3 = chislo1 * chislo2;
            Str = chislo3.ToString();
            Console.WriteLine("\nРезультат умножения: " + Str);

            chislo3 = chislo1 / chislo2;
            Str = chislo3.ToString();
            Console.WriteLine("\nРезультат деления: " + Str);

            chislo3 = -chislo1;
            Str = chislo3.ToString();
            Console.WriteLine("\nРезультат операции унарного - к первому числу: " + Str);


            
            Console.WriteLine("\nРезультат сравнения число1 > числа2? : " + (chislo1>chislo2));
            Console.WriteLine("\nРезультат сравнения число1 < числа2? : " + (chislo1<chislo2));

            Console.WriteLine("\nРезультат сравнения число1 >= числа2? : " + (chislo1>=chislo2));
            Console.WriteLine("\nРезультат сравнения число1 <= числа2? : " + (chislo1<=chislo2));

            Console.WriteLine("\nРезультат сравнения число1 == числа2? : " + (chislo1==chislo2));
            Console.WriteLine("\nРезультат сравнения число1 != числа2? : " + (chislo1!=chislo2) + "\n\n\n");
        }
    }
}
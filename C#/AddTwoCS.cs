/*
Aliyah Millán
CPSC-362
6 May 2022
*/

using System;
class Program {
  static void Main(string[] args) {
      int num1, num2, sum;
      Console.WriteLine("++++++++++++ADDITION CALCULATOR++++++++++++");
      Console.Write("What is the first number you want to add? ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("What is the second number? ");
      num2 = Convert.ToInt32(Console.ReadLine());
      sum = num1 + num2;
      Console.Write("Sum = " + sum + "\n");
      Console.ReadKey();
  }
}

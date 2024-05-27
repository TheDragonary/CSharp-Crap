using System;

class Program {
  static public void Main(String[] args){ 
    while (true){
      Console.WriteLine("Check if a number is even or odd:");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number % 2 == 0){
        Console.WriteLine("Even");
      }
      else if (number % 2 != 0){
        Console.WriteLine("Odd");
      }
      Console.WriteLine();
      Console.WriteLine("Press Enter to restart:");
      Console.ReadLine();
      Console.Clear();
    }
  }
}
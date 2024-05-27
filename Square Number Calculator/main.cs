using System;

class Program {
  public static void Main (string[] args) {
    while (true){
      Console.WriteLine ("Input number to square:");
      double num = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(num * num);
      Console.WriteLine();
      Console.WriteLine("Press Enter to restart or any other key to exit:");
      if(Console.ReadKey().Key == ConsoleKey.Enter){
        Console.Clear();
      }
      else{
        System.Environment.Exit(1);
      }
    }
  }
}
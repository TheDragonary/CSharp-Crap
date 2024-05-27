using System;

class Program {
  public static void Main (string[] args) {
    Calculator.calculator();
  }
}

public class Calculator{
  public static void calculator(){
    while(true){
      Console.WriteLine ("Input number:");
      double num1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Input second number:");
      double num2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Choose operator (+, -, *, /, %):");
      string op = Console.ReadLine();
      double answer = 0;
      if(op == "+"){
        answer = num1 + num2;
      }
      if(op == "-"){
        answer = num1 - num2;
      }
      if(op == "*"){
        answer = num1 * num2;
      }
      if(op == "/"){
        answer = num1 / num2;
      }
      if(op == "%"){
        answer = num1 % num2;
      }
      Console.WriteLine(Math.Round(answer, 2));
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

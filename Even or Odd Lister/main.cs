using System;

class Program {
  static public void Main(String[] args){
    static void IsEven(){
      int number = 0;
      while (true){
        if (number % 2 == 0){
          Console.WriteLine(number + " = Even");
        }
        else if (number % 2 != 0){
          Console.WriteLine(number + " = Odd");
        }
      number++;
      }
    }
    IsEven();
  }
}
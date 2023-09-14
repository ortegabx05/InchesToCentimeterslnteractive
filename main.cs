using System;

class Program {
  public static void Main (string[] args) {
    const double InchesToCentimetersInteractive = 2.54;

    Console.WriteLine("Enter the amount of inches to calculate to centimeters: ");
    double inches = Convert.ToInt32(Console.ReadLine());
    double cent = inches * InchesToCentimetersInteractive;
    
    Console.WriteLine ("{0} inches is {1} centimeters", inches, cent);
  }
}
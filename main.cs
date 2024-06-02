using System;

class Program {
  public static void Main (string[] args) {

            const double CentimetersInInch = 2.54;

            Console.Write("Enter a measurement in inches: ");
            string input = Console.ReadLine();

            double inches = Convert.ToDouble(input);

            double centimeters = inches * CentimetersInInch;

            Console.WriteLine("{0} inches is {1} centimeters.", inches, centimeters);

  }
}
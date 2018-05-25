using System;

namespace ClassProj2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Input number.");
			double inputNumber = double.Parse(Console.ReadLine());

			Console.WriteLine(Calculator.Addition(inputNumber));
			Console.ReadLine();
		}
    }
}

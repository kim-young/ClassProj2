using System;
namespace ClassProj2
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public static int Addition(int number)
		{
			int result = number + 100;
			return result;
		}
        
		public static double Addition(double number)
		{
			double result = (double)number + 200;
			return result;
		}

		public static int Addition(string number)
        {
			int result = int.Parse(number) + 500;
            return result;
        }
    }
}

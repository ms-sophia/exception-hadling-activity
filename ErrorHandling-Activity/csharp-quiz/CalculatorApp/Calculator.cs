namespace CalculatorApp;
using System;

public class DivideByZeroWithDoubleException : Exception
{

    //public DivideByZeroWithDoubleException() : base("Cannot divide by zero.") { }

    public DivideByZeroWithDoubleException(string message) : base(message) { }

    //public DivideByZeroWithDoubleException(string message, Exception inner) : base(message, inner) { }
}
public class Calculator
{
    public double PerformOperation(double num1, double num2, string operation)
    {
        double answer = 0;
      
            switch (operation)
            {
                case "add":
                    answer = num1 + num2;
                    break;

                case "subtract":
                    answer = num1 - num2;
                    break;


                case "multiply":
                    answer =  num1 * num2;
                    break;


                case "divide":
                if (num2 == 0.0)
                {
                    throw new DivideByZeroWithDoubleException("Cannot divide by zero.");
                }
                answer =  num1 / num2;
                    break;

            }


        // TODO: Implement the PerformOperation method
        //throw new NotImplementedException();
        return answer;
    }
}
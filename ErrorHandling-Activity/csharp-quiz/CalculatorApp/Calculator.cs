namespace CalculatorApp;

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
                    answer =  num1 / num2;
                    break;

            }


        // TODO: Implement the PerformOperation method
        throw new NotImplementedException();
        return answer;
    }
}
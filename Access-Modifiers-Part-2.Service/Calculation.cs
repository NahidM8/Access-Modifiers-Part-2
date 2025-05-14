namespace Access_Modifiers_Part_2.Service
{
    public class Calculation
    {
        public double Calc(double x, double y,char op)
        {
            double result = 0;
            switch(op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("0 a bolmek olmaz");
                        break;
                    }
                    else
                    {
                        result = x / y;
                        break;
                    }  
                default:
                    break;
            }

            return result;
        }
    }
}

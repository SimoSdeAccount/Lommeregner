using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operator;
            double firstNumber;
            double lastNumber = 1; //skal initieres med værdi fordi den kun bliver valgt på basis af valgt operator.
            double result = 0;
            Console.WriteLine("indtast operation: +, -, *, /, root, pow, fact");
            Operator = Console.ReadLine();
            Console.WriteLine("Indtast det første tal");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            if(Operator != "fact")
            {
                Console.WriteLine("Indtast det andet tal");
                lastNumber = Convert.ToDouble(Console.ReadLine());
            }
            switch(Operator)
            {
                case "+": 
                result = Adder(firstNumber, lastNumber);
                break;
                case "-":
                result = Subtractor(firstNumber, lastNumber);
                break;
                case "*":
                result = Multiplier(firstNumber, lastNumber);
                break;
                case "/":
                result = Divider(firstNumber, lastNumber);
                break;
                case "root": 
                result = Rooter(firstNumber, lastNumber);
                break;
                case "pow": 
                result = Power(firstNumber, lastNumber);
                break;
                case "fact": 
                result = Factorial(firstNumber);
                break;
                default: break;
            }
            while(true)
            {
                Console.WriteLine("The result is as follows:");
                Console.WriteLine(result);
                Console.WriteLine("Tast n hvis du ikke vil regne videre, ellers vælg operator og tal til at regne videre");
                Console.WriteLine("Operatore: +, -, *, /, root, pow, fact");
                string valg = Console.ReadLine();
                if(valg == "n")
                {
                    break;
                }
                else
                {
                    Operator = valg;
                    if(Operator != "fact")
                    {
                        Console.WriteLine("Vælg tal");
                        lastNumber = Convert.ToDouble(Console.ReadLine());
                    }
                    
                    switch (Operator)
                    {
                        case "+":
                            result += lastNumber;
                            break;
                        case "-":
                            result -= lastNumber;
                            break;
                        case "*":
                            result *= lastNumber;
                            break;
                        case "/":
                            result /= lastNumber;
                            break;
                        case "root":
                            result = Rooter(result, lastNumber);
                            break;
                        case "pow":
                            result = Power(result, lastNumber);
                            break;
                        case "fact":
                            result = Factorial(result);
                            break;
                        default:
                            Console.WriteLine("ugyldig operator");
                            break;
                    }
                }
            }
            Console.WriteLine("Tak fordi du benyttede dig af lommeregneren.");
            Console.ReadLine();
        }
        static double Factorial(double firstNumber)
        {
            double result = 1;
            for (int i = 0; i < firstNumber; i++)
            {
                result *= (firstNumber - i);
            }
            return result;
        }
        static double Power(double  firstNumber, double lastNumber)
        {
            return Math.Pow(firstNumber, lastNumber);
        }
        static double Rooter(double firstNumber, double lastNumber)
        {
            return Math.Pow(firstNumber, 1 / lastNumber);
        }
        static double Adder(double firstNumber, double lastNumber)
        {
            return firstNumber + lastNumber;
        }
        static double Subtractor(double firstNumber, double lastNumber)
        {
            return firstNumber - lastNumber;
        }
        static double Multiplier(double firstNumber, double lastNumber)
        {
            return firstNumber * lastNumber;
        }
        static double Divider(double firstNumber, double lastNumber)
        {
            try
            {
                return firstNumber / lastNumber;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }
    }
}
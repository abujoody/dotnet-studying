using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalculator
{
    class CalculatorInput
    {
        private string _firstArg;
        private string _secondArg;
        private string _operation;

        public string getFirstArg()
        {
            return _firstArg;
        }

        public string getSecondArg()
        {
            return _secondArg;
        }

        public string getOperation()
        {
            return _operation;
        }

        public void inputFirstArg()
        {
            Console.Write("Type first number, please: ");
            _firstArg = Console.ReadLine();
        }

        public void inputSecondArg()
        {
            Console.Write("Type second number, please: ");
            _secondArg = Console.ReadLine();
        }

        public void inputOperation()
        {
            Console.Write("Type operation, please: ");
            _operation = Console.ReadLine();
        }
    }

    class Calculator
    {
        public void showHelp()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Type two numbers and operation between them,\n" +
                              "like this: 5 + 7, 7 ^ 6, and so on and press Enter");
            Console.WriteLine();
            Console.WriteLine("Available operations: +, -, *, /, ^");
            Console.WriteLine();
            Console.WriteLine("To quit just type 'q' and press Enter");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();
        }

        public double performOperation(double firstArg, double secondArg, char operation)
        {
            double result = 0.0;
            switch (operation)
            {
                case '+':
                    result = firstArg + secondArg;
                    break;
                case '-':
                    result = firstArg - secondArg;
                    break;
                case '*':
                    result = firstArg * secondArg;
                    break;
                case '/':
                    if (secondArg != 0)
                    {
                        result = firstArg / secondArg;
                    }
                    else
                    {
                        Console.WriteLine("Error. Second arg is zero. Returned value is 0.0. Type correct numbers");
                    }
                    break;
                case '^':
                    result = Math.Pow(firstArg, secondArg);
                    break;
                default:
                    Console.WriteLine("Wrong operation. Available operations +, -, /, *, ^");
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static bool checkForQuit(string st)
        {
            return st.Equals("q");
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            CalculatorInput input = new CalculatorInput();

            while (true)
            {
                calc.showHelp();

                double firstArg = 0.0;
                double secondArg = 0.0;
                char operation = '\0';

                double result = 0.0;
                try
                {
                    input.inputFirstArg();
                    if (checkForQuit(input.getFirstArg()))
                        break;

                    firstArg = Convert.ToDouble(input.getFirstArg());

                    input.inputSecondArg();
                    if (checkForQuit(input.getSecondArg()))
                        break;

                    secondArg = Convert.ToDouble(input.getSecondArg());

                    input.inputOperation();
                    if (checkForQuit(input.getOperation()))
                        break;

                    operation = Convert.ToChar(input.getOperation());

                    result = calc.performOperation(firstArg, secondArg, operation);

                    Console.WriteLine("Result: {0}", result);
                }
                catch
                {
                    Console.WriteLine("Error. Wrong data. See help message");
                }

                if (checkForQuit(Console.ReadLine()))
                    break;
            }
        }
    }
}

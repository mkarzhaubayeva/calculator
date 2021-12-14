using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, ans;
            string restartCalc = "yes";
            bool isInvalidOp = true;
            bool isInvalidNum1 = true;
            bool isInvalidNum2 = true;
            string op;

            while (restartCalc == "yes")
            {
                Console.WriteLine("Choose an operation among {+, -, *, /}");
                while (isInvalidOp)
                {
                    
                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        isInvalidOp = false;
                        Console.WriteLine("Enter the first number.");
                        while (isInvalidNum1)
                        {
                            try
                            {
                                num1 = Convert.ToInt32(Console.ReadLine());
                                isInvalidNum1 = false;
                                Console.WriteLine("Enter the second number.");
                                while (isInvalidNum2)
                                {
                                    try
                                    {
                                        num2 = Convert.ToInt32(Console.ReadLine());
                                        isInvalidNum2 = false;
                                        if (op == "+")
                                        {
                                            ans = num1 + num2;
                                        } else if (op == "-")
                                        {
                                            ans = num1 - num2;
                                        } else if (op == "*")
                                        {
                                            ans = num1 * num2;
                                        } else
                                        {
                                            ans = num1 / num2;
                                        }
                                        Console.WriteLine("The answer is: {0}", ans);
                                        Console.WriteLine("Do you want to make one more calculation? Enter yes or no.");
                                        if (Console.ReadLine() == "no")
                                        {
                                            restartCalc = "no";
                                            break;

                                        } else
                                        {
                                            //restartCalc = "yes";
                                            isInvalidOp = true;
                                            isInvalidNum1 = true;
                                            isInvalidNum2 = true;
                                            break;
                                        }
                                    } catch
                                    {
                                        Console.WriteLine("Invalid input. Enter a valid number.");
                                    }
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Enter a valid number.");
                            }
                            break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Choose an operation among {+, -, *, /}");
                    }
                }
                //break;
            }
            
        }
    }
}
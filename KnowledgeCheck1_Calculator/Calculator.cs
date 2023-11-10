using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            var inputs = new GetInputsForCalcuation();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var getNumsForAdd = inputs.GetTwoInputNumber();

                    if (int.TryParse(getNumsForAdd[0], out int addNumOne) && int.TryParse(getNumsForAdd[1], out int addNumTwo))
                    {
                        Console.Write($"{getNumsForAdd[0]} + {getNumsForAdd[1]} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var getNumsForSub = inputs.GetTwoInputNumber();

                    if (int.TryParse(getNumsForSub[0], out int subNumOne) && int.TryParse(getNumsForSub[1], out int subNumTwo))
                    {
                        Console.Write($"{getNumsForSub[0]} - {getNumsForSub[1]} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    // Add code here
                    Console.WriteLine("Enter 2 integers to multiply");
                    var getNumsForMul = inputs.GetTwoInputNumber();

                    if (int.TryParse(getNumsForMul[0], out int mulNumOne) && int.TryParse(getNumsForMul[1], out int mulNumTwo))
                    {
                        Console.Write($"{getNumsForMul[0]} * {getNumsForMul[1]} = ");
                        Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var getNumsForDiv = inputs.GetTwoInputNumber();

                    if (double.TryParse(getNumsForDiv[0], out double divNumOne) && double.TryParse(getNumsForDiv[1], out double divNumTwo))
                    {
                        Console.Write($"{getNumsForDiv[0]} / {getNumsForDiv[1]} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }

            

        }

        

    }
}
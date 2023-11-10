using System;
namespace KnowledgeCheck1_Calculator
{
	public class GetInputsForCalcuation
	{
        public string[] GetTwoInputNumber()
        {
            string[] twoInputNums = new string[2];
            twoInputNums[0] = Console.ReadLine();
            twoInputNums[1] = Console.ReadLine();
            return twoInputNums;
        }
    }
}
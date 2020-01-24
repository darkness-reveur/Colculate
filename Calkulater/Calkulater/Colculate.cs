using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulater
{
    class Colculate
    {
        //public void Addition(string a, string b)
        //{
        //    bool BoolItem1FirstElement = DataProcessing.TypeCheck(a).Item1;
        //    bool BoolItem2FirstElement = DataProcessing.TypeCheck(a).Item2;
        //    bool BoolItem1SecondElement = DataProcessing.TypeCheck(b).Item1;
        //    bool BoolItem2SecondElement = DataProcessing.TypeCheck(b).Item2;
        //    if (!BoolItem1FirstElement || !BoolItem2FirstElement || !BoolItem1SecondElement || !BoolItem2SecondElement)
        //    {

        //    }
        //}
        public string Addition(string firstElement, string secondElement)
        {
           
            if (!DataProcessing.TypeCheck(firstElement,secondElement))
            {
                return firstElement + secondElement;
            }
            else
            {
                double firstNumber = double.Parse(firstElement);
                double secondNumber = double.Parse(secondElement);
                double result = firstNumber + secondNumber;
                return result.ToString();
            }
        }
        public string Multiplication(string firstElement, string secondElement)
        {
            
            if (DataProcessing.TypeCheck(firstElement, secondElement))
            {
                double firstNumber = double.Parse(firstElement);
                double secondNumber = double.Parse(secondElement);
                double result = firstNumber * secondNumber;
                return result.ToString();
            }
            else
            {
                return "Operator \'*\' cannot be applied to operands of type \'string\' and \'string\'";
            }
        }
        public string Division(string firstElement, string secondElement)
        {
            if (DataProcessing.TypeCheck(firstElement, secondElement))
            {
                double firstNumber = double.Parse(firstElement);
                double secondNumber = double.Parse(secondElement);
                double result = firstNumber / secondNumber;
                return result.ToString();
            }
            else
            {
                return "Operator \'/\' cannot be applied to operands of type \'string\' and \'string\'";
            }
        }
        //{
        //    return a / b;
        //}


        //public string Division(double a, double b)
        //{
        //    return a / b;
        //}
    }
}

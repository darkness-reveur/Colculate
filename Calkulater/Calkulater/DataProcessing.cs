using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulater
{
    class DataProcessing
    {                 //((int or double = true), (int or char = true))
        //public static (bool,bool) TypeCheck(string firstElement)
        //{
        //    bool isItInt = int.TryParse(firstElement, out int helperNumberInt);
        //    bool isItDouble = double.TryParse(firstElement, out double helperNumberDouble);
        //    bool isItChar = char.TryParse(firstElement, out char helperNumberChar);
        //    if (isItDouble)
        //    {
        //        return (true,true);//int
        //    }
        //    else if (isItInt)
        //    {
        //        return (true, false);//double
        //    }
        //    else if (isItChar)
        //    {
        //        return (false,true);//char
        //    }
        //    else
        //    {
        //        return (false,false);//string
        //    }
        //}
        public static bool TypeCheck(string firstElement, string secondElement)
        {
            if (double.TryParse(firstElement, out double a) && double.TryParse(secondElement, out double b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

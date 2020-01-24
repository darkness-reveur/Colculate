using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulater
{
    class Program
    {
        static void Main(string[] args)
        {
            Colculate colculate = new Colculate();
            bool isFirstElementNegative = false;
            char operation = ' ';
            int count = 0;
            string expression = "";
            string firstElement = "-";
            string secondElement = "-";
            while (true)
            {
                Console.WriteLine("Введите выражение");
                expression = Console.ReadLine().Replace(" ", string.Empty);
                char[] Elements = expression.ToCharArray();
                //for (int i=0;i<Elements.Length;i++)
                //{
                //    Console.WriteLine(Elements[i]);
                //}
                for (int i = 1; i < Elements.Length; i++)
                {
                    if (Elements[i] == '/' || Elements[i] == '+' || Elements[i] == '-' || Elements[i] == '*')
                    {
                        operation = Elements[i];
                        count += 1;
                    }
                }
                if (Elements[0] == '-')
                {
                    isFirstElementNegative = true;
                }
                if (count == 1)
                {
                    break;
                }
                else if (count < 1)
                {
                    Console.WriteLine("Вы не написали операцию для элементов");
                }
                else
                {
                    Console.WriteLine("На данный момент приложение может производить математические операции только с двумя элементами");
                }
                
            }
            string[] elements = Spliting(expression);
            if (isFirstElementNegative)
            {
                firstElement += elements[0];
            }
            else
            {
                firstElement = elements[0];
            }
            if (operation == '-')
            {
                operation = '+';
                secondElement += elements[1];
            }
            else
            {
                secondElement = elements[1];
            }
            switch (operation)
            {
                case '+':
                    Console.WriteLine( " ="+colculate.Addition(firstElement,secondElement));
                    break;
                case '/':
                    Console.WriteLine( " ="+colculate.Division(firstElement,secondElement));
                    break;
                case '*':
                    Console.WriteLine(  " =" +colculate.Multiplication(firstElement,secondElement));
                    break;
            }

        }
        static string[] Spliting(string expression)
        {
            return expression.Split(new char[] { '/', '*', '+', '-' });
        }

    }
}

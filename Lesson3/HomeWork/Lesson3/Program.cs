using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Sum(float firstNumber, float secondNumber)
            {            
                float result = firstNumber + secondNumber;

                return result;
             }
            
            float Div(float firstNumber, float secondNumber)
            {
                float result = firstNumber / secondNumber;

                return result;
            }

            float Mult1(float firstNumber, float secondNumber)//аргумент
            {
                float result = firstNumber * secondNumber;    //тело

                return result;

                
            }         

            float Mult2()
            {
                float result = Sum(2, 2) * Div(4, 2);

                return result;


            }
           
            void Mult3()
            {
                Console.WriteLine(Sum(2, 2) * Div(4, 2));


            }
            Console.WriteLine(Mult1(Sum(1, 2), Div(4, 2)));
            Console.WriteLine(Mult2());
            Mult3();


        }
    }
}


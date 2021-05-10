﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Primitive Data Types
            //Example 1
            //byte number;
            byte number = 2;
            //Console.WriteLine(number); //compilation error

            //Example 2
            int count = 10;

            //compilation error - default data type is double
            //float totalPrice = 20.95; 


            float totalPrice = 20.95f;
            char character = 'A';



            string firstName = "Anwesh";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            var newNumber = 2; //show data type by hovering on variable
            var newCount = 10;
            var newTotalPrice = 20.95f;
            var newCharacter = 'A';
            var newFirstName = "Anwesh";
            var newIsWorking = false;


            Console.WriteLine(newNumber);
            Console.WriteLine(newCount);
            Console.WriteLine(newTotalPrice);
            Console.WriteLine(newCharacter);
            Console.WriteLine(newFirstName);
            Console.WriteLine(newIsWorking);

            //Min and Max value for primitive data types
            Console.WriteLine("Min value - {0}, Max value - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", char.MinValue, char.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min value - {0}, Max value - {1}", byte.MinValue, byte.MaxValue);

            const float Pi = 3.14f;
            // Pi = 1; // shows error if you re-assign a constant

            Console.WriteLine(Pi);
        }
    }
}

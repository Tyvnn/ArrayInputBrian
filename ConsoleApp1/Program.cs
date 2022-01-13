﻿using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lets figure out how many number will be in this array by asking the user
            Console.WriteLine("How many numbers are in your array?");
            int arrayLength = Int32.Parse(Console.ReadLine());
            //Now that we have the asnwer lets initialize the array
            int[] intArray = new int[arrayLength];
            //lets add numbers to the array
            AddNumbers(intArray,arrayLength);
            //lets get the magic number, and compare it to the array.
            //If its in our array, it will return the index of that number.
            //If its not, it will return a -1
            Console.WriteLine(LinearSearch(intArray,GetMagicNumber()));
            //end of main function
        }
        static int GetMagicNumber()
        {
            //Lets figure out what number we are searching for in our array by asking the user
            Console.WriteLine("What number would you like to search for in the array");
            int magicNumber = Int32.Parse(Console.ReadLine());
            //return the magic number to the main program
            return magicNumber;
            //end of the GetMagicNumber Method
        }
        static void AddNumbers(int[] intArray, int arrayLength)
        {
            //Lets figure out what all the numbers will be in the array
            Console.WriteLine("What is the first number in your array?");
            //the loopMessageCount variable will tell me how many times we have compeleted a loop and it also happens to be the first index for our array.
            //The loop will stop once we fill in the last index
            for (int loopMessageCount = 0; loopMessageCount < arrayLength;)
            { 
                //ask user for number input
                intArray[loopMessageCount] = Int32.Parse(Console.ReadLine());
                //show them what number they put in, and then ask what the next number is
                Console.WriteLine("The number you inserted was " + intArray[loopMessageCount] + " What is the next number you would like to add?");
                //Lets add a loop to the counter and run it again!
                loopMessageCount++;
            }
        }
        public static int LinearSearch(int[] inputArray, int inputKey)
        {
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] == inputKey)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
  


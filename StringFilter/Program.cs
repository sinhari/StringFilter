using System;
using System.Collections.Generic;

namespace StringFilter
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<string> inputList = new List<string>(), comparisonList = new List<string>(), baseList = new List<string>(), outputList=new List<string>();

            Console.WriteLine("Please enter a string");
            string inputText = Console.ReadLine();
            inputList.Add(inputText);

            while (!String.IsNullOrEmpty(inputText))
            {

                Console.WriteLine("Please enter another string: ");
                inputText = Console.ReadLine();
                inputList.Add(inputText);
            }


            if (String.IsNullOrEmpty(inputText))
            {
                inputList.Remove(inputText);
                Console.WriteLine("The list you have entered is: " + string.Join(", ",inputList.ConvertAll(m => $"'{m}'").ToArray()));
                Console.ReadLine();
            }

            Console.WriteLine("Press enter to proceed further to get the filtered output:");
            Console.ReadLine();

            //preparing the comparisonList with all 6 letter words and the baseList with the reamining ones
            FilterCore.GetSortedList(inputList, comparisonList, baseList);

            outputList = FilterCore.FilterText(baseList, comparisonList);
            Console.WriteLine("The filtered list is: " + string.Join(", ", outputList.ConvertAll(m => $"'{m}'").ToArray()));
            Console.Read();
        }
       
    }
}

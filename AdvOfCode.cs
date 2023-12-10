using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatt_Alg_Other_learning.AdventOfCode
{
    public class AdvOfCode
    {
        public void Day1()
        {
            string? line;
            Console.WriteLine("PROGRAM BEGIN");


            // Variables used for the problem BEGIN
            int totalSum = 0;
            string tempString = "";
            List<string> numbers = new List<string>() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            bool firstNumberFound = false;
            int R_INDEX = 0;
            int L_INDEX = int.MaxValue;
            int R_INDEX_str = 0;
            int L_INDEX_str = int.MaxValue;
            string firstStrValue = "";
            string lastStrValue = "";
            // Variables used for the problem END
            Console.WriteLine("Enter Input: ");
            do
            {
                R_INDEX = 0;
                L_INDEX = int.MaxValue;
                R_INDEX_str = 0;
                L_INDEX_str = int.MaxValue;
                firstNumberFound = false;
                line = Console.ReadLine();

                if (line.Length == 1 && line[0] == 'q')
                {
                    break;
                }
                for (var i = 0; i < line.Length; i++)
                {
                    if (!line.Any(char.IsDigit))
                    {
                        continue;
                    }
                    if (char.IsNumber(line[i]) && firstNumberFound == false)
                    {
                        L_INDEX = i;
                        R_INDEX = i;
                        firstNumberFound = true;
                        continue;
                    }
                    else if (char.IsNumber(line[i]))
                    {
                        R_INDEX = i;
                    }
                }
                for (var i = 0; i < numbers.Count; i++)
                {
                    var tempIndex = line.IndexOf(numbers[i]);
                    if (tempIndex < L_INDEX_str && tempIndex != -1)
                    {
                        L_INDEX_str = tempIndex;
                        firstStrValue = convertToNumberChar(numbers[i]);
                    }
                    if (tempIndex > R_INDEX_str && tempIndex != -1)
                    {
                        R_INDEX_str = tempIndex;
                        lastStrValue = convertToNumberChar(numbers[i]);
                    }
                }

                if(L_INDEX_str < L_INDEX)
                {
                    tempString += firstStrValue;
                }
                else
                {
                    if(L_INDEX != int.MaxValue)
                        tempString += line[L_INDEX];
                }
                if(R_INDEX_str > R_INDEX)
                {
                    tempString += lastStrValue;
                }
                else
                {
                    tempString += line[R_INDEX];
                }
                Console.WriteLine(tempString);

                totalSum += int.Parse(tempString);
                tempString = "";

            } while (!String.IsNullOrWhiteSpace(line));
            Console.WriteLine(totalSum);

            Console.WriteLine("PROGRAM END");
        }

        public string convertToNumberChar(string str)
        {
            var number = "";
            switch (str)
            {
                case "one": 
                    number = "1"; 
                    break;
                case "two": 
                    number = "2"; 
                    break;
                case "three":
                    number = "3"; 
                    break;
                case "four":
                    number = "4"; 
                    break;
                case "five":
                    number = "5"; 
                    break;
                case "six":
                    number = "6"; 
                    break;
                case "seven":
                    number = "7";
                    break;
                case "eight":
                    number = "8";
                    break;
                case "nine":
                    number = "9";
                    break;
                default:
                    number = "";
                    break;
            }
            return number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem17
    {
        public void Run()
        {
            var total = 0;
            for (var i = 1; i <= 1000; i++)
            {
                var numArray = ConvertToString(i);
                var tempString = "";
                if (numArray.Length == 4)
                {
                    tempString = "one thousand";
                }
                else if(numArray.Length == 3)
                {
                    tempString = numArray[0] + " hundred and ";
                    switch (numArray[1])
                    {
                        case "nine":
                            tempString += "ninety " + numArray[2];
                            break;
                        case "eight":
                            tempString += "eighty " + numArray[2];
                            break;
                        case "seven":
                            tempString += "seventy " + numArray[2];
                            break;
                        case "six":
                            tempString += "sixty " + numArray[2];
                            break;
                        case "five":
                            tempString += "fifty " + numArray[2];
                            break;
                        case "four":
                            tempString += "forty " + numArray[2];
                            break;
                        case "three":
                            tempString += "thirty " + numArray[2];
                            break;
                        case "two":
                            tempString += "twenty " + numArray[2];
                            break;
                        case "one":
                            switch (numArray[2])
                            {
                                case "nine":
                                    tempString += "nineteen";
                                    break;
                                case "eight":
                                    tempString += "eighteen";
                                    break;
                                case "seven":
                                    tempString += "seventeen";
                                    break;
                                case "six":
                                    tempString += "sixteen";
                                    break;
                                case "five":
                                    tempString += "fifteen";
                                    break;
                                case "four":
                                    tempString += "fourteen";
                                    break;
                                case "three":
                                    tempString += "thirteen";
                                    break;
                                case "two":
                                    tempString += "twelve";
                                    break;
                                case "one":
                                    tempString += "eleven";
                                    break;
                                default:
                                    tempString += "ten";
                                    break;
                            }
                            break;
                        default:
                            tempString += numArray[2];
                            break;

                    }
                }
                else if (numArray.Length == 2)
                {
                    switch (numArray[0])
                    {
                        case "nine":
                            tempString += "ninety " + numArray[1];
                            break;
                        case "eight":
                            tempString += "eighty " + numArray[1];
                            break;
                        case "seven":
                            tempString += "seventy " + numArray[1];
                            break;
                        case "six":
                            tempString += "sixty " + numArray[1];
                            break;
                        case "five":
                            tempString += "fifty " + numArray[1];
                            break;
                        case "four":
                            tempString += "forty " + numArray[1];
                            break;
                        case "three":
                            tempString += "thirty " + numArray[1];
                            break;
                        case "two":
                            tempString += "twenty " + numArray[1];
                            break;
                        case "one":
                            switch (numArray[1])
                            {
                                case "nine":
                                    tempString += "nineteen";
                                    break;
                                case "eight":
                                    tempString += "eighteen";
                                    break;
                                case "seven":
                                    tempString += "seventeen";
                                    break;
                                case "six":
                                    tempString += "sixteen";
                                    break;
                                case "five":
                                    tempString += "fifteen";
                                    break;
                                case "four":
                                    tempString += "fourteen";
                                    break;
                                case "three":
                                    tempString += "thirteen";
                                    break;
                                case "two":
                                    tempString += "twelve";
                                    break;
                                case "one":
                                    tempString += "eleven";
                                    break;
                                default:
                                    tempString += "ten";
                                    break;
                            }
                            break;
                        default:
                            tempString += numArray[1];
                            break;

                    }
                }
                else
                {
                    tempString = numArray[0];
                }
                tempString = tempString.Replace(" zero", "");
                if (tempString.EndsWith(" and"))
                {
                    tempString = tempString.Replace(" and", "");
                }
                total += tempString.Replace(" ", "").Length;
                Console.WriteLine(tempString + " : " + tempString.Replace(" ", "").Length);
            }
            Console.WriteLine(total);
        }

        private string[] ConvertToString(int number)
        {
            var array = number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            var result = "";
            foreach (var num in array)
            {
                switch (num)
                {
                    case 1:
                        result += "one ";
                        break;
                    case 2:
                        result += "two ";
                        break;
                    case 3:
                        result += "three ";
                        break;
                    case 4:
                        result += "four ";
                        break;
                    case 5:
                        result += "five ";
                        break;
                    case 6:
                        result += "six ";
                        break;
                    case 7:
                        result += "seven ";
                        break;
                    case 8:
                        result += "eight ";
                        break;
                    case 9:
                        result += "nine ";
                        break;
                    default:
                        result += "zero ";
                        break;
                }
            }
            return result.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWords
{
    public class Class1
    {
        static string Units(int N)
        {
            string word = "";
            switch (N)
            {
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
                case 10:
                    word = "ten";
                    break;
                case 11:
                    word = "eleven";
                    break;
                case 12:
                    word = "twelve";
                    break;
                default:
                    break;
            }
            return word;
        }

        static string Teens(int N)
        {
            string word = "";
            switch (N)
            {
                case 13:
                    word = "thir";
                    break;
                case 14:
                    word = "four";
                    break;
                case 15:
                    word = "fif";
                    break;
                case 16:
                    word = "six";
                    break;
                case 17:
                    word = "seven";
                    break;
                case 18:
                    word = "eight";
                    break;
                case 19:
                    word = "nine";
                    break;
                default:
                    break;
            }
            return word + "teen";
        }

        static string Tens(int N)
        {
            string word = "";
            switch (N)
            {
                case 20:
                    word = "twen";
                    break;
                case 30:
                    word = "thir";
                    break;
                case 40:
                    word = "for";
                    break;
                case 50:
                    word = "fif";
                    break;
                case 60:
                    word = "six";
                    break;
                case 70:
                    word = "seven";
                    break;
                case 80:
                    word = "eigh";
                    break;
                case 90:
                    word = "nine";
                    break;

                default:
                    break;
            }
            return word + "ty";
        }

        static string Hundreds(int N)
        {
            string word = "";
            if (N < 10)
            {
                word = Units(N) + " hundred";
            }


            return word;
        }

        static string Thousands(int N)
        {
            string numberWord = "";
            int unchanged_N = N;
            if (N < 100 && N >= 20)
            {
                numberWord += Tens(N / 10 * 10);
                N %= 10;
            }
            if (N < 20 && N >= 13)
            {
                numberWord += Teens(N);
            }
            if (N != 0 && N != unchanged_N)
            {
                numberWord += "-";
            }
            if (N > 0 && N <= 12)
            {
                numberWord += Units(N);
            }



            return numberWord += " thousand";
        }

        public static string FormatNumber(int N)
        {
            if (N == 0)
            {
                return "zero";
            }
            string numberWord = "";
            int unchanged_N = N;
            if (N >= 1000 && N <= 100000)
            {
                numberWord += Thousands((N / 1000));
                N %= 1000;
            }
            if (N != 0 && N != unchanged_N)
            {
                numberWord += " ";
            }
            if (N < 1000 && N >= 100)
            {
                numberWord += Hundreds(N / 100);
                N %= 100;
            }
            if (N != 0 && N != unchanged_N)
            {
                numberWord += " and ";
            }
            if (N < 20 && N > 12)
            {
                numberWord += Teens(N);
            }
            if (N < 100 && N >= 20)
            {
                numberWord += Tens(N / 10 * 10);
                N %= 10;
            }
            
            string endWord = numberWord.TrimEnd(' ').Split(' ').Last();
            if (N > 0 && N < 11 && N != unchanged_N && endWord != "and")
            {
                numberWord += "-";
            }
            if (N > 0 && N < 13)
            {
                numberWord += Units(N);
            }
            return numberWord;
        }
    }
}


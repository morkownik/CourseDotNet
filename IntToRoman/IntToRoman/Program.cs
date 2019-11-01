using System;

namespace IntToRoman
{
    class Program 
    {
        static void Main(string[] args)
        {
            ConvertArabicToRoman startConvert = new ConvertArabicToRoman();
            startConvert.ArabicNumbersToRoman(0);
        }
    }

    class ConvertArabicToRoman
    {
       public string ArabicNumbersToRoman(int inputNumber)
        {
            Console.WriteLine(inputNumber);
            if (inputNumber < 1 || inputNumber > 3999)
                Console.WriteLine( "Invalid Roman Number Value");
            string s = "";
            while (inputNumber >= 1000)
            {
                s += "M";
                inputNumber -= 1000;
            }
            while (inputNumber >= 900)
            {
                s += "CM";
                inputNumber -= 900;
            }
            while (inputNumber >= 500)
            {
                s += "D";
                inputNumber -= 500;
            }
            while (inputNumber >= 400)
            {
                s += "CD";
                inputNumber -= 400;
            }
            while (inputNumber >= 100)
            {
                s += "C";
                inputNumber -= 100;
            }
            while (inputNumber >= 90)
            {
                s += "XC";
                inputNumber -= 90;
            }
            while (inputNumber >= 50)
            {
                s += "L";
                inputNumber -= 50;
            }
            while (inputNumber >= 40)
            {
                s += "XL";
                inputNumber -= 40;
            }
            while (inputNumber >= 10)
            {
                s += "X";
                inputNumber -= 10;
            }
            while (inputNumber >= 9)
            {
                s += "IX";
                inputNumber -= 9;
            }
            while (inputNumber >= 5)
            {
                s += "V";
                inputNumber -= 5;
            }
            while (inputNumber >= 4)
            {
                s += "IV";
                inputNumber -= 4;
            }
            while (inputNumber >= 1)
            {
                s += "I";
                inputNumber -= 1;
            }
            Console.WriteLine(s);
            Console.ReadLine();
            return s;           
        }
    }
}

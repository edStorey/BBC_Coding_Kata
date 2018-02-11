﻿

namespace BBC_Coding_Kata
{
    // Class contains methods and variables used to convert decimal numbers to Roman Numerals
    public class RomanNumerals
    {
        // Public method accessed for conversion, this method can convert decimal numbers between 1-3999
        public static string ConvertToNumerals(int decimalNumber)
        {
            string numeralNumber = "";
            int I = 1, X = 10, C = 100, M = 1000, MMax = 3999;
            int[] divisor = { M, C, X, I };

            // If the input number is over 3999 no conversion is required and the following string is returned
            if (decimalNumber > MMax) { return numeralNumber = "Cannot support numbers over 3999"; }
            
            // Each digit is isolated by dividing by a power of ten
            // the Roman Numeral for that digit is calculated and concatenated with any previous character in the string numerNumber
            // the remander is then stored and used in the next loop iteration
            for (int i = 0; i < divisor.Length; i++){
                int currentDigit = decimalNumber / divisor[i];
                numeralNumber = numeralNumber + numeralConverter(currentDigit, decimalNumber);
                decimalNumber = decimalNumber % divisor[i];           
            }

            // The full roman numeral is outputted
            return numeralNumber;
        }

         private static string numeralConverter(int digit, int fullNumber)
        {
            string numeralOut;

            int X = 10;
            int C = 100;
            int M = 1000;
            string one, five, ten;

            // Based on the full input number decide which range of numbers is being converted
            // if full number is between 10-99 use numerals: X, L, C = 10, 50, 100
            // if full number is between 100-999 use numerals: C, D, M = 100, 500, 1000
            // if full number is greater than 1000 only numeral M will needed
            // else use numerals: I, V, X = 1, 5, 10 when converting the input digit
            if (fullNumber >= X && fullNumber < C)
            { one = "X"; five = "L"; ten = "C"; }
            else if (fullNumber >= C && fullNumber < M)
            { one = "C"; five = "D"; ten = "M"; }
            else if (fullNumber >= M)
            { one = "M"; five = "M"; ten = "M"; }
            else
            { one = "I"; five = "V"; ten = "X"; }

            numeralOut = numeral(digit, one, five, ten);

            return numeralOut;
        }
           
        
        // This method converts decimal numbers under 10^3 to roman numerals
        private static string numeral(int digit, string one, string five, string ten)
        {
            string numeral = "";
            int I = 1;
            int IV = 4;
            int V = 5;
            int IX = 9;
            int X = 10;
            string blankNume = "";
            int loopSkip = 0;

            // If digit is < 4 concatonate appropriate number of I/X/C
            if (digit < IV)

                numeral = numeral + numeralLoop(numeral, blankNume, one, blankNume, digit);
                for (int i = I; i <= digit; i++)
                    numeral = numeral + one;
            // If digit == 4 output IV/XL/CD
            else if (digit == IV)
            {
                numeral = numeral + one + five;
            }
            // If digit > 4 && < 9 concatonate I/X/C after V/L/D approiate number of times
            else if (digit >= V && digit < IX)
            {
                numeral = numeral + five;
                for (int i = I; i <= (digit - V); i++)
                    numeral = numeral + one;
            }
            // If digit = 9 output IX/XC/CM
            else if (digit == IX)
            {
                for (int i = I; i <= (X - digit); i++)
                    numeral = numeral + one;
                numeral = numeral + ten;
            }
            // Else no ouput
            else
                numeral = "";

            return numeral;
        }

        private static string numeralLoop(string numeral, string preNum, string centreNums, string postNum, int loopLength)
        {
            int I = 1;
            numeral = numeral + preNum;
            for (int i = I; i <= loopLength; i++)
                numeral = numeral + centreNums;
            numeral = numeral + postNum;
            return numeral;
        }
    } ;

}

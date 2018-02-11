

namespace BBC_Coding_Kata
{
    // Class contains methods and variables used to convert decimal numbers to Roman Numerals
    public class RomanNumerals
    {
        // Public method accessed for conversion, this method can convert decimal numbers between 1-3999
        public static string ConvertToNumerals(int DecimalNumber)
        {
            string NumeralNumber = "";
            int X = 10, C = 100, M = 1000;
            
            // The input number is divided into separate digits
            // The first digit to be converted is 10^3
            int currentDigit = DecimalNumber / M;

            // The 10^3 digit is converted into roman numerals and the remainder is stored
            NumeralNumber = numeralInThousands(currentDigit);
            DecimalNumber = DecimalNumber % M;

            // If the input number is over 3999 no more conversion is required and the following string is accepted
            if (NumeralNumber == "Cannot support numbers over 3999") { }
            else
            {
                // The digit at 10^2 is stored
                currentDigit = DecimalNumber / C;

                // The digit at 10^2 is converted to roman numerals and concatenated to output from digit at 10^3
                // This method accepts the full input as a second argument
                // The remainder is again stored
                NumeralNumber = NumeralNumber + numeral(currentDigit, DecimalNumber);
                DecimalNumber = DecimalNumber % C;

                // The digit at 10^1 is stored
                currentDigit = DecimalNumber / X;

                // The digit at 10^1 is converted to roman numerals and concatenated
                // The remainder is stored
                NumeralNumber = NumeralNumber + numeral(currentDigit, DecimalNumber);
                DecimalNumber = DecimalNumber % X;

                // The digit at 10^0 is stored
                currentDigit = DecimalNumber;

                // The digit at 10^0 is converted to roman numerals and concatenated
                NumeralNumber = NumeralNumber + numeral(currentDigit, DecimalNumber);
            }

            // The full roman numeral or error message is outputted
            return NumeralNumber;
        }

        // This method converts decimal digits at 10^3
        private static string numeralInThousands(int input)
        {
            // Since numbers above 3999 are not accepted, if the number is 4 or above
            // an error message is outputted
            string numeral = "";
            int MMax = 4;

            // If input is less than 4 concatenate Roman number "M" the appropriate number of times
            // Else output error message
            if (input < MMax)
                for (int i = 1; i <= input; i++)
                    numeral = numeral + "M";
            else
                numeral = "Cannot support numbers over 3999";

            return numeral;
        }
        
        // This method converts decimal numbers under 10^3 to roman numerals
        private static string numeral(int digit, int fullNumber)
        {
            string numeral = "";
            int I = 1;
            int IV = 4;
            int V = 5;
            int IX = 9;
            int X = 10;
            int C = 100;
            int M = 1000;
            string one, five, ten;

            // Based on the full input number decide which range of numbers is being converted
            // if full number is between 10-99 use numerals: X, L, C = 10, 50, 100
            // if full number is between 100-999 use numerals: C, D, M = 100, 500, 1000
            // else use numerals: I, V, X = 1, 5, 10 when converting the input digit
            if (fullNumber >= X && fullNumber < C)
            { one = "X"; five = "L"; ten = "C"; }
            else if (fullNumber >= C && fullNumber < M)
            { one = "C"; five = "D"; ten = "M"; }
            else
            { one = "I"; five = "V"; ten = "X"; }

            // If digit is < 4 concatonate appropriate number of I/X/C
            if (digit < IV)
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
    } ;

}

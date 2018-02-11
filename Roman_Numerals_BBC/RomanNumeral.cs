

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

            int tenThousand = DecimalNumber / M;

            NumeralNumber = numeralThousands(tenThousand);
            DecimalNumber = DecimalNumber % M;

            if (NumeralNumber == "Cannot support numbers over 3999") { }
            else
            {
                int thousand = DecimalNumber / C;

                NumeralNumber = NumeralNumber + numeral(thousand, DecimalNumber);
                DecimalNumber = DecimalNumber % C;

                int hundred = DecimalNumber / X;

                NumeralNumber = NumeralNumber + numeral(hundred, DecimalNumber);
                DecimalNumber = DecimalNumber % X;

                int ten = DecimalNumber;
                NumeralNumber = NumeralNumber + numeral(ten, DecimalNumber);
            }
            return NumeralNumber;
        }


        private static string numeralThousands(int input)
        {
            string numeral = "";
            int MMax = 4;

            if (input < MMax)
                for (int i = 1; i <= input; i++)
                    numeral = numeral + "M";
            else
                numeral = "Cannot support numbers over 3999";

            return numeral;
        }

        private static string numeral(int input, int digit)
        {
            string numeral = "";
            int I = 1;
            int IV = 4;
            int V = 5;
            int IX = 9;
            int X = 10;
            int C = 100;
            string one, five, ten;


            if (digit >= X && digit < C)
            { one = "X"; five = "L"; ten = "C"; }
            else if (digit >= C)
            { one = "C"; five = "D"; ten = "M"; }
            else
            { one = "I"; five = "V"; ten = "X"; }

            if (input < IV)
                for (int i = I; i <= input; i++)
                    numeral = numeral + one;
            else if (input == IV)
            {
                numeral = numeral + one + five;
            }
            else if (input >= V && input < IX)
            {
                numeral = numeral + five;
                for (int i = I; i <= (input - V); i++)
                    numeral = numeral + one;
            }
            else if (input == IX)
            {
                for (int i = I; i <= (X - input); i++)
                    numeral = numeral + one;
                numeral = numeral + ten;
            }
            else
                numeral = "";

            return numeral;
        }
    } ;

}

using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BBC_Coding_Kata
{

    public class RomanNumerals
    {
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
                for (int i = 1; i <= input; i++)
                    numeral = numeral + one;
            else if (input == IV)
            {
                for (int i = 1; i <= (V - input); i++)
                    numeral = numeral + one;
                numeral = numeral + five;
            }
            else if (input >= V && input < IX)
            {
                numeral = numeral + five;
                for (int i = 1; i <= (input - V); i++)
                    numeral = numeral + one;
            }
            else if (input == IX)
            {
                for (int i = 1; i <= (X - input); i++)
                    numeral = numeral + one;
                numeral = numeral + ten;
            }
            else
                numeral = "";

            return numeral;
        }
    }

    public class Test
    {
        private static Dictionary<int , string> Decimal_Roman = new Dictionary<int,string>{
        {  1, "I"},
        {  2, "II"},
        {  3, "III"},
        {  4, "IV"},
        {  5, "V"},
        {  6, "VI"},
        {  7, "VII"},
        {  8, "VIII"},
        {  9, "IX"},
        {  10, "X"},
        {  12, "XII"},
        {  15, "XV"},
        {  19, "XIX"},
        {  20, "XX"},
        {  31, "XXXI"},
        {  46, "XLVI"},
        {  50, "L"},
        {  74, "LXXIV"},
        {  99, "XCIX"},
        {  100, "C"},
        {  247, "CCXLVII"},
        {  482, "CDLXXXII"},
        {  500, "D"},
        {  791, "DCCXCI"},
        {  999, "CMXCIX"},
        {  1000, "M"},
        {  2693, "MMDCXCIII"},
        {  3999, "MMMCMXCIX"},
        {  4000, "Cannot support numbers over 3999"},
        {  10000, "Cannot support numbers over 3999"}

        };

        public static bool numeralTest(){
            bool error = false;
            foreach (var dec in Decimal_Roman)
            {
                if (RomanNumerals.ConvertToNumerals(dec.Key) != dec.Value)
                {
                    error = true;
                    break;
                }
                else
                    error = false;               
            }
            return error;     
        }

       /* {  1, "I"}, {  2, "II"}, {  3, "III"}, {  4, "IV"}, {  5, "V"},
        {  6, "VI"}, {  7, "VII"}, {  8, "VIII"}, {  9, "IX"}, {  10, "X"},
        {  12, "XII"}, {  15, "XV"}, {  19, "XIX"}, {  20, "XX"}, {  31, "XXXI"},
        {  46, "XLVI"}, {  50, "L"}, {  74, "LXXIV"}, {  99, "XCIX"}, {  100, "C"},
        {  247, "CCXLVII"}, {  482, "CDLXXXII"}, {  500, "D"}, {  791, "DCCXCI"}, {  999, "CMXCIX"},
        {  1000, "M"}, {  2693, "MMDCXCIII"}, {  3999, "MMMCMXCIX"},
        {  4000, "Cannot support numbers over 3999"},  {  10000, "Cannot support numbers over 3999"}*/

       
        
    };


    class Console_Output
    {
        static void Main(string[] args)
        {
            bool test_output = false;

            test_output = Test.numeralTest();

            if (test_output == true)
                Console.WriteLine("Error");
            else
                Console.WriteLine("No Error");

            Console.ReadLine();

        }
    }
            /*string input = "";
            int dec = 0;
            int ten;
            int hundred;
            int thousand;
            int tenThousand;

            int I = 1;
            int V = 5;
            int L = 50;
            int C = 100;
            int D = 500;
            int M = 1000;
            string numeral = "";

            while (true)
            {
               // Console.Write("Input Decimal Number: ");

                //input = Console.ReadLine();
                //dec = Convert.ToInt32(input);
                

               /* Console.Write("Base: ");
                Console.WriteLine(Convert.ToString(thousand));
                Console.Write("Mod: ");
                Console.Write(Convert.ToString(dec));
                Console.ReadLine();
                
                numeral = RomanNumerals.ConvertToNumerals(dec);
                if (numeral == "Cannot support numbers over 3999")
                {
                    Console.WriteLine(numeral);
                    Console.ReadLine();
                    break;
                }
                dec = dec + 1;

                Console.WriteLine(numeral);
                //Console.ReadLine();
            }

        }

    }*/

   





}

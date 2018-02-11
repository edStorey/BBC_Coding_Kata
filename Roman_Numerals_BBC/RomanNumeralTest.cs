using System.Collections.Generic;

namespace BBC_Coding_Kata
{
    // Class contains a method and variables deisgned to test Class RomanNumerals 
    public class RomanNumeralTest
    {
        // Dictionary keys denote input and values are the expected output
        private static Dictionary<int, string> Decimal_Roman = new Dictionary<int, string>{
        // Inputs of 1-10 are tested, if the first 10 inputs are correct inputs > 9 should work as expected
        // aditional inputs between 10 - 3999 are given to test concation is working correctly and correct range of values are accepted
        // large numbers over 3999 are added to test whether the upper limit of 3999 is correct
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

        // This method compares an input to its expected output
        public static bool numeralTest()
        {
            bool error = false;

            // For each var in Dictionary Deciman_Roman, test whether the expected outputs are correct
            // using the key as input and value as expected output
            // if an output is incorrect set output bool error = true and break loop  
            // else set bool error = false
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
    }
}

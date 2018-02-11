using System.Collections.Generic;

namespace BBC_Coding_Kata
{
    public class RomanNumeralTest
    {
        private static Dictionary<int, string> Decimal_Roman = new Dictionary<int, string>{
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

        public static bool numeralTest()
        {
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
    }
}

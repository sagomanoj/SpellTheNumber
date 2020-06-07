using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellTheNumbers
{
    public class SpellNumberProvider
    {

        private static SpellNumberProvider _instance = null;
        private static string[] zeroToNineteen = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private SpellNumberProvider()
        {
        }

        public static SpellNumberProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SpellNumberProvider();

                return _instance;
            }
        }


        public string SpellTheNumber(long number)
        {
            if (number == 0)
                return SpellNumberConstants.Zero;

            if (number < 0)
                return SpellNumberConstants.Zero + SpellTheNumber(Math.Abs(number));

            string result = string.Empty;



            if ((number / SpellNumberConstants.OneHundred) > 0)
            {
                result += string.Format("{0} {1} ", SpellTheNumber(number / SpellNumberConstants.OneHundred), SpellNumberConstants.Hundred);
                number %= SpellNumberConstants.OneHundred;
            }

            if (number > 0)
            {
                if (!string.IsNullOrEmpty(result))
                    result += string.Format("{0} ", SpellNumberConstants.And);

                if (number < SpellNumberConstants.Twenty)
                    result += zeroToNineteen[number];
                else
                {
                    result += tens[number / SpellNumberConstants.Ten];
                    if ((number % SpellNumberConstants.Ten) > 0)
                        result += " " + zeroToNineteen[number % SpellNumberConstants.Ten];
                }
            }

            return result;
        }
    }
}

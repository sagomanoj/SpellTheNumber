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



            return result;
        }
    }
}

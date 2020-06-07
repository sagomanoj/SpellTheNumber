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
    }
}

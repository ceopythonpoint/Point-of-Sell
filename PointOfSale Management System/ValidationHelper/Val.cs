using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationHelper
{
    public class Val
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                return false;

            return true;
        }
    }
}

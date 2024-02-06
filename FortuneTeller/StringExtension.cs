using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    public static class StringExtension
    {
        public static bool IsNull(this string str) { 
            return string.IsNullOrWhiteSpace(str);
        }
    }
}

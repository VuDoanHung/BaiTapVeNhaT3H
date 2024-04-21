using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonLibs
{
    public class CommonLibs
    {

        public static bool CheckIntType(string content)
        {
            var checkcondition = int.TryParse(content, out int result);
            return checkcondition;
        }

        public static bool CheckName(string content)
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");

            return regexItem.IsMatch(content);
        }
    }
   
}

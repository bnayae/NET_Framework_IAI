using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_RefVrsVal
{
    class MyParser
    {
        //function that returns the first character of the string, in upper
        //and determines if it was successfull.
        public static char parseString(string str, out bool result)
        {
            if (str == null)
            {
                result = false;
                return (char)0;
            }
            if (str.Length == 0)
            {
                result = false;
                return (char)0;
            }
            char ch = str.ToUpper().ToCharArray()[0];
            result = true;
            return ch;
        }

        public static char parseString2(string str, out bool result)
        {
            result = false;
            //string.IsNullOrEmpty(str) || 
            if (string.IsNullOrWhiteSpace(str))
            {
                return (char)0;
            }
            
            char ch = str.Trim().ToUpper().ToCharArray()[0];
            result = true;
            return ch;
        }
        public static ParseResult parseString2(string str)
        {
            ParseResult pr = new ParseResult();
            if (string.IsNullOrWhiteSpace(str))
                return pr;
            pr.charRes  = str.Trim().ToUpper().ToCharArray()[0];
            pr.isValid = true;
            return pr;
        }
    }
}

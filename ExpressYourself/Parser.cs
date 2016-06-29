using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExpressYourself
{
    public class Parser
    {
        /// <summary>
        /// Looks for a title in a Media file string.
        /// </summary>
        /// <param name="str">The string to search</param>
        /// <returns>the title string if it exists</returns>
        public static string GetTitle(string str)
        {
            // TODO
            var titleExpression = new Regex(@"Title\:(.*),+");
            var match = titleExpression.Match(str);
            if (!match.Success)
            {
                return "Title Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            } 
            else
    { 
            return "";
        }
        }

        public static string GetType(string str)
        {
            // TODO
            var typeexp = new Regex(@"Type:\s([A-Za-z]+)");
            var match = typeexp.Match(str)
               if(!match.Success)
            {
                return "Type Not Found";
            }
            else
            {
                return match.Groups[1].Value;
            }
            return "";
        }

        public static string GetLength(string str)
        {
            // TODO
            var lengthexp = new Regex(@"Length: ([\w]*[\s][0-9a-z]+)");
            var match = lengthexp.Match(str);
            if(!match.Success)
            {
                return "Length Not Found";
            }
            else
            {
                return match.Groups[1].Value;
                {
                
                }
            
            else
 {

            }
            return "";
        }

        public static bool IsValidLine(string str)
        {
            // TODO
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_IT
{
    class ReformatStringAlternatingCase
    {
        public static string Reformat(string s)
        {
            StringBuilder result = new StringBuilder();
            bool toggle = true;

            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    if (toggle)
                    {
                        result.Append(Char.ToUpper(c));
                    }
                    else
                    {
                        result.Append(Char.ToLower(c));
                    }
                    toggle = !toggle; 
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_IT
{

    class MagicPotionIdentifier
        {
            public static string IsMagicalPotion(long power)
            {
                int cubeRoot = (int)Math.Round(Math.Pow(power, 1.0 / 3));
                if (Math.Pow(cubeRoot, 3) == power)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        } 
}

//OUTPUT WILL BE NO I made the mistake while answering on the assessment


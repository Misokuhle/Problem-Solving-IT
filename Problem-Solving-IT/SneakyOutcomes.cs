using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_IT
{
    class SneakyOutcomes
    {
        public static int[] FindDuplicates(int[] outcomes)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int outcome in outcomes)
            {
                if (seen.Contains(outcome))
                {
                    duplicates.Add(outcome);
                }
                else
                {
                    seen.Add(outcome);
                }
            }

            return duplicates.ToArray();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_IT
{
    class OrganizingBooksIntoIdenticalSets
    {
        public static string CanOrganizeBooks(int[] shelf)
        {
            var groups = shelf.GroupBy(x => x).Select(group => group.Count()).ToArray();
            int gcd = groups[0];

            foreach (var groupCount in groups)
            {
                gcd = GCD(gcd, groupCount);
                if (gcd == 1) return "NO";
            }

            return gcd > 1 ? "YES" : "NO";
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_IT
{
    class Program
    {
        static void Main()
        {
            // Test MagicPotionIdentifier
            long potionPower = 132651201231L; 
            string resultPotion = MagicPotionIdentifier.IsMagicalPotion(potionPower);
            Console.WriteLine($"Potion power {potionPower}: {resultPotion}");

            // Test SneakyOutcomes
            int[] outcomes = { 123456, 234567, 123347, 456789, 567890, 678901, 789012, 890123, 901234, 112233, 223344, 334455, 789012, 222234, 123347 };
            int[] duplicateOutcomes = SneakyOutcomes.FindDuplicates(outcomes);
            Console.WriteLine($"Duplicate outcomes: [{string.Join(", ", duplicateOutcomes)}]");

            // Test ReformatStringAlternatingCase
            string testString = "Za^B8g@E2jH*kWl!MoPqXr7YvT1c$Fs3Ud9IwZ&yX0pLkV6sHqN^tB4rA+oZ%gFj";
            string reformattedString = ReformatStringAlternatingCase.Reformat(testString);
            Console.WriteLine($"Reformatted string: {reformattedString}");

            // Test OrganizingBooksIntoIdenticalSets
            int[] shelf = { 1234567, 1234567, 2345678, 2345678, 3456789, 3456789, 1234567, 2345678, 3456789, 4567890, 4567890, 5678901, 5678901, 6789012, 6789012, 1234567, 2345678, 3456789, 4567890, 5678901, 4567890, 5678901 };
            string canOrganize = OrganizingBooksIntoIdenticalSets.CanOrganizeBooks(shelf);
            Console.WriteLine($"Can organize books into identical sets: {canOrganize}");
        }
    }
}


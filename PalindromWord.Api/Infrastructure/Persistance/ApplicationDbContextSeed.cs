using PalindromWord.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PalindromWord.Api.Infrastructure.Persistance
{
    public static class ApplicationDbContextSeed
    {
        public static void EnsureSeedDataForContext(this ApplicationDbContext context)
        {
            AddPalindromes(context);
            
            context.SaveChanges();
        }

        private static void AddPalindromes(ApplicationDbContext context)
        {
            var palindromes = new List<PalindromeWord>();
            if (!context.PalindromeWords.Any(x => x.Word == "Don't nod."))
            {
                palindromes.Add(new PalindromeWord("Don't nod."));
            }
            if (!context.PalindromeWords.Any(x => x.Word == "Radar"))
            {
                palindromes.Add(new PalindromeWord("Radar"));
            }
            if (!context.PalindromeWords.Any(x => x.Word == "No lemon, no melon"))
            {
                palindromes.Add(new PalindromeWord("No lemon, no melon"));
            }
            context.PalindromeWords.AddRange(palindromes);
        }
    }
}

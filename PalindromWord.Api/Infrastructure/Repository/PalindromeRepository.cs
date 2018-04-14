using PalindromWord.Api.Infrastructure.Persistance;
using PalindromWord.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromWord.Api.Infrastructure.Repository
{
    public class PalindromeRepository : IRepository<PalindromeWord>
    {
        private readonly ApplicationDbContext _context;

        public PalindromeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(PalindromeWord entity)
        {
            _context.PalindromeWords.Add(entity);
        }

        public PalindromeWord FindById(int id)
        {
            var result = _context.PalindromeWords
                  .SingleOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<PalindromeWord> List()
        {
            var result = _context.PalindromeWords
                .ToList();

            return result;
        }
    }
}

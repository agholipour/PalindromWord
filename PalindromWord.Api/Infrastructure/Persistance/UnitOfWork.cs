using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PalindromWord.Api.Infrastructure.Repository;
using PalindromWord.Domain;

namespace PalindromWord.Api.Infrastructure.Persistance
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IRepository<PalindromeWord> _palindromeWordRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IRepository<PalindromeWord> PalindromeWordRepository
        {
            get
            {
                return _palindromeWordRepository = _palindromeWordRepository ?? new PalindromeRepository(_context);
            }
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;

        }
    }
}

using PalindromWord.Api.Infrastructure.Repository;
using PalindromWord.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromWord.Api.Infrastructure.Persistance
{
   public interface IUnitOfWork
    {
        IRepository<PalindromeWord> PalindromeWordRepository { get; }

        bool Save();
    }
}

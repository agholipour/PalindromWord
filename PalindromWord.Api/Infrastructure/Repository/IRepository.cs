using PalindromWord.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromWord.Api.Infrastructure.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> List();
        void Add(T entity);
        T FindById(int id);
    }
}

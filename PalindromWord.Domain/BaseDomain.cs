using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromWord.Domain
{
    public class BaseEntity
    {
        public virtual int Id { get; protected internal set; }
    }
}

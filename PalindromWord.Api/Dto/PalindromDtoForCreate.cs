using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromWord.Api.Dto
{
    public class PalindromeDtoForCreate
    {
        [Required]
        [StringLength(100)]
        public string Word { get; set; }
    }
}

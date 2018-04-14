using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PalindromWord.Domain
{
    public class PalindromeWord : BaseEntity,IValidatableObject
    {
        public PalindromeWord()
        {

        }
        public PalindromeWord(string word)
        {
            this.Word = word;
        }
        [Required]
        [StringLength(100)]
        public string Word { get;protected internal set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Word) &&
                  ! IsPalindrome(Word))
                yield return new ValidationResult($"{Word} is not Palindrome",new[] { this.Word});
        }
        private  bool IsPalindrome(string str)
        {
            return Enumerable.Range(0, str.Length / 2).All(i => str[i] == str[str.Length - i - 1]);
        }
    }
}

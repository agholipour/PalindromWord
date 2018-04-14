using Microsoft.EntityFrameworkCore;
using PalindromWord.Domain;


namespace PalindromWord.Api.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PalindromeWord> PalindromeWords { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}

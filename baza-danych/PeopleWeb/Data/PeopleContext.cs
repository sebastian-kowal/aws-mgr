using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace PeopleWeb.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Person> People { get; set; }
    }
}

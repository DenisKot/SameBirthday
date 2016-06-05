using System.Data.Entity;
using SameBirthday.Models;

namespace SameBirthday.Data
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("AzureConnection")
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
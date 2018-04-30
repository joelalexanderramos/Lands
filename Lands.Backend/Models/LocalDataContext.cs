namespace Lands.Backend.Models
{
    using System.Data.Entity;
    using Domain;

    public class LocalDataContext : DataContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }
    }
}
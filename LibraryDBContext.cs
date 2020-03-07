using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI;

namespace LibraryAPI
{
    public class LibraryDBContext : DbContext

    {
        public DbSet<Books> Books;

        public DbSet<Users> Users;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
            modelBuilder.Entity<Users>()
            .HasMany(b=>b.books)
            .WithOne(u=>u.user)
            .HasForeignKey(b=>b.UserID)
            ;;

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<LibraryAPI.Books> Books_1 { get; set; }
    }
}

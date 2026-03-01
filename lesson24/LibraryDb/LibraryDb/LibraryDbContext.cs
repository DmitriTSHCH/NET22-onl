using LibraryDb.Models;
using LibraryDb.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace LibraryDb
{
    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("DefaultConnection"));
        }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<BookDetail> BookDetails { get; set; }
        public virtual DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public virtual DbSet<MemberContact> MemberContacts { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new PublisherConfigurations());
            modelBuilder.ApplyConfiguration(new MemberConfigurations());
            modelBuilder.ApplyConfiguration(new LoanConfigurations());
            modelBuilder.ApplyConfiguration(new BookDetailConfigurations());
            modelBuilder.ApplyConfiguration(new AuthorBiographyConfigurations());
            modelBuilder.ApplyConfiguration(new MemberContactConfigurations());

            modelBuilder.Entity<BookCategory>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}

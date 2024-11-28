using Microsoft.EntityFrameworkCore;
using System;
using library.Models;
using System.Net;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors {get; set;}
    public DbSet<Loan> Loans {get; set;}
    public DbSet<BookAuthor> bookAuthors {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookAuthor>()
            .HasKey(ba => new {ba.BookID, ba.AuthorID});
        modelBuilder.Entity<BookAuthor>()
            .HasOne(ba => ba.Book)
            .WithMany(b => b.BookAuthors)
            .HasForeignKey(ba => ba.BookID);
        modelBuilder.Entity<BookAuthor>()
            .HasOne(ba => ba.Author)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.AuthorID);
        modelBuilder.Entity<Loan>()
            .HasOne(l => l.Book)
            .WithMany(b => b.Loans)
            .HasForeignKey(l => l.BookID);
            
                
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-EHB8M0R;Database=Library;Trusted_Connection=True;TrustServerCertificate=True; ");
    }

}


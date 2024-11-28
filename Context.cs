using Microsoft.EntityFrameworkCore;
using System;
using library.Models;
using System.Net;

public class AppDbContext : DbContext
{
    public DbSet<Book> Books {get; set;}
    public DbSet<Author> Authors {get; set;}
    public DbSet<Loan> Loans {get; set;}
    public DbSet<BookAuthor> BookAuthors {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-EHB8M0R;Database=Library;Trusted_Connection=True;TrustServerCertificate=True; ");
    }

}


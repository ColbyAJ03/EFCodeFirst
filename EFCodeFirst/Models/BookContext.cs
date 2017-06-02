using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst.Models
{
    public class BookContext : DbContext

    {
        public BookContext() 
            : base("name=BookContext")
        { }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(x => x.Id);
            modelBuilder.Entity<Book>().Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);

        }
    }
}
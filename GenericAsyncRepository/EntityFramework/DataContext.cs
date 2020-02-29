using GenericAsyncRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAsyncRepository.EntityFramework
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>()
                .HasOne(b => b.Blog)
                .WithMany(p => p.Posts)
                .IsRequired();
            base.OnModelCreating(builder);
        }
    }
}

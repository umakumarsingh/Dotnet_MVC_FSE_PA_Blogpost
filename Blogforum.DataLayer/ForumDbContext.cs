using Blogforum.Entities;
using System;
using System.Data.Entity;

namespace Blogforum.DataLayer
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
            : base("name=BlogConnectionString")
        {

        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasKey(x => x.PostId);
            modelBuilder.Entity<Comment>()
                .HasKey(x => x.CommId);
        }
    }
}

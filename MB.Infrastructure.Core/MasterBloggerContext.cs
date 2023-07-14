using MB.Domin.ArticleAgg;
using MB.Domin.ArticleCategoryAgg;
using MB.Domin.CommentAgg;
using MB.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Core
{
    public class MasterBloggerContext:DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Comment> comments { get; set; }

        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping()); 
            modelBuilder.ApplyConfiguration(new CommentMapping());

            base.OnModelCreating(modelBuilder);
        }


    }
}

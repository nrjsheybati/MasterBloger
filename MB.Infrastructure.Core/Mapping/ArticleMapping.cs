using MB.Domin.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.EFCore.Mapping
{
    public class ArticleMapping: IEntityTypeConfiguration<Articles>
    {

        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            builder.ToTable("Articles");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Image);
            builder.Property(x => x.Content);
            builder.Property(x => x.CreateionDate);
            builder.Property(x => x.IsDeleted);

            builder.HasOne(x => x.articleCategory).WithMany(x => x.Articles).HasForeignKey(x => x.ArticleCategoryId);
            //builder.HasMany(x => x.Comments).WithOne(x => x.Article).HasForeignKey(x => x.ArticleId);
        }
    }
}

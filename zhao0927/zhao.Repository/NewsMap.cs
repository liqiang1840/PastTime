using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Zhao.Domain;

namespace zhao.Repository
{
    public class NewsMap : EntityTypeConfiguration<News>
    {
        public NewsMap()
        {
            this.HasKey(c => c.Id);
            this.ToTable("News");
            this.HasRequired(t => t.Catalog)
                .WithMany(t => t.News)
                .HasForeignKey(t => t.Catalog.CatalogCode)
                .WillCascadeOnDelete(false); //
        }
    }
}

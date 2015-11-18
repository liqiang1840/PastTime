using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Zhao.Domain;

namespace zhao.Repository
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        // Primary Key
        public AuthorMap()
        {
            this.HasKey(t => t.AuthorId);
            // Properties
            this.Property(t => t.AuthorName).HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Author");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.AuthorName).HasColumnName("AuthorName");
            //this.Property(t => t.Authority).HasColumnName("Authority");
        }

    }
}

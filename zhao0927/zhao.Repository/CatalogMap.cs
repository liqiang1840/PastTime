using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using Zhao.Domain;

namespace zhao.Repository
{
    public class CatalogMap : EntityTypeConfiguration<Catalog>
    {
        public CatalogMap()
        {
            this.HasKey(c => c.CatalogCode);
            this.ToTable("Catalog");
        }
    }
}

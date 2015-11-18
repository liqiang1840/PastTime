using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using Zhao.Domain;

namespace zhao.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : this("name=ZhaoConnectString")
        {
        }

        internal EFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFDbContext>());
        }

        public virtual IDbSet<News> News { get; set; }

        public virtual IDbSet<Catalog> Catalog { get; set; }

        public virtual IDbSet<Author> Author { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new CatalogMap());
            modelBuilder.Configurations.Add(new NewsMap());
        }
    }

}

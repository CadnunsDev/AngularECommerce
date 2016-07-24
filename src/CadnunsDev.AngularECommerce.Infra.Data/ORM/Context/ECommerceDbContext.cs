using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadnunsDev.AngularECommerce.Domain.Entities;
using CadnunsDev.AngularECommerce.Infra.Data.ORM.Mapping;

namespace CadnunsDev.AngularECommerce.Infra.Data.ORM.Context
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext() : base("AngularECommerceDb")
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMapping());
        }
    }
}

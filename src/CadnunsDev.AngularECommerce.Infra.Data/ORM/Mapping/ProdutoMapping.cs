using CadnunsDev.AngularECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsDev.AngularECommerce.Infra.Data.ORM.Mapping
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            ToTable("Produtos");
            HasKey(x => x.ProdutoId);
        }
    }
}

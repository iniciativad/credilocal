using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CrediLocal.Domain.Entities;

namespace CrediLocal.Infra.Data.EntityConfig 
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired();
            
            Property(c => c.Sobrenome)
            .IsRequired();

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(160);
        }
    }
}

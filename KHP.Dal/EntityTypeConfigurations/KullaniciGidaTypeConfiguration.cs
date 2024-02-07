using KHP.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHP.Dal.EntityTypeConfigurations
{
    public class KullaniciGidaTypeConfiguration : IEntityTypeConfiguration<KullaniciGida>
    {
        public void Configure(EntityTypeBuilder<KullaniciGida> builder)
        {
            throw new NotImplementedException();
        }
    }
}

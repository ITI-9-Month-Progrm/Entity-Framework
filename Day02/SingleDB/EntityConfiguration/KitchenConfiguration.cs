using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SingleDB.Entity.LOGIN_MANAGERDB;

namespace SingleDB.EntityConfiguration
{
    public class KitchenConfiguration : IEntityTypeConfiguration<Kitchen>
    {
        public void Configure(EntityTypeBuilder<Kitchen> builder)
        {
            builder.HasKey(K => K.user_name);
            builder.Property(k => k.user_name).HasMaxLength(50);
            builder.Property(k => k.pass_word).HasMaxLength(50).IsRequired();
        }
    }
}

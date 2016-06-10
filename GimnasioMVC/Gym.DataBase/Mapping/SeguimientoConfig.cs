using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gym.DataBase.Mapping
{
    public class SeguimientoConfig: EntityTypeConfiguration<Seguimiento>
    {
        public SeguimientoConfig()
        {
            //Property(o => o.Peso)
            //    .HasPrecision(2, 2);

            ToTable("Seguimiento", "dbo");
            HasKey(o => o.Id);
        }

    }
}

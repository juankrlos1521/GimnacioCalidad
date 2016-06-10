using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gym.DataBase.Mapping
{
    class TrabajadorConfig : EntityTypeConfiguration<Trabajador>
    {
        public TrabajadorConfig()
        {

            ToTable("Trabajador", "dbo");

            HasKey(o => o.Id);

        }
    }
}

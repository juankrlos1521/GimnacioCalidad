using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;


namespace Gym.DataBase.Mapping
{
    public class TipoConfig:EntityTypeConfiguration<Tipo>
    {
        public TipoConfig()
        {
            ToTable("Tipo", "dbo");
            HasKey(o => o.Id);
        }
    }
}

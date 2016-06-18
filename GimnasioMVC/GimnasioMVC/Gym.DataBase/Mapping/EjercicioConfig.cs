using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gym.DataBase.Mapping
{
    public class EjercicioConfig:EntityTypeConfiguration<Ejercicio>
    {
        public EjercicioConfig()
        {
            ToTable("Ejercicios", "dbo");
            HasKey(o => o.Id);
        }
    }
}

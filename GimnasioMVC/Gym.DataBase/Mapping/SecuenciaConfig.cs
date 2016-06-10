using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gym.DataBase.Mapping
{
    public class SecuenciaConfig:EntityTypeConfiguration<Secuencia>
    {
        public SecuenciaConfig()
        {
            ToTable("Secuencia", "dbo");
            HasKey(o => new { o.RutinaId, o.EjercicioId });

            Property(cp => cp.EjercicioId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(o => o.RutinaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(o => o.Ejercicios)
               .WithMany(o => o.Secuencias)
               .HasForeignKey(cp => cp.EjercicioId);

            HasRequired(o => o.Rutinas)
                .WithMany(o => o.Secuencias)
                .HasForeignKey(cp => cp.RutinaId);
        }

    }
}

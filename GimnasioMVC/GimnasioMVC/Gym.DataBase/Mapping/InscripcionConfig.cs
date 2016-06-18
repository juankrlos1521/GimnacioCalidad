using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Gym.Models.Models;
using System.Data.Entity.ModelConfiguration;

namespace Gym.DataBase.Mapping
{
    class InscripcionConfig:EntityTypeConfiguration<Inscripcion>
    {
        public InscripcionConfig()
        {
            //Property(o => o.Peso)
            //    .HasPrecision(2, 2);

            ToTable("Inscripcion", "dbo");
            HasKey(o => o.Id);

            this.HasMany(i => i.Cursos).WithMany(c => c.Inscripciones).Map(t => t.ToTable("InscripcionCurso").MapLeftKey("InscripcionId").MapRightKey("CursoId"));
            //this.HasMany(i => i.Paquetes).WithMany(p => p.Inscripciones).Map(t => t.ToTable("InscripcionPaquete").MapLeftKey("InscripcionId").MapRightKey("PaqueteId"));
        }
    }
}

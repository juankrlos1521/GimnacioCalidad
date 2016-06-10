using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Gym.Models.Models;
using Gym.DataBase.Mapping;

namespace Gym.DataBase.ActaModels
{
    public class GymContext: DbContext
    {
        public virtual IDbSet<Seguimiento> Seguimientos { get; set; }
        public virtual IDbSet<Trabajador> Trabajadores { get; set; }
        public virtual IDbSet<Ejercicio> Ejercicios { get; set; }
        public virtual IDbSet<Rutina> Rutinas { get; set; }
        public virtual IDbSet<Secuencia> Secuencias { get; set; }
        public virtual IDbSet<Tipo> Tipos { get; set; }
        public virtual IDbSet<Cliente> Clientes { get; set; }
        public virtual IDbSet<Inscripcion> Inscripciones { get; set; }
        public virtual IDbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add<Seguimiento>(new SeguimientoConfig());
            modelBuilder.Configurations.Add<Trabajador>(new TrabajadorConfig());
            modelBuilder.Configurations.Add<Ejercicio>(new EjercicioConfig());
            modelBuilder.Configurations.Add<Rutina>(new RutinaConfig());
            modelBuilder.Configurations.Add<Secuencia>(new SecuenciaConfig());
            modelBuilder.Configurations.Add<Tipo>(new TipoConfig());
            modelBuilder.Configurations.Add<Cliente>(new ClienteConfig());
            modelBuilder.Configurations.Add<Inscripcion>(new InscripcionConfig());
            modelBuilder.Configurations.Add<Pago>(new PagoConfig());

        }
    }
}

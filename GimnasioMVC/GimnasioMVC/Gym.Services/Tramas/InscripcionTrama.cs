using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.DataBase.ActaModels;
using Gym.Models.Models;
using Gym.Interfaces.Titulos;
using System.Data.Entity;

namespace Gym.Services.Tramas
{
    public class InscripcionTrama : IInscripcionTitulo
    {
        private readonly GymContext entidadInscripcion;

        public void AddInscripcionCursos(Inscripcion inscripcion)
        {
            if (inscripcion.ClienteId == 0)
            {
                entidadInscripcion.Entry(inscripcion.Cliente).State = EntityState.Added;
            }
            else
            {
                entidadInscripcion.Entry(inscripcion.Cliente).State = EntityState.Unchanged;
            }

            inscripcion.Cursos.ForEach(i =>
            {
                i.Stock = i.Stock - 1;
                entidadInscripcion.Entry(i).State = EntityState.Modified;
                entidadInscripcion.Entry(i.Trabajador).State = EntityState.Unchanged;
            });
            entidadInscripcion.Inscripciones.Add(inscripcion);
            entidadInscripcion.SaveChanges();
        }

        public IEnumerable<Inscripcion> GetAllInscripciones(String criterio)
        {
            var query = from q in entidadInscripcion.Inscripciones.Include(c => c.Cliente)
                        select q;

            if (!String.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Cliente.Dni.Contains(criterio)
                        select c;
            }
            return query;
        }
    }
}

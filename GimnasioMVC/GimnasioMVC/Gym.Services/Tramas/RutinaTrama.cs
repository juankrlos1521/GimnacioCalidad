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
    public class RutinaTrama:IRutinaTitulo
    {
        private readonly GymContext entidadRutina;

        public RutinaTrama(GymContext RutinaEntidadIngresada)
        {
            this.entidadRutina = RutinaEntidadIngresada;

        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Rutina rutina)
        {
            entidadRutina.Rutinas.Add(rutina);
            entidadRutina.SaveChanges();
        }

        public IList<Rutina> ListameTodo(int? Idseg)
        {
            return entidadRutina.Rutinas.Where(x => x.SeguimientoId == Idseg).ToList();
        }

        public void Modificar(Rutina rutina)
        {
            throw new NotImplementedException();
        }

        public Rutina TraerRutinaPorId(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Seguimiento> TraerTodasSeguimientos()
        {
            return entidadRutina.Seguimientos.Include("Cliente").ToList();
        }
    }
}

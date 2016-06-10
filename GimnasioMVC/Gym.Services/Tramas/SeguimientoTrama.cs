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
    public class SeguimientoTrama: ISeguimientoTitulo
    {
        private readonly GymContext entidadSeguimiento;

        public SeguimientoTrama(GymContext SeguimientoEntidadIngresada)
        {
            this.entidadSeguimiento = SeguimientoEntidadIngresada;

        }

        public void Eliminar(int id)
        {
            var _seguimiento = entidadSeguimiento.Seguimientos.Find(id);
            if (_seguimiento != null)
            {
                entidadSeguimiento.Seguimientos.Remove(_seguimiento);
                entidadSeguimiento.SaveChanges();
            }

        }

        public void Insertar(Seguimiento seguimiento)
        {
            entidadSeguimiento.Seguimientos.Add(seguimiento);
            entidadSeguimiento.SaveChanges();
        }

        public IList<Seguimiento> ListameTodo(int? IdCli)
        {

            return entidadSeguimiento.Seguimientos.Where(x => x.ClienteId == IdCli).ToList();
        }

        public void Modificar(Seguimiento seguimiento)
        {
            Seguimiento _seguimiento = entidadSeguimiento.Seguimientos.Where(x => x.Id == seguimiento.Id).SingleOrDefault();
            if (_seguimiento != null)
            {
                entidadSeguimiento.Entry(_seguimiento).CurrentValues.SetValues(seguimiento);
                entidadSeguimiento.SaveChanges();
            }
        
        }

        public Seguimiento TraerSeguimientoPorId(int? id)
        {
            return entidadSeguimiento.Seguimientos.First(x => x.Id == id);
        }
    }
}

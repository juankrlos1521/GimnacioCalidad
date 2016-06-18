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
    public class TrabajadorTrama : ITrabajadorTitulo
    {
        private readonly GymContext entidadTrabajador;

        public TrabajadorTrama(GymContext TrabajadorEntidadIngresada)
        {
            this.entidadTrabajador = TrabajadorEntidadIngresada;
        }

        public void BuscarTrabajador(string nombre, string apaterno, string amaterno, string dni)
        {
            throw new NotImplementedException();
        }

        public void InsertarTrabajador(Trabajador trabajador)
        {
            entidadTrabajador.Trabajadores.Add(trabajador);
            entidadTrabajador.SaveChanges();
        }

        public IList<Trabajador> ListarTrabajadores(string paterno)
        {
            return entidadTrabajador.Trabajadores.Where(x => x.ApePaterno.ToUpper().Contains("")).ToList();
        }

        public void ModificarTrabajador(Trabajador trabajador)
        {
            Trabajador _trabajador = entidadTrabajador.Trabajadores.Where(x => x.Id == trabajador.Id).SingleOrDefault();
            if (entidadTrabajador != null)
            {
                entidadTrabajador.Entry(entidadTrabajador).CurrentValues.SetValues(trabajador);
                entidadTrabajador.SaveChanges();
            }
        }

        public Trabajador TraerTrabajadorPorId(int? id)
        {
            return entidadTrabajador.Trabajadores.First(x => x.Id == id);
        }


        public void InhabilitarTrabajador(int id, bool? estado)
        {
            Trabajador _trabajador = entidadTrabajador.Trabajadores.First(x => x.Id == id);
            if (_trabajador.Estado == true)
            {
                _trabajador.Estado = false;
            }
            else
            {
                _trabajador.Estado = true;
            }

            entidadTrabajador.SaveChanges();

        }
        
    }
}
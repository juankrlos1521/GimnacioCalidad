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

        public void InhabilitarTrabajador(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertarTrabajador(Trabajador trabajador)
        {
            throw new NotImplementedException();
        }

        public IList<Trabajador> ListarTrabajadores(string paterno)
        {
            return entidadTrabajador.Trabajadores.Where(x => x.ApePaterno.ToUpper().Contains("")).ToList();
        }

        public void ModificarTrabajador(Trabajador trabajador)
        {
            throw new NotImplementedException();
        }

        public Trabajador TraerTrabajadorPorId(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

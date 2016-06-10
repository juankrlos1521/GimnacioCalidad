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
    public class ClienteTrama:IClienteTitulo
    {
        private readonly GymContext entidadCliente;

        public ClienteTrama(GymContext ClienteEntidadIngresada)
        {
            this.entidadCliente = ClienteEntidadIngresada;

        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> ListameTodo(string Nombre)
        {
            return entidadCliente.Clientes.Where(x => x.Nombre.Contains("")).ToList();
        }

        public void Modificar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente TraerClientePorId(int? id)
        {
            throw new NotImplementedException();
        }

       
    }
}

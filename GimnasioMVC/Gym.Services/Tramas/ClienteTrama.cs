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
            var _cliente = entidadCliente.Clientes.Find(id);
            if (_cliente != null)
            {
                entidadCliente.Clientes.Remove(_cliente);
                entidadCliente.SaveChanges();
            }
        }

        public void Insertar(Cliente cliente)
        {
            entidadCliente.Clientes.Add(cliente);
            entidadCliente.SaveChanges();
        }

        public IList<Cliente> ListameTodo(string Nombre)
        {
            return entidadCliente.Clientes.Where(x => x.Nombre.Contains("")).ToList();
        }

        public void Modificar(Cliente cliente)
        {
            Cliente _cliente = entidadCliente.Clientes.Where(c => c.Id == cliente.Id).SingleOrDefault();
            if (_cliente != null)
            {
                entidadCliente.Entry(_cliente).CurrentValues.SetValues(cliente);
                entidadCliente.SaveChanges();
            }
        }

        public Cliente TraerClientePorId(int? id)
        {
            return entidadCliente.Clientes.First(c => c.Id == id);
        }

       
    }
}

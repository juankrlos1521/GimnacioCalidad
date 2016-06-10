using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface IClienteTitulo
    {
        IList<Cliente> ListameTodo(String Nombre);
        Cliente TraerClientePorId(int? id);
        void Insertar(Cliente cliente);
        void Modificar(Cliente cliente);
        void Eliminar(int id);
    }
}

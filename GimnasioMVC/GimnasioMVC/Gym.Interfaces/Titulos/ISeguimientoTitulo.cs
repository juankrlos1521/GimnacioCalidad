using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface ISeguimientoTitulo
    {
        IList<Seguimiento> ListameTodo(int? IdCli);        
        Seguimiento TraerSeguimientoPorId(int? id);
        void Insertar(Seguimiento seguimiento);
        void Modificar(Seguimiento seguimiento);
        void Eliminar(int id);
        List<Cliente> TraerTodosClientes();
    }
}

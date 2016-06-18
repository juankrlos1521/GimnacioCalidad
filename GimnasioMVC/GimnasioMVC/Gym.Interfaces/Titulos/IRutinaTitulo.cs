using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface IRutinaTitulo
    {
        IList<Rutina> ListameTodo(int? IdSeg);
        Rutina TraerRutinaPorId(int? id);
        void Insertar(Rutina rutina);
        void Modificar(Rutina rutina);
        void Eliminar(int id);
        List<Seguimiento> TraerTodasSeguimientos();
    }
}

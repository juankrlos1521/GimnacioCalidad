using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface ITrabajadorTitulo
    {
        IList<Trabajador> ListarTrabajadores(String paterno);
        Trabajador TraerTrabajadorPorId(int? id);
        void BuscarTrabajador(String nombre, String apaterno, String amaterno, String dni);
        void InsertarTrabajador(Trabajador trabajador);
        void ModificarTrabajador(Trabajador trabajador);
        void InhabilitarTrabajador(int id, bool? estado);
    }
}

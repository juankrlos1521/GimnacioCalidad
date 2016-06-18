using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface IRutinaSecuencia
    {
        List<Ejercicio> ObtenerTodosLosEjercicios();
        Ejercicio FindEjercicio(int id);
    }
}

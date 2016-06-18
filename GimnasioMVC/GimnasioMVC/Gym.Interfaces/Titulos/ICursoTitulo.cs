using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface ICursoTitulo
    {
        IList<Curso> ListarCursos(String nombre);
        Curso TraerCursoPorId(int? id);
        void Insertar(Curso curso);
        void Modificar(Curso curso);
        void Eliminar(int id);
    }
}

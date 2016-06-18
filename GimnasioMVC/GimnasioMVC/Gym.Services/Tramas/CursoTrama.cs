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
    public class CursoTrama : ICursoTitulo
    {
        private readonly GymContext entidadCurso;

        public CursoTrama(GymContext CursoEntidadIngresada)
        {
            this.entidadCurso = CursoEntidadIngresada;
        }

        public IList<Curso> ListarCursos(string nombre)
        {
            return entidadCurso.Cursos.Where(x => x.Nombre.Contains("")).ToList();
        }

        public Curso TraerCursoPorId(int? id)
        {
            return entidadCurso.Cursos.First(c => c.Id == id);
        }

        public void Insertar(Curso curso)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Curso curso)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}

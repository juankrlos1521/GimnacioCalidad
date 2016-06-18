﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gym.Models.Models;

namespace Gym.Interfaces.Titulos
{
    public interface IInscripcionTitulo
    {
        void AddInscripcionCursos(Inscripcion inscripcion);
        IEnumerable<Inscripcion> GetAllInscripciones(String criterio);
    }
}

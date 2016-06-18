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
    public class RutinaSecuenciaTrama:IRutinaSecuencia
    {
        private readonly GymContext entidadRutinaSecuencia;

        public RutinaSecuenciaTrama(GymContext RutinaSecuenciaEntidadIngresada)
        {
            this.entidadRutinaSecuencia = RutinaSecuenciaEntidadIngresada;

        }

        public Ejercicio FindEjercicio(int id)
        {
            return entidadRutinaSecuencia.Ejercicios.FirstOrDefault(o => o.Id == id);
            
        }

        public List<Ejercicio> ObtenerTodosLosEjercicios()
        {
            return entidadRutinaSecuencia.Ejercicios.ToList();
        }
    }
}

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
    public class SecuenciaTrama:ISecuenciaTitulo
    {
        private readonly GymContext entidadSecuencia;

        public SecuenciaTrama(GymContext SecuenciaEntidadIngresada)
        {
            this.entidadSecuencia = SecuenciaEntidadIngresada;

        }

        public void Insertar(Secuencia secuencia)
        {
            entidadSecuencia.Secuencias.Add(secuencia);
            entidadSecuencia.SaveChanges();
        }
    }
}

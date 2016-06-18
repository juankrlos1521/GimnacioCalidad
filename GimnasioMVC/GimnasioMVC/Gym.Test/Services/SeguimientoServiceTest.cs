using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Gym.Services.Tramas;
using Gym.Models.Models;
using Moq;
using System.Data.Entity;
using Gym.DataBase.ActaModels;

namespace Gym.Test.Services
{
    [TestFixture]
    public class SeguimientoServiceTest
    {
        private Mock<GymContext> entitiesMock;

        [SetUp]
        public void SetUp()
        {
            //Preparar  - Arrange Global
            var db = DBMentiritas();
            var mockDbset = new Mock<IDbSet<Seguimiento>>();
            mockDbset.Setup(x => x.Provider).Returns(db.Provider);
            mockDbset.Setup(x => x.Expression).Returns(db.Expression);
            mockDbset.Setup(x => x.ElementType).Returns(db.ElementType);
            mockDbset.Setup(x => x.GetEnumerator()).Returns(db.GetEnumerator);
            entitiesMock = new Mock<GymContext>();
            entitiesMock.Setup(x => x.Seguimientos).Returns(mockDbset.Object);
        }

        [Test]
        public void _01_Retorna_Lista_Seguimientos_ClienteId_3()
        {
            //Actuar - Act
            
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.ListameTodo(1);

            //Afirmar - Assert
            Assert.IsInstanceOf(typeof(IList<Seguimiento>), result);
            Assert.AreEqual(3, result.Count);
        }

        [Test]
        public void _02_Test_Pierna_Obser_Por_Id_3_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(3);

            //Afirmar - Assert
            Assert.AreEqual("Como el mar, muerto.", result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(2.22), result.Pierna);
        }

        [Test]
        public void _03_Test_Abdom_Obser_Por_Id_69_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(69);

            //Afirmar - Assert
            Assert.AreEqual("Excelente Figura", result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(10.25), result.Abdomen);
        }

        [Test]
        public void _04_Test_Altura_Obser_Por_Id_1_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(1);

            //Afirmar - Assert
            Assert.AreEqual(null, result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(1.75), result.Altura);
        }

        [Test]
        public void _05_Test_Brazos_Obser_Por_Id_2_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(2);

            //Afirmar - Assert
            Assert.AreEqual("Como un toro.", result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(0.89), result.Brazo);
        }

        [Test]
        public void _06_Test_Altura_Obser_Por_Id_101_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(101);

            //Afirmar - Assert
            Assert.AreEqual("Ninguno", result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(13.0), result.Pecho);
        }

        [Test]
        public void _07_Test_Brazos_Obser_Por_Id_37_Ok()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);
            var result = service.TraerSeguimientoPorId(37);

            //Afirmar - Assert
            Assert.AreEqual("Esqueletico", result.Observaciones);
            Assert.AreEqual(Convert.ToDecimal(15.0), result.Peso);
        }

        [Test]
        public void _08_Test_Insertar_Seguimiento_Id_45()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);

            //Afirmar - Assert
            service.Insertar(new Seguimiento { Id = 45, Abdomen = 5, Altura = 6, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/2019"), Pecho = 9, Peso = Convert.ToDecimal(15.0), Pierna = Convert.ToDecimal(1.5), Observaciones = "Figurita" });
        }

        [Test]
        public void _09_Test_Insertar_Seguimiento_Id_89()
        {
            //Actuar - Act
            var service = new SeguimientoTrama(entitiesMock.Object);

            //Afirmar - Assert
            service.Insertar(new Seguimiento { Id = 89, Abdomen = 10, Altura = 26, Brazo = 17, Cintura = 44, Fecha = Convert.ToDateTime("05/05/2019"), Pecho = 29, Peso = Convert.ToDecimal(15.0), Pierna = Convert.ToDecimal(1.5), Observaciones = null });
        }

        [Test]
        public void _10_Retorna_Lista_Seguimientos_ClienteId_225()
        {
            //Actuar - Act
            var repo = new SeguimientoTrama(entitiesMock.Object);
            var result = repo.ListameTodo(2);

            //Afirmar - Assert
            Assert.AreEqual(1, result.Count());

        }

        [Test]
        public void _11_Retorna_Lista_Seguimientos_ClienteId_350()
        {
            //Actuar - Act
            var repo = new SeguimientoTrama(entitiesMock.Object);
            var result = repo.ListameTodo(5);

            //Afirmar - Assert
            Assert.AreEqual(1, result.Count());
        }


        private IQueryable<Seguimiento> DBMentiritas()
        {
            return new List<Seguimiento>
            {
                new Seguimiento { Id = 1, Abdomen = 5, Altura = Convert.ToDecimal(1.75), Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/2016"), Pecho = 9, Peso = 15, Pierna = Convert.ToDecimal(8.25), Observaciones = null , ClienteId=1},
                new Seguimiento { Id = 2, Abdomen = 5, Altura = 6, Brazo =  Convert.ToDecimal(0.89), Cintura = 4, Fecha = Convert.ToDateTime("05/05/2017"), Pecho = 9, Peso = 15, Pierna = Convert.ToDecimal(4.23), Observaciones = "Como un toro." , ClienteId=2},
                new Seguimiento { Id = 3, Abdomen = 5, Altura = 6, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/2013"), Pecho = 9, Peso = 15, Pierna = Convert.ToDecimal(2.22), Observaciones = "Como el mar, muerto." , ClienteId=4},
                new Seguimiento { Id = 4, Abdomen = 5, Altura = 6, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/1995"), Pecho = 9, Peso = 15, Pierna = Convert.ToDecimal(1.5), Observaciones = "OMG" , ClienteId=1},
                new Seguimiento { Id = 69, Abdomen = Convert.ToDecimal(10.25), Altura = 5, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/2020"), Pecho = 9, Peso = 15, Pierna = Convert.ToDecimal(0.25), Observaciones = "Excelente Figura" , ClienteId=3},
                new Seguimiento { Id = 101, Abdomen = 5, Altura = 6, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/2019"), Pecho = Convert.ToDecimal(13.0), Peso = 15, Pierna = Convert.ToDecimal(1.5), Observaciones = "Ninguno" , ClienteId=5},
                new Seguimiento { Id = 37, Abdomen = 5, Altura = 6, Brazo = 7, Cintura = 4, Fecha = Convert.ToDateTime("05/05/1999"), Pecho = 9, Peso = Convert.ToDecimal(15.0), Pierna = Convert.ToDecimal(1.5), Observaciones = "Esqueletico", ClienteId=1},

            }.AsQueryable();
        }


    }
}

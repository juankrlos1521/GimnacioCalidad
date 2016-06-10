using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Moq;
using System.Web.Mvc;
using Gym.Interfaces.Titulos;
using Gym.Models.Models;
using Gym.Web.Controllers;
using NUnit.Framework;


namespace Gym.Test.Controllers
{
    [TestFixture]
    public class SeguimientoControllerTest
    {
        private Seguimiento SeguimientoCliente { get; set; }

        [SetUp]
        public void InstanciaAntesDeCadaTest()
        {
            SeguimientoCliente = new Seguimiento();
        }
        [Test]
        public void _01_IndexAccion_retornarIndex()
        {
            string expected = "Index";
            var mock = new Mock<ISeguimientoTitulo>();
            SeguimientoController controller = new SeguimientoController(mock.Object);

            ViewResult result = controller.Index(2) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.ViewName);
            //DateTime datex = Convert.ToDateTime("01/01/1990");
            //mock.Setup(x => x.ListameTodo(datex)).Returns(new List<Seguimiento>());
            //var controller = new SeguimientoController(mock.Object);

            //var viewx = controller.Index();

            //Assert.IsInstanceOf(typeof(ViewResult), viewx);
            //Assert.AreEqual("Index", viewx);
            //Assert.IsInstanceOf(typeof(List<Seguimiento>), viewx);            

        }

        [Test]
        public void _02_TestSeguimientoCrearRetormarVistaesOk()
        {
            var controller = new SeguimientoController(null);

            var view = controller.Create() as ViewResult;

            AssertViewWithoutModel(view, "Create");

        }

        [Test]
        public void _03_TestSeguimientoGuardadoExitoRedireccionandoIndex()
        {
            var mock = new Mock<ISeguimientoTitulo>();
            var controller = new SeguimientoController(mock.Object);

            var redirect = controller.Create(new Seguimiento { Observaciones = "Hola" }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        //[Test]
        //public void _04_TestSeguimientoDetailsRedirectToIndexWhenIdIsZero()
        //{
        //    // Arrange
            
        //    var controller = new SeguimientoController(null);

        //    // Act

        //    var redirect = controller.Details(0) as RedirectToRouteResult;

        //    //Assert
        //    Assert.IsNotNull(redirect);
        //    Assert.AreEqual("Index", redirect.RouteValues["action"]);
        //}

        [Test]
        public void _05_TestSeguimientoDetalleRetornarVistaEsOk()
        {
            // Arrange
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(x => x.TraerSeguimientoPorId(1)).Returns(new Seguimiento { });
            var controller = new SeguimientoController(mock.Object);

            // Act

            var view = controller.Details(1) as ViewResult;

            //Assert
            AssertViewsWithModel(view, "Details");
            Assert.IsInstanceOf(typeof(Seguimiento), view.Model);
        }

        [Test]
        public void _06_TestSeguimientoGuardadoCorrectamenteRedireccionaraIndex()
        {
            DateTime datex = Convert.ToDateTime("01/01/1990");
            var mock = new Mock<ISeguimientoTitulo>();
            var controller = new SeguimientoController(mock.Object);

            var redirect = controller.Create(new Seguimiento
            {
                Fecha = datex,
                Peso =3000.00M,
                Altura = 12.21M,
                Brazo = 12.21M,
                Pierna = 123.23M,
                Cintura = 12.21M,
                Abdomen = 123.23M,
                Pecho = 8765M,
                Observaciones = "qwewrt"
            }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        [Test]
        public void _07_TestSeguimientoEditarRetornarVistaEsOk()
        {
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(x => x.TraerSeguimientoPorId(1)).Returns(new Seguimiento());

            var controller = new SeguimientoController(mock.Object);

            var view = controller.Edit(1) as ViewResult;

            AssertViewsWithModel(view, "Edit");
            mock.Verify(x => x.TraerSeguimientoPorId(1), Times.Exactly(1));

        }
        [Test]
        public void _08_TestSeguimientoEditarGuardarExito()
        {
            //arrange
            var mock = new Mock<ISeguimientoTitulo>();
            var controller = new SeguimientoController(mock.Object);

            var redirect = controller.Edit(new Seguimiento { Observaciones = "7162146789" }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }



        [Test]
        public void TestIndexReturnViewIsOkjjjjjjjjjjjjjjjj()
        {
            DateTime datex = Convert.ToDateTime("01/01/1990");
            //Arrange
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(x => x.ListameTodo(2)).Returns(new List<Seguimiento>());
            var controller = new SeguimientoController(mock.Object);

            // Act
            var view = controller.Index(2);

            //Assert
            mock.Verify(x => x.ListameTodo(2), Times.Once);
            AssertViewsWithModel(view, "Index");
            Assert.IsInstanceOf(typeof(List<Seguimiento>), view.Model);
        }



        private void AssertViewsWithModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view, "Vista no puede ser nulo");
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNotNull(view.Model);
        }

        private void AssertViewWithoutModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view);
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNull(view.Model);
        }


    }
}

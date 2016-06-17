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
        DateTime _fechaIni = Convert.ToDateTime("01/01/1990");

        //[Test]
        //public void _01_Vista_Retorna_Index_Ok()
        //{
        //    //Preparar  - Arrange
        //    var mock = new Mock<ISeguimientoTitulo>();
        //    mock.Setup(o => o.ListameTodo(1)).Returns(new List<Seguimiento>());
        //    var controller = new SeguimientoController(mock.Object);

        //    //Actuar - Act
        //    var result = controller.Index(1);

        //    //Afirmar - Assert
        //    mock.Verify(x => x.ListameTodo(1), Times.Once);
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("Index", result.ViewName);
        //    Assert.IsInstanceOf(typeof(ViewResult), result);
        //    Assert.IsInstanceOf(typeof(List<Seguimiento>), result.Model);
        //}

        //[Test]
        //public void _02_Index_Llama_Seguimiento()
        //{
        //    //Preparar  - Arrange
        //    var mock = new Mock<ISeguimientoTitulo>();
        //    mock.Setup(o => o.ListameTodo(1)).Returns(new List<Seguimiento>());
        //    var controller = new SeguimientoController(mock.Object);

        //    //Actuar - Act
        //    controller.Index(1);

        //    //Afirmar - Assert
        //    mock.Verify(o => o.ListameTodo(1), Times.Exactly(1));
        //}

        [Test]
        public void _03_Vista_Create_Ok()
        {
            //Preparar  - Arrange
            var controller = new SeguimientoController(null);

            //Actuar - Act
            var view = controller.Create() as ViewResult;

            //Afirmar - Assert
            Assert.IsInstanceOf(typeof(ViewResult), view);
            AssertViewWithoutModel(view, "Create");

        }

        [Test]
        public void _04_Create_Guardado_Exito_Redirect_Index()
        {
            //Preparar  - Arrange
            var mock = new Mock<ISeguimientoTitulo>();
            var controller = new SeguimientoController(mock.Object);
            
            //Actuar - Act
            var redirect = controller.Create(new Seguimiento { Observaciones = "Sufre del Corazón" }) as RedirectToRouteResult;

            //Afirmar - Assert
            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
            Assert.IsInstanceOf(typeof(RedirectToRouteResult), redirect);
        }

        [Test]
        public void _05_Falla_Validacion_Return_Vista_Create()
        {
            //Preparar  - Arrange
            var seguimiento = new Seguimiento { };
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(o => o.ListameTodo(1));

            //Actuar - Act
            var controller = new SeguimientoController(mock.Object);

            //Afirmar - Assert
            var view = controller.Create(seguimiento);
            Assert.IsInstanceOf(typeof(RedirectToRouteResult), view);
        }

        [Test]
        public void _06_Detalles_Redireccionar_Index_Cuando_Id_Es_Cero()
        {
            //Preparar  - Arrange
            var controller = new SeguimientoController(null);

            //Actuar - Act
            var redirect = controller.Details(0) as RedirectToRouteResult;

            //Afirmar - Assert
            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        [Test]
        public void _07_Detalles_Seguimiento_Id_Cinco_Vista_Ok()
        {
            var _id = 5;
            //Preparar  - Arrange
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(x => x.TraerSeguimientoPorId(_id)).Returns(new Seguimiento { });
            var controller = new SeguimientoController(mock.Object);
            
            //Actuar - Act
            var view = controller.Details(_id) as ViewResult;

            //Afirmar - Assert
            AssertViewsWithModel(view, "Details");
            Assert.IsInstanceOf(typeof(Seguimiento), view.Model);
        }

        [Test]
        public void _08_Editar_Id_4_Retorna_Vista_Ok()
        {
            //Preparar  - Arrange
            var _id = 4;
            var mock = new Mock<ISeguimientoTitulo>();
            mock.Setup(x => x.TraerSeguimientoPorId(_id)).Returns(new Seguimiento());

            //Actuar - Act
            var controller = new SeguimientoController(mock.Object);

            //Afirmar - Assert
            var view = controller.Edit(_id) as ViewResult;
            AssertViewsWithModel(view, "Edit");
            mock.Verify(x => x.TraerSeguimientoPorId(_id), Times.Exactly(1));

        }
        [Test]
        public void _09_Edit_Guardar_Ok()
        {
            //Preparar  - Arrange
            var mock = new Mock<ISeguimientoTitulo>();
            var controller = new SeguimientoController(mock.Object);

            //Actuar - Act
            var redirect = controller.Edit(new Seguimiento { Observaciones = "Salud de PPK" }) as RedirectToRouteResult;
            
            //Afirmar - Assert
            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        [Test]
        public void _10_Edit_Falla_Guardar()
        {
            //Preparar  - Arrange
            var controller = new SeguimientoController(null);

            //Actuar - Act
            var view = controller.Edit(new Seguimiento()) as ViewResult;

            //Afirmar - Assert
            AssertViewsWithModel(view, "Edit");

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

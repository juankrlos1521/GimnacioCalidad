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
    public class TrabajadorControllerTest
    {
        //[Test]
        //public void TestTrabajador1_RetornarIndex_trabajador()
        //{
        //    string expected = "Index";
        //    var mock = new Mock<ITrabajadorTitulo>();
        //    TrabajadorController controller = new TrabajadorController(mock.Object);

        //    ViewResult result = controller.Index() as ViewResult;

        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(expected, result.ViewName);
        //}


        ////[Test]
        ////public void TestTrabajador2_AbrirCreateTrabajador_trabajador()
        ////{
        ////    var controller = new TrabajadorController(null);

        ////    var view = controller.Create() as ViewResult;

        ////    AssertViewWithoutModel(view, "Create");

        ////}

        //[Test]
        //public void TestTrabajador3_GuardadoExitosoRedireccionarIndex_Trabajador()
        //{
        //    var mock = new Mock<ITrabajadorTitulo>();
        //    var controller = new TrabajadorController(mock.Object);

        //    var redirect = controller.Create(new Trabajador { Estado = false }) as RedirectToRouteResult;

        //    Assert.IsNotNull(redirect);
        //    Assert.AreEqual("Index", redirect.RouteValues["action"]);
        //}

        //private void AssertViewWithoutModel(ViewResult view, string viewName)
        //{
        //    Assert.IsNotNull(view);
        //    Assert.AreEqual(viewName, view.ViewName);
        //    Assert.IsNull(view.Model);
        //}
    }
}
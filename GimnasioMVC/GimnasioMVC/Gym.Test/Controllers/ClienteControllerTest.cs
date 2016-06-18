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
    public class ClienteControllerTest
    {
        [Test]
        public void TestCliente1_RetornarIndex_Cliente()
        {
            string expected = "Index";
            var mock = new Mock<IClienteTitulo>();
            ClienteController controller = new ClienteController(mock.Object);

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result.ViewName);
        }


        [Test]
        public void TestCliente2_AbrirCreateCliente_Cliente()
        {
            var controller = new ClienteController(null);

            var view = controller.Create() as ViewResult;

            AssertViewWithoutModel(view, "Create");

        }

        [Test]
        public void TestCliente3_GuardadoExitosoRedireccionarIndex_Cliente()
        {
            var mock = new Mock<IClienteTitulo>();
            var controller = new ClienteController(mock.Object);

            var redirect = controller.Create(new Cliente { Estado = false }) as RedirectToRouteResult;

            Assert.IsNotNull(redirect);
            Assert.AreEqual("Index", redirect.RouteValues["action"]);
        }

        private void AssertViewWithoutModel(ViewResult view, string viewName)
        {
            Assert.IsNotNull(view);
            Assert.AreEqual(viewName, view.ViewName);
            Assert.IsNull(view.Model);
        }
    }
}

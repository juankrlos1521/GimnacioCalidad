using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

using Gym.Interfaces.Titulos;
using Gym.Services.Tramas;


namespace Gym.Web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>(); 

            //Registrar Componentes
            container.RegisterType<ISeguimientoTitulo, SeguimientoTrama>();
            container.RegisterType<ITrabajadorTitulo, TrabajadorTrama>();
            container.RegisterType<IRutinaTitulo, RutinaTrama>();
            container.RegisterType<IClienteTitulo, ClienteTrama>();


            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}
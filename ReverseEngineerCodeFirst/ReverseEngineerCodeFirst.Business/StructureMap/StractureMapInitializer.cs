using System;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;
using ReverseEngineerCodeFirst.Data.Contexts;
using ReverseEngineerCodeFirst.Data.Services.Implementations.EF;
using ReverseEngineerCodeFirst.Data.Services.Interfaces;
using ReverseEngineerCodeFirst.Data.Services.Interfaces.Base;
using StructureMap;

namespace ReverseEngineerCodeFirst.Business.StructureMap
{
  public static class StractureMapInitializer
  {
    public static void InitializeTypes()
    {
      ObjectFactory.Initialize(x =>
                                 {
                                   x.For<IUnitOfWork>().HybridHttpOrThreadLocalScoped().Use(() => new TestContext());
                                   
                                   //x.For<IUserService>().Use<UserService>();
                                 });
    }
    //public static void Init(ControllerBuilder builder = null)
    //{
    //  InitializeTypes();
    //  if (builder != null)
    //    builder.SetControllerFactory(new StructureMapControllerFactory());
    //}
  }

  //public class StructureMapControllerFactory : DefaultControllerFactory
  //{
  //  protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
  //  {
  //    try
  //    {
  //      return ObjectFactory.GetInstance(controllerType) as Controller;
  //    }
  //    catch (ArgumentNullException)
  //    {
  //      throw new HttpException(404, "Controller Not Found!");
  //    }
  //  }
  //}
}

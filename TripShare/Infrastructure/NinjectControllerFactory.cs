using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;

namespace TripShare.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
        private void AddBindings()
        {
            // put bindings here
        }
    }
}
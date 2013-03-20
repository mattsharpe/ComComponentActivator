using System;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ComponentActivator;
using Castle.MicroKernel.Context;

namespace WindsorTests
{
    public class ComComponentActivator : DefaultComponentActivator, IDependencyAwareActivator
    {
        public ComComponentActivator(ComponentModel model, IKernelInternal kernel, ComponentInstanceDelegate onCreation, ComponentInstanceDelegate onDestruction)
            : base(model, kernel, onCreation, onDestruction)
        {
        }

        public override object Create(CreationContext context, Burden burden)
        {
            try
            {
                burden.SetRootInstance(Activator.CreateInstance(burden.Model.Implementation));
                return burden.Instance;
            }
            catch (MissingMethodException ex)
            {
                throw new Exception("Couldn't instantiate " + burden.Model.Implementation, ex);
            }
        }

        public bool CanProvideRequiredDependencies(ComponentModel component)
        {
            return true;
        }

        public bool IsManagedExternally(ComponentModel component)
        {
            return false;
        }
    }
}
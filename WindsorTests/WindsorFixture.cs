using Castle.MicroKernel.ComponentActivator;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using NUnit.Framework;
using SampleComponentLib;

namespace WindsorTests
{
    [TestFixture]
    public class WindsorFixture
    {
        [Test]
        [ExpectedException(typeof(ComponentActivatorException),
            ExpectedMessage = "ComponentActivator: could not instantiate SampleComponentLib.TestClass")]
        public void Fails()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<ITest>().ImplementedBy<TestClass>());

            container.Resolve<ITest>();
        }

        [Test]
        public void Passes()
        {
            var container = new WindsorContainer();
            
            container.Register(Component.For<ITest>()
                .Activator<ComComponentActivator>()
                .ImplementedBy<TestClass>());

            var test = container.Resolve<ITest>();

            test.DoSomething();
        }
    }
}

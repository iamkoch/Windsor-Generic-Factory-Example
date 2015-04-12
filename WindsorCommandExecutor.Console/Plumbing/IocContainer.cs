using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Plumbing
{
    public static class IocContainer
    {
        private static readonly WindsorContainer container = new WindsorContainer();

        public static WindsorContainer BootstrapWindsor(string assemblyLocation)
        {
            container.AddFacility<StartableFacility>(facility => facility.DeferredStart());

            container.Install(FromAssembly.InDirectory(new AssemblyFilter(assemblyLocation)));

            return container;
        }
    }
}
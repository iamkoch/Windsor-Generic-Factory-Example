using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Iamkoch.Samples.WindsorCommandExecutor.Console.Handlers;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Installer
{
    public class CommandHandlerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                        .InSameNamespaceAs<LogTextToConsoleCommandHandler>()
                                        .WithServiceFirstInterface()
                                        .LifestyleTransient());
        }
    }
}
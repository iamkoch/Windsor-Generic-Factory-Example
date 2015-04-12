using System;
using System.Reflection;

using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

using Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Installer
{
    public class CommandHandlerImplementationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof(ICommandHandler<>))
                    .AsFactory(c => c.SelectedWith(new CommandHandlerComponentSelector())));
        }

        private class CommandHandlerComponentSelector : DefaultTypedFactoryComponentSelector
        {
            protected override Type GetComponentType(MethodInfo method, object[] arguments)
            {
                var message = arguments[0];
                var handlerType = typeof(ICommandHandler<>).MakeGenericType(message.GetType());
                return handlerType;
            }
        }
    }
}
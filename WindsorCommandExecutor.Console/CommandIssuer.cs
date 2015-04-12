using System;

using Iamkoch.Samples.WindsorCommandExecutor.Console.Commands;
using Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts;
using Iamkoch.Samples.WindsorCommandExecutor.Console.Plumbing;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console
{
    public class CommandIssuer
    {
        public void Start()
        {
            var applicationRoot = AppDomain.CurrentDomain.BaseDirectory;

            var container = IocContainer.BootstrapWindsor(applicationRoot);

            var commandHandler = container.Resolve<ICommandHandler<LogTextToConsoleCommand>>();

            commandHandler.Handle(new LogTextToConsoleCommand
                                      {
                                          Text = "Log this out to the console"
                                      });
        }
    }
}
using Iamkoch.Samples.WindsorCommandExecutor.Console.Commands;
using Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Handlers
{
    public class LogTextToConsoleCommandHandler : ICommandHandler<LogTextToConsoleCommand>
    {
        public void Handle(LogTextToConsoleCommand command)
        {
            System.Console.WriteLine(command.Text);
        }
    }
}
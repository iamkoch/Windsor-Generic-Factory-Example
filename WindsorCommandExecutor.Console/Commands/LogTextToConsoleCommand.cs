using Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts;

namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Commands
{
    public class LogTextToConsoleCommand : ICommand
    {
        public string Text { get; set; }
    }
}
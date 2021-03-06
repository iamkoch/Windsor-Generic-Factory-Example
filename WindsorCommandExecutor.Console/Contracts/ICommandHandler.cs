﻿namespace Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
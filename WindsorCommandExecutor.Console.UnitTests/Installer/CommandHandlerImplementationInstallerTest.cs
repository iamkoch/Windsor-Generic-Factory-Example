using System;
using System.Collections.Generic;
using System.Linq;

using Iamkoch.Samples.WindsorCommandExecutor.Console.Commands;
using Iamkoch.Samples.WindsorCommandExecutor.Console.Contracts;
using Iamkoch.Samples.WindsorCommandExecutor.Console.Installer;

using NUnit.Framework;

namespace WindsorCommandExecutor.Console.UnitTests.Installer
{
    [TestFixture]
    public class CommandHandlerImplementationInstallerTest : WindsorContainerTest<CommandHandlerImplementationInstaller>
    {
        protected override List<Type> HandlerTypes
        {
            get
            {
                return new List<Type>
                           {
                               typeof(ICommandHandler<LogTextToConsoleCommand>)
                           };
            }
        }
    }
}
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
    public class CommandHandlerInstallerTests : WindsorContainerTest<CommandHandlerInstaller>
    {
        protected override List<Type> ImplementationTypes
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
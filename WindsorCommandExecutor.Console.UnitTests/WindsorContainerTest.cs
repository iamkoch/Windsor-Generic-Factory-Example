using System;
using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

using Iamkoch.Samples.WindsorCommandExecutor.Console.Installer;

using NUnit.Framework;

namespace WindsorCommandExecutor.Console.UnitTests
{
    public abstract class WindsorContainerTest<T> where T : IWindsorInstaller
    {
        protected virtual List<Type> HandlerTypes
        {
            get { return null; }
        }

        protected virtual List<Type> ImplementationTypes
        {
            get { return null; }
        }

        private IWindsorContainer WindsorContainer { get; set; }

        [SetUp]
        public void SetUp()
        {
            WindsorContainer = new WindsorContainer();

            AddInstaller(Activator.CreateInstance<T>());
        }

        [Test]
        public void AssertImplementations()
        {
            (ImplementationTypes ?? new List<Type>()).ForEach(x => Assert.That(WindsorContainer.Kernel.ResolveAll(x).Length, Is.EqualTo(1)));
        }

        [Test]
        public void AssertHandlers()
        {
            (HandlerTypes ?? new List<Type>()).ForEach(x => Assert.That(GetHandlers(x).Length, Is.EqualTo(1)));
        }

        private IWindsorContainer AddInstaller(params IWindsorInstaller[] windsorInstallers)
        {
            return WindsorContainer.Install(windsorInstallers);
        }

        private T[] GetImplementations<T>()
        {
            return WindsorContainer.Kernel.ResolveAll<T>();
        }

        private T[] GetImplementations(Type type)
        {
            return WindsorContainer.Kernel.ResolveAll<T>();
        }

        private IHandler[] GetHandlers(Type type)
        {
            return WindsorContainer.Kernel.GetAssignableHandlers(type);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac;

namespace Template.Console.UnitTests._03_Console
{
    [TestClass]
    public class SettingsUnitTests
    {
        public SettingsUnitTests()
        {
            // Initialize Autofac
            Cmd.DiContainer.DiContainer.Initialize();
        }
        [TestMethod]
        public void InitializedSettingsTest()
        {
            // Review Settings (Unit Test Layer)
            // Should match presentation layer(s)
            var buildDate = Cmd.DiContainer.DiContainer.container.Resolve<Cmd.Configuration.ISettings>().BuildDate;
            var buildVersion = Cmd.DiContainer.DiContainer.container.Resolve<Cmd.Configuration.ISettings>().BuildVersion;
            Assert.IsNotNull(buildDate);
            Assert.IsNotNull(buildVersion);
        }
    }
}

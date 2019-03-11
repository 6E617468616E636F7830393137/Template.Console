using System;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Template.Console.Cmd.DiContainer;

namespace Template.Console.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        // Initializes the Autofac DiContainer
        public IContainer container = DiContainer.Initialize();
        [TestMethod]
        public void BuildDateTest()
        {
            // Implements Container
            var buildVersion = container.Resolve<Bll.BuildInformation.IBuildData>().setBuidInformation(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                System.Convert.ToDateTime(DateTime.Now).ToString());
            System.Console.WriteLine(buildVersion.BuildDate);
            System.Console.WriteLine(buildVersion.BuildVersion);
            Assert.IsNotNull(buildVersion);
        }
        [TestMethod]
        public void SettingsTest()
        {
            // Implements Container
            var setting = container.Resolve<Cmd.Configuration.ISettings>().ConfigMessage;
            System.Console.WriteLine(setting);
            Assert.IsNotNull(setting);
        }
        [TestMethod]
        public void MessageManagerTest()
        {
            // Implements Container
            var messageManager = container.Resolve<Bll.MessageManager.IMessage>().setMessage(container.Resolve<Cmd.Configuration.ISettings>().ConfigMessage);
            var outputMessage = container.Resolve<Bll.MessageManager.IMessage>().getMessage(messageManager);
            System.Console.WriteLine(outputMessage);
            Assert.IsNotNull(messageManager);
            Assert.IsNotNull(outputMessage);

        }
    }
}

using Autofac;
using Template.Console.Cmd.Configuration;
using Logger = Log4net.Helper.Logging.Logger;

namespace Template.Console.Cmd
{
    class Program
    {        
        static void Main(string[] args)
        {
            Logger.Info(": : : : : Starting : : : : : ");
            Execute();
        }
        static void Execute()
        {
            // Initializes the Autofac DiContainer
            var container = DiContainer.DiContainer.Initialize();
            // Implements Container
            var messageManager = container.Resolve<Bll.MessageManager.IMessage>().setMessage(container.Resolve<Configuration.ISettings>().ConfigMessage);
            var outputMessage = container.Resolve<Bll.MessageManager.IMessage>().getMessage(messageManager);
            var buildVersion = container.Resolve<Bll.BuildInformation.IBuildData>().setBuidInformation(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                System.Convert.ToDateTime(Properties.Resources.BuildDate).ToString());            
            //var messageManager = MessageManager.setMessage(settings.ConfigMessage);
            //var outputMessage = MessageManager.getMessage(messageManager);
            //BuildManager.setBuidInformation(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),
            //    System.Convert.ToDateTime(Properties.Resources.BuildDate).ToString());
            //var buildVersion = BuildManager.version;
            System.Console.WriteLine(outputMessage);
            Logger.Debug($"Ouput Message : {outputMessage}");
            System.Console.WriteLine($"Build Version: {buildVersion.BuildVersion}");
            Logger.Debug($"Build Version: {buildVersion.BuildVersion}");
            System.Console.WriteLine($"Build Date: {buildVersion.BuildDate}");
            Logger.Debug($"Build Date: {buildVersion.BuildDate}");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }
    }
}

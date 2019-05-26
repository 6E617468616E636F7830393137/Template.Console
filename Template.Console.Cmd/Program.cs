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
            var buildDate = Cmd.DiContainer.DiContainer.container.Resolve<Cmd.Configuration.ISettings>().BuildDate;
            var buildVersion = Cmd.DiContainer.DiContainer.container.Resolve<Cmd.Configuration.ISettings>().BuildVersion;
            System.Console.WriteLine($"Build Version: {buildVersion}");
            System.Console.WriteLine($"Build Date: {buildDate}");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }
    }
}

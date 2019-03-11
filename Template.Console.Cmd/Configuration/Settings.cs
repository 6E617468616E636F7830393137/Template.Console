using System.Configuration;

namespace Template.Console.Cmd.Configuration
{
    public class Settings : ISettings
    {
        public string ConfigMessage { get; } = ConfigurationManager.AppSettings["ConfigMessage"];
    }
}

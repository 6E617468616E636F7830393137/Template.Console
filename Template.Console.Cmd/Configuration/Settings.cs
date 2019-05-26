using System;
using System.Configuration;

namespace Template.Console.Cmd.Configuration
{
    public class Settings : ISettings
    {
        public string BuildDate { get; } = Convert.ToDateTime(Properties.Resources.BuildDate).ToString();
        public string BuildVersion { get; } = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public string ConfigMessage { get; } = ConfigurationManager.AppSettings["ConfigMessage"];
    }
}

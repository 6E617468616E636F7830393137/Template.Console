namespace Template.Console.Cmd.Configuration
{
    public interface ISettings
    {
        string BuildDate { get; }
        string BuildVersion { get; }
        string ConfigMessage { get; }
    }
}

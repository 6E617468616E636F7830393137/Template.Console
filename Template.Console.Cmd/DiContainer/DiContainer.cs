using Autofac;
using System.Reflection;
namespace Template.Console.Cmd.DiContainer
{
    public class DiContainer
    {
        // Create Container Object
        public static ContainerBuilder builder;
        public static IContainer container;
        // Initialize Container Object
        public static IContainer Initialize()
        {
            builder = new ContainerBuilder();
            // Register Sal
            // builder.RegisterType<[Class_Name]>().As<[Interface_Name]>();
            // Register Dal
            // Register Bll
            builder.RegisterType<Bll.MessageManager.Message>().As<Bll.MessageManager.IMessage>();
            builder.RegisterType<Bll.BuildInformation.BuildData>().As<Bll.BuildInformation.IBuildData>();
            // Register Cmd
            builder.RegisterType<Configuration.Settings>().As<Configuration.ISettings>();
            container = builder.Build();
            return container;
        }

    }
}

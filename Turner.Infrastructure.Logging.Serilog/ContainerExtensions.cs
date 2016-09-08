using Serilog;
using SimpleInjector;

namespace Turner.Infrastructure.Logging.Serilog
{
    public static class ContainerExtensions
    {
        public static void ConfigureSerilog(this Container container)
        {
            var config = new LoggerConfiguration();
            config.WriteTo.ColoredConsole();

            ConfigureSerilog(container, config);
        }

        public static void ConfigureSerilog(this Container container, LoggerConfiguration loggerConfig)
        {
            container.RegisterSingleton<ILogger, SerilogAdapter>();
            container.RegisterSingleton<global::Serilog.ILogger>(loggerConfig.CreateLogger);
        }
    }
}
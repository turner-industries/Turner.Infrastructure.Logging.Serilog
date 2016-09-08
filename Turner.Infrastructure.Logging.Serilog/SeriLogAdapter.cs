namespace Turner.Infrastructure.Logging.Serilog
{
    internal class SerilogAdapter : ILogger
    {
        private readonly global::Serilog.ILogger _logger;

        public SerilogAdapter(global::Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void Information(string logMessage)
        {
            _logger.Information(logMessage);
        }

        public void Debug(string logMessage)
        {
            _logger.Debug(logMessage);
        }
    }
}
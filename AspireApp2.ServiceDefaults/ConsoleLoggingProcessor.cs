using OpenTelemetry.Logs;
using OpenTelemetry;
using Microsoft.Extensions.Logging;

namespace AspireApp2.ServiceDefaults
{
    public class ConsoleLoggingProcessor : BaseProcessor<LogRecord>
    {
        private readonly ILogger<ConsoleLoggingProcessor> _logger;

        public ConsoleLoggingProcessor(ILogger<ConsoleLoggingProcessor> logger)
        {
            _logger = logger;
        }

        public override void OnEnd(LogRecord data)
        {
            base.OnEnd(data);
            _logger.LogInformation("Log sent to endpoint: {FormattedMessage}", data.FormattedMessage);
        }
    }
}

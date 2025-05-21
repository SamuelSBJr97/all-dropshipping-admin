using Microsoft.Extensions.Logging;
using Serilog;

namespace DropshippingAdmin.Infrastructure.Services
{
    public class SerilogLoggingService : ILogger
    {
        private readonly ILogger _logger;
        public SerilogLoggingService()
        {
            _logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }
        public IDisposable BeginScope<TState>(TState state) => null!;
        public bool IsEnabled(LogLevel logLevel) => true;
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            _logger.Information(formatter(state, exception));
        }
    }
}

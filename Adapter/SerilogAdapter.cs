
namespace Adapter;

public class SerilogAdapter : IAppLogger
{
    private readonly SerilogLogger _logger;

    public SerilogAdapter(SerilogLogger serilogLogger)
    {
        _logger = serilogLogger;
    }
    public void LogError(string message, Exception ex)
    {
       _logger.Error(ex, message);
    }

    public void LogInfo(string message)
    {
        _logger.Information(message);   
    }
}
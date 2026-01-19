namespace Adapter;

public class SerilogLogger
{
    public void Information(string message)
    {
        Console.WriteLine($"[INFO] {message}");
    }

    public void Error(Exception ex, string message)
    {
        Console.WriteLine($"[ERROR] {message} | {ex.Message}");
    }
}
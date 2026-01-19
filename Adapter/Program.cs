
namespace Adapter;

internal class Program
{
    static void Main(string[] args)
    {
        IAppLogger logger = new SerilogAdapter(new SerilogLogger());

        logger.LogInfo("User created successfully");

        try
        {
            throw new Exception("Database connection failed");
        }
        catch (Exception ex)
        {
            logger.LogError("Error while creating user", ex);
        }

    }
}

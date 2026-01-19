namespace Decorator;

public class LoggingStorageDecorator : FileDecorator
{
    public LoggingStorageDecorator(IFileStorage fileStorage) : base(fileStorage)
    {
    }

    public override void SaveFile(string path)
    {
        Console.WriteLine($"Logging a save file in this path : {path}");
        base.SaveFile(path);
    }

    public override string GetFile(string path) {
        Console.WriteLine($"Logging a get file in this path : {path}");
        return base.GetFile(path);
    }
}


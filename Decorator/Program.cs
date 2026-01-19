namespace Decorator;

internal class Program
{
    static void Main(string[] args)
    {
        IFileStorage fileStorage = new EncryptedStorageDecorator(new LoggingStorageDecorator(new LocalFileStorage()));
        Console.WriteLine(fileStorage.GetFile("c://ddd.com"));
    }
}


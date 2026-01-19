namespace Decorator;

public class LocalFileStorage : IFileStorage
{
    public string GetFile(string path)
    {
        return "binaryData";
    }

    public void SaveFile(string path)
    {
        Console.WriteLine("Saved file success");
    }
}


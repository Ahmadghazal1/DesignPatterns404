namespace Decorator;

public interface IFileStorage
{
    void SaveFile(string path);
    string GetFile(string path);
}


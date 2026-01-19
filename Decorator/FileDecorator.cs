namespace Decorator;

public abstract class FileDecorator : IFileStorage
{
    protected readonly IFileStorage _fileStorage;

    protected FileDecorator(IFileStorage fileStorage)
    {
        _fileStorage = fileStorage;
    }

    public virtual void SaveFile(string path)
        => _fileStorage.SaveFile(path);

    public virtual string GetFile(string path)
        => _fileStorage.GetFile(path);
}


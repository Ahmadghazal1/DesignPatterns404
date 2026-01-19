namespace Decorator;

public class EncryptedStorageDecorator : FileDecorator
{
    public EncryptedStorageDecorator(IFileStorage fileStorage)
        : base(fileStorage) { }

    public override void SaveFile(string path)
    {
        Console.WriteLine("Encrypting file...");
        base.SaveFile(path);
    }

    public override string GetFile(string path)
    {
        Console.WriteLine("Decrypting file...");
        return base.GetFile(path);
    }
}


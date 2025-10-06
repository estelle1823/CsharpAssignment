using Infrastructure.cs.Interfaces;

namespace Infrastructure.cs.Services;

public class JsonFileService(string, filePath) : IFileService
{
    private readonly string _filePath = filePath;

    public string GetJsonContentFromFile()
    {
        throw new NotImplementedException();
    }

    public bool SaveJsonContentToFile(string jsonContent)
    {
        throw new NotImplementedException();
    }
}

using Infrastructure.cs.Interfaces;
using System.Text.Json;
namespace Infrastructure.cs.Services;

public class JsonFileService : IFileService
{
    private readonly string _filePath;

    public JsonFileService(string filePath = @"c:\data\products.json")
    {
        _filePath = filePath;
    }

    public bool SaveJsonContentToFile(string jsonContent)
    {
        try
        {
            File.WriteAllText(_filePath, jsonContent);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public string GetJsonContentFromFile()
    {
        if (!File.Exists(_filePath))
            return string.Empty;

        return File.ReadAllText(_filePath);
    }
}
using Infrastructure.cs.Interfaces;
using System.Text.Json;
namespace Infrastructure.cs.Services;

public class JsonFileService(string filePath, JsonSerializerOptions? options = null) : IFileService
{
    private readonly string _filePath = filePath;
    private readonly JsonSerializerOptions _options = options ?? new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true,
    };


    public string GetJsonContentFromFile()
    {
        if (!File.Exists(_filePath))
            return string.Empty;

        return File.ReadAllText(_filePath);
    }

    public bool SaveJsonContentToFile(string jsonContent)
    {
        try
        {
            var directory = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(_filePath, content);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

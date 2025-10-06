namespace Infrastructure.cs.Interfaces;

public interface IFileService
{
    bool SaveJsonContentToFile(string jsonContent);
    string GetJsonContentFromFile();

}


using System.Reflection.Emit;

namespace Infrastructure1.Interfaces;

public interface IFileService
{


    bool SaveJsonContentToFile(string jsonContent, string fileName);

    string GetJsonContentFromFile(string filePath);



}

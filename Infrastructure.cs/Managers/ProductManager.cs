using Infrastructure.cs.Interfaces;

namespace Infrastructure.cs.Managers;

public class ProductManager
{
    private readonly IFileService _fileService;
    public ProductManager(IFileService fileService)
    { 
        _fileService = fileService;
    }
}


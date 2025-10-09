using Infrastructure1.Interfaces;

namespace Infrastructure1.Managers
{
    public class ProductManager(IFileService fileService)
    {
        private readonly IFileService _fileService = fileService;

        public void SaveProduct()
        {

        }
    }
}
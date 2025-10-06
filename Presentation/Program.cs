builder.Services.AddSingleton<IFileService, JsonFileService>();


IFileService fileService = new JsonFileService();
fileService.SaveContentToFile("");

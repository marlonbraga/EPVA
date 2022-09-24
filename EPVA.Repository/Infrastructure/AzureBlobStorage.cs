using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace EPVA.Repository.Infrastructure
{
    public class AzureBlobStorage
    {
        private readonly IConfiguration configuration;

        public AzureBlobStorage(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string> UploadFile(string fileName, Stream buffer, string directory = "")
        {
            if (!string.IsNullOrWhiteSpace(directory))
                directory += "/";
        
            BlobServiceClient blobServiceClient = new BlobServiceClient(this.configuration["BlobStorageConnection"]);
            BlobContainerClient container = blobServiceClient.GetBlobContainerClient($"apostilas");

            var info = await container.UploadBlobAsync(fileName, buffer);

	        return $"{this.configuration["BlobStorageBasePath"]}/apostilas/{directory}{fileName}";
        }
    }
}

using Azure.Storage.Blobs;

string connectionString = "Your_Connection_String";
string containerName = "files";

var blobService = new BlobServiceClient(connectionString);
var container = blobService.GetBlobContainerClient(containerName);
await container.CreateIfNotExistsAsync();

var blob = container.GetBlobClient("sample.txt");
await blob.UploadAsync("sample.txt", true);

Console.WriteLine("Uploaded to Blob Storage");
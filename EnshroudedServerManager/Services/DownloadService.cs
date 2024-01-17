
namespace EnshroudedServerManager.Services
{
    public class DownloadService
    {
        public async Task<bool> DownloadAndSave(string sourceFile, string destinationFolder, string destinationFileName)
        {
            Stream fileStream = await GetFileStream(sourceFile);

            if (fileStream != Stream.Null)
            {
                await SaveStream(fileStream, destinationFolder, destinationFileName);

                return true;
            }

            return false;
        }

        public async Task<Stream> GetFileStream(string fileUrl)
        {
            HttpClient httpClient = new HttpClient();
            try
            {
                Stream fileStream = await httpClient.GetStreamAsync(fileUrl);
                return fileStream;
            }
            catch (Exception)
            {
                return Stream.Null;
            }
        }

        public async Task SaveStream(Stream fileStream, string destinationFolder, string destinationFileName)
        {
            if (!Directory.Exists(destinationFolder))
                Directory.CreateDirectory(destinationFolder);

            string path = Path.Combine(destinationFolder, destinationFileName);

            using (FileStream outputFileStream = new FileStream(path, FileMode.CreateNew))
            {
                await fileStream.CopyToAsync(outputFileStream);
            }
        }
    }
}

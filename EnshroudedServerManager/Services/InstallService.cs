using System.Diagnostics;
using System.IO.Compression;

namespace EnshroudedServerManager.Services
{
    public class InstallService
    {
        private string _downloadLink = @"https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
        private string _steamCmdPath = @"./SteamCmd/";
        private string _steamCmdZipPath = @"./SteamCmd/";
        private string _steamCmdZipFileName = @"Steamcmd.zip";
        private string _steamCmdCombinedPath = string.Empty;

        //private string _steamAppId = "2278520";
        private string _steamAppId = "2430930";
        private string _serverPath = @"../Serverfiles";
        private string _pathSteamCmdExe = @".\SteamCmd\steamcmd.exe";

        public InstallService(Form installForm) 
        {
            _steamCmdCombinedPath = Path.Combine(_steamCmdZipPath, _steamCmdZipFileName);
        }

        public async Task<bool> InstallSteamCmdAsync()
        {
            //Check if dir exists
            if (!Directory.Exists(_steamCmdPath))
            {
                Directory.CreateDirectory(_steamCmdPath);
            }

            //Clean up if needed
            if (File.Exists(_steamCmdCombinedPath))
            {
                File.Delete(_steamCmdCombinedPath);
            }

            DownloadService downloadService = new DownloadService();
            _ = await downloadService.DownloadAndSave(_downloadLink, _steamCmdZipPath, _steamCmdZipFileName);  

            if (File.Exists(_steamCmdCombinedPath))
            {
                try
                {
                    ZipFile.ExtractToDirectory(_steamCmdCombinedPath, _steamCmdZipPath);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return false;
        }

        public bool InstallOrUpdateServerfiles()
        {
            try
            {
                Process.Start(_pathSteamCmdExe, "+force_install_dir " + _serverPath + " +login anonymous +app_update " + _steamAppId + " validate +quit");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

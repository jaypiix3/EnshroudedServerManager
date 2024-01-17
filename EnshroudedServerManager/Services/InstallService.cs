using System.Diagnostics;
using System.IO.Compression;

namespace EnshroudedServerManager.Services
{
    public class InstallService
    {
        private PathAndLinkService _pathAndLinkService;

        public InstallService(Form installForm) 
        {
            _pathAndLinkService = new PathAndLinkService();

            _pathAndLinkService.SteamCmdCombinedPath = Path.Combine(_pathAndLinkService.SteamCmdPath, _pathAndLinkService.SteamCmdZipFileName);
        }

        public async Task<bool> InstallSteamCmdAsync()
        {
            //Check if dir exists
            if (!Directory.Exists(_pathAndLinkService.SteamCmdPath))
            {
                Directory.CreateDirectory(_pathAndLinkService.SteamCmdPath);
            }

            //Clean up if needed
            if (File.Exists(_pathAndLinkService.SteamCmdCombinedPath))
            {
                File.Delete(_pathAndLinkService.SteamCmdCombinedPath);
            }

            DownloadService downloadService = new DownloadService();
            _ = await downloadService.DownloadAndSave(_pathAndLinkService.SteamCmdDownloadLink, _pathAndLinkService.SteamCmdPath, _pathAndLinkService.SteamCmdZipFileName);  

            if (File.Exists(_pathAndLinkService.SteamCmdCombinedPath))
            {
                try
                {
                    ZipFile.ExtractToDirectory(_pathAndLinkService.SteamCmdCombinedPath, _pathAndLinkService.SteamCmdPath);
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
                Process.Start(_pathAndLinkService.SteamCmdExe, "+force_install_dir " + _pathAndLinkService.ServerPathWithBackstep + " +login anonymous +app_update " + _pathAndLinkService.SteamAppId + " validate +quit");
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

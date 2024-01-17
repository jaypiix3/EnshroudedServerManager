using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnshroudedServerManager.Services
{
    public class PathAndLinkService
    {
        //private string _steamAppId = "2278520";
        public string SteamAppId = "2430930";

        public string SteamCmdDownloadLink = @"https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
        public string SteamCmdPath = @"./SteamCmd/";
        public string SteamCmdZipFileName = @"Steamcmd.zip";
        public string SteamCmdCombinedPath = string.Empty;
        public string SteamCmdExe = @".\SteamCmd\steamcmd.exe";

        public string SettingsFilePath = @"./settings.json";

        //public string ServerPath = @"./serverfiles";
        public string ServerPathWithBackstep = @"../serverfiles";
        public string TestSystem = @".\serverfiles\ShooterGame\Binaries\Win64\ArkAscendedServer.exe";
        public string ServerExePath = @"./serverfiles/steamapps/common/EnshroudedServer/enshrouded_server.exe";
        public string ServerConfigPath = @"./serverfiles/steamapps/common/EnshroudedServer/enshrouded_server.json";
        

        public PathAndLinkService()
        {
            SteamCmdCombinedPath = Path.Combine(SteamCmdPath, SteamCmdZipFileName);
        }
    }
}

using EnshroudedServerManager.Models;
using EnshroudedServerManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnshroudedServerManager
{
    public partial class SettingsForm : Form
    {
        private PaintService _paintService;
        private InstallService _installService;
        private SettingsService _settingsService;
        private PathAndLinkService _pathAndLinkService;

        private Settings? _settings;

        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public SettingsForm()
        {
            InitializeComponent();

            _paintService = new PaintService();
            _installService = new InstallService(this);
            _settingsService = new SettingsService();
            _pathAndLinkService = new PathAndLinkService();

            LoadSettingsOnStart();

            if (File.Exists(_pathAndLinkService.ServerConfigPath))
            {
                UpdateUI();
            }
            else if (Directory.Exists(_pathAndLinkService.SteamCmdPath))
            {
                btnSetupServer.Enabled = false;

                lSteamCmdStatus.Text = "Installed";
                lSteamCmdStatus.ForeColor = Color.LimeGreen;

                lServerInstallStatus.Text = "Unknown";
                lServerInstallStatus.ForeColor = Color.Goldenrod;
            }
        }

        private void LoadSettingsOnStart()
        {
            try
            {
                if (File.Exists(_pathAndLinkService.SettingsFilePath))
                {
                    _settings = _settingsService.LoadSettings(_pathAndLinkService.SettingsFilePath);

                    if (_settings != null)
                    {
                        tbServername.Text = _settings.Name;
                        tbPassword.Text = _settings.Password;
                        tbSaveDirectory.Text = _settings.SaveDirectory;
                        tbLogDirectory.Text = _settings.LogDirectory;
                        tbIpAddress.Text = _settings.IpAddress;
                        tbGamePort.Text = _settings.GamePort.ToString();
                        tbQueryPort.Text = _settings.QueryPort.ToString();
                        tbSlotCount.Text = _settings.SlotCount.ToString();
                    }
                }
            }
            catch (Exception)
            {
                CustomMessageBox cmb = new CustomMessageBox("Couldn't load settings", "While loading the settings, an error occured.");
                cmb.ShowDialog();
            }
        }

        private void UpdateUI()
        {
            lSteamCmdStatus.Text = "Installed";
            lSteamCmdStatus.ForeColor = Color.LimeGreen;

            lServerInstallStatus.Text = "Installed";
            lServerInstallStatus.ForeColor = Color.LimeGreen;

            tbServername.Enabled = true;
            tbPassword.Enabled = true;
            tbSaveDirectory.Enabled = true;
            tbLogDirectory.Enabled = true;
            tbIpAddress.Enabled = true;
            tbGamePort.Enabled = true;
            tbQueryPort.Enabled = true;
            tbSlotCount.Enabled = true;
            btnCreateFirewallRule.Enabled = true;

            btnSaveSettings.Enabled = true;

            groupBoxConfiguration.Text = "Configuration";

            btnSetupServer.Enabled = false;
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void SettingsForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnSetupServer_Click(object sender, EventArgs e)
        {
            var installedSteamCmd = _installService.InstallSteamCmdAsync();

            if (await installedSteamCmd)
            {
                lSteamCmdStatus.Text = "Installed";
                lSteamCmdStatus.ForeColor = Color.LimeGreen;

                var serverfileDownloadStarted = _installService.InstallOrUpdateServerfiles();

                if (serverfileDownloadStarted)
                {
                    lServerInstallStatus.Text = "Download started";
                    lServerInstallStatus.ForeColor = Color.LimeGreen;

                    await DelayedClose();
                }
            }
        }

        private async Task DelayedClose()
        {
            await Task.Delay(5000);
            this.Close();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                _settings = new Settings()
                {
                    Name = tbServername.Text,
                    Password = tbPassword.Text,
                    SaveDirectory = tbSaveDirectory.Text,
                    LogDirectory = tbLogDirectory.Text,
                    IpAddress = tbIpAddress.Text,
                    GamePort = Convert.ToInt32(tbGamePort.Text),
                    QueryPort = Convert.ToInt32(tbQueryPort.Text),
                    SlotCount = Convert.ToInt32(tbSlotCount.Text)
                };

                _settingsService.SaveSettings(_settings, _pathAndLinkService.SettingsFilePath);

                CustomMessageBox cmb = new CustomMessageBox("Settings saved", "Settings are saved. After the next server start \nsettings will be updated.");
                cmb.ShowDialog();

            }
            catch (Exception)
            {
                CustomMessageBox cmb = new CustomMessageBox("Error while saving", @"While saving the settings an error occured.");
                cmb.ShowDialog();
            }


        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            _paintService.CustomBackgroundPainter(
            this,
            e,
            linethickness: 1,
            linecolor: Color.FromArgb(52, 52, 52),
            offsetborder: 1
            );
        }

        protected void UpdateLabelByInvoke(string percentage)
        {
            lSteamCmdStatus.Text = percentage;
        }

        private void btnCreateFirewallRule_Click(object sender, EventArgs e)
        {
            if (tbGamePort.Text.Length > 0 && tbQueryPort.Text.Length > 0)
            {
                try
                {
                    int gamePortNumber = Convert.ToInt32(tbGamePort.Text);
                    int queryPortNumber = Convert.ToInt32(tbQueryPort.Text);
                    string gamePortCommand = $"netsh advfirewall firewall add rule name=\"Enshrouded_GameServerPort_UDP\" dir=in action=allow protocol=UDP localport={gamePortNumber}";
                    string queryPortCommand = $"netsh advfirewall firewall add rule name=\"Enshrouded_QueryServerPort_TCP\" dir=in action=allow protocol=TCP localport={queryPortNumber}";

                    RunCommand(new List<string> { gamePortCommand, queryPortCommand });

                    CustomMessageBox cmb = new CustomMessageBox("Success", $"Firewall rules succesfully created!\nGamePort (UDP: {gamePortNumber}) and QueryPort (TCP: {queryPortNumber})");
                    cmb.ShowDialog();
                }
                catch (Exception)
                {
                    CustomMessageBox cmb = new CustomMessageBox("Error appeared", "An error occured, please check your firewall rules manually.");
                    cmb.ShowDialog();
                }
            } 
        }

        public void RunCommand(List<string> commands)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();

            // Pass the command to cmd.exe
            foreach(var command in commands)
            {
                process.StandardInput.WriteLine(command);
            }
            
            process.StandardInput.Flush();
            process.StandardInput.Close();

            // Wait for the command to complete
            process.WaitForExit();

            // Output any command results
            string result = process.StandardOutput.ReadToEnd();
        }
    }
}

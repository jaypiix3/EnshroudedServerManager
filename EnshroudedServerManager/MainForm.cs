using EnshroudedServerManager.Models;
using EnshroudedServerManager.Services;
using System.ComponentModel;
using System.Diagnostics;
using System.Management;

namespace EnshroudedServerManager
{
    public partial class MainForm : Form
    {
        private PaintService _paintService;
        private SettingsService _settingsService;

        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        private string _test = @".\serverfiles\ShooterGame\Binaries\Win64\ArkAscendedServer.exe";
        private string _pathServerExe = @"./serverfiles/steamapps/common/EnshroudedServer/enshrouded_server.exe";
        private string _pathServerConfig = @"./serverfiles/steamapps/common/EnshroudedServer/enshrouded_server.json";
        private string _pathSourceConfig = @"settings.json";

        private bool  _restarted= false;

        private Process? _procServer;
        private bool _procRunning = false;

        private Settings? _settings;

        public MainForm()
        {
            InitializeComponent();

            //Initialize Services
            _paintService = new PaintService();
            _settingsService = new SettingsService();

            this.bwHealthCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(bwHealthCheck_DoWork);

            try
            {
                ManagementEventWatcher stopWatch = new ManagementEventWatcher(new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
                stopWatch.EventArrived += new EventArrivedEventHandler(stopWatch_EventArrived);
                stopWatch.Start();
            }
            catch (Exception)
            {
                CustomMessageBox cmb = new CustomMessageBox("Administrator rights needed", "Please start the application as administrator.");
                cmb.ShowDialog();
                this.Close();
            }
        }

        public void LoadSettings()
        {
            if (File.Exists(_pathSourceConfig))
            {
                _settings = _settingsService.LoadSettings(_pathSourceConfig);

                if (_settings != null)
                {
                    if (_settings.Name.Length > 23)
                    {
                        lServerName.Text = _settings.Name.Substring(0, 23) + "...";
                    }
                    else
                    {
                        lServerName.Text = _settings.Name;
                    }
                    
                    lGamePort.Text = _settings.GamePort.ToString();
                    lQueryPort.Text = _settings.QueryPort.ToString();
                }
            }
        }

        #region Process_Information

        private void bwHealthCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_procRunning)
            {
                if (_procServer != null)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(UpdateProcessInformationOnUI));
                    }
                    else
                    {
                        UpdateProcessInformationOnUI();
                    }
                }

                Thread.Sleep(2000);
            }
        }

        private void UpdateProcessInformationOnUI()
        {
            if (_procServer != null && !_procServer.HasExited)
            {
                _procServer?.Refresh();
                lProcessId.Text = @$"[{(_procServer?.Id)}] {_procServer?.ProcessName}";

                var ramAllocation = _procServer?.WorkingSet64;
                var allocationInMB = ramAllocation / (1024 * 1024);
                lProcessMemory.Text = (allocationInMB).ToString();
            }

        }

        #endregion

        #region Form_Events...

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (_procServer != null)
            {
                _procServer.Kill();
            }
        }

        #endregion

        #region Click_Events...

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                if (_procServer == null)
                {
                    try
                    {
                        if (File.Exists(_pathServerConfig))
                        {
                            File.Delete(_pathServerConfig);
                        }

                        File.Copy(_pathSourceConfig, _pathServerConfig);
                    }
                    catch
                    {
                        CustomMessageBox cmb = new CustomMessageBox("Error while starting", "Server settings couln't be replace in the server \nfolder. Please check if something blocks the file.");
                        cmb.ShowDialog();
                        return;
                    }

                    btnStartStop.Text = "Stop";
                    lStatus.Text = "Online";
                    lStatus.ForeColor = Color.LimeGreen;

                    _procServer = Process.Start(_test);
                    _procRunning = true;

                    if (!bwHealthCheck.IsBusy)
                        bwHealthCheck.RunWorkerAsync();

                    bwHealthCheck.WorkerSupportsCancellation = true;
                }
                else
                {
                    CustomMessageBox cmb = new CustomMessageBox("Already running", "The server is already running!");
                    cmb.Show();
                }
            }
            else
            {
                btnStartStop.Text = "Start";
                lStatus.Text = "Offline";
                lStatus.ForeColor = Color.Red;

                lProcessId.Text = "/";
                lProcessMemory.Text = "0";

                _procServer?.Kill();
                _procServer = null;
                _procRunning = false;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.ShowDialog();

            LoadSettings();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Event_Trace...

        /// <summary>
        /// Event should recognize when server application gets closed by something else than the manager and reset via methodinvoker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void stopWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            try
            {
                if (_procServer != null && (UInt32)e.NewEvent.Properties["ProcessID"].Value == _procServer.Id)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new MethodInvoker(SwitchUIToOfflineOrRestart));
                    }
                    else
                    {
                        SwitchUIToOfflineOrRestart();
                    }
                }
            }
            catch (Exception)
            {
                CustomMessageBox cmb = new CustomMessageBox("Critical Error", "Tool invalid UI Status - Couln't track process events. \n Please start this applicatio as Administrator.");
                cmb.ShowDialog();
                this.Close();
            }

        }

        public void SwitchUIToOfflineOrRestart()
        {
            if (cbAutoRestart.Checked && !_restarted)
            {
                _procServer = Process.Start(_test);
                _procRunning = true;

                _restarted = true;
            }
            else
            {
                btnStartStop.Text = "Start";
                lStatus.Text = "Offline";
                lStatus.ForeColor = Color.Red;

                lProcessId.Text = "/";
                lProcessMemory.Text = "0";

                _procServer = null;
            }
        }

        public void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            Console.WriteLine("Process started: {0}", e.NewEvent.Properties["ProcessName"].Value);
        }


        #endregion

        #region Custom_Paint...

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            _paintService.CustomBackgroundPainter(
            this,
            e,
            linethickness: 1,
            linecolor: Color.FromArgb(52, 52, 52),
            offsetborder: 1
            ); ;
        }

        #endregion

        #region Form_Drag...

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        #endregion
    }
}
using EnshroudedServerManager.Services;

namespace EnshroudedServerManager
{
    public partial class MainForm : Form
    {
        private SteamCmdService _steamCmdService;

        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        public MainForm()
        {
            InitializeComponent();

            //Initialize Services
            _steamCmdService = new SteamCmdService();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.White, this.Bounds);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Starten")
            {
                btnStartStop.Text = "Stop";
                lStatus.Text = "Online";
                lStatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                btnStartStop.Text = "Starten";
                lStatus.Text = "Offline";
                lStatus.ForeColor = Color.Red;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.ShowDialog();
        }

        
    }
}
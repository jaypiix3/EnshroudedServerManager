using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnshroudedServerManager
{
    public partial class SettingsForm : Form
    {
        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        public SettingsForm()
        {
            InitializeComponent();
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

        private void btnSetupServer_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {

        }
    }
}

using EnshroudedServerManager.Services;
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
    public partial class CustomMessageBox : Form
    {
        private PaintService _paintService;

        private bool _dragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;

        public CustomMessageBox(string title, string message)
        {
            InitializeComponent();

            _paintService = new PaintService();

            lTitle.Text = title;
            lMessage.Text = message;
        }

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void CustomMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
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
            ); ;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

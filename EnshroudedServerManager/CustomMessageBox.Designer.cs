namespace EnshroudedServerManager
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            lTitle = new Label();
            lMessage = new Label();
            btnStartStop = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(38, 38, 38);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.DarkGray;
            btnClose.Location = new Point(326, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lTitle
            // 
            lTitle.AutoSize = true;
            lTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lTitle.ForeColor = SystemColors.GradientInactiveCaption;
            lTitle.Location = new Point(12, 12);
            lTitle.Name = "lTitle";
            lTitle.Size = new Size(39, 21);
            lTitle.TabIndex = 3;
            lTitle.Text = "Titel";
            // 
            // lMessage
            // 
            lMessage.AutoSize = true;
            lMessage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lMessage.ForeColor = SystemColors.ButtonFace;
            lMessage.Location = new Point(12, 52);
            lMessage.Name = "lMessage";
            lMessage.Size = new Size(68, 17);
            lMessage.TabIndex = 10;
            lMessage.Text = "Nachricht";
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartStop.BackColor = Color.FromArgb(38, 38, 38);
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartStop.ForeColor = Color.DarkGray;
            btnStartStop.Location = new Point(133, 95);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(97, 30);
            btnStartStop.TabIndex = 11;
            btnStartStop.Text = "OK";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(363, 138);
            Controls.Add(btnStartStop);
            Controls.Add(lMessage);
            Controls.Add(lTitle);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            Text = "MessageBox";
            MouseDown += CustomMessageBox_MouseDown;
            MouseMove += CustomMessageBox_MouseMove;
            MouseUp += CustomMessageBox_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label lTitle;
        private Label lMessage;
        private Button btnStartStop;
    }
}
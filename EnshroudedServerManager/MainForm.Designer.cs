namespace EnshroudedServerManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            btnMinimize = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnStartStop = new Button();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            lStatus = new Label();
            btnSettings = new Button();
            bwHealthCheck = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            label4 = new Label();
            lProcessMemory = new Label();
            button1 = new Button();
            label13 = new Label();
            lProcessId = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(38, 38, 38);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.DarkGray;
            btnClose.Location = new Point(816, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(38, 38, 38);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.DarkGray;
            btnMinimize.Location = new Point(785, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientInactiveCaption;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 2;
            label1.Text = "Enshrouded Server Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(79, 35);
            label2.Name = "label2";
            label2.Size = new Size(171, 17);
            label2.TabIndex = 4;
            label2.Text = "Burning-Fury Enshrouded";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(541, 35);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 5;
            label3.Text = "Status:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStartStop);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(25, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 81);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serverinformation";
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartStop.BackColor = Color.FromArgb(38, 38, 38);
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartStop.ForeColor = Color.DarkGray;
            btnStartStop.Location = new Point(687, 28);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(97, 30);
            btnStartStop.TabIndex = 9;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = false;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(401, 35);
            label8.Name = "label8";
            label8.Size = new Size(76, 17);
            label8.TabIndex = 11;
            label8.Text = "Queryport:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(481, 35);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 10;
            label9.Text = "16237";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(262, 35);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 9;
            label6.Text = "Gameport:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(341, 35);
            label7.Name = "label7";
            label7.Size = new Size(48, 17);
            label7.TabIndex = 8;
            label7.Text = "16236";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(26, 35);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 7;
            label5.Text = "Name:";
            // 
            // lStatus
            // 
            lStatus.AutoSize = true;
            lStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lStatus.ForeColor = Color.Red;
            lStatus.Location = new Point(597, 35);
            lStatus.Name = "lStatus";
            lStatus.Size = new Size(49, 17);
            lStatus.TabIndex = 6;
            lStatus.Text = "Offline";
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.BackColor = Color.FromArgb(38, 38, 38);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.DarkGray;
            btnSettings.Location = new Point(754, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(25, 25);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "⛭";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lProcessMemory);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lProcessId);
            groupBox2.ForeColor = Color.LightGray;
            groupBox2.Location = new Point(25, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(447, 108);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Serverinformation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(26, 68);
            label4.Name = "label4";
            label4.Size = new Size(161, 17);
            label4.TabIndex = 11;
            label4.Text = "Physical memory usage:";
            // 
            // lProcessMemory
            // 
            lProcessMemory.AutoSize = true;
            lProcessMemory.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lProcessMemory.ForeColor = SystemColors.ControlDark;
            lProcessMemory.Location = new Point(224, 68);
            lProcessMemory.Name = "lProcessMemory";
            lProcessMemory.Size = new Size(16, 17);
            lProcessMemory.TabIndex = 10;
            lProcessMemory.Text = "0";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(38, 38, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkGray;
            button1.Location = new Point(934, 28);
            button1.Name = "button1";
            button1.Size = new Size(97, 30);
            button1.TabIndex = 9;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(26, 35);
            label13.Name = "label13";
            label13.Size = new Size(63, 17);
            label13.TabIndex = 7;
            label13.Text = "Process:";
            // 
            // lProcessId
            // 
            lProcessId.AutoSize = true;
            lProcessId.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lProcessId.ForeColor = SystemColors.ControlDark;
            lProcessId.Location = new Point(224, 35);
            lProcessId.Name = "lProcessId";
            lProcessId.Size = new Size(16, 17);
            lProcessId.TabIndex = 4;
            lProcessId.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(853, 590);
            Controls.Add(groupBox2);
            Controls.Add(btnSettings);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnMinimize;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label lStatus;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Button btnSettings;
        private Button btnStartStop;
        private System.ComponentModel.BackgroundWorker bwHealthCheck;
        private GroupBox groupBox2;
        private Button button1;
        private Label label13;
        private Label lProcessId;
        private Label label4;
        private Label lProcessMemory;
    }
}
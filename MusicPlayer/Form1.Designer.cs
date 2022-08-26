namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLego = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListMusic = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblLego);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 56);
            this.panel1.TabIndex = 0;
            // 
            // lblLego
            // 
            this.lblLego.AutoSize = true;
            this.lblLego.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLego.Location = new System.Drawing.Point(42, 24);
            this.lblLego.Name = "lblLego";
            this.lblLego.Size = new System.Drawing.Size(137, 26);
            this.lblLego.TabIndex = 0;
            this.lblLego.Tag = "";
            this.lblLego.Text = "Music Player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(664, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListMusic
            // 
            this.ListMusic.BackColor = System.Drawing.Color.Lavender;
            this.ListMusic.FormattingEnabled = true;
            this.ListMusic.ItemHeight = 16;
            this.ListMusic.Location = new System.Drawing.Point(497, 83);
            this.ListMusic.Name = "ListMusic";
            this.ListMusic.Size = new System.Drawing.Size(204, 340);
            this.ListMusic.TabIndex = 1;
            this.ListMusic.SelectedIndexChanged += new System.EventHandler(this.ListMusic_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSelect.Location = new System.Drawing.Point(497, 429);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(204, 57);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl.Location = new System.Drawing.Point(569, 497);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(132, 16);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Developed by: Ermiti";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(331, 451);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(713, 665);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.ListMusic);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLego;
        private System.Windows.Forms.ListBox ListMusic;
        private System.Windows.Forms.Button btnSelect;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lbl;
    }
}


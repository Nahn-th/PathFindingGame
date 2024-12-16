namespace GameMovement
{
    partial class frmPause
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
            this.btnResume = new System.Windows.Forms.PictureBox();
            this.btnReplay = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResume
            // 
            this.btnResume.Image = global::GameMovement.Properties.Resources.Default_4x4;
            this.btnResume.Location = new System.Drawing.Point(93, 142);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(176, 68);
            this.btnResume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResume.TabIndex = 6;
            this.btnResume.TabStop = false;
            this.btnResume.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnReplay
            // 
            this.btnReplay.Image = global::GameMovement.Properties.Resources.Default_4x2;
            this.btnReplay.Location = new System.Drawing.Point(191, 41);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(78, 84);
            this.btnReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReplay.TabIndex = 5;
            this.btnReplay.TabStop = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GameMovement.Properties.Resources.Default_4x3;
            this.btnHome.Location = new System.Drawing.Point(93, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(78, 84);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 4;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(362, 250);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPause";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPause";
            ((System.ComponentModel.ISupportInitialize)(this.btnResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnResume;
        private System.Windows.Forms.PictureBox btnReplay;
        private System.Windows.Forms.PictureBox btnHome;
    }
}
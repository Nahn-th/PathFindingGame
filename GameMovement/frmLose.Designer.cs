namespace GameMovement
{
    partial class frmLose
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnReplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.pictureBox1.Image = global::GameMovement.Properties.Resources.Thua;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GameMovement.Properties.Resources.Default_4x3;
            this.btnHome.Location = new System.Drawing.Point(71, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(82, 75);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Image = global::GameMovement.Properties.Resources.Default_4x2;
            this.btnReplay.Location = new System.Drawing.Point(223, 95);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(82, 75);
            this.btnReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReplay.TabIndex = 0;
            this.btnReplay.TabStop = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // frmLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(380, 190);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnReplay;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
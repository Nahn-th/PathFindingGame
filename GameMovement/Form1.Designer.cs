namespace GameMovement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCollected = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Interval = 20;
            this.movementTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lblCollected
            // 
            this.lblCollected.AutoSize = true;
            this.lblCollected.BackColor = System.Drawing.Color.Transparent;
            this.lblCollected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCollected.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollected.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCollected.Location = new System.Drawing.Point(0, 706);
            this.lblCollected.Name = "lblCollected";
            this.lblCollected.Size = new System.Drawing.Size(247, 48);
            this.lblCollected.TabIndex = 1;
            this.lblCollected.Text = "Collected:  00";
            this.lblCollected.Click += new System.EventHandler(this.lblCollected_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPause.Image = global::GameMovement.Properties.Resources.DefaultPause_4x;
            this.btnPause.Location = new System.Drawing.Point(0, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(936, 51);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 2;
            this.btnPause.TabStop = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 754);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblCollected);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lv1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label lblCollected;
        private System.Windows.Forms.PictureBox btnPause;
    }
}


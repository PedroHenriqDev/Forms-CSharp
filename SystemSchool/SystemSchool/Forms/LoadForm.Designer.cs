namespace SystemSchool.Forms
{
    partial class LoadForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LabelManagerSchool = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemSchool.Properties.Resources.icons8_school_80;
            this.pictureBox1.Location = new System.Drawing.Point(286, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Cyan;
            this.progressBar.Location = new System.Drawing.Point(98, 322);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(605, 32);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LabelManagerSchool
            // 
            this.LabelManagerSchool.AutoSize = true;
            this.LabelManagerSchool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelManagerSchool.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelManagerSchool.ForeColor = System.Drawing.Color.LightBlue;
            this.LabelManagerSchool.Location = new System.Drawing.Point(300, 259);
            this.LabelManagerSchool.Name = "LabelManagerSchool";
            this.LabelManagerSchool.Size = new System.Drawing.Size(201, 32);
            this.LabelManagerSchool.TabIndex = 2;
            this.LabelManagerSchool.Text = "Manager School";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelVersion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelVersion.Location = new System.Drawing.Point(333, 379);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(95, 21);
            this.LabelVersion.TabIndex = 3;
            this.LabelVersion.Text = "Version 1.0";
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.LabelManagerSchool);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LabelManagerSchool;
        private System.Windows.Forms.Label LabelVersion;
    }
}
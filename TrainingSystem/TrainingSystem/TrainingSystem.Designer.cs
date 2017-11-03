namespace TrainingSystem
{
    partial class TrainingSystem
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnOffline = new System.Windows.Forms.Button();
            this.panelLearn = new System.Windows.Forms.Panel();
            this.btnLearn = new System.Windows.Forms.Button();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.picAfter = new System.Windows.Forms.PictureBox();
            this.picBefore = new System.Windows.Forms.PictureBox();
            this.lblOffline = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLearn.SuspendLayout();
            this.panelOnline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnOnline);
            this.panelMenu.Controls.Add(this.btnOffline);
            this.panelMenu.Location = new System.Drawing.Point(1, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(730, 52);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(370, 3);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(350, 46);
            this.btnOnline.TabIndex = 1;
            this.btnOnline.Text = "Online";
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.Click += new System.EventHandler(this.btnOnline_Click);
            // 
            // btnOffline
            // 
            this.btnOffline.Location = new System.Drawing.Point(11, 3);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(350, 46);
            this.btnOffline.TabIndex = 0;
            this.btnOffline.Text = "Offline";
            this.btnOffline.UseVisualStyleBackColor = true;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // panelLearn
            // 
            this.panelLearn.Controls.Add(this.btnLearn);
            this.panelLearn.Location = new System.Drawing.Point(1, 372);
            this.panelLearn.Name = "panelLearn";
            this.panelLearn.Size = new System.Drawing.Size(730, 52);
            this.panelLearn.TabIndex = 1;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(190, 3);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(350, 46);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // panelOnline
            // 
            this.panelOnline.Controls.Add(this.picAfter);
            this.panelOnline.Controls.Add(this.picBefore);
            this.panelOnline.Controls.Add(this.lblOffline);
            this.panelOnline.Controls.Add(this.lblOnline);
            this.panelOnline.Location = new System.Drawing.Point(1, 59);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Size = new System.Drawing.Size(730, 307);
            this.panelOnline.TabIndex = 3;
            // 
            // picAfter
            // 
            this.picAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAfter.Location = new System.Drawing.Point(373, 34);
            this.picAfter.Name = "picAfter";
            this.picAfter.Size = new System.Drawing.Size(347, 270);
            this.picAfter.TabIndex = 3;
            this.picAfter.TabStop = false;
            // 
            // picBefore
            // 
            this.picBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBefore.Location = new System.Drawing.Point(14, 34);
            this.picBefore.Name = "picBefore";
            this.picBefore.Size = new System.Drawing.Size(347, 270);
            this.picBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBefore.TabIndex = 2;
            this.picBefore.TabStop = false;
            this.picBefore.Click += new System.EventHandler(this.picBefore_Click);
            this.picBefore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBefore_MouseDown);
            this.picBefore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBefore_MouseMove);
            this.picBefore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBefore_MouseUp);
            // 
            // lblOffline
            // 
            this.lblOffline.AutoSize = true;
            this.lblOffline.Location = new System.Drawing.Point(11, 18);
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(37, 13);
            this.lblOffline.TabIndex = 0;
            this.lblOffline.Text = "Offline";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(11, 18);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(37, 13);
            this.lblOnline.TabIndex = 1;
            this.lblOnline.Text = "Online";
            this.lblOnline.Visible = false;
            // 
            // TrainingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 425);
            this.Controls.Add(this.panelOnline);
            this.Controls.Add(this.panelLearn);
            this.Controls.Add(this.panelMenu);
            this.Name = "TrainingSystem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training System";
            this.panelMenu.ResumeLayout(false);
            this.panelLearn.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panelOnline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBefore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnOffline;
        private System.Windows.Forms.Panel panelLearn;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Label lblOffline;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.PictureBox picAfter;
        private System.Windows.Forms.PictureBox picBefore;
    }
}


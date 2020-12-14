namespace Russianbullet
{
    partial class Russian_Bullet
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.FireBtn = new System.Windows.Forms.Button();
            this.ShAwayBtn = new System.Windows.Forms.Button();
            this.PicBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadBtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadBtn.Location = new System.Drawing.Point(830, 47);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(170, 89);
            this.LoadBtn.TabIndex = 2;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpinBtn.Enabled = false;
            this.SpinBtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpinBtn.Location = new System.Drawing.Point(830, 168);
            this.SpinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(170, 89);
            this.SpinBtn.TabIndex = 3;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = false;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // FireBtn
            // 
            this.FireBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FireBtn.Enabled = false;
            this.FireBtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FireBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FireBtn.Location = new System.Drawing.Point(830, 293);
            this.FireBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FireBtn.Name = "FireBtn";
            this.FireBtn.Size = new System.Drawing.Size(170, 89);
            this.FireBtn.TabIndex = 5;
            this.FireBtn.Text = "Fire";
            this.FireBtn.UseVisualStyleBackColor = false;
            this.FireBtn.Click += new System.EventHandler(this.FireBtn_Click);
            // 
            // ShAwayBtn
            // 
            this.ShAwayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShAwayBtn.Enabled = false;
            this.ShAwayBtn.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShAwayBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShAwayBtn.Location = new System.Drawing.Point(830, 423);
            this.ShAwayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ShAwayBtn.Name = "ShAwayBtn";
            this.ShAwayBtn.Size = new System.Drawing.Size(170, 89);
            this.ShAwayBtn.TabIndex = 11;
            this.ShAwayBtn.Text = "Fire Away";
            this.ShAwayBtn.UseVisualStyleBackColor = false;
            this.ShAwayBtn.Click += new System.EventHandler(this.ShAwayBtn_Click);
            // 
            // PicBox1
            // 
            this.PicBox1.BackgroundImage = global::Russianbullet.Resource1.bg_pic;
            this.PicBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox1.Location = new System.Drawing.Point(23, 29);
            this.PicBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PicBox1.Name = "PicBox1";
            this.PicBox1.Size = new System.Drawing.Size(751, 483);
            this.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox1.TabIndex = 6;
            this.PicBox1.TabStop = false;
            // 
            // Russian_Bullet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ShAwayBtn);
            this.Controls.Add(this.FireBtn);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.PicBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Russian_Bullet";
            this.Text = "Game War";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Button FireBtn;
        private System.Windows.Forms.PictureBox PicBox1;
        private System.Windows.Forms.Button ShAwayBtn;
    }
}


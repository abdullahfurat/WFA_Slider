namespace WFA_Slider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnStartStop = new MetroFramework.Controls.MetroTile();
            this.btnLast = new MetroFramework.Controls.MetroTile();
            this.btnFirst = new MetroFramework.Controls.MetroTile();
            this.btnBack = new MetroFramework.Controls.MetroTile();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "r1.jpg");
            this.imageList.Images.SetKeyName(1, "r2.jpg");
            this.imageList.Images.SetKeyName(2, "r3.jpg");
            this.imageList.Images.SetKeyName(3, "r4.png");
            this.imageList.Images.SetKeyName(4, "r5.png");
            this.imageList.Images.SetKeyName(5, "r6.jpg");
            this.imageList.Images.SetKeyName(6, "r7.jpg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.Location = new System.Drawing.Point(311, 587);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar.Maximum = 1000;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(568, 28);
            this.trackBar.TabIndex = 9;
            this.trackBar.Text = "metroTrackBar1";
            this.trackBar.Value = 100;
            this.trackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNext.Location = new System.Drawing.Point(887, 503);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(132, 112);
            this.btnNext.TabIndex = 4;
            this.btnNext.TileImage = global::WFA_Slider.Properties.Resources.icon_next;
            this.btnNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.UseTileImage = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.ActiveControl = null;
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStartStop.Location = new System.Drawing.Point(311, 503);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(568, 76);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.TileImage = global::WFA_Slider.Properties.Resources.icon_start;
            this.btnStartStop.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartStop.UseCustomBackColor = true;
            this.btnStartStop.UseSelectable = true;
            this.btnStartStop.UseTileImage = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnLast
            // 
            this.btnLast.ActiveControl = null;
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLast.Location = new System.Drawing.Point(1027, 503);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(132, 112);
            this.btnLast.TabIndex = 6;
            this.btnLast.TileImage = global::WFA_Slider.Properties.Resources.icon_right;
            this.btnLast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLast.UseCustomBackColor = true;
            this.btnLast.UseSelectable = true;
            this.btnLast.UseTileImage = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.ActiveControl = null;
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnFirst.Location = new System.Drawing.Point(31, 503);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(132, 112);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.TileImage = global::WFA_Slider.Properties.Resources.icon_left;
            this.btnFirst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFirst.UseCustomBackColor = true;
            this.btnFirst.UseSelectable = true;
            this.btnFirst.UseTileImage = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveControl = null;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBack.Location = new System.Drawing.Point(171, 503);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 112);
            this.btnBack.TabIndex = 8;
            this.btnBack.TileImage = global::WFA_Slider.Properties.Resources.icon_back;
            this.btnBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseTileImage = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pcbImage.Location = new System.Drawing.Point(31, 78);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(1128, 418);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 3;
            this.pcbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 639);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.trackBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Slider";
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnNext;
        private MetroFramework.Controls.MetroTile btnStartStop;
        private MetroFramework.Controls.MetroTile btnLast;
        private MetroFramework.Controls.MetroTile btnFirst;
        private MetroFramework.Controls.MetroTile btnBack;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTrackBar trackBar;
    }
}


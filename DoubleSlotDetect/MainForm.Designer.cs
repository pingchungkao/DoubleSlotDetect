namespace DoubleSlotDetect
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CCD1DisplayimageBox = new Emgu.CV.UI.ImageBox();
            this.CCD2DisplayimageBox = new Emgu.CV.UI.ImageBox();
            this.ShowCCD1label = new System.Windows.Forms.Label();
            this.ShowCCD2label = new System.Windows.Forms.Label();
            this.CCD1Livebutton = new System.Windows.Forms.Button();
            this.CCD2Livebutton = new System.Windows.Forms.Button();
            this.CCD1Grabbutton = new System.Windows.Forms.Button();
            this.CCD2Grabbutton = new System.Windows.Forms.Button();
            this.CCD1SetupButton = new System.Windows.Forms.Button();
            this.CCD2SetupButton = new System.Windows.Forms.Button();
            this.CCD1SaveButton = new System.Windows.Forms.Button();
            this.CCD2SaveButton = new System.Windows.Forms.Button();
            this.CCD1LoadButton = new System.Windows.Forms.Button();
            this.CCD2LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CCD1DisplayimageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCD2DisplayimageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CCD1DisplayimageBox
            // 
            this.CCD1DisplayimageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CCD1DisplayimageBox.Location = new System.Drawing.Point(12, 37);
            this.CCD1DisplayimageBox.Name = "CCD1DisplayimageBox";
            this.CCD1DisplayimageBox.Size = new System.Drawing.Size(640, 480);
            this.CCD1DisplayimageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CCD1DisplayimageBox.TabIndex = 2;
            this.CCD1DisplayimageBox.TabStop = false;
            // 
            // CCD2DisplayimageBox
            // 
            this.CCD2DisplayimageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CCD2DisplayimageBox.Location = new System.Drawing.Point(682, 37);
            this.CCD2DisplayimageBox.Name = "CCD2DisplayimageBox";
            this.CCD2DisplayimageBox.Size = new System.Drawing.Size(640, 480);
            this.CCD2DisplayimageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CCD2DisplayimageBox.TabIndex = 3;
            this.CCD2DisplayimageBox.TabStop = false;
            // 
            // ShowCCD1label
            // 
            this.ShowCCD1label.AutoSize = true;
            this.ShowCCD1label.BackColor = System.Drawing.Color.White;
            this.ShowCCD1label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowCCD1label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowCCD1label.Location = new System.Drawing.Point(12, 9);
            this.ShowCCD1label.Name = "ShowCCD1label";
            this.ShowCCD1label.Size = new System.Drawing.Size(83, 22);
            this.ShowCCD1label.TabIndex = 4;
            this.ShowCCD1label.Text = "Camera 1";
            // 
            // ShowCCD2label
            // 
            this.ShowCCD2label.AutoSize = true;
            this.ShowCCD2label.BackColor = System.Drawing.Color.White;
            this.ShowCCD2label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowCCD2label.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowCCD2label.Location = new System.Drawing.Point(682, 9);
            this.ShowCCD2label.Name = "ShowCCD2label";
            this.ShowCCD2label.Size = new System.Drawing.Size(83, 22);
            this.ShowCCD2label.TabIndex = 5;
            this.ShowCCD2label.Text = "Camera 2";
            // 
            // CCD1Livebutton
            // 
            this.CCD1Livebutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD1Livebutton.Location = new System.Drawing.Point(12, 523);
            this.CCD1Livebutton.Name = "CCD1Livebutton";
            this.CCD1Livebutton.Size = new System.Drawing.Size(83, 31);
            this.CCD1Livebutton.TabIndex = 6;
            this.CCD1Livebutton.Text = "Live";
            this.CCD1Livebutton.UseVisualStyleBackColor = true;
            this.CCD1Livebutton.Click += new System.EventHandler(this.CCD1Livebutton_Click);
            // 
            // CCD2Livebutton
            // 
            this.CCD2Livebutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD2Livebutton.Location = new System.Drawing.Point(682, 523);
            this.CCD2Livebutton.Name = "CCD2Livebutton";
            this.CCD2Livebutton.Size = new System.Drawing.Size(83, 31);
            this.CCD2Livebutton.TabIndex = 7;
            this.CCD2Livebutton.Text = "Live";
            this.CCD2Livebutton.UseVisualStyleBackColor = true;
            this.CCD2Livebutton.Click += new System.EventHandler(this.CCD1Livebutton_Click);
            // 
            // CCD1Grabbutton
            // 
            this.CCD1Grabbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD1Grabbutton.Location = new System.Drawing.Point(12, 560);
            this.CCD1Grabbutton.Name = "CCD1Grabbutton";
            this.CCD1Grabbutton.Size = new System.Drawing.Size(83, 31);
            this.CCD1Grabbutton.TabIndex = 8;
            this.CCD1Grabbutton.Text = "Grab";
            this.CCD1Grabbutton.UseVisualStyleBackColor = true;
            this.CCD1Grabbutton.Click += new System.EventHandler(this.CCD1Grabbutton_Click);
            // 
            // CCD2Grabbutton
            // 
            this.CCD2Grabbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD2Grabbutton.Location = new System.Drawing.Point(682, 560);
            this.CCD2Grabbutton.Name = "CCD2Grabbutton";
            this.CCD2Grabbutton.Size = new System.Drawing.Size(83, 31);
            this.CCD2Grabbutton.TabIndex = 9;
            this.CCD2Grabbutton.Text = "Grab";
            this.CCD2Grabbutton.UseVisualStyleBackColor = true;
            this.CCD2Grabbutton.Click += new System.EventHandler(this.CCD1Grabbutton_Click);
            // 
            // CCD1SetupButton
            // 
            this.CCD1SetupButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD1SetupButton.Location = new System.Drawing.Point(538, 523);
            this.CCD1SetupButton.Name = "CCD1SetupButton";
            this.CCD1SetupButton.Size = new System.Drawing.Size(114, 68);
            this.CCD1SetupButton.TabIndex = 10;
            this.CCD1SetupButton.Text = "Setup";
            this.CCD1SetupButton.UseVisualStyleBackColor = true;
            this.CCD1SetupButton.Click += new System.EventHandler(this.CCD1SetupButton_Click);
            // 
            // CCD2SetupButton
            // 
            this.CCD2SetupButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD2SetupButton.Location = new System.Drawing.Point(1208, 528);
            this.CCD2SetupButton.Name = "CCD2SetupButton";
            this.CCD2SetupButton.Size = new System.Drawing.Size(114, 68);
            this.CCD2SetupButton.TabIndex = 11;
            this.CCD2SetupButton.Text = "Setup";
            this.CCD2SetupButton.UseVisualStyleBackColor = true;
            this.CCD2SetupButton.Click += new System.EventHandler(this.CCD1SetupButton_Click);
            // 
            // CCD1SaveButton
            // 
            this.CCD1SaveButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD1SaveButton.Location = new System.Drawing.Point(101, 523);
            this.CCD1SaveButton.Name = "CCD1SaveButton";
            this.CCD1SaveButton.Size = new System.Drawing.Size(96, 31);
            this.CCD1SaveButton.TabIndex = 12;
            this.CCD1SaveButton.Text = "Save Image";
            this.CCD1SaveButton.UseVisualStyleBackColor = true;
            this.CCD1SaveButton.Click += new System.EventHandler(this.CCD1Savebutton_Click);
            // 
            // CCD2SaveButton
            // 
            this.CCD2SaveButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD2SaveButton.Location = new System.Drawing.Point(771, 523);
            this.CCD2SaveButton.Name = "CCD2SaveButton";
            this.CCD2SaveButton.Size = new System.Drawing.Size(96, 31);
            this.CCD2SaveButton.TabIndex = 13;
            this.CCD2SaveButton.Text = "Save Image";
            this.CCD2SaveButton.UseVisualStyleBackColor = true;
            this.CCD2SaveButton.Click += new System.EventHandler(this.CCD1Savebutton_Click);
            // 
            // CCD1LoadButton
            // 
            this.CCD1LoadButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD1LoadButton.Location = new System.Drawing.Point(101, 560);
            this.CCD1LoadButton.Name = "CCD1LoadButton";
            this.CCD1LoadButton.Size = new System.Drawing.Size(96, 31);
            this.CCD1LoadButton.TabIndex = 14;
            this.CCD1LoadButton.Text = "Load Image";
            this.CCD1LoadButton.UseVisualStyleBackColor = true;
            this.CCD1LoadButton.Click += new System.EventHandler(this.CCD1LoadButton_Click);
            // 
            // CCD2LoadButton
            // 
            this.CCD2LoadButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCD2LoadButton.Location = new System.Drawing.Point(771, 560);
            this.CCD2LoadButton.Name = "CCD2LoadButton";
            this.CCD2LoadButton.Size = new System.Drawing.Size(96, 31);
            this.CCD2LoadButton.TabIndex = 15;
            this.CCD2LoadButton.Text = "Load Image";
            this.CCD2LoadButton.UseVisualStyleBackColor = true;
            this.CCD2LoadButton.Click += new System.EventHandler(this.CCD1LoadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 814);
            this.Controls.Add(this.CCD2LoadButton);
            this.Controls.Add(this.CCD1LoadButton);
            this.Controls.Add(this.CCD2SaveButton);
            this.Controls.Add(this.CCD1SaveButton);
            this.Controls.Add(this.CCD2SetupButton);
            this.Controls.Add(this.CCD1SetupButton);
            this.Controls.Add(this.CCD2Grabbutton);
            this.Controls.Add(this.CCD1Grabbutton);
            this.Controls.Add(this.CCD2Livebutton);
            this.Controls.Add(this.CCD1Livebutton);
            this.Controls.Add(this.ShowCCD2label);
            this.Controls.Add(this.ShowCCD1label);
            this.Controls.Add(this.CCD2DisplayimageBox);
            this.Controls.Add(this.CCD1DisplayimageBox);
            this.Name = "MainForm";
            this.Text = "疊片檢查";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CCD1DisplayimageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCD2DisplayimageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox CCD1DisplayimageBox;
        private Emgu.CV.UI.ImageBox CCD2DisplayimageBox;
        private System.Windows.Forms.Label ShowCCD1label;
        private System.Windows.Forms.Label ShowCCD2label;
        private System.Windows.Forms.Button CCD1Livebutton;
        private System.Windows.Forms.Button CCD2Livebutton;
        private System.Windows.Forms.Button CCD1Grabbutton;
        private System.Windows.Forms.Button CCD2Grabbutton;
        private System.Windows.Forms.Button CCD1SetupButton;
        private System.Windows.Forms.Button CCD2SetupButton;
        private System.Windows.Forms.Button CCD1SaveButton;
        private System.Windows.Forms.Button CCD2SaveButton;
        private System.Windows.Forms.Button CCD1LoadButton;
        private System.Windows.Forms.Button CCD2LoadButton;
    }
}


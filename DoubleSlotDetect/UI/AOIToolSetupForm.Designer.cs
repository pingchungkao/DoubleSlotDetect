namespace DoubleSlotDetect
{
    partial class AOIToolSetupForm
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
            this.DisplayImageBox = new Emgu.CV.UI.ImageBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PositionStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectROIButton = new System.Windows.Forms.Button();
            this.FilterImageBox = new Emgu.CV.UI.ImageBox();
            this.ShowGrayButton = new System.Windows.Forms.Button();
            this.GrayFilterComboBox = new System.Windows.Forms.ComboBox();
            this.pnSetup = new System.Windows.Forms.Panel();
            this.ThresholdLowLabel = new System.Windows.Forms.Label();
            this.MorphologyGroupBox = new System.Windows.Forms.GroupBox();
            this.MorphExecTimeNumeric3 = new System.Windows.Forms.NumericUpDown();
            this.MorphExecTimeNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.MaskSizeNumeric3 = new System.Windows.Forms.NumericUpDown();
            this.MaskSizeNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.ElementShapeComboBox3 = new System.Windows.Forms.ComboBox();
            this.ElementShapeComboBox2 = new System.Windows.Forms.ComboBox();
            this.MorphOpComboBox3 = new System.Windows.Forms.ComboBox();
            this.MorphOpComboBox2 = new System.Windows.Forms.ComboBox();
            this.MaskSizeNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.MorphExecTimeNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.ElementShapeComboBox1 = new System.Windows.Forms.ComboBox();
            this.MorphOpComboBox1 = new System.Windows.Forms.ComboBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ThresholdHighLabel = new System.Windows.Forms.Label();
            this.ThresholdHighTrackBar = new System.Windows.Forms.TrackBar();
            this.ShowBinaryButton = new System.Windows.Forms.Button();
            this.ThresholdLowTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImageBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterImageBox)).BeginInit();
            this.pnSetup.SuspendLayout();
            this.MorphologyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdHighTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdLowTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayImageBox
            // 
            this.DisplayImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayImageBox.Location = new System.Drawing.Point(0, 0);
            this.DisplayImageBox.Name = "DisplayImageBox";
            this.DisplayImageBox.Size = new System.Drawing.Size(640, 480);
            this.DisplayImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisplayImageBox.TabIndex = 2;
            this.DisplayImageBox.TabStop = false;
            this.DisplayImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayImageBox_Paint);
            this.DisplayImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisplayImageBox_MouseDown);
            this.DisplayImageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DisplayImageBox_MouseMove);
            this.DisplayImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DisplayImageBox_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.PositionStripStatus,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 696);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            // 
            // PositionStripStatus
            // 
            this.PositionStripStatus.AutoSize = false;
            this.PositionStripStatus.Name = "PositionStripStatus";
            this.PositionStripStatus.Size = new System.Drawing.Size(200, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(200, 17);
            // 
            // SelectROIButton
            // 
            this.SelectROIButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectROIButton.Location = new System.Drawing.Point(12, 498);
            this.SelectROIButton.Name = "SelectROIButton";
            this.SelectROIButton.Size = new System.Drawing.Size(100, 49);
            this.SelectROIButton.TabIndex = 4;
            this.SelectROIButton.Text = "Select ROI";
            this.SelectROIButton.UseVisualStyleBackColor = true;
            this.SelectROIButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterImageBox
            // 
            this.FilterImageBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterImageBox.Location = new System.Drawing.Point(248, 193);
            this.FilterImageBox.Name = "FilterImageBox";
            this.FilterImageBox.Size = new System.Drawing.Size(274, 223);
            this.FilterImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilterImageBox.TabIndex = 2;
            this.FilterImageBox.TabStop = false;
            // 
            // ShowGrayButton
            // 
            this.ShowGrayButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowGrayButton.Location = new System.Drawing.Point(231, 11);
            this.ShowGrayButton.Name = "ShowGrayButton";
            this.ShowGrayButton.Size = new System.Drawing.Size(116, 43);
            this.ShowGrayButton.TabIndex = 5;
            this.ShowGrayButton.Text = "灰階";
            this.ShowGrayButton.UseVisualStyleBackColor = true;
            this.ShowGrayButton.Click += new System.EventHandler(this.ShowGrayButton_Click);
            // 
            // GrayFilterComboBox
            // 
            this.GrayFilterComboBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GrayFilterComboBox.FormattingEnabled = true;
            this.GrayFilterComboBox.Items.AddRange(new object[] {
            "Gray",
            "B",
            "G",
            "R"});
            this.GrayFilterComboBox.Location = new System.Drawing.Point(87, 19);
            this.GrayFilterComboBox.Name = "GrayFilterComboBox";
            this.GrayFilterComboBox.Size = new System.Drawing.Size(121, 28);
            this.GrayFilterComboBox.TabIndex = 6;
            this.GrayFilterComboBox.Text = "Gray";
            this.GrayFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.GrayFilterComboBox_SelectedIndexChanged);
            // 
            // pnSetup
            // 
            this.pnSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSetup.Controls.Add(this.ThresholdLowLabel);
            this.pnSetup.Controls.Add(this.MorphologyGroupBox);
            this.pnSetup.Controls.Add(this.TestButton);
            this.pnSetup.Controls.Add(this.ResultRichTextBox);
            this.pnSetup.Controls.Add(this.ThresholdHighLabel);
            this.pnSetup.Controls.Add(this.ThresholdHighTrackBar);
            this.pnSetup.Controls.Add(this.ShowBinaryButton);
            this.pnSetup.Controls.Add(this.ThresholdLowTrackBar);
            this.pnSetup.Controls.Add(this.GrayFilterComboBox);
            this.pnSetup.Controls.Add(this.ShowGrayButton);
            this.pnSetup.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnSetup.Location = new System.Drawing.Point(640, 0);
            this.pnSetup.Name = "pnSetup";
            this.pnSetup.Size = new System.Drawing.Size(360, 696);
            this.pnSetup.TabIndex = 7;
            // 
            // ThresholdLowLabel
            // 
            this.ThresholdLowLabel.BackColor = System.Drawing.Color.White;
            this.ThresholdLowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdLowLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThresholdLowLabel.Location = new System.Drawing.Point(185, 75);
            this.ThresholdLowLabel.Name = "ThresholdLowLabel";
            this.ThresholdLowLabel.Size = new System.Drawing.Size(40, 20);
            this.ThresholdLowLabel.TabIndex = 8;
            this.ThresholdLowLabel.Text = "0";
            // 
            // MorphologyGroupBox
            // 
            this.MorphologyGroupBox.Controls.Add(this.MorphExecTimeNumeric3);
            this.MorphologyGroupBox.Controls.Add(this.MorphExecTimeNumeric2);
            this.MorphologyGroupBox.Controls.Add(this.MaskSizeNumeric3);
            this.MorphologyGroupBox.Controls.Add(this.MaskSizeNumeric2);
            this.MorphologyGroupBox.Controls.Add(this.ElementShapeComboBox3);
            this.MorphologyGroupBox.Controls.Add(this.ElementShapeComboBox2);
            this.MorphologyGroupBox.Controls.Add(this.MorphOpComboBox3);
            this.MorphologyGroupBox.Controls.Add(this.MorphOpComboBox2);
            this.MorphologyGroupBox.Controls.Add(this.MaskSizeNumeric1);
            this.MorphologyGroupBox.Controls.Add(this.MorphExecTimeNumeric1);
            this.MorphologyGroupBox.Controls.Add(this.ElementShapeComboBox1);
            this.MorphologyGroupBox.Controls.Add(this.MorphOpComboBox1);
            this.MorphologyGroupBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MorphologyGroupBox.Location = new System.Drawing.Point(12, 162);
            this.MorphologyGroupBox.Name = "MorphologyGroupBox";
            this.MorphologyGroupBox.Size = new System.Drawing.Size(335, 250);
            this.MorphologyGroupBox.TabIndex = 14;
            this.MorphologyGroupBox.TabStop = false;
            this.MorphologyGroupBox.Text = "形態學";
            // 
            // MorphExecTimeNumeric3
            // 
            this.MorphExecTimeNumeric3.Location = new System.Drawing.Point(284, 127);
            this.MorphExecTimeNumeric3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MorphExecTimeNumeric3.Name = "MorphExecTimeNumeric3";
            this.MorphExecTimeNumeric3.Size = new System.Drawing.Size(45, 29);
            this.MorphExecTimeNumeric3.TabIndex = 2;
            this.MorphExecTimeNumeric3.ValueChanged += new System.EventHandler(this.MorphExecTimeNumeric1_ValueChanged);
            // 
            // MorphExecTimeNumeric2
            // 
            this.MorphExecTimeNumeric2.Location = new System.Drawing.Point(284, 94);
            this.MorphExecTimeNumeric2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MorphExecTimeNumeric2.Name = "MorphExecTimeNumeric2";
            this.MorphExecTimeNumeric2.Size = new System.Drawing.Size(45, 29);
            this.MorphExecTimeNumeric2.TabIndex = 1;
            this.MorphExecTimeNumeric2.ValueChanged += new System.EventHandler(this.MorphExecTimeNumeric1_ValueChanged);
            // 
            // MaskSizeNumeric3
            // 
            this.MaskSizeNumeric3.Location = new System.Drawing.Point(233, 128);
            this.MaskSizeNumeric3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaskSizeNumeric3.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric3.Name = "MaskSizeNumeric3";
            this.MaskSizeNumeric3.Size = new System.Drawing.Size(45, 29);
            this.MaskSizeNumeric3.TabIndex = 2;
            this.MaskSizeNumeric3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric3.ValueChanged += new System.EventHandler(this.MaskSizeNumeric1_ValueChanged);
            // 
            // MaskSizeNumeric2
            // 
            this.MaskSizeNumeric2.Location = new System.Drawing.Point(233, 93);
            this.MaskSizeNumeric2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaskSizeNumeric2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric2.Name = "MaskSizeNumeric2";
            this.MaskSizeNumeric2.Size = new System.Drawing.Size(45, 29);
            this.MaskSizeNumeric2.TabIndex = 1;
            this.MaskSizeNumeric2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric2.ValueChanged += new System.EventHandler(this.MaskSizeNumeric1_ValueChanged);
            // 
            // ElementShapeComboBox3
            // 
            this.ElementShapeComboBox3.FormattingEnabled = true;
            this.ElementShapeComboBox3.Items.AddRange(new object[] {
            "Rectangle",
            "Cross ",
            "Ellipse "});
            this.ElementShapeComboBox3.Location = new System.Drawing.Point(115, 129);
            this.ElementShapeComboBox3.Name = "ElementShapeComboBox3";
            this.ElementShapeComboBox3.Size = new System.Drawing.Size(112, 28);
            this.ElementShapeComboBox3.TabIndex = 2;
            this.ElementShapeComboBox3.Text = "Rectangle";
            this.ElementShapeComboBox3.SelectedIndexChanged += new System.EventHandler(this.ElementShapeComboBox1_SelectedIndexChanged);
            // 
            // ElementShapeComboBox2
            // 
            this.ElementShapeComboBox2.FormattingEnabled = true;
            this.ElementShapeComboBox2.Items.AddRange(new object[] {
            "Rectangle",
            "Cross ",
            "Ellipse "});
            this.ElementShapeComboBox2.Location = new System.Drawing.Point(115, 95);
            this.ElementShapeComboBox2.Name = "ElementShapeComboBox2";
            this.ElementShapeComboBox2.Size = new System.Drawing.Size(112, 28);
            this.ElementShapeComboBox2.TabIndex = 2;
            this.ElementShapeComboBox2.Text = "Rectangle";
            this.ElementShapeComboBox2.SelectedIndexChanged += new System.EventHandler(this.ElementShapeComboBox1_SelectedIndexChanged);
            // 
            // MorphOpComboBox3
            // 
            this.MorphOpComboBox3.FormattingEnabled = true;
            this.MorphOpComboBox3.Items.AddRange(new object[] {
            "Erode ",
            "Dilate ",
            "Open ",
            "Close ",
            "Gradient ",
            "Tophat ",
            "Blackhat ",
            "HitMiss "});
            this.MorphOpComboBox3.Location = new System.Drawing.Point(15, 129);
            this.MorphOpComboBox3.Name = "MorphOpComboBox3";
            this.MorphOpComboBox3.Size = new System.Drawing.Size(94, 28);
            this.MorphOpComboBox3.TabIndex = 2;
            this.MorphOpComboBox3.Tag = "2";
            this.MorphOpComboBox3.Text = "Erode ";
            this.MorphOpComboBox3.SelectedIndexChanged += new System.EventHandler(this.MorphOpComboBox0_SelectedIndexChanged);
            // 
            // MorphOpComboBox2
            // 
            this.MorphOpComboBox2.FormattingEnabled = true;
            this.MorphOpComboBox2.Items.AddRange(new object[] {
            "Erode ",
            "Dilate ",
            "Open ",
            "Close ",
            "Gradient ",
            "Tophat ",
            "Blackhat ",
            "HitMiss "});
            this.MorphOpComboBox2.Location = new System.Drawing.Point(15, 95);
            this.MorphOpComboBox2.Name = "MorphOpComboBox2";
            this.MorphOpComboBox2.Size = new System.Drawing.Size(94, 28);
            this.MorphOpComboBox2.TabIndex = 1;
            this.MorphOpComboBox2.Tag = "1";
            this.MorphOpComboBox2.Text = "Erode ";
            this.MorphOpComboBox2.SelectedIndexChanged += new System.EventHandler(this.MorphOpComboBox0_SelectedIndexChanged);
            // 
            // MaskSizeNumeric1
            // 
            this.MaskSizeNumeric1.Location = new System.Drawing.Point(233, 61);
            this.MaskSizeNumeric1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaskSizeNumeric1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric1.Name = "MaskSizeNumeric1";
            this.MaskSizeNumeric1.Size = new System.Drawing.Size(45, 29);
            this.MaskSizeNumeric1.TabIndex = 0;
            this.MaskSizeNumeric1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaskSizeNumeric1.ValueChanged += new System.EventHandler(this.MaskSizeNumeric1_ValueChanged);
            // 
            // MorphExecTimeNumeric1
            // 
            this.MorphExecTimeNumeric1.Location = new System.Drawing.Point(284, 61);
            this.MorphExecTimeNumeric1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MorphExecTimeNumeric1.Name = "MorphExecTimeNumeric1";
            this.MorphExecTimeNumeric1.Size = new System.Drawing.Size(45, 29);
            this.MorphExecTimeNumeric1.TabIndex = 0;
            this.MorphExecTimeNumeric1.ValueChanged += new System.EventHandler(this.MorphExecTimeNumeric1_ValueChanged);
            // 
            // ElementShapeComboBox1
            // 
            this.ElementShapeComboBox1.FormattingEnabled = true;
            this.ElementShapeComboBox1.Items.AddRange(new object[] {
            "Rectangle",
            "Cross ",
            "Ellipse "});
            this.ElementShapeComboBox1.Location = new System.Drawing.Point(115, 62);
            this.ElementShapeComboBox1.Name = "ElementShapeComboBox1";
            this.ElementShapeComboBox1.Size = new System.Drawing.Size(112, 28);
            this.ElementShapeComboBox1.TabIndex = 0;
            this.ElementShapeComboBox1.Text = "Rectangle";
            this.ElementShapeComboBox1.SelectedIndexChanged += new System.EventHandler(this.ElementShapeComboBox1_SelectedIndexChanged);
            // 
            // MorphOpComboBox1
            // 
            this.MorphOpComboBox1.FormattingEnabled = true;
            this.MorphOpComboBox1.Items.AddRange(new object[] {
            "Erode ",
            "Dilate ",
            "Open ",
            "Close ",
            "Gradient ",
            "Tophat ",
            "Blackhat ",
            "HitMiss "});
            this.MorphOpComboBox1.Location = new System.Drawing.Point(15, 60);
            this.MorphOpComboBox1.Name = "MorphOpComboBox1";
            this.MorphOpComboBox1.Size = new System.Drawing.Size(94, 28);
            this.MorphOpComboBox1.TabIndex = 0;
            this.MorphOpComboBox1.Tag = "0";
            this.MorphOpComboBox1.Text = "Erode ";
            this.MorphOpComboBox1.SelectedIndexChanged += new System.EventHandler(this.MorphOpComboBox0_SelectedIndexChanged);
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TestButton.Location = new System.Drawing.Point(231, 418);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(116, 41);
            this.TestButton.TabIndex = 13;
            this.TestButton.Text = "測試";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultRichTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultRichTextBox.Location = new System.Drawing.Point(0, 465);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(358, 229);
            this.ResultRichTextBox.TabIndex = 12;
            this.ResultRichTextBox.Text = "";
            // 
            // ThresholdHighLabel
            // 
            this.ThresholdHighLabel.BackColor = System.Drawing.Color.White;
            this.ThresholdHighLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdHighLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ThresholdHighLabel.Location = new System.Drawing.Point(185, 111);
            this.ThresholdHighLabel.Name = "ThresholdHighLabel";
            this.ThresholdHighLabel.Size = new System.Drawing.Size(40, 20);
            this.ThresholdHighLabel.TabIndex = 11;
            this.ThresholdHighLabel.Text = "255";
            // 
            // ThresholdHighTrackBar
            // 
            this.ThresholdHighTrackBar.LargeChange = 1;
            this.ThresholdHighTrackBar.Location = new System.Drawing.Point(12, 111);
            this.ThresholdHighTrackBar.Maximum = 255;
            this.ThresholdHighTrackBar.Name = "ThresholdHighTrackBar";
            this.ThresholdHighTrackBar.Size = new System.Drawing.Size(167, 45);
            this.ThresholdHighTrackBar.TabIndex = 10;
            this.ThresholdHighTrackBar.Value = 255;
            this.ThresholdHighTrackBar.ValueChanged += new System.EventHandler(this.ThresholdLowTrackBar_ValueChanged);
            // 
            // ShowBinaryButton
            // 
            this.ShowBinaryButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ShowBinaryButton.Location = new System.Drawing.Point(231, 88);
            this.ShowBinaryButton.Name = "ShowBinaryButton";
            this.ShowBinaryButton.Size = new System.Drawing.Size(116, 43);
            this.ShowBinaryButton.TabIndex = 9;
            this.ShowBinaryButton.Text = "二值化";
            this.ShowBinaryButton.UseVisualStyleBackColor = true;
            this.ShowBinaryButton.Click += new System.EventHandler(this.ShowBinaryButton_Click);
            // 
            // ThresholdLowTrackBar
            // 
            this.ThresholdLowTrackBar.LargeChange = 1;
            this.ThresholdLowTrackBar.Location = new System.Drawing.Point(12, 73);
            this.ThresholdLowTrackBar.Maximum = 255;
            this.ThresholdLowTrackBar.Name = "ThresholdLowTrackBar";
            this.ThresholdLowTrackBar.Size = new System.Drawing.Size(167, 45);
            this.ThresholdLowTrackBar.TabIndex = 7;
            this.ThresholdLowTrackBar.ValueChanged += new System.EventHandler(this.ThresholdLowTrackBar_ValueChanged);
            // 
            // AOIToolSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 718);
            this.Controls.Add(this.pnSetup);
            this.Controls.Add(this.FilterImageBox);
            this.Controls.Add(this.SelectROIButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DisplayImageBox);
            this.Name = "AOIToolSetupForm";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.AOIToolSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImageBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterImageBox)).EndInit();
            this.pnSetup.ResumeLayout(false);
            this.pnSetup.PerformLayout();
            this.MorphologyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaskSizeNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MorphExecTimeNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdHighTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdLowTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnSetup;
        private Emgu.CV.UI.ImageBox DisplayImageBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel PositionStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button SelectROIButton;
        private Emgu.CV.UI.ImageBox FilterImageBox;
        private System.Windows.Forms.Button ShowGrayButton;
        private System.Windows.Forms.ComboBox GrayFilterComboBox;
        private System.Windows.Forms.Button ShowBinaryButton;
        private System.Windows.Forms.Label ThresholdLowLabel;
        private System.Windows.Forms.TrackBar ThresholdLowTrackBar;
        private System.Windows.Forms.Label ThresholdHighLabel;
        private System.Windows.Forms.TrackBar ThresholdHighTrackBar;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.GroupBox MorphologyGroupBox;
        private System.Windows.Forms.ComboBox MorphOpComboBox1;
        private System.Windows.Forms.ComboBox ElementShapeComboBox1;
        private System.Windows.Forms.NumericUpDown MorphExecTimeNumeric1;
        private System.Windows.Forms.NumericUpDown MaskSizeNumeric1;
        private System.Windows.Forms.ComboBox MorphOpComboBox3;
        private System.Windows.Forms.ComboBox MorphOpComboBox2;
        private System.Windows.Forms.ComboBox ElementShapeComboBox3;
        private System.Windows.Forms.ComboBox ElementShapeComboBox2;
        private System.Windows.Forms.NumericUpDown MaskSizeNumeric3;
        private System.Windows.Forms.NumericUpDown MaskSizeNumeric2;
        private System.Windows.Forms.NumericUpDown MorphExecTimeNumeric3;
        private System.Windows.Forms.NumericUpDown MorphExecTimeNumeric2;
    }
}
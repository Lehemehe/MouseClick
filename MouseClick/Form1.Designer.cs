namespace MouseClick {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSelectArea = new System.Windows.Forms.Button();
            this.timerRepeat = new System.Windows.Forms.Timer(this.components);
            this.textBoxRepeat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxLR = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListStatus = new System.Windows.Forms.ImageList(this.components);
            this.timerMouseMonitor = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(31, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(52, 20);
            this.textBoxX.TabIndex = 0;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(31, 45);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(52, 20);
            this.textBoxY.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSelectArea);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse position";
            // 
            // buttonSelectArea
            // 
            this.buttonSelectArea.Location = new System.Drawing.Point(100, 20);
            this.buttonSelectArea.Name = "buttonSelectArea";
            this.buttonSelectArea.Size = new System.Drawing.Size(63, 45);
            this.buttonSelectArea.TabIndex = 3;
            this.buttonSelectArea.Text = "Select click area";
            this.buttonSelectArea.UseVisualStyleBackColor = true;
            this.buttonSelectArea.Click += new System.EventHandler(this.buttonSelectArea_Click);
            // 
            // timerRepeat
            // 
            this.timerRepeat.Tick += new System.EventHandler(this.timerRepeat_Tick);
            // 
            // textBoxRepeat
            // 
            this.textBoxRepeat.Location = new System.Drawing.Point(194, 123);
            this.textBoxRepeat.Name = "textBoxRepeat";
            this.textBoxRepeat.Size = new System.Drawing.Size(52, 20);
            this.textBoxRepeat.TabIndex = 0;
            this.textBoxRepeat.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat click Interval (1000  = 1sec)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.Checked = true;
            this.checkBoxLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLeft.Location = new System.Drawing.Point(202, 41);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(78, 17);
            this.checkBoxLeft.TabIndex = 5;
            this.checkBoxLeft.Text = "Left Button";
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.Location = new System.Drawing.Point(202, 64);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(85, 17);
            this.checkBoxRight.TabIndex = 5;
            this.checkBoxRight.Text = "Right Button";
            this.checkBoxRight.UseVisualStyleBackColor = true;
            // 
            // checkBoxLR
            // 
            this.checkBoxLR.AutoSize = true;
            this.checkBoxLR.Checked = true;
            this.checkBoxLR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLR.Location = new System.Drawing.Point(202, 87);
            this.checkBoxLR.Name = "checkBoxLR";
            this.checkBoxLR.Size = new System.Drawing.Size(67, 17);
            this.checkBoxLR.TabIndex = 5;
            this.checkBoxLR.Text = "L then R";
            this.checkBoxLR.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "info";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.BackgroundImage")));
            this.toolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel3.BackgroundImage")));
            this.toolStripStatusLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // imageListStatus
            // 
            this.imageListStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatus.ImageStream")));
            this.imageListStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatus.Images.SetKeyName(0, "Mouse01.png");
            this.imageListStatus.Images.SetKeyName(1, "Mouse02.png");
            // 
            // timerMouseMonitor
            // 
            this.timerMouseMonitor.Interval = 20;
            this.timerMouseMonitor.Tick += new System.EventHandler(this.timerMouseMonitor_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 175);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxLR);
            this.Controls.Add(this.checkBoxRight);
            this.Controls.Add(this.checkBoxLeft);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRepeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseClick Automation";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerRepeat;
        private System.Windows.Forms.TextBox textBoxRepeat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.Button buttonSelectArea;
        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxLR;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ImageList imageListStatus;
        private System.Windows.Forms.Timer timerMouseMonitor;
    }
}


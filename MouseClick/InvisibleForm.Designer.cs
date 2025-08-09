namespace MouseClick {
    partial class InvisibleForm {
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
            this.SuspendLayout();
            // 
            // InvisibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "InvisibleForm";
            this.Opacity = 0.02;
            this.Text = "InvisibleForm";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InvisibleForm_MouseClick);
            this.Load += new System.EventHandler(this.InvisibleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
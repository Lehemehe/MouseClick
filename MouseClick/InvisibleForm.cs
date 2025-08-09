using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Automation;

namespace MouseClick {
    public partial class InvisibleForm :Form {
        public InvisibleForm() {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private FullScreen fullScreen = new FullScreen();
        public int iMouseX, iMouseY;
        Automation.UserInput userInput = new UserInput();


        private void InvisibleForm_Load(object sender, EventArgs e) {
            fullScreen.Maximize(this);
            this.Capture = true;
            Cursor.Current = Cursors.Cross;
        }


        private void InvisibleForm_MouseClick(object sender, MouseEventArgs e) {
            iMouseX = userInput.MousePositionX;
            iMouseY = userInput.MousePositionY;
            this.Capture = false;
            fullScreen.Restore (this);
            this.Dispose();
        }


        public int getMouseX() {
            return iMouseX;
        }

        public int getMouseY() {
            return iMouseY;
        }
    }
}
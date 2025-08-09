using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Security;
using System.Security.Permissions;


using Automation;

namespace MouseClick {
    public partial class Form1 :Form {

        public Form1() {
            InitializeComponent();

            statusFlash = new StatusIconFlash(
                imageListStatus,
                toolStripStatusLabel1,
                0);
            statusFlash.FlashInterval = 200;
            statusFlash.TextRunFlash = "Running ... (move the mouse to STOP)";
            statusFlash.TextStopFlash = "Select click area";
            statusFlash.IconStopFlash = 0;
            statusFlash.InitBefoRun ();
        }

        StatusIconFlash statusFlash;

        Automation.UserInput userInput = new UserInput();
        int iMouseX, iMouseY, iRepeat;

        MousePosition mousePos;


        private void toolStripButtonStart_Click(object sender, EventArgs e) {
            if (textBoxX.Text == "") return;
            if (textBoxY.Text == "") return;
            
            iMouseX = Convert.ToInt32(textBoxX.Text);
            iMouseY = Convert.ToInt32(textBoxY.Text);
            iRepeat = Convert.ToInt32(textBoxRepeat.Text);

            timerRepeat.Interval = iRepeat;
            timerRepeat.Start();

            toolStripButtonStart.Enabled = false;
            toolStripButtonStop.Enabled = true;

            statusFlash.StartFlashing();

            mousePos = new MousePosition();
        }

        private void timerRepeat_Tick(object sender, EventArgs e) {
            userInput.SaveMousePosition();
            timerMouseMonitor.Stop();
            userInput.SendMouseSetPos(iMouseX, iMouseY);

            if (checkBoxLR.Checked == true) {
                if (checkBoxLeft.Checked == true) {
                    userInput.SendMouseLeftClick();
                }
                if (checkBoxRight.Checked == true) {
                    userInput.SendMouseRightClick();
                }
            } else {
                if (checkBoxRight.Checked == true) {
                    userInput.SendMouseRightClick();
                }
                if (checkBoxLeft.Checked == true) {
                    userInput.SendMouseLeftClick();
                }
            }

            userInput.RestoreMousePosition();
            timerMouseMonitor.Start();
            MouseTest();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            StopAutomation();
        }


        private void buttonSelectArea_Click(object sender, EventArgs e) {
            this.Visible = false;

            InvisibleForm form = new InvisibleForm();
            form.ShowDialog();

            textBoxX.Text = form.getMouseX().ToString();
            textBoxY.Text = form.getMouseY().ToString();
            this.Visible = true;
        }


        private void toolStripButtonStop_Click(object sender, EventArgs e) {
            StopAutomation();
        }


        private void StopAutomation() {
            //Cursor.Current = Cursors.Arrow;
            statusFlash.StopFlashing ();
            timerRepeat.Stop();
            toolStripButtonStart.Enabled = true;
            toolStripButtonStop.Enabled = false;
        }


        private void timerMouseMonitor_Tick(object sender, EventArgs e) {
            MouseTest();
        }


        private void MouseTest(){
            if (!mousePos.IsMouseOnPosition()) {
                timerMouseMonitor.Stop();
                StopAutomation();
                mousePos = null;
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MouseClick {
    class StatusIconFlash {

        //Icon[] ico;
        private int iAnimaceCurrent;
        private int iAnimaceMax,iAnimaceMin;
        private System.Windows.Forms.Timer timerFlash;

        private System.Windows.Forms.ToolStripStatusLabel statusIcon;

        private ImageList imageListIcons;

        //from imageList
        private int iIconStopFlash, iIconRunFlash;

        //-1  = null
        //0-x = number of the bitmap
        public int IconStopFlash {
            set { this.iIconStopFlash = value; }
        }

        public int IconRunFlash {
            set { this.iIconRunFlash = value; }
        }
        
        private string sTextStopFlash, sTextRunFlash;
        public string TextStopFlash {
            set { this.sTextStopFlash = value; }
        }

        public string TextRunFlash {
            set { this.sTextRunFlash = value; }
        }


        public int FlashInterval {
            set {  this.timerFlash.Interval = value; }
        }


        public StatusIconFlash(ImageList imageList, ToolStripStatusLabel toolLabelItem, int iStartIcon) {
            statusIcon = toolLabelItem;
            //this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();

            this.timerFlash = new System.Windows.Forms.Timer();
            this.timerFlash.Tick += new System.EventHandler(this.timerFlash_Tick);
            this.timerFlash.Interval = 300;

            //preparation of icons for animation
            imageListIcons = imageList;
            iAnimaceMax = imageList.Images.Count;
            iAnimaceCurrent = iStartIcon;
            iAnimaceMin = iStartIcon;

            iIconRunFlash = iAnimaceMin;
            iIconStopFlash = -1;

            sTextStopFlash = "";
            sTextRunFlash = "";
        }

        public void InitBefoRun() {
            StopFlashing();
        }


        public void StartFlashing(){
            if (iIconRunFlash >= 0) {
                statusIcon.Image = imageListIcons.Images[iIconRunFlash];
            } else {
                statusIcon.Image = null;
            }
            statusIcon.Text = sTextRunFlash;
            timerFlash.Start();
        }


        public void StopFlashing() {
            timerFlash.Stop();
            if (iIconStopFlash >= 0) {
                statusIcon.Image = imageListIcons.Images[iIconStopFlash];
            } else {
                statusIcon.Image = null;
            }
            statusIcon.Text = sTextStopFlash;
        }


        private void timerFlash_Tick(object sender, EventArgs e)
        {
            statusIcon.Image = imageListIcons.Images[iAnimaceCurrent];

                iAnimaceCurrent ++;
                if (iAnimaceCurrent  == iAnimaceMax) {
                    iAnimaceCurrent = iAnimaceMin;
                }
        }
    }
}

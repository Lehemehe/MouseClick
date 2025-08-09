using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MouseClick {
    class MousePosition {

        private int iMouseX, iMouseY;

        public MousePosition() {
            iMouseX = Cursor.Position.X;
            iMouseY = Cursor.Position.Y;
        }

        public bool IsMouseOnPosition() {
            if (iMouseX != Cursor.Position.X ||
            iMouseY != Cursor.Position.Y) {
                return false;
            } else {
                return true;
            }
        }
    }
}

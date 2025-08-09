using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace Automation {
    class UserInput {
        private int iHandle;

        [DllImport("user32.dll")]
        private static extern int FindWindow(
            string strclassName,
            string strWindowName);


        [DllImport("user32.dll")]
        public static extern int SendMessage(
            int hwnd,
            int iMsg,
            int iwParam,
            int ilParam);


        [DllImport("user32.dll")]
        private static extern int ShowWindow(
            int hwnd,
            int nCmdShow);

        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(
            int nInputs,
            ref INPUT pInputs,
            int cbSize);


        private const int SW_MAXIMIZE = 3;

        //mouse event constants
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        const int MOUSEEVENTF_RIGHTDOWN = 8;
        const int MOUSEEVENTF_RIGHT_UP = 16;
        //input type constant
        const int INPUT_MOUSE = 0;
        const int MOUSEEVENTF_ABSOLUTE = 0x8000; //  absolute move;


        Point clickLocation;

        Point clickLocationSave = new Point();

        public struct MOUSEINPUT {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT {
            public uint type;
            public MOUSEINPUT mi;
        };

        public UserInput(string strclassName, string strWindowName) {
            for (int i = 0; i < 1000; i++) {
                iHandle = FindWindow(strclassName, strWindowName);
                if (iHandle != 0) break;

                Thread.Sleep(200);
            }

            if (iHandle == 0) {
                Exception myException = new Exception("Can't find specified window '" + strWindowName + "'");
                myException.Source = "WindowAutomation constructor";
                throw myException;
            }
        }

        //void konstruktor
        public UserInput() {

        }


        //private int iMouseX;

        public int MousePositionX {
            get { return Cursor.Position.X; }
            //set { iMouseX = value; }
        }

        public int MousePositionY {
            get { return Cursor.Position.Y; }
            //set { iMouseX = value; }
        }


        public void SendMouseLeftClick() {
            INPUT i = new INPUT();

            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;

            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;

            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref i, Marshal.SizeOf(i));

            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        public void SendMouseRightClick() {
            INPUT i = new INPUT();

            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;

            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;

            i.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            SendInput(1, ref i, Marshal.SizeOf(i));

            i.mi.dwFlags = MOUSEEVENTF_RIGHT_UP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }




        //posle klik na ulozenou pozici mysi
        public void SendMouseRightClickOnSavePosition() {
            INPUT i = new INPUT();

            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;

            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;

            Point clickLocation = new Point(0, 0);
            clickLocation.X = Cursor.Position.X;
            clickLocation.Y = Cursor.Position.Y;

            Cursor.Position = clickLocationSave;

            i.mi.dwFlags = MOUSEEVENTF_RIGHTDOWN;
            SendInput(1, ref i, Marshal.SizeOf(i));

            i.mi.dwFlags = MOUSEEVENTF_RIGHT_UP;
            SendInput(1, ref i, Marshal.SizeOf(i));

            Cursor.Position = clickLocation;
        }


        public void SendMouseDragToPos(int iX, int iY) {
            INPUT i = new INPUT();

            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;

            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;

            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref i, Marshal.SizeOf(i));

            SendMouseSetPos(iX, iY);

            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }


        public void wait(int iMilisec) {
            Thread.Sleep(iMilisec);
        }


        public void SendMouseSetPos(int iX, int iY) {
            Point clickLocation = new Point(0, 0);

            clickLocation.X = iX;
            clickLocation.Y = iY;

            Cursor.Position = clickLocation;
        }


        public void SaveMousePosition() {
            clickLocationSave.X = Cursor.Position.X;
            clickLocationSave.Y = Cursor.Position.Y;
        }


        public void RestoreMousePosition() {
            this.SendMouseSetPos(clickLocationSave.X, clickLocationSave.Y);
        }


        public void SendText(string strText) {
            bool bCapsLock = Control.IsKeyLocked(Keys.CapsLock);

            if (bCapsLock) {
                //with SHIFT key
                strText = "+(" + strText + ")";
            }

            SendKeys.Send(strText);
            //Thread.Sleep(500);
        }


        public void SendTab() {
            //Thread.Sleep(500);
            SendKeys.Send("{TAB}");
            //Thread.Sleep(500);
        }


        public void SendTab(int iRepeat) {
            //Thread.Sleep(500);
            for (int i = 1; i < iRepeat; i++) {
                SendKeys.Send("{TAB}");
                //Thread.Sleep(100);
            }
            //Thread.Sleep(500);
        }


        public void SendDelete() {
            //Thread.Sleep(500);
            SendKeys.Send("{DELETE}");
            //Thread.Sleep(500);
        }


        public void SendEnter() {
            //Thread.Sleep(500);
            SendKeys.Send("{ENTER}");
            //Thread.Sleep(500);
        }


        public void SendAltText(string strText) {
            SendKeys.Send("%(" + strText + ")");
            //Thread.Sleep(500);
        }


        public void SendArrowUp() {
            //Thread.Sleep(200);
            SendKeys.Send("{UP}");
            //Thread.Sleep(200);
        }

        public void SendArrowDown() {
            //Thread.Sleep(200);
            SendKeys.Send("{DOWN}");
            //Thread.Sleep(200);
        }

        public void SendMaximize() {
            ShowWindow(iHandle, SW_MAXIMIZE);
        }

    }
}

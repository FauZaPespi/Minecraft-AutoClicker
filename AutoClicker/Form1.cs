using System;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        //protected override CreateParams CreateParams
        //{
        //    get
        //   {
        //        CreateParams handleparam = base.CreateParams;
        //        handleparam.ExStyle |= 0x2000000;
        //        return handleparam;
        //    }
        //}

        const int WM_LBUTTONDOWN = 0x0201;
        const int WM_LBUTTONUP = 0x0202;

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public int cbSize;
            public int flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINTAPI
        {
            public int x;
            public int y;
        }

        const int CURSOR_SHOWING = 0x00000001;

        bool isCursorVisible;

        public Form1()
        {
            InitializeComponent();

        }

        public bool CursorOnOf()
        {
            CURSORINFO pci = new CURSORINFO();
            pci.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
            if (GetCursorInfo(out pci))
            {
                isCursorVisible = (pci.flags & CURSOR_SHOWING) != 0;

                if (isCursorVisible)
                {
                    return true;
                    Console.WriteLine("Mouse is visible");
                }
                else
                {
                    return false;
                    Console.WriteLine("Mouse is invisible");
                }
            }
            else
            {
                return false;
                Console.WriteLine("I'm lost ididnt know where are your mouse");
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = guna2TrackBar1.Value.ToString() + "CPS";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Sobre <3";
        }

        private void sToggleButton1_CheckedChanged(object sender, EventArgs e)
        {


            if (sToggleButton1.Checked)
            {
                leftClickerTimer.Start();

            }
            else
            {
                leftClickerTimer.Stop();
            }

        }

        private void leftClickerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                leftClickerTimer.Interval = 800 / Convert.ToInt32((guna2TrackBar1.Value).ToString("0"));
                if (guna2TrackBar1.Value > 0)
                {
                    Process[] processes = Process.GetProcessesByName("javaw");
                    foreach (Process process in processes)
                        if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                        {
                            if (MouseButtons == MouseButtons.Left)
                            {
                                if (CursorOnOf())
                                {
                                    Clicker.leftclick(1);
                                }
                            }
                        }
                }
            }
            catch (Exception) { }
        }

        private void sToggleButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sToggleButton2.Checked)
            {
                if (CursorOnOf())
                {
                    rightClickerTimer.Start();
                }

            }
            else
            {
                rightClickerTimer.Stop();
            }
        }

        private void rightClickerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                rightClickerTimer.Interval = 800 / Convert.ToInt32((guna2TrackBar2.Value).ToString("0"));
                if (guna2TrackBar2.Value > 0)
                {
                    Process[] processes = Process.GetProcessesByName("javaw");
                    foreach (Process process in processes)
                        if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                        {
                            if (MouseButtons == MouseButtons.Right)
                            {
                                if (CursorOnOf())
                                {
                                    Clicker.rightclick(1);
                                }
                            }
                        }
                }
            }
            catch (Exception) { }
        }

        private void nav1_Load(object sender, EventArgs e)
        {

        }
    }
}

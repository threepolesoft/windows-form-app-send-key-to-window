using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendKeyToWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Timer tm_serch;
        private Timer tm;

        private void Form1_Load(object sender, EventArgs e)
        {
            serch();
        }

        public void serch()
        {
            tm = new Timer();
            tm.Interval = 1000 * 3;
            tm.Start();
            tm.Tick += tm_Tick;

            this.lbStatus.Text = string.Empty;

            tm_serch = new Timer();
            tm_serch.Interval = 200 * 1;
            tm_serch.Tick += tm_serch_Tick;
            tm_serch.Start();
        }

        public int tc = 0;
        void tm_serch_Tick(object sender, EventArgs e)
        {
            tc++;

            if (tc==1)
            {
                this.lbSerch.Text = "Serching";
                this.lbSerch.Update();
            }
            else if(tc==2)
            {
                this.lbSerch.Text = "Serching.";
                this.lbStatus.Update();
            }
            else if (tc==3)
            {
                this.lbSerch.Text = "Serching..";
                this.lbStatus.Update();
            }

            else if (tc == 4)
            {
                this.lbSerch.Text = "Serching...";
                this.lbStatus.Update();
                tc = 0;
            }
        }

        public IntPtr hdl = IntPtr.Zero;
        public string tl = string.Empty;

        void tm_Tick(object sender, EventArgs e)
        {

            if (_api.GetActiveWindowTitle() != "Key Send to Active Window")
            {
                this.lbHandler.Text = "Handler : " + _api.GetActiveWindowHandle().ToString();
                this.lbActiveWindow.Text = "Active Window : " + _api.GetActiveWindowTitle();

                this.hdl = _api.GetActiveWindowHandle();
                this.tl = _api.GetActiveWindowTitle();
            }

        }

        private void btnTraceActiveWindow_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tl))
            {
                tm_serch.Stop();
                tm.Stop();

                this.lbSerch.Text = "";
                this.lbStatus.Text = "Trace Successfull";
                this.lbStatus.ForeColor = Color.Green;
            }
            else
            {
                this.lbStatus.Text = "No Active window found!";
                this.lbStatus.ForeColor = Color.Red;
            }
            
        }

        private void rtxtCommandBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _api.SendKeys(hdl, e.KeyChar.ToString());
            _api.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.lbStatus.Text == "Trace Successfull")
            {
                //_api.LeftMouseClick(e.X, e.Y);
                _api.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Pc_Auto_Shutdown
{
    public partial class Form1 : Form
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 00");
        }

        private void BtnSleep_Click(object sender, EventArgs e)
        {
            LockWorkStation();
        }

        private void BtnReboot_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown","/r /t 00");
            
        }
    }
}

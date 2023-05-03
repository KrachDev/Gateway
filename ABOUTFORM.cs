using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Gateway
{
    public partial class ABOUTFORM : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        public ABOUTFORM()
        {
            InitializeComponent();
            DNlblb.Text = "Loading..."; //Device name  emp"DESKTOP1123"
            WNlbl.Text = "Loading..."; //Windows user name
            clbl.Text = "Loading..."; //cpu
            glbl.Text = "Loading..."; //gpu
            rlbl.Text = "Loading..."; //ram
            hdlbl.Text = ""; //hard drive
            Task.Run(() => UpdateSystemInfo());
        }

        private void UpdateSystemInfo()
        {
            // Code to retrieve system information here
            // Retrieve device name
            string deviceName = Environment.MachineName;
            DNlblb.Invoke(new Action(() => DNlblb.Text = deviceName));

            // Retrieve Windows user name
            string userName = Environment.UserName;
            WNlbl.Invoke(new Action(() => WNlbl.Text = userName));
            // Retrieve CPU information
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                clbl.Invoke(new Action(() => clbl.Text = obj["Name"].ToString())); // Display CPU name
            }

            // Retrieve GPU information
            searcher = new ManagementObjectSearcher("select * from Win32_VideoController");
            collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                glbl.Invoke(new Action(() => glbl.Text = obj["Name"].ToString())); // Display GPU name
            }

            // Retrieve RAM information
            searcher = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                ulong totalMemory = (ulong)obj["TotalPhysicalMemory"];
                rlbl.Invoke(new Action(() => rlbl.Text = (totalMemory / (1024 * 1024)).ToString() + " MB")); // Display total RAM in MB
            }

            // Retrieve hard drive information
            searcher = new ManagementObjectSearcher("select * from Win32_LogicalDisk where DriveType=3");
            collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string driveLetter = obj["DeviceID"].ToString();
                ulong freeSpace = (ulong)obj["FreeSpace"];
                ulong totalSpace = (ulong)obj["Size"];
                hdlbl.Invoke(new Action(() => hdlbl.Text += "Drive " + driveLetter + ": " + (freeSpace / (1024 * 1024 * 1024)).ToString() + " GB free of " + (totalSpace / (1024 * 1024 * 1024)).ToString() + " GB" + Environment.NewLine)); // Display hard drive space
            }

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ABOUTFORM_Load(object sender, EventArgs e)
        {
            string version = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
            DNlblb.Text = version;
        }


        private void VersionLbl_Click(object sender, EventArgs e)
        {

        }

        private void Headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Headerpanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

    }
}

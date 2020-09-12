using DiskCapacityMonitoring.Controls;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DiskCapacityMonitoring
{
    public partial class MainForm : Form
    {
        #region Variables

        // Delay time to update UI
        private readonly int delaySeconds = 60;

        #endregion Variables

        #region Create & Load & Shown

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;
        }
        
        public void MainForm_Shown(object sender, EventArgs e)
        {
            // Set local disk and share disk
            SetDisk();

            // Refresh thread
            Thread th = new Thread(new ThreadStart(RefreshDisk));
            th.Start();
        }

        #endregion Create & Load & Shown

        #region Methods

        /// <summary>
        /// Create disk
        /// </summary>
        private void SetDisk()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo di in drives)
            {
                // Unusable disk
                if (di.IsReady == false)
                    continue;

                DiskCtl ctl = new DiskCtl
                {
                    DISK_TYPE = di.DriveType,
                    DISK_NAME = di.Name,
                    TOTAL_SIZE = di.TotalSize,
                    FREE_SIZE = di.AvailableFreeSpace
                };

                FlowLayoutPanel flp = (ctl.DISK_TYPE == DriveType.Fixed) ? uiFlp_Local : uiFlp_Share;
                flp.Controls.Add(ctl);
            }
        }

        /// <summary>
        /// Refresh UI 
        /// </summary>
        private void RefreshDisk()
        {
            while (true)
            {
                Thread.Sleep(1000 * this.delaySeconds);

                RefreshDiskCapacity();
            }
        }

        /// <summary>
        /// Update disk capacity 
        /// </summary>
        private void RefreshDiskCapacity()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo di in drives)
            {
                // Unusable disk
                if (di.IsReady == false)
                    continue;

                FlowLayoutPanel flp = (di.DriveType == DriveType.Fixed) ? uiFlp_Local : uiFlp_Share;
                foreach (Control c in flp.Controls)
                {
                    if (!(c is DiskCtl))
                        continue;

                    DiskCtl ctl = c as DiskCtl;
                    if (ctl.DISK_NAME == di.Name)
                    {
                        ctl.FREE_SIZE = di.AvailableFreeSpace;
                        ctl.SetDiskCapacity();
                    }
                }
            }
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}

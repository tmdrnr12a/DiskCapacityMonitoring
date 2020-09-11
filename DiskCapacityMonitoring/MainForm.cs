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

        private int delaySeconds = 60;

        #endregion Variables

        #region Create & Load & Shown

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;
        }
        
        public void MainForm_Shown(object sender, EventArgs e)
        {
            // Local 및 Share Disk 세팅
            SetDisk();

            // 확인한 Disk 에 대한 UI를 갱신하는 스레드 실행
            Thread th = new Thread(new ThreadStart(RefreshDisk));
            th.Start();
        }

        #endregion Create & Load & Shown

        #region Methods

        private void SetDisk()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo di in drives)
            {
                if (di.IsReady == false)
                    continue;

                DiskCtl ctl = new DiskCtl();
                ctl.DISK_TYPE = di.DriveType;
                ctl.DISK_NAME = di.Name;
                ctl.TOTAL_SIZE = di.TotalSize;
                ctl.FREE_SIZE = di.AvailableFreeSpace;

                FlowLayoutPanel flp = (ctl.DISK_TYPE == DriveType.Fixed) ? uiFlp_Local : uiFlp_Share;
                flp.Controls.Add(ctl);
            }
        }

        private void RefreshDisk()
        {
            while (true)
            {
                Thread.Sleep(1000 * this.delaySeconds);

                RefreshDiskCapacity();
            }
        }

        private void RefreshDiskCapacity()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo di in drives)
            {
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

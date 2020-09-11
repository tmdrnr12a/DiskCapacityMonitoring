using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DiskCapacityMonitoring.Controls
{
    public partial class DiskCtl : UserControl
    {

        #region Variables 

        public enum E_UNIT { UNKNOWN, MB, GB, TB, PB }

        // UNIT
        private long BYTE = 0;
        private long MEGA = 0;
        private long GIGA = 0;
        private long TERA = 0;
        private long PETA = 0;

        // DISK Infomation
        public DriveType DISK_TYPE = DriveType.Unknown;
        public E_UNIT DISK_UNIT = E_UNIT.UNKNOWN;
        public string DISK_NAME = string.Empty;
        public double TOTAL_SIZE = 0;           // Byte Value
        public double FREE_SIZE = 0;            // Byte Value        

        #endregion Variables 

        #region Create & Load & Shown 

        public DiskCtl()
        {
            InitializeComponent();

            this.Load += DiskCtl_Load;
        }

        private void DiskCtl_Load(object sender, EventArgs e)
        {
            SetDistUnit();
            SetDiskIcon();
            SetDiskInfo();
            SetDiskCapacity();
        }

        #endregion Create & Load & Shown

        #region Methods

        /// <summary>
        /// Check disk unit type
        /// </summary>
        private void SetDistUnit()
        {
            this.BYTE = 1024;
            this.MEGA = this.BYTE * 1024;
            this.GIGA = this.MEGA * 1024;
            this.TERA = this.GIGA * 1024;
            this.PETA = this.TERA * 1024;

            if (this.MEGA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.GIGA)
                this.DISK_UNIT = E_UNIT.MB;

            else if (this.GIGA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.TERA)
                this.DISK_UNIT = E_UNIT.GB;

            else if (this.TERA <= this.TOTAL_SIZE && this.TOTAL_SIZE < this.PETA)
                this.DISK_UNIT = E_UNIT.TB;

            else if (this.PETA <= this.TOTAL_SIZE)
                this.DISK_UNIT = E_UNIT.UNKNOWN;
        }

        /// <summary>
        /// Set disk icon
        /// </summary>
        private void SetDiskIcon()
        {
            switch (this.DISK_TYPE)
            {
                case DriveType.Fixed:
                    uiPic_Image.BackgroundImage = Properties.Resources.Folder;
                    break;

                case DriveType.Network:
                    uiPic_Image.BackgroundImage = Properties.Resources.ShareFolder;
                    break;
            }

            uiPic_Image.BackgroundImageLayout = ImageLayout.Zoom;
        }

        /// <summary>
        /// Set disk information
        /// </summary>
        private void SetDiskInfo()
        {
            uiLab_DiskName.Text = this.DISK_NAME;

            uiNPB_DiskCapacity.BackColor = Color.FromKnownColor(KnownColor.Control);
            uiNPB_DiskCapacity.Style = ProgressBarStyle.Continuous;

            uiNPB_DiskCapacity.VisualMode = ProgressBarDisplayMode.Percentage;
            uiNPB_DiskCapacity.TextColor = Color.Black;
        }

        /// <summary>
        /// Set disk capacity (ProgressBar & Text)
        /// </summary>
        public void SetDiskCapacity()
        {
            int value = Convert.ToInt32((this.TOTAL_SIZE - this.FREE_SIZE) / this.TOTAL_SIZE * 100);
            SetProgressValue(value);
            SetProgressColor(value);

            SetUsageText();
        }

        /// <summary>
        /// Set ProgressBar value
        /// </summary>
        /// <param name="value"></param>
        private void SetProgressValue(int value)
        {
            if (uiNPB_DiskCapacity.InvokeRequired == true)
            {
                uiNPB_DiskCapacity.Invoke(new MethodInvoker(delegate ()
                {
                    uiNPB_DiskCapacity.Value = value;
                }));
            }
            else
            {
                uiNPB_DiskCapacity.Value = value;
            }
        }

        /// <summary>
        /// Set ProgressBar color
        /// </summary>
        /// <param name="value"></param>
        private void SetProgressColor(int value)
        {
            if (0 <= value && value < 25)
                uiNPB_DiskCapacity.ProgressColor = Color.FromArgb(116, 182, 102);

            else if (25 <= value && value < 50)
                uiNPB_DiskCapacity.ProgressColor = Color.FromArgb(118, 190, 219);

            else if (50 <= value && value < 75)
                uiNPB_DiskCapacity.ProgressColor = Color.FromArgb(230, 176, 95);

            else
                uiNPB_DiskCapacity.ProgressColor = Color.FromArgb(201, 92, 84);
        }

        /// <summary>
        /// Set usage text
        /// </summary>
        private void SetUsageText()
        {
            double unitValue = GetDiskUnitValue();
            double freeSize = Math.Round(this.FREE_SIZE / unitValue, 2);
            double totalSize = Math.Round(this.TOTAL_SIZE / unitValue, 2);

            string usageText = String.Format("{0} {1} free of {2} {1}", freeSize, this.DISK_UNIT.ToString(), totalSize);
            uiLab_DiskUsage.Text = usageText;
        }

        /// <summary>
        /// Get disk unit value
        /// </summary>
        /// <returns></returns>
        private double GetDiskUnitValue()
        {
            double unitValue = 0;
            switch (this.DISK_UNIT)
            {
                case E_UNIT.MB: unitValue = this.MEGA; break;
                case E_UNIT.GB: unitValue = this.GIGA; break;
                case E_UNIT.TB: unitValue = this.TERA; break;
                case E_UNIT.PB: unitValue = this.PETA; break;
                case E_UNIT.UNKNOWN: break;
            }

            return unitValue;
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}

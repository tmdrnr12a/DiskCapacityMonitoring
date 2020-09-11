namespace DiskCapacityMonitoring.Controls
{
    partial class DiskCtl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPnl_Main = new System.Windows.Forms.Panel();
            this.uiPic_Image = new System.Windows.Forms.PictureBox();
            this.uiLab_DiskName = new System.Windows.Forms.Label();
            this.uiLab_DiskUsage = new System.Windows.Forms.Label();
            this.uiNPB_DiskCapacity = new DiskCapacityMonitoring.Controls.NewProgressBar();
            this.uiPnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPnl_Main
            // 
            this.uiPnl_Main.Controls.Add(this.uiNPB_DiskCapacity);
            this.uiPnl_Main.Controls.Add(this.uiPic_Image);
            this.uiPnl_Main.Controls.Add(this.uiLab_DiskName);
            this.uiPnl_Main.Controls.Add(this.uiLab_DiskUsage);
            this.uiPnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPnl_Main.Location = new System.Drawing.Point(0, 0);
            this.uiPnl_Main.Name = "uiPnl_Main";
            this.uiPnl_Main.Size = new System.Drawing.Size(290, 88);
            this.uiPnl_Main.TabIndex = 0;
            // 
            // uiPic_Image
            // 
            this.uiPic_Image.Location = new System.Drawing.Point(13, 16);
            this.uiPic_Image.Name = "uiPic_Image";
            this.uiPic_Image.Size = new System.Drawing.Size(55, 56);
            this.uiPic_Image.TabIndex = 14;
            this.uiPic_Image.TabStop = false;
            // 
            // uiLab_DiskName
            // 
            this.uiLab_DiskName.AutoSize = true;
            this.uiLab_DiskName.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_DiskName.Location = new System.Drawing.Point(72, 16);
            this.uiLab_DiskName.Name = "uiLab_DiskName";
            this.uiLab_DiskName.Size = new System.Drawing.Size(43, 13);
            this.uiLab_DiskName.TabIndex = 13;
            this.uiLab_DiskName.Text = "Drive";
            // 
            // uiLab_DiskUsage
            // 
            this.uiLab_DiskUsage.AutoSize = true;
            this.uiLab_DiskUsage.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLab_DiskUsage.Location = new System.Drawing.Point(72, 59);
            this.uiLab_DiskUsage.Name = "uiLab_DiskUsage";
            this.uiLab_DiskUsage.Size = new System.Drawing.Size(48, 13);
            this.uiLab_DiskUsage.TabIndex = 12;
            this.uiLab_DiskUsage.Text = "Usage";
            // 
            // uiNPB_DiskCapacity
            // 
            this.uiNPB_DiskCapacity.CustomText = "";
            this.uiNPB_DiskCapacity.Location = new System.Drawing.Point(74, 33);
            this.uiNPB_DiskCapacity.Name = "uiNPB_DiskCapacity";
            this.uiNPB_DiskCapacity.ProgressColor = System.Drawing.Color.LightGreen;
            this.uiNPB_DiskCapacity.Size = new System.Drawing.Size(201, 23);
            this.uiNPB_DiskCapacity.TabIndex = 17;
            this.uiNPB_DiskCapacity.TextColor = System.Drawing.Color.Black;
            this.uiNPB_DiskCapacity.TextFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.uiNPB_DiskCapacity.VisualMode = DiskCapacityMonitoring.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // DiskCtl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiPnl_Main);
            this.Name = "DiskCtl";
            this.Size = new System.Drawing.Size(290, 88);
            this.uiPnl_Main.ResumeLayout(false);
            this.uiPnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiPnl_Main;
        private System.Windows.Forms.PictureBox uiPic_Image;
        private System.Windows.Forms.Label uiLab_DiskName;
        private System.Windows.Forms.Label uiLab_DiskUsage;
        private NewProgressBar uiNPB_DiskCapacity;
    }
}

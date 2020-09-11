namespace DiskCapacityMonitoring
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLab_Local = new System.Windows.Forms.Label();
            this.uiFlp_Local = new System.Windows.Forms.FlowLayoutPanel();
            this.uiFlp_Share = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiLab_Share = new System.Windows.Forms.Label();
            this.uiTlp_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 2;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.uiTlp_Main.Controls.Add(this.panel3, 1, 0);
            this.uiTlp_Main.Controls.Add(this.panel2, 0, 0);
            this.uiTlp_Main.Controls.Add(this.uiFlp_Local, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiFlp_Share, 1, 1);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 2;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0332F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.9668F));
            this.uiTlp_Main.Size = new System.Drawing.Size(664, 482);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiLab_Local);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 52);
            this.panel2.TabIndex = 8;
            // 
            // uiLab_Local
            // 
            this.uiLab_Local.BackColor = System.Drawing.Color.Black;
            this.uiLab_Local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLab_Local.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_Local.ForeColor = System.Drawing.Color.White;
            this.uiLab_Local.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Local.Name = "uiLab_Local";
            this.uiLab_Local.Size = new System.Drawing.Size(326, 52);
            this.uiLab_Local.TabIndex = 2;
            this.uiLab_Local.Text = "Local Disk";
            this.uiLab_Local.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiFlp_Local
            // 
            this.uiFlp_Local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlp_Local.Location = new System.Drawing.Point(3, 61);
            this.uiFlp_Local.Name = "uiFlp_Local";
            this.uiFlp_Local.Size = new System.Drawing.Size(326, 418);
            this.uiFlp_Local.TabIndex = 3;
            // 
            // uiFlp_Share
            // 
            this.uiFlp_Share.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlp_Share.Location = new System.Drawing.Point(335, 61);
            this.uiFlp_Share.Name = "uiFlp_Share";
            this.uiFlp_Share.Size = new System.Drawing.Size(326, 418);
            this.uiFlp_Share.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uiLab_Share);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(335, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 52);
            this.panel3.TabIndex = 9;
            // 
            // uiLab_Share
            // 
            this.uiLab_Share.BackColor = System.Drawing.Color.Black;
            this.uiLab_Share.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLab_Share.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.uiLab_Share.ForeColor = System.Drawing.Color.White;
            this.uiLab_Share.Location = new System.Drawing.Point(0, 0);
            this.uiLab_Share.Name = "uiLab_Share";
            this.uiLab_Share.Size = new System.Drawing.Size(326, 52);
            this.uiLab_Share.TabIndex = 2;
            this.uiLab_Share.Text = "Share Disk";
            this.uiLab_Share.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 482);
            this.Controls.Add(this.uiTlp_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Disk Capacity Monitoring";
            this.uiTlp_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.FlowLayoutPanel uiFlp_Local;
        private System.Windows.Forms.FlowLayoutPanel uiFlp_Share;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label uiLab_Local;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label uiLab_Share;
    }
}


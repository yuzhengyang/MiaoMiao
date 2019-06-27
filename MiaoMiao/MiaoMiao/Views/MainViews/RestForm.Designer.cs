namespace MiaoMiao.Views.MainViews
{
    partial class RestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestForm));
            this.TmMain = new System.Windows.Forms.Timer(this.components);
            this.TmTime = new System.Windows.Forms.Timer(this.components);
            this.PnProgress = new System.Windows.Forms.Panel();
            this.LbProgress = new System.Windows.Forms.Label();
            this.LbCopyright = new System.Windows.Forms.Label();
            this.LbTime = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.LbChineseHour = new System.Windows.Forms.Label();
            this.LbLike = new System.Windows.Forms.Label();
            this.PnProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmMain
            // 
            this.TmMain.Interval = 50;
            this.TmMain.Tick += new System.EventHandler(this.TmMain_Tick);
            // 
            // TmTime
            // 
            this.TmTime.Interval = 1000;
            this.TmTime.Tick += new System.EventHandler(this.TmTime_Tick);
            // 
            // PnProgress
            // 
            this.PnProgress.BackColor = System.Drawing.Color.Transparent;
            this.PnProgress.Controls.Add(this.LbProgress);
            this.PnProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnProgress.Location = new System.Drawing.Point(0, 345);
            this.PnProgress.Name = "PnProgress";
            this.PnProgress.Size = new System.Drawing.Size(544, 1);
            this.PnProgress.TabIndex = 0;
            // 
            // LbProgress
            // 
            this.LbProgress.BackColor = System.Drawing.Color.White;
            this.LbProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbProgress.Location = new System.Drawing.Point(0, 0);
            this.LbProgress.Name = "LbProgress";
            this.LbProgress.Size = new System.Drawing.Size(1, 1);
            this.LbProgress.TabIndex = 0;
            // 
            // LbCopyright
            // 
            this.LbCopyright.AutoSize = true;
            this.LbCopyright.BackColor = System.Drawing.Color.Transparent;
            this.LbCopyright.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbCopyright.ForeColor = System.Drawing.Color.White;
            this.LbCopyright.Location = new System.Drawing.Point(12, 299);
            this.LbCopyright.Name = "LbCopyright";
            this.LbCopyright.Size = new System.Drawing.Size(176, 31);
            this.LbCopyright.TabIndex = 1;
            this.LbCopyright.Text = "要注意休息哟~";
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.BackColor = System.Drawing.Color.Transparent;
            this.LbTime.Font = new System.Drawing.Font("微软雅黑", 57.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbTime.ForeColor = System.Drawing.Color.White;
            this.LbTime.Location = new System.Drawing.Point(290, 9);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(242, 101);
            this.LbTime.TabIndex = 2;
            this.LbTime.Text = "99:99";
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.BackColor = System.Drawing.Color.Transparent;
            this.LbDate.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbDate.ForeColor = System.Drawing.Color.White;
            this.LbDate.Location = new System.Drawing.Point(205, 110);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(327, 52);
            this.LbDate.TabIndex = 3;
            this.LbDate.Text = "12月12日 星期一";
            // 
            // LbChineseHour
            // 
            this.LbChineseHour.AutoSize = true;
            this.LbChineseHour.BackColor = System.Drawing.Color.Transparent;
            this.LbChineseHour.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbChineseHour.ForeColor = System.Drawing.Color.White;
            this.LbChineseHour.Location = new System.Drawing.Point(190, 51);
            this.LbChineseHour.Name = "LbChineseHour";
            this.LbChineseHour.Size = new System.Drawing.Size(94, 48);
            this.LbChineseHour.TabIndex = 4;
            this.LbChineseHour.Text = "上午";
            // 
            // LbLike
            // 
            this.LbLike.AutoSize = true;
            this.LbLike.BackColor = System.Drawing.Color.Transparent;
            this.LbLike.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbLike.ForeColor = System.Drawing.Color.White;
            this.LbLike.Location = new System.Drawing.Point(12, 9);
            this.LbLike.Name = "LbLike";
            this.LbLike.Size = new System.Drawing.Size(70, 75);
            this.LbLike.TabIndex = 5;
            this.LbLike.Text = "♡";
            this.LbLike.Click += new System.EventHandler(this.LbLike_Click);
            // 
            // RestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(544, 346);
            this.Controls.Add(this.LbLike);
            this.Controls.Add(this.LbChineseHour);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.PnProgress);
            this.Controls.Add(this.LbCopyright);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestForm";
            this.Text = "LockForm";
            this.Load += new System.EventHandler(this.RestForm_Load);
            this.DoubleClick += new System.EventHandler(this.RestForm_DoubleClick);
            this.PnProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmMain;
        private System.Windows.Forms.Timer TmTime;
        private System.Windows.Forms.Panel PnProgress;
        private System.Windows.Forms.Label LbProgress;
        private System.Windows.Forms.Label LbCopyright;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Label LbChineseHour;
        private System.Windows.Forms.Label LbLike;
    }
}
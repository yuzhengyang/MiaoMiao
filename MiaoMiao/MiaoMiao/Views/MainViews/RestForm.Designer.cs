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
            this.PnProgress = new System.Windows.Forms.Panel();
            this.LbProgress = new System.Windows.Forms.Label();
            this.PnProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // TmMain
            // 
            this.TmMain.Tick += new System.EventHandler(this.TmMain_Tick);
            // 
            // PnProgress
            // 
            this.PnProgress.BackColor = System.Drawing.Color.Transparent;
            this.PnProgress.Controls.Add(this.LbProgress);
            this.PnProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnProgress.Location = new System.Drawing.Point(0, 228);
            this.PnProgress.Name = "PnProgress";
            this.PnProgress.Size = new System.Drawing.Size(315, 1);
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
            // RestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(315, 229);
            this.Controls.Add(this.PnProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestForm";
            this.Text = "LockForm";
            this.Load += new System.EventHandler(this.RestForm_Load);
            this.DoubleClick += new System.EventHandler(this.RestForm_DoubleClick);
            this.PnProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmMain;
        private System.Windows.Forms.Panel PnProgress;
        private System.Windows.Forms.Label LbProgress;
    }
}
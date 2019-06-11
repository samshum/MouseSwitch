namespace MouseSwitch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkbox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.左手习惯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右手习惯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.切换鼠标滚轮方向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAC操作习惯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windows操作习惯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "使用习惯";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "鼠标使用习惯切换";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkbox1,
            this.左手习惯ToolStripMenuItem,
            this.右手习惯ToolStripMenuItem,
            this.切换鼠标滚轮方向ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // checkbox1
            // 
            this.checkbox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.checkbox1.Image = global::MouseSwitch.Properties.Resources.block;
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(180, 22);
            this.checkbox1.Text = "随系统启动";
            this.checkbox1.Click += new System.EventHandler(this.随系统启动ToolStripMenuItem_Click);
            // 
            // 左手习惯ToolStripMenuItem
            // 
            this.左手习惯ToolStripMenuItem.Name = "左手习惯ToolStripMenuItem";
            this.左手习惯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.左手习惯ToolStripMenuItem.Text = "左手习惯";
            this.左手习惯ToolStripMenuItem.Click += new System.EventHandler(this.左手习惯ToolStripMenuItem_Click);
            // 
            // 右手习惯ToolStripMenuItem
            // 
            this.右手习惯ToolStripMenuItem.Name = "右手习惯ToolStripMenuItem";
            this.右手习惯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.右手习惯ToolStripMenuItem.Text = "右手习惯";
            this.右手习惯ToolStripMenuItem.Click += new System.EventHandler(this.右手习惯ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 切换鼠标滚轮方向ToolStripMenuItem
            // 
            this.切换鼠标滚轮方向ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAC操作习惯ToolStripMenuItem,
            this.windows操作习惯ToolStripMenuItem});
            this.切换鼠标滚轮方向ToolStripMenuItem.Name = "切换鼠标滚轮方向ToolStripMenuItem";
            this.切换鼠标滚轮方向ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.切换鼠标滚轮方向ToolStripMenuItem.Text = "切换鼠标滚轮方向";
            // 
            // mAC操作习惯ToolStripMenuItem
            // 
            this.mAC操作习惯ToolStripMenuItem.Name = "mAC操作习惯ToolStripMenuItem";
            this.mAC操作习惯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mAC操作习惯ToolStripMenuItem.Text = "MAC操作习惯";
            this.mAC操作习惯ToolStripMenuItem.Click += new System.EventHandler(this.MAC操作习惯ToolStripMenuItem_Click);
            // 
            // windows操作习惯ToolStripMenuItem
            // 
            this.windows操作习惯ToolStripMenuItem.Name = "windows操作习惯ToolStripMenuItem";
            this.windows操作习惯ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.windows操作习惯ToolStripMenuItem.Text = "Windows操作习惯";
            this.windows操作习惯ToolStripMenuItem.Click += new System.EventHandler(this.Windows操作习惯ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 198);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkbox1;
        private System.Windows.Forms.ToolStripMenuItem 左手习惯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右手习惯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem 切换鼠标滚轮方向ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAC操作习惯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windows操作习惯ToolStripMenuItem;
    }
}


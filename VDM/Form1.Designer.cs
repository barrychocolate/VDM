namespace VDM
{
    partial class frmVDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVDM));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tvwLinks = new System.Windows.Forms.TreeView();
            this.btnTreeview = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadLink = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.cmsNotifyIcon.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(174, 27);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(93, 27);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(75, 23);
            this.btnMessage.TabIndex = 1;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 27);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tvwLinks
            // 
            this.tvwLinks.Location = new System.Drawing.Point(12, 85);
            this.tvwLinks.Name = "tvwLinks";
            this.tvwLinks.Size = new System.Drawing.Size(324, 484);
            this.tvwLinks.TabIndex = 4;
            this.tvwLinks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvwLinks_AfterSelect);
            // 
            // btnTreeview
            // 
            this.btnTreeview.Location = new System.Drawing.Point(12, 56);
            this.btnTreeview.Name = "btnTreeview";
            this.btnTreeview.Size = new System.Drawing.Size(75, 23);
            this.btnTreeview.TabIndex = 5;
            this.btnTreeview.Text = "build treeview";
            this.btnTreeview.UseVisualStyleBackColor = true;
            this.btnTreeview.Click += new System.EventHandler(this.BtnTreeview_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(348, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_label
            // 
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 17);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cmsNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "VDM";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dockToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // dockToolStripMenuItem
            // 
            this.dockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topLeftToolStripMenuItem,
            this.topRightToolStripMenuItem,
            this.bottomRightToolStripMenuItem,
            this.bottomLeftToolStripMenuItem});
            this.dockToolStripMenuItem.Name = "dockToolStripMenuItem";
            this.dockToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.dockToolStripMenuItem.Text = "Dock";
            // 
            // topLeftToolStripMenuItem
            // 
            this.topLeftToolStripMenuItem.Name = "topLeftToolStripMenuItem";
            this.topLeftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.topLeftToolStripMenuItem.Text = "Top Left";
            this.topLeftToolStripMenuItem.Click += new System.EventHandler(this.TopLeftToolStripMenuItem_Click);
            // 
            // topRightToolStripMenuItem
            // 
            this.topRightToolStripMenuItem.Name = "topRightToolStripMenuItem";
            this.topRightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.topRightToolStripMenuItem.Text = "Top Right";
            this.topRightToolStripMenuItem.Click += new System.EventHandler(this.TopRightToolStripMenuItem_Click);
            // 
            // bottomRightToolStripMenuItem
            // 
            this.bottomRightToolStripMenuItem.Checked = true;
            this.bottomRightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomRightToolStripMenuItem.Name = "bottomRightToolStripMenuItem";
            this.bottomRightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bottomRightToolStripMenuItem.Text = "Bottom Right";
            this.bottomRightToolStripMenuItem.Click += new System.EventHandler(this.BottomRightToolStripMenuItem_Click);
            // 
            // bottomLeftToolStripMenuItem
            // 
            this.bottomLeftToolStripMenuItem.Name = "bottomLeftToolStripMenuItem";
            this.bottomLeftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bottomLeftToolStripMenuItem.Text = "Bottom Left";
            this.bottomLeftToolStripMenuItem.Click += new System.EventHandler(this.BottomLeftToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnLoadLink
            // 
            this.btnLoadLink.Location = new System.Drawing.Point(93, 56);
            this.btnLoadLink.Name = "btnLoadLink";
            this.btnLoadLink.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLink.TabIndex = 9;
            this.btnLoadLink.Text = "test link";
            this.btnLoadLink.UseVisualStyleBackColor = true;
            this.btnLoadLink.Click += new System.EventHandler(this.btnLoadLink_Click);
            // 
            // frmVDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 581);
            this.Controls.Add(this.btnLoadLink);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTreeview);
            this.Controls.Add(this.tvwLinks);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmVDM";
            this.ShowInTaskbar = false;
            this.Text = "VDM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVDM_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsNotifyIcon.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TreeView tvwLinks;
        private System.Windows.Forms.Button btnTreeview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_label;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadLink;
    }
}


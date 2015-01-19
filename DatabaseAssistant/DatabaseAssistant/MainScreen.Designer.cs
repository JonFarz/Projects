namespace WindowsFormsApplication1
{
    partial class MainScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BkupRstTab = new System.Windows.Forms.TabPage();
            this.RestorePanel = new System.Windows.Forms.Panel();
            this.RestoreDatabaseFrameLabel = new System.Windows.Forms.Label();
            this.RestoreServerDropDown = new System.Windows.Forms.ComboBox();
            this.RestoreServerDatabaseDropDown = new System.Windows.Forms.ComboBox();
            this.BackupPanel = new System.Windows.Forms.Panel();
            this.BackupLable = new System.Windows.Forms.Label();
            this.BackupSeverDropDown = new System.Windows.Forms.ComboBox();
            this.BackupDatabaseDropDown = new System.Windows.Forms.ComboBox();
            this.BackupRestoreDropDown = new System.Windows.Forms.ComboBox();
            this.OpeningApplicationsTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.BkupRstTab.SuspendLayout();
            this.RestorePanel.SuspendLayout();
            this.BackupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = global::WindowsFormsApplication1.Properties.Settings.Default.BLRAnchor;
            this.tabControl1.Controls.Add(this.BkupRstTab);
            this.tabControl1.Controls.Add(this.OpeningApplicationsTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // BkupRstTab
            // 
            this.BkupRstTab.Controls.Add(this.RestorePanel);
            this.BkupRstTab.Controls.Add(this.BackupPanel);
            this.BkupRstTab.Controls.Add(this.BackupRestoreDropDown);
            this.BkupRstTab.Location = new System.Drawing.Point(4, 4);
            this.BkupRstTab.Name = "BkupRstTab";
            this.BkupRstTab.Padding = new System.Windows.Forms.Padding(3);
            this.BkupRstTab.Size = new System.Drawing.Size(970, 394);
            this.BkupRstTab.TabIndex = 0;
            this.BkupRstTab.Text = "Backup and Restore";
            this.BkupRstTab.UseVisualStyleBackColor = true;
            // 
            // RestorePanel
            // 
            this.RestorePanel.Controls.Add(this.RestoreDatabaseFrameLabel);
            this.RestorePanel.Controls.Add(this.RestoreServerDropDown);
            this.RestorePanel.Controls.Add(this.RestoreServerDatabaseDropDown);
            this.RestorePanel.Location = new System.Drawing.Point(298, 183);
            this.RestorePanel.Name = "RestorePanel";
            this.RestorePanel.Size = new System.Drawing.Size(447, 132);
            this.RestorePanel.TabIndex = 5;
            this.RestorePanel.Visible = false;
            // 
            // RestoreDatabaseFrameLabel
            // 
            this.RestoreDatabaseFrameLabel.AutoSize = true;
            this.RestoreDatabaseFrameLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDatabaseFrameLabel.Location = new System.Drawing.Point(117, 78);
            this.RestoreDatabaseFrameLabel.Name = "RestoreDatabaseFrameLabel";
            this.RestoreDatabaseFrameLabel.Size = new System.Drawing.Size(188, 30);
            this.RestoreDatabaseFrameLabel.TabIndex = 4;
            this.RestoreDatabaseFrameLabel.Text = "Restore Database";
            // 
            // RestoreServerDropDown
            // 
            this.RestoreServerDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreServerDropDown.FormattingEnabled = true;
            this.RestoreServerDropDown.Location = new System.Drawing.Point(3, 3);
            this.RestoreServerDropDown.Name = "RestoreServerDropDown";
            this.RestoreServerDropDown.Size = new System.Drawing.Size(166, 32);
            this.RestoreServerDropDown.TabIndex = 1;
            this.RestoreServerDropDown.Text = "Server";
            // 
            // RestoreServerDatabaseDropDown
            // 
            this.RestoreServerDatabaseDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreServerDatabaseDropDown.FormattingEnabled = true;
            this.RestoreServerDatabaseDropDown.Location = new System.Drawing.Point(238, 3);
            this.RestoreServerDatabaseDropDown.Name = "RestoreServerDatabaseDropDown";
            this.RestoreServerDatabaseDropDown.Size = new System.Drawing.Size(206, 32);
            this.RestoreServerDatabaseDropDown.TabIndex = 2;
            this.RestoreServerDatabaseDropDown.Text = "Database";
            // 
            // BackupPanel
            // 
            this.BackupPanel.Controls.Add(this.BackupLable);
            this.BackupPanel.Controls.Add(this.BackupSeverDropDown);
            this.BackupPanel.Controls.Add(this.BackupDatabaseDropDown);
            this.BackupPanel.Location = new System.Drawing.Point(298, 6);
            this.BackupPanel.Name = "BackupPanel";
            this.BackupPanel.Size = new System.Drawing.Size(447, 132);
            this.BackupPanel.TabIndex = 3;
            this.BackupPanel.Visible = false;
            // 
            // BackupLable
            // 
            this.BackupLable.AutoSize = true;
            this.BackupLable.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupLable.Location = new System.Drawing.Point(117, 78);
            this.BackupLable.Name = "BackupLable";
            this.BackupLable.Size = new System.Drawing.Size(187, 30);
            this.BackupLable.TabIndex = 4;
            this.BackupLable.Text = "Backup DataBase";
            // 
            // BackupSeverDropDown
            // 
            this.BackupSeverDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupSeverDropDown.FormattingEnabled = true;
            this.BackupSeverDropDown.Location = new System.Drawing.Point(3, 3);
            this.BackupSeverDropDown.Name = "BackupSeverDropDown";
            this.BackupSeverDropDown.Size = new System.Drawing.Size(166, 32);
            this.BackupSeverDropDown.TabIndex = 1;
            this.BackupSeverDropDown.Text = "Server";
            this.BackupSeverDropDown.SelectedValueChanged += new System.EventHandler(this.ServerCombBoxSVC);
            // 
            // BackupDatabaseDropDown
            // 
            this.BackupDatabaseDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupDatabaseDropDown.FormattingEnabled = true;
            this.BackupDatabaseDropDown.Location = new System.Drawing.Point(238, 3);
            this.BackupDatabaseDropDown.Name = "BackupDatabaseDropDown";
            this.BackupDatabaseDropDown.Size = new System.Drawing.Size(206, 32);
            this.BackupDatabaseDropDown.TabIndex = 2;
            this.BackupDatabaseDropDown.Text = "Database";
            // 
            // BackupRestoreDropDown
            // 
            this.BackupRestoreDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupRestoreDropDown.FormattingEnabled = true;
            this.BackupRestoreDropDown.Items.AddRange(new object[] {
            "Backup",
            "Backup and Restore",
            "Restore"});
            this.BackupRestoreDropDown.Location = new System.Drawing.Point(6, 6);
            this.BackupRestoreDropDown.MaxDropDownItems = 25;
            this.BackupRestoreDropDown.Name = "BackupRestoreDropDown";
            this.BackupRestoreDropDown.Size = new System.Drawing.Size(244, 32);
            this.BackupRestoreDropDown.Sorted = true;
            this.BackupRestoreDropDown.TabIndex = 0;
            this.BackupRestoreDropDown.Text = "Backup And/Or Restore";
            this.BackupRestoreDropDown.SelectedValueChanged += new System.EventHandler(this.BackUpRestoreDropDownSVC);
            // 
            // OpeningApplicationsTab
            // 
            this.OpeningApplicationsTab.Location = new System.Drawing.Point(4, 4);
            this.OpeningApplicationsTab.Name = "OpeningApplicationsTab";
            this.OpeningApplicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OpeningApplicationsTab.Size = new System.Drawing.Size(970, 394);
            this.OpeningApplicationsTab.TabIndex = 1;
            this.OpeningApplicationsTab.Text = "Open Applications With Credentials";
            this.OpeningApplicationsTab.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(981, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainScreen";
            this.Text = "Database Assistant";
            this.tabControl1.ResumeLayout(false);
            this.BkupRstTab.ResumeLayout(false);
            this.RestorePanel.ResumeLayout(false);
            this.RestorePanel.PerformLayout();
            this.BackupPanel.ResumeLayout(false);
            this.BackupPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage BkupRstTab;
        private System.Windows.Forms.TabPage OpeningApplicationsTab;
        private System.Windows.Forms.ComboBox BackupRestoreDropDown;
        private System.Windows.Forms.ComboBox BackupSeverDropDown;
        private System.Windows.Forms.ComboBox BackupDatabaseDropDown;
        private System.Windows.Forms.Panel BackupPanel;
        private System.Windows.Forms.Label BackupLable;
        private System.Windows.Forms.Panel RestorePanel;
        private System.Windows.Forms.Label RestoreDatabaseFrameLabel;
        private System.Windows.Forms.ComboBox RestoreServerDropDown;
        private System.Windows.Forms.ComboBox RestoreServerDatabaseDropDown;

    }
}


namespace Willard.DevOps.AWS.APIWrapper
{
  partial class WorkspaceCreator
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkspaceCreator));
      this.regionDropdownLabel = new System.Windows.Forms.Label();
      this.regionDropdown = new System.Windows.Forms.ComboBox();
      this.bundleDropdownLabel = new System.Windows.Forms.Label();
      this.bundleDropdown = new System.Windows.Forms.ComboBox();
      this.createWorkspaceButton = new System.Windows.Forms.Button();
      this.userNameLabel = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.userNameDropdown = new System.Windows.Forms.ComboBox();
      this.directoryDropdown = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.workspaceDataGridView = new System.Windows.Forms.DataGridView();
      this.label2 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // regionDropdownLabel
      // 
      this.regionDropdownLabel.AutoSize = true;
      this.regionDropdownLabel.Location = new System.Drawing.Point(12, 41);
      this.regionDropdownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.regionDropdownLabel.Name = "regionDropdownLabel";
      this.regionDropdownLabel.Size = new System.Drawing.Size(82, 13);
      this.regionDropdownLabel.TabIndex = 0;
      this.regionDropdownLabel.Text = "Amazon Region";
      // 
      // regionDropdown
      // 
      this.regionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.regionDropdown.DropDownWidth = 300;
      this.regionDropdown.FormattingEnabled = true;
      this.regionDropdown.Location = new System.Drawing.Point(10, 56);
      this.regionDropdown.Margin = new System.Windows.Forms.Padding(2);
      this.regionDropdown.Name = "regionDropdown";
      this.regionDropdown.Size = new System.Drawing.Size(226, 21);
      this.regionDropdown.TabIndex = 1;
      this.regionDropdown.SelectedIndexChanged += new System.EventHandler(this.RegionDropdown_SelectedIndexChanged);
      // 
      // bundleDropdownLabel
      // 
      this.bundleDropdownLabel.AutoSize = true;
      this.bundleDropdownLabel.Location = new System.Drawing.Point(12, 83);
      this.bundleDropdownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.bundleDropdownLabel.Name = "bundleDropdownLabel";
      this.bundleDropdownLabel.Size = new System.Drawing.Size(40, 13);
      this.bundleDropdownLabel.TabIndex = 2;
      this.bundleDropdownLabel.Text = "Bundle";
      // 
      // bundleDropdown
      // 
      this.bundleDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.bundleDropdown.Enabled = false;
      this.bundleDropdown.FormattingEnabled = true;
      this.bundleDropdown.Location = new System.Drawing.Point(10, 98);
      this.bundleDropdown.Margin = new System.Windows.Forms.Padding(2);
      this.bundleDropdown.Name = "bundleDropdown";
      this.bundleDropdown.Size = new System.Drawing.Size(226, 21);
      this.bundleDropdown.TabIndex = 3;
      this.bundleDropdown.SelectedIndexChanged += new System.EventHandler(this.BundleDropdown_SelectedIndexChanged);
      // 
      // createWorkspaceButton
      // 
      this.createWorkspaceButton.Enabled = false;
      this.createWorkspaceButton.Location = new System.Drawing.Point(10, 330);
      this.createWorkspaceButton.Margin = new System.Windows.Forms.Padding(2);
      this.createWorkspaceButton.Name = "createWorkspaceButton";
      this.createWorkspaceButton.Size = new System.Drawing.Size(226, 24);
      this.createWorkspaceButton.TabIndex = 8;
      this.createWorkspaceButton.Text = "Create Workspace";
      this.createWorkspaceButton.UseVisualStyleBackColor = true;
      this.createWorkspaceButton.Click += new System.EventHandler(this.CreateWorkspaceButton_Click);
      // 
      // userNameLabel
      // 
      this.userNameLabel.AutoSize = true;
      this.userNameLabel.Location = new System.Drawing.Point(12, 124);
      this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.userNameLabel.Name = "userNameLabel";
      this.userNameLabel.Size = new System.Drawing.Size(57, 13);
      this.userNameLabel.TabIndex = 9;
      this.userNameLabel.Text = "UserName";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(811, 24);
      this.menuStrip1.TabIndex = 13;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
      // 
      // userNameDropdown
      // 
      this.userNameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.userNameDropdown.Enabled = false;
      this.userNameDropdown.FormattingEnabled = true;
      this.userNameDropdown.Location = new System.Drawing.Point(10, 139);
      this.userNameDropdown.Margin = new System.Windows.Forms.Padding(2);
      this.userNameDropdown.Name = "userNameDropdown";
      this.userNameDropdown.Size = new System.Drawing.Size(226, 21);
      this.userNameDropdown.TabIndex = 14;
      this.userNameDropdown.SelectedIndexChanged += new System.EventHandler(this.UserNameDropdown_SelectedIndexChanged);
      // 
      // directoryDropdown
      // 
      this.directoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.directoryDropdown.Enabled = false;
      this.directoryDropdown.FormattingEnabled = true;
      this.directoryDropdown.Location = new System.Drawing.Point(10, 182);
      this.directoryDropdown.Margin = new System.Windows.Forms.Padding(2);
      this.directoryDropdown.Name = "directoryDropdown";
      this.directoryDropdown.Size = new System.Drawing.Size(226, 21);
      this.directoryDropdown.TabIndex = 16;
      this.directoryDropdown.SelectedIndexChanged += new System.EventHandler(this.DirectoryDropdown_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 167);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Directory";
      // 
      // workspaceDataGridView
      // 
      this.workspaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.workspaceDataGridView.Location = new System.Drawing.Point(255, 56);
      this.workspaceDataGridView.Name = "workspaceDataGridView";
      this.workspaceDataGridView.Size = new System.Drawing.Size(544, 298);
      this.workspaceDataGridView.TabIndex = 17;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(252, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(197, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Current Workspaces in Selected Region";
      // 
      // WorkspaceCreator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(811, 366);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.workspaceDataGridView);
      this.Controls.Add(this.directoryDropdown);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.userNameDropdown);
      this.Controls.Add(this.userNameLabel);
      this.Controls.Add(this.createWorkspaceButton);
      this.Controls.Add(this.bundleDropdown);
      this.Controls.Add(this.bundleDropdownLabel);
      this.Controls.Add(this.regionDropdown);
      this.Controls.Add(this.regionDropdownLabel);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "WorkspaceCreator";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AWS Workspace Creator";
      this.Load += new System.EventHandler(this.WorkspaceCreator_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.workspaceDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label regionDropdownLabel;
    private System.Windows.Forms.ComboBox regionDropdown;
    private System.Windows.Forms.Label bundleDropdownLabel;
    private System.Windows.Forms.ComboBox bundleDropdown;
    private System.Windows.Forms.Button createWorkspaceButton;
    private System.Windows.Forms.Label userNameLabel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ComboBox userNameDropdown;
    private System.Windows.Forms.ComboBox directoryDropdown;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView workspaceDataGridView;
    private System.Windows.Forms.Label label2;
  }
}


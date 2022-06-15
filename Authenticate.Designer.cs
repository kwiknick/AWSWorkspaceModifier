namespace Willard.DevOps.AWS.APIWrapper
{
  partial class Authenticate
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.awsSecretKeyTextBox = new System.Windows.Forms.MaskedTextBox();
      this.awsAccessKeyTextBox = new System.Windows.Forms.MaskedTextBox();
      this.authenticateButton = new System.Windows.Forms.Button();
      this.resetButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "AWS Access Key";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 122);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "AWS Secret Key";
      // 
      // awsSecretKeyTextBox
      // 
      this.awsSecretKeyTextBox.Location = new System.Drawing.Point(173, 122);
      this.awsSecretKeyTextBox.Name = "awsSecretKeyTextBox";
      this.awsSecretKeyTextBox.Size = new System.Drawing.Size(420, 22);
      this.awsSecretKeyTextBox.TabIndex = 4;
      this.awsSecretKeyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AwsSecretKeyTextBox_KeyPress);
      // 
      // awsAccessKeyTextBox
      // 
      this.awsAccessKeyTextBox.Location = new System.Drawing.Point(173, 76);
      this.awsAccessKeyTextBox.Name = "awsAccessKeyTextBox";
      this.awsAccessKeyTextBox.Size = new System.Drawing.Size(420, 22);
      this.awsAccessKeyTextBox.TabIndex = 5;
      // 
      // authenticateButton
      // 
      this.authenticateButton.Location = new System.Drawing.Point(173, 166);
      this.authenticateButton.Name = "authenticateButton";
      this.authenticateButton.Size = new System.Drawing.Size(210, 32);
      this.authenticateButton.TabIndex = 6;
      this.authenticateButton.Text = "Authenticate";
      this.authenticateButton.UseVisualStyleBackColor = true;
      this.authenticateButton.Click += new System.EventHandler(this.AuthenticateButton_Click);
      // 
      // resetButton
      // 
      this.resetButton.Location = new System.Drawing.Point(389, 166);
      this.resetButton.Name = "resetButton";
      this.resetButton.Size = new System.Drawing.Size(204, 32);
      this.resetButton.TabIndex = 7;
      this.resetButton.Text = "Reset Form";
      this.resetButton.UseVisualStyleBackColor = true;
      this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
      // 
      // Authenticate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(620, 241);
      this.Controls.Add(this.resetButton);
      this.Controls.Add(this.authenticateButton);
      this.Controls.Add(this.awsAccessKeyTextBox);
      this.Controls.Add(this.awsSecretKeyTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Authenticate";
      this.Text = "Authenticate";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MaskedTextBox awsSecretKeyTextBox;
    private System.Windows.Forms.MaskedTextBox awsAccessKeyTextBox;
    private System.Windows.Forms.Button authenticateButton;
    private System.Windows.Forms.Button resetButton;
  }
}
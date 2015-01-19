namespace WindowsFormsApplication1
{
    partial class LoginForm
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
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UNameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxtBox.Location = new System.Drawing.Point(110, 79);
            this.PasswordTxtBox.MaxLength = 50;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '$';
            this.PasswordTxtBox.Size = new System.Drawing.Size(256, 20);
            this.PasswordTxtBox.TabIndex = 11;
            this.PasswordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PWordKeyPress);
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTxtBox.Location = new System.Drawing.Point(110, 43);
            this.UserNameTxtBox.MaxLength = 200;
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(256, 20);
            this.UserNameTxtBox.TabIndex = 10;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(12, 81);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(88, 18);
            this.PassLabel.TabIndex = 9;
            this.PassLabel.Text = "Password:";
            // 
            // UNameLabel
            // 
            this.UNameLabel.AutoSize = true;
            this.UNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameLabel.Location = new System.Drawing.Point(12, 45);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(90, 18);
            this.UNameLabel.TabIndex = 8;
            this.UNameLabel.Text = "Username:";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.Location = new System.Drawing.Point(110, 117);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(256, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 152);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.UserNameTxtBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UNameLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}

namespace TripleJP_Lending_System
{
    partial class LogInFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(48, 50);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(308, 36);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameGroupBox.Location = new System.Drawing.Point(39, 32);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Size = new System.Drawing.Size(328, 66);
            this.usernameGroupBox.TabIndex = 2;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(48, 120);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(308, 36);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxt_KeyPress);
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordGroupBox.Location = new System.Drawing.Point(39, 102);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(328, 65);
            this.passwordGroupBox.TabIndex = 4;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(264, 183);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(103, 44);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log-in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LogInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 255);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triple JP Lending System";
            this.Load += new System.EventHandler(this.LogInFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Button logInButton;
    }
}


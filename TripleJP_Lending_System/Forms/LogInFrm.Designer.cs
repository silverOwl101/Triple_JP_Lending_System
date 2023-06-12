
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameGroupBox = new System.Windows.Forms.GroupBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(48, 50);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(308, 29);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTxt_KeyPress);
            // 
            // usernameGroupBox
            // 
            this.usernameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameGroupBox.Location = new System.Drawing.Point(39, 32);
            this.usernameGroupBox.Name = "usernameGroupBox";
            this.usernameGroupBox.Size = new System.Drawing.Size(328, 66);
            this.usernameGroupBox.TabIndex = 2;
            this.usernameGroupBox.TabStop = false;
            this.usernameGroupBox.Text = "Username";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTextBox.Location = new System.Drawing.Point(48, 120);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.PasswordChar = '*';
            this.passWordTextBox.Size = new System.Drawing.Size(308, 29);
            this.passWordTextBox.TabIndex = 1;
            this.passWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passWordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTxt_KeyPress);
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordGroupBox.Location = new System.Drawing.Point(39, 102);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(328, 65);
            this.passwordGroupBox.TabIndex = 4;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.usernameGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triple JP Lending System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.GroupBox usernameGroupBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Button logInButton;
    }
}


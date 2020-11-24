
namespace HomeAssignment
{
    partial class Login
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.lnklblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.lnklblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(89, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 30);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(89, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(358, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(240, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 32);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.AccessibleDescription = "btnClose";
            this.btnPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPassword.Location = new System.Drawing.Point(89, 164);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(106, 32);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Close";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // lnklblCreateAccount
            // 
            this.lnklblCreateAccount.AutoSize = true;
            this.lnklblCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnklblCreateAccount.Location = new System.Drawing.Point(276, 216);
            this.lnklblCreateAccount.Name = "lnklblCreateAccount";
            this.lnklblCreateAccount.Size = new System.Drawing.Size(70, 23);
            this.lnklblCreateAccount.TabIndex = 4;
            this.lnklblCreateAccount.TabStop = true;
            this.lnklblCreateAccount.Text = "Sign Up";
            // 
            // lnklblForgotPassword
            // 
            this.lnklblForgotPassword.AutoSize = true;
            this.lnklblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnklblForgotPassword.Location = new System.Drawing.Point(90, 216);
            this.lnklblForgotPassword.Name = "lnklblForgotPassword";
            this.lnklblForgotPassword.Size = new System.Drawing.Size(135, 23);
            this.lnklblForgotPassword.TabIndex = 5;
            this.lnklblForgotPassword.TabStop = true;
            this.lnklblForgotPassword.Text = "Forgot Password";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResults.Location = new System.Drawing.Point(87, 27);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 20);
            this.lblResults.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 269);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lnklblForgotPassword);
            this.Controls.Add(this.lnklblCreateAccount);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.LinkLabel lnklblCreateAccount;
        private System.Windows.Forms.LinkLabel lnklblForgotPassword;
        private System.Windows.Forms.Label lblResults;
    }
}
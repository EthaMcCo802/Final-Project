namespace Final_Project
{
    partial class LoginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.associateCreateButton = new System.Windows.Forms.Button();
            this.associateLoginButton = new System.Windows.Forms.Button();
            this.managerCreateButton = new System.Windows.Forms.Button();
            this.managerLoginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 800);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login or create an account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "PIN:";
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(374, 239);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(190, 34);
            this.userTextBox.TabIndex = 4;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox.Location = new System.Drawing.Point(374, 322);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(190, 34);
            this.pinTextBox.TabIndex = 5;
            // 
            // associateCreateButton
            // 
            this.associateCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associateCreateButton.Location = new System.Drawing.Point(202, 473);
            this.associateCreateButton.Name = "associateCreateButton";
            this.associateCreateButton.Size = new System.Drawing.Size(119, 80);
            this.associateCreateButton.TabIndex = 6;
            this.associateCreateButton.Text = "Create associate account";
            this.associateCreateButton.UseVisualStyleBackColor = true;
            this.associateCreateButton.Click += new System.EventHandler(this.associateCreateButton_Click);
            // 
            // associateLoginButton
            // 
            this.associateLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associateLoginButton.Location = new System.Drawing.Point(445, 473);
            this.associateLoginButton.Name = "associateLoginButton";
            this.associateLoginButton.Size = new System.Drawing.Size(119, 80);
            this.associateLoginButton.TabIndex = 7;
            this.associateLoginButton.Text = "Associate login";
            this.associateLoginButton.UseVisualStyleBackColor = true;
            // 
            // managerCreateButton
            // 
            this.managerCreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerCreateButton.Location = new System.Drawing.Point(202, 611);
            this.managerCreateButton.Name = "managerCreateButton";
            this.managerCreateButton.Size = new System.Drawing.Size(119, 80);
            this.managerCreateButton.TabIndex = 8;
            this.managerCreateButton.Text = "Create manager account";
            this.managerCreateButton.UseVisualStyleBackColor = true;
            this.managerCreateButton.Click += new System.EventHandler(this.managerCreateButton_Click);
            // 
            // managerLoginButton
            // 
            this.managerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLoginButton.Location = new System.Drawing.Point(445, 611);
            this.managerLoginButton.Name = "managerLoginButton";
            this.managerLoginButton.Size = new System.Drawing.Size(119, 80);
            this.managerLoginButton.TabIndex = 9;
            this.managerLoginButton.Text = "Manager login";
            this.managerLoginButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(210, 747);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Property of Ethan McComb Shopping Centre Inc. TM";
            // 
            // shutdownButton
            // 
            this.shutdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.Location = new System.Drawing.Point(626, 20);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(147, 50);
            this.shutdownButton.TabIndex = 11;
            this.shutdownButton.Text = "Shutdown";
            this.shutdownButton.UseVisualStyleBackColor = true;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shutdownButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.managerLoginButton);
            this.Controls.Add(this.managerCreateButton);
            this.Controls.Add(this.associateLoginButton);
            this.Controls.Add(this.associateCreateButton);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(798, 826);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Button associateCreateButton;
        private System.Windows.Forms.Button associateLoginButton;
        private System.Windows.Forms.Button managerCreateButton;
        private System.Windows.Forms.Button managerLoginButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button shutdownButton;
    }
}

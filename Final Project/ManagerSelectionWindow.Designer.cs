namespace Final_Project
{
    partial class ManagerSelectionWindow
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.warehouseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 800);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(653, 20);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(120, 50);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // priceButton
            // 
            this.priceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceButton.Location = new System.Drawing.Point(277, 219);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(222, 96);
            this.priceButton.TabIndex = 14;
            this.priceButton.Text = "Price management";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // warehouseButton
            // 
            this.warehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseButton.Location = new System.Drawing.Point(277, 434);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(222, 96);
            this.warehouseButton.TabIndex = 15;
            this.warehouseButton.Text = "Warehouse recievings";
            this.warehouseButton.UseVisualStyleBackColor = true;
            this.warehouseButton.Click += new System.EventHandler(this.warehouseButton_Click);
            // 
            // ManagerSelectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warehouseButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerSelectionWindow";
            this.Size = new System.Drawing.Size(798, 826);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button warehouseButton;
    }
}

namespace Final_Project
{
    partial class WarehouseRecievingsWindow
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
            this.searchButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.warehouseInventoryInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.warehouseInventoryOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(436, 303);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 50);
            this.searchButton.TabIndex = 51;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(212, 303);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(87, 50);
            this.buyButton.TabIndex = 50;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityInput.Location = new System.Drawing.Point(419, 226);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(65, 38);
            this.QuantityInput.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 48;
            this.label7.Text = "Quantity:";
            // 
            // warehouseInventoryInput
            // 
            this.warehouseInventoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseInventoryInput.Location = new System.Drawing.Point(419, 166);
            this.warehouseInventoryInput.Name = "warehouseInventoryInput";
            this.warehouseInventoryInput.Size = new System.Drawing.Size(238, 38);
            this.warehouseInventoryInput.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 32);
            this.label6.TabIndex = 46;
            this.label6.Text = "Warehouse inventory:";
            // 
            // warehouseInventoryOutput
            // 
            this.warehouseInventoryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseInventoryOutput.Location = new System.Drawing.Point(26, 469);
            this.warehouseInventoryOutput.Name = "warehouseInventoryOutput";
            this.warehouseInventoryOutput.Size = new System.Drawing.Size(742, 333);
            this.warehouseInventoryOutput.TabIndex = 45;
            this.warehouseInventoryOutput.Text = "Enter warehouse item name or number";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(742, 337);
            this.label3.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 43;
            this.label2.Text = "Manager";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(665, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 50);
            this.backButton.TabIndex = 42;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 800);
            this.label1.TabIndex = 41;
            // 
            // WarehouseRecievingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.warehouseInventoryInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warehouseInventoryOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseRecievingsWindow";
            this.Size = new System.Drawing.Size(798, 826);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox warehouseInventoryInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warehouseInventoryOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}

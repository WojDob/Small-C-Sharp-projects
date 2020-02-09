namespace PriceCalculator
{
    partial class ChooseComputerForm
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
            this.processorsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ssd240 = new System.Windows.Forms.RadioButton();
            this.sata500 = new System.Windows.Forms.RadioButton();
            this.sata1000 = new System.Windows.Forms.RadioButton();
            this.drivePriceTextBox = new System.Windows.Forms.TextBox();
            this.processorPriceTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processorsComboBox
            // 
            this.processorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processorsComboBox.FormattingEnabled = true;
            this.processorsComboBox.Location = new System.Drawing.Point(12, 51);
            this.processorsComboBox.Name = "processorsComboBox";
            this.processorsComboBox.Size = new System.Drawing.Size(238, 21);
            this.processorsComboBox.TabIndex = 0;
            this.processorsComboBox.SelectedIndexChanged += new System.EventHandler(this.processorsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(49, 268);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 4;
            // 
            // ssd240
            // 
            this.ssd240.AutoSize = true;
            this.ssd240.Checked = true;
            this.ssd240.Location = new System.Drawing.Point(15, 173);
            this.ssd240.Name = "ssd240";
            this.ssd240.Size = new System.Drawing.Size(86, 17);
            this.ssd240.TabIndex = 5;
            this.ssd240.TabStop = true;
            this.ssd240.Text = "240 GB SSD";
            this.ssd240.UseVisualStyleBackColor = true;
            this.ssd240.CheckedChanged += new System.EventHandler(this.ssd240_CheckedChanged);
            // 
            // sata500
            // 
            this.sata500.AutoSize = true;
            this.sata500.Location = new System.Drawing.Point(15, 196);
            this.sata500.Name = "sata500";
            this.sata500.Size = new System.Drawing.Size(92, 17);
            this.sata500.TabIndex = 6;
            this.sata500.Text = "500 GB SATA";
            this.sata500.UseVisualStyleBackColor = true;
            this.sata500.CheckedChanged += new System.EventHandler(this.sata500_CheckedChanged);
            // 
            // sata1000
            // 
            this.sata1000.AutoSize = true;
            this.sata1000.Location = new System.Drawing.Point(15, 219);
            this.sata1000.Name = "sata1000";
            this.sata1000.Size = new System.Drawing.Size(98, 17);
            this.sata1000.TabIndex = 7;
            this.sata1000.Text = "1000 GB SATA";
            this.sata1000.UseVisualStyleBackColor = true;
            this.sata1000.CheckedChanged += new System.EventHandler(this.sata1000_CheckedChanged);
            // 
            // drivePriceTextBox
            // 
            this.drivePriceTextBox.Location = new System.Drawing.Point(49, 138);
            this.drivePriceTextBox.Name = "drivePriceTextBox";
            this.drivePriceTextBox.ReadOnly = true;
            this.drivePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.drivePriceTextBox.TabIndex = 8;
            // 
            // processorPriceTextBox
            // 
            this.processorPriceTextBox.Location = new System.Drawing.Point(72, 15);
            this.processorPriceTextBox.Name = "processorPriceTextBox";
            this.processorPriceTextBox.ReadOnly = true;
            this.processorPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.processorPriceTextBox.TabIndex = 9;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(12, 331);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(178, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ChooseComputerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 361);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.processorPriceTextBox);
            this.Controls.Add(this.drivePriceTextBox);
            this.Controls.Add(this.sata1000);
            this.Controls.Add(this.sata500);
            this.Controls.Add(this.ssd240);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processorsComboBox);
            this.Name = "ChooseComputerForm";
            this.Text = "ChooseComputerForm";
            
            this.Load += new System.EventHandler(this.ChooseComputerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processorsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.RadioButton ssd240;
        private System.Windows.Forms.RadioButton sata500;
        private System.Windows.Forms.RadioButton sata1000;
        private System.Windows.Forms.TextBox drivePriceTextBox;
        private System.Windows.Forms.TextBox processorPriceTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
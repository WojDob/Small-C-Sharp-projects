namespace Histogram
{
    partial class MainForm
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
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.showTableButton = new System.Windows.Forms.Button();
            this.makeBarChartButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(12, 12);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(367, 51);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // showTableButton
            // 
            this.showTableButton.Location = new System.Drawing.Point(12, 97);
            this.showTableButton.Name = "showTableButton";
            this.showTableButton.Size = new System.Drawing.Size(367, 51);
            this.showTableButton.TabIndex = 1;
            this.showTableButton.Text = "Show table";
            this.showTableButton.UseVisualStyleBackColor = true;
            this.showTableButton.Click += new System.EventHandler(this.showTableButton_Click);
            // 
            // makeBarChartButton
            // 
            this.makeBarChartButton.Location = new System.Drawing.Point(12, 154);
            this.makeBarChartButton.Name = "makeBarChartButton";
            this.makeBarChartButton.Size = new System.Drawing.Size(367, 51);
            this.makeBarChartButton.TabIndex = 2;
            this.makeBarChartButton.Text = "Make bar chart";
            this.makeBarChartButton.UseVisualStyleBackColor = true;
            this.makeBarChartButton.Click += new System.EventHandler(this.makeBarChartButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(367, 22);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 214);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.makeBarChartButton);
            this.Controls.Add(this.showTableButton);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Button showTableButton;
        private System.Windows.Forms.Button makeBarChartButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


namespace PriceCalculator
{
    partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceTextBoxMain = new System.Windows.Forms.TextBox();
            this.chooseMonitorButton = new System.Windows.Forms.Button();
            this.chooseComputerButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editMonitorsButton = new System.Windows.Forms.Button();
            this.editProcessorsButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 173);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.totalPriceTextBoxMain);
            this.tabPage1.Controls.Add(this.chooseMonitorButton);
            this.tabPage1.Controls.Add(this.chooseComputerButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prices";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total price:";
            // 
            // totalPriceTextBoxMain
            // 
            this.totalPriceTextBoxMain.Location = new System.Drawing.Point(326, 68);
            this.totalPriceTextBoxMain.Name = "totalPriceTextBoxMain";
            this.totalPriceTextBoxMain.ReadOnly = true;
            this.totalPriceTextBoxMain.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTextBoxMain.TabIndex = 2;
            // 
            // chooseMonitorButton
            // 
            this.chooseMonitorButton.Location = new System.Drawing.Point(167, 48);
            this.chooseMonitorButton.Name = "chooseMonitorButton";
            this.chooseMonitorButton.Size = new System.Drawing.Size(119, 59);
            this.chooseMonitorButton.TabIndex = 1;
            this.chooseMonitorButton.Text = "Choose monitor";
            this.chooseMonitorButton.UseVisualStyleBackColor = true;
            this.chooseMonitorButton.Click += new System.EventHandler(this.chooseMonitorButton_Click);
            // 
            // chooseComputerButton
            // 
            this.chooseComputerButton.Location = new System.Drawing.Point(22, 48);
            this.chooseComputerButton.Name = "chooseComputerButton";
            this.chooseComputerButton.Size = new System.Drawing.Size(119, 59);
            this.chooseComputerButton.TabIndex = 0;
            this.chooseComputerButton.Text = "Choose computer";
            this.chooseComputerButton.UseVisualStyleBackColor = true;
            this.chooseComputerButton.Click += new System.EventHandler(this.chooseComputerButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.editMonitorsButton);
            this.tabPage2.Controls.Add(this.editProcessorsButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 147);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // editMonitorsButton
            // 
            this.editMonitorsButton.Location = new System.Drawing.Point(264, 35);
            this.editMonitorsButton.Name = "editMonitorsButton";
            this.editMonitorsButton.Size = new System.Drawing.Size(165, 80);
            this.editMonitorsButton.TabIndex = 1;
            this.editMonitorsButton.Text = "Edit monitors";
            this.editMonitorsButton.UseVisualStyleBackColor = true;
            this.editMonitorsButton.Click += new System.EventHandler(this.editMonitorsButton_Click);
            // 
            // editProcessorsButton
            // 
            this.editProcessorsButton.Location = new System.Drawing.Point(25, 35);
            this.editProcessorsButton.Name = "editProcessorsButton";
            this.editProcessorsButton.Size = new System.Drawing.Size(165, 80);
            this.editProcessorsButton.TabIndex = 0;
            this.editProcessorsButton.Text = "Edit processors";
            this.editProcessorsButton.UseVisualStyleBackColor = true;
            this.editProcessorsButton.Click += new System.EventHandler(this.editProcessorsButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 172);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseMonitorButton;
        private System.Windows.Forms.Button chooseComputerButton;
        private System.Windows.Forms.Button editMonitorsButton;
        private System.Windows.Forms.Button editProcessorsButton;
        public System.Windows.Forms.TextBox totalPriceTextBoxMain;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace Airports
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.miejBox = new System.Windows.Forms.CheckBox();
            this.wojBox = new System.Windows.Forms.CheckBox();
            this.iataBox = new System.Windows.Forms.CheckBox();
            this.dlugBox = new System.Windows.Forms.CheckBox();
            this.nsBox = new System.Windows.Forms.CheckBox();
            this.ewBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 454);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // miejBox
            // 
            this.miejBox.AutoSize = true;
            this.miejBox.Location = new System.Drawing.Point(381, 12);
            this.miejBox.Name = "miejBox";
            this.miejBox.Size = new System.Drawing.Size(108, 21);
            this.miejBox.TabIndex = 1;
            this.miejBox.Text = "Miejscowosc";
            this.miejBox.UseVisualStyleBackColor = true;
            // 
            // wojBox
            // 
            this.wojBox.AutoSize = true;
            this.wojBox.Location = new System.Drawing.Point(381, 39);
            this.wojBox.Name = "wojBox";
            this.wojBox.Size = new System.Drawing.Size(115, 21);
            this.wojBox.TabIndex = 2;
            this.wojBox.Text = "Wojewodztwo";
            this.wojBox.UseVisualStyleBackColor = true;
            // 
            // iataBox
            // 
            this.iataBox.AutoSize = true;
            this.iataBox.Location = new System.Drawing.Point(381, 66);
            this.iataBox.Name = "iataBox";
            this.iataBox.Size = new System.Drawing.Size(60, 21);
            this.iataBox.TabIndex = 3;
            this.iataBox.Text = "IATA";
            this.iataBox.UseVisualStyleBackColor = true;
            // 
            // dlugBox
            // 
            this.dlugBox.AutoSize = true;
            this.dlugBox.Location = new System.Drawing.Point(380, 93);
            this.dlugBox.Name = "dlugBox";
            this.dlugBox.Size = new System.Drawing.Size(116, 21);
            this.dlugBox.TabIndex = 4;
            this.dlugBox.Text = "Dlugosc pasa";
            this.dlugBox.UseVisualStyleBackColor = true;
            // 
            // nsBox
            // 
            this.nsBox.AutoSize = true;
            this.nsBox.Location = new System.Drawing.Point(380, 120);
            this.nsBox.Name = "nsBox";
            this.nsBox.Size = new System.Drawing.Size(53, 21);
            this.nsBox.TabIndex = 5;
            this.nsBox.Text = "N/S";
            this.nsBox.UseVisualStyleBackColor = true;
            // 
            // ewBox
            // 
            this.ewBox.AutoSize = true;
            this.ewBox.Location = new System.Drawing.Point(381, 147);
            this.ewBox.Name = "ewBox";
            this.ewBox.Size = new System.Drawing.Size(56, 21);
            this.ewBox.TabIndex = 6;
            this.ewBox.Text = "E/W";
            this.ewBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Informacje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ewBox);
            this.Controls.Add(this.nsBox);
            this.Controls.Add(this.dlugBox);
            this.Controls.Add(this.iataBox);
            this.Controls.Add(this.wojBox);
            this.Controls.Add(this.miejBox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox miejBox;
        private System.Windows.Forms.CheckBox wojBox;
        private System.Windows.Forms.CheckBox iataBox;
        private System.Windows.Forms.CheckBox dlugBox;
        private System.Windows.Forms.CheckBox nsBox;
        private System.Windows.Forms.CheckBox ewBox;
        private System.Windows.Forms.Button button1;
    }
}


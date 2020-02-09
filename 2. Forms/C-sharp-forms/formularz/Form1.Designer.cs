namespace formularz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.mRadioButton = new System.Windows.Forms.RadioButton();
            this.kRadioButton = new System.Windows.Forms.RadioButton();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.goToStart = new System.Windows.Forms.Button();
            this.goToEnd = new System.Windows.Forms.Button();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wzrost";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(144, 38);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(137, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(144, 84);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(137, 20);
            this.surnameBox.TabIndex = 5;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(144, 125);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(137, 20);
            this.dateBox.TabIndex = 6;
            this.dateBox.TextChanged += new System.EventHandler(this.dateBox_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(144, 167);
            this.heightBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(136, 20);
            this.heightBox.TabIndex = 7;
            this.heightBox.TextChanged += new System.EventHandler(this.heightBox_TextChanged);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(9, 241);
            this.prevButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(49, 45);
            this.prevButton.TabIndex = 8;
            this.prevButton.Text = " <";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(76, 241);
            this.newButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(87, 45);
            this.newButton.TabIndex = 9;
            this.newButton.Text = "Nowy";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(176, 241);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 45);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(295, 241);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 45);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(411, 241);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 45);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Zapis";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(528, 241);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(55, 45);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // mRadioButton
            // 
            this.mRadioButton.AutoSize = true;
            this.mRadioButton.Location = new System.Drawing.Point(347, 39);
            this.mRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mRadioButton.Name = "mRadioButton";
            this.mRadioButton.Size = new System.Drawing.Size(34, 17);
            this.mRadioButton.TabIndex = 14;
            this.mRadioButton.TabStop = true;
            this.mRadioButton.Text = "M";
            this.mRadioButton.UseVisualStyleBackColor = true;
            this.mRadioButton.CheckedChanged += new System.EventHandler(this.mRadioButton_CheckedChanged);
            // 
            // kRadioButton
            // 
            this.kRadioButton.AutoSize = true;
            this.kRadioButton.Location = new System.Drawing.Point(347, 84);
            this.kRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kRadioButton.Name = "kRadioButton";
            this.kRadioButton.Size = new System.Drawing.Size(32, 17);
            this.kRadioButton.TabIndex = 15;
            this.kRadioButton.TabStop = true;
            this.kRadioButton.Text = "K";
            this.kRadioButton.UseVisualStyleBackColor = true;
            this.kRadioButton.CheckedChanged += new System.EventHandler(this.kRadioButton_CheckedChanged);
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Prezes",
            "Manager",
            "Pracownik szeregowy",
            "Stażysta"});
            this.positionComboBox.Location = new System.Drawing.Point(347, 168);
            this.positionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(174, 21);
            this.positionComboBox.TabIndex = 16;
            this.positionComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stanowisko";
            // 
            // goToStart
            // 
            this.goToStart.Location = new System.Drawing.Point(9, 291);
            this.goToStart.Name = "goToStart";
            this.goToStart.Size = new System.Drawing.Size(49, 41);
            this.goToStart.TabIndex = 18;
            this.goToStart.Text = "<<";
            this.goToStart.UseVisualStyleBackColor = true;
            this.goToStart.Click += new System.EventHandler(this.goToStart_Click);
            // 
            // goToEnd
            // 
            this.goToEnd.Location = new System.Drawing.Point(528, 291);
            this.goToEnd.Name = "goToEnd";
            this.goToEnd.Size = new System.Drawing.Size(55, 41);
            this.goToEnd.TabIndex = 19;
            this.goToEnd.Text = ">>";
            this.goToEnd.UseVisualStyleBackColor = true;
            this.goToEnd.Click += new System.EventHandler(this.goToEnd_Click);
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(144, 202);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(136, 20);
            this.salaryBox.TabIndex = 20;
            this.salaryBox.TextChanged += new System.EventHandler(this.salaryBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Wynagrodzenie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.goToEnd);
            this.Controls.Add(this.goToStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.kRadioButton);
            this.Controls.Add(this.mRadioButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.RadioButton mRadioButton;
        private System.Windows.Forms.RadioButton kRadioButton;
        private System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button goToStart;
        private System.Windows.Forms.Button goToEnd;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label6;
    }
}


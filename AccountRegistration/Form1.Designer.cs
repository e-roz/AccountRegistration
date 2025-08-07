namespace AccountRegistration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            label6 = new Label();
            contactNumberTxtBox = new TextBox();
            panel6 = new Panel();
            label5 = new Label();
            ageTxtBox = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            middleNameTxtBox = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            firstNameTxtBox = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            lastNameTxtBox = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            studentNumTxtBox = new TextBox();
            programComboBox = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            addressTxtBox = new TextBox();
            nextBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel7, 1, 2);
            tableLayoutPanel1.Controls.Add(panel6, 0, 2);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(589, 193);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Controls.Add(contactNumberTxtBox);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(297, 131);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 59);
            panel7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(103, 18);
            label6.TabIndex = 2;
            label6.Text = "Contact Number:";
            // 
            // contactNumberTxtBox
            // 
            contactNumberTxtBox.Anchor = AnchorStyles.None;
            contactNumberTxtBox.Location = new Point(3, 22);
            contactNumberTxtBox.Name = "contactNumberTxtBox";
            contactNumberTxtBox.Size = new Size(282, 23);
            contactNumberTxtBox.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(ageTxtBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 131);
            panel6.Name = "panel6";
            panel6.Size = new Size(288, 59);
            panel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 3);
            label5.Name = "label5";
            label5.Size = new Size(37, 18);
            label5.TabIndex = 2;
            label5.Text = "Age :";
            // 
            // ageTxtBox
            // 
            ageTxtBox.Anchor = AnchorStyles.None;
            ageTxtBox.Location = new Point(3, 22);
            ageTxtBox.Name = "ageTxtBox";
            ageTxtBox.Size = new Size(282, 23);
            ageTxtBox.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(middleNameTxtBox);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(297, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 58);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 1);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 2;
            label4.Text = "Middle Name:";
            // 
            // middleNameTxtBox
            // 
            middleNameTxtBox.Anchor = AnchorStyles.None;
            middleNameTxtBox.Location = new Point(3, 22);
            middleNameTxtBox.Name = "middleNameTxtBox";
            middleNameTxtBox.Size = new Size(282, 23);
            middleNameTxtBox.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(firstNameTxtBox);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 58);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Anchor = AnchorStyles.None;
            firstNameTxtBox.Location = new Point(3, 22);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(282, 23);
            firstNameTxtBox.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lastNameTxtBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(297, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 58);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Anchor = AnchorStyles.None;
            lastNameTxtBox.Location = new Point(3, 23);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(282, 23);
            lastNameTxtBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(studentNumTxtBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 58);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 4);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 1;
            label1.Text = "Student No.:";
            // 
            // studentNumTxtBox
            // 
            studentNumTxtBox.Anchor = AnchorStyles.None;
            studentNumTxtBox.Location = new Point(4, 23);
            studentNumTxtBox.Name = "studentNumTxtBox";
            studentNumTxtBox.Size = new Size(282, 23);
            studentNumTxtBox.TabIndex = 0;
            // 
            // programComboBox
            // 
            programComboBox.FormattingEnabled = true;
            programComboBox.Location = new Point(78, 25);
            programComboBox.Name = "programComboBox";
            programComboBox.Size = new Size(430, 23);
            programComboBox.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(addressTxtBox);
            panel1.Controls.Add(programComboBox);
            panel1.Location = new Point(12, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 184);
            panel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(78, 61);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 4;
            label8.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(80, 5);
            label7.Name = "label7";
            label7.Size = new Size(54, 18);
            label7.TabIndex = 3;
            label7.Text = "Program";
            // 
            // addressTxtBox
            // 
            addressTxtBox.Location = new Point(78, 82);
            addressTxtBox.Multiline = true;
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(430, 81);
            addressTxtBox.TabIndex = 2;
            // 
            // nextBtn
            // 
            nextBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBtn.Location = new Point(263, 455);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(86, 30);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "NEXT";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 558);
            Controls.Add(nextBtn);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmRegistration";
            Text = "FormRegistration";
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox programComboBox;
        private TextBox studentNumTxtBox;
        private Panel panel1;
        private TextBox addressTxtBox;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private TextBox contactNumberTxtBox;
        private Label label5;
        private TextBox ageTxtBox;
        private Label label4;
        private TextBox middleNameTxtBox;
        private Label label3;
        private TextBox firstNameTxtBox;
        private Label label2;
        private TextBox lastNameTxtBox;
        private Label label1;
        private Button nextBtn;
        private Label label6;
        private Label label8;
        private Label label7;
    }
}

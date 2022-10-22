namespace Group9_Project
{
    partial class Create
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRemind = new System.Windows.Forms.TextBox();
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboImportant = new System.Windows.Forms.ComboBox();
            this.comboRepeat = new System.Windows.Forms.ComboBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deadline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Important: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remind: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repeat: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(182, 84);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(404, 69);
            this.txtTitle.TabIndex = 7;
            // 
            // txtRemind
            // 
            this.txtRemind.Location = new System.Drawing.Point(182, 341);
            this.txtRemind.Name = "txtRemind";
            this.txtRemind.Size = new System.Drawing.Size(250, 27);
            this.txtRemind.TabIndex = 10;
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.Location = new System.Drawing.Point(182, 240);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(250, 27);
            this.dateTimeDeadline.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(29, 432);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 39);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(424, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboImportant
            // 
            this.comboImportant.FormattingEnabled = true;
            this.comboImportant.Location = new System.Drawing.Point(182, 290);
            this.comboImportant.Name = "comboImportant";
            this.comboImportant.Size = new System.Drawing.Size(250, 28);
            this.comboImportant.TabIndex = 15;
            // 
            // comboRepeat
            // 
            this.comboRepeat.FormattingEnabled = true;
            this.comboRepeat.Items.AddRange(new object[] {
            "No",
            "Every Day",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboRepeat.Location = new System.Drawing.Point(182, 386);
            this.comboRepeat.Name = "comboRepeat";
            this.comboRepeat.Size = new System.Drawing.Size(250, 28);
            this.comboRepeat.TabIndex = 16;
            this.comboRepeat.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(438, 181);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(148, 27);
            this.txtCategory.TabIndex = 18;
            this.txtCategory.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(182, 181);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(250, 28);
            this.comboCategory.TabIndex = 19;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 483);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboRepeat);
            this.Controls.Add(this.comboImportant);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dateTimeDeadline);
            this.Controls.Add(this.txtRemind);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Create";
            this.Text = "Create";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtTitle;
        private TextBox txtRemind;
        private DateTimePicker dateTimeDeadline;
        private Button btnCreate;
        private Button btnExit;
        private ComboBox comboImportant;
        private ComboBox comboRepeat;
        private TextBox txtCategory;
        private Label label7;
        private ComboBox comboCategory;
    }
}
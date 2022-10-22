namespace Group9_Project
{
    partial class Detail
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
            this.txtRepeat = new System.Windows.Forms.ComboBox();
            this.comboImportant = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateTimeDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtRemind = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRepeat
            // 
            this.txtRepeat.FormattingEnabled = true;
            this.txtRepeat.Items.AddRange(new object[] {
            "No",
            "Every Day",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.txtRepeat.Location = new System.Drawing.Point(205, 409);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(250, 28);
            this.txtRepeat.TabIndex = 30;
            // 
            // comboImportant
            // 
            this.comboImportant.FormattingEnabled = true;
            this.comboImportant.Location = new System.Drawing.Point(205, 313);
            this.comboImportant.Name = "comboImportant";
            this.comboImportant.Size = new System.Drawing.Size(250, 28);
            this.comboImportant.TabIndex = 29;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(447, 455);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 39);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(52, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 39);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeDeadline
            // 
            this.dateTimeDeadline.Location = new System.Drawing.Point(205, 263);
            this.dateTimeDeadline.Name = "dateTimeDeadline";
            this.dateTimeDeadline.Size = new System.Drawing.Size(250, 27);
            this.dateTimeDeadline.TabIndex = 26;
            // 
            // txtRemind
            // 
            this.txtRemind.Location = new System.Drawing.Point(205, 364);
            this.txtRemind.Name = "txtRemind";
            this.txtRemind.Size = new System.Drawing.Size(250, 27);
            this.txtRemind.TabIndex = 25;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(205, 116);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(404, 69);
            this.txtTitle.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(205, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 27);
            this.txtName.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(52, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Repeat: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Remind: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Important: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Deadline:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Title: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name: ";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(251, 455);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(162, 39);
            this.btnFinish.TabIndex = 31;
            this.btnFinish.Text = "Finished";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(205, 212);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(250, 28);
            this.comboCategory.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(52, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Category: ";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 509);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.comboImportant);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "Detail";
            this.Text = "Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox txtRepeat;
        private ComboBox comboImportant;
        private Button btnHome;
        private Button btnUpdate;
        private DateTimePicker dateTimeDeadline;
        private TextBox txtRemind;
        private TextBox txtTitle;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnFinish;
        private ComboBox comboCategory;
        private Label label7;
    }
}
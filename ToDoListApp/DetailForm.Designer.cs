namespace Group9_Project
{
    partial class DetailForm
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
            this.comboImportant = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupRepeat = new System.Windows.Forms.GroupBox();
            this.Sa = new System.Windows.Forms.CheckBox();
            this.Fr = new System.Windows.Forms.CheckBox();
            this.Th = new System.Windows.Forms.CheckBox();
            this.We = new System.Windows.Forms.CheckBox();
            this.Tu = new System.Windows.Forms.CheckBox();
            this.Mo = new System.Windows.Forms.CheckBox();
            this.Su = new System.Windows.Forms.CheckBox();
            this.comboTypeRepeat = new System.Windows.Forms.ComboBox();
            this.txtRepeatCount = new System.Windows.Forms.TextBox();
            this.timeRemind = new System.Windows.Forms.DateTimePicker();
            this.timeDueDate = new System.Windows.Forms.DateTimePicker();
            this.dateRemind = new System.Windows.Forms.DateTimePicker();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupRepeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboImportant
            // 
            this.comboImportant.FormattingEnabled = true;
            this.comboImportant.Location = new System.Drawing.Point(205, 269);
            this.comboImportant.Name = "comboImportant";
            this.comboImportant.Size = new System.Drawing.Size(250, 28);
            this.comboImportant.TabIndex = 29;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(447, 604);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(162, 39);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(52, 604);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 39);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(205, 116);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(404, 69);
            this.txtDes.TabIndex = 24;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(205, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(404, 27);
            this.txtTitle.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(52, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Repeat: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(52, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Group: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title: ";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(251, 604);
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
            // groupRepeat
            // 
            this.groupRepeat.Controls.Add(this.Sa);
            this.groupRepeat.Controls.Add(this.Fr);
            this.groupRepeat.Controls.Add(this.Th);
            this.groupRepeat.Controls.Add(this.We);
            this.groupRepeat.Controls.Add(this.Tu);
            this.groupRepeat.Controls.Add(this.Mo);
            this.groupRepeat.Controls.Add(this.Su);
            this.groupRepeat.Controls.Add(this.comboTypeRepeat);
            this.groupRepeat.Controls.Add(this.txtRepeatCount);
            this.groupRepeat.Location = new System.Drawing.Point(205, 457);
            this.groupRepeat.Name = "groupRepeat";
            this.groupRepeat.Size = new System.Drawing.Size(250, 131);
            this.groupRepeat.TabIndex = 34;
            this.groupRepeat.TabStop = false;
            this.groupRepeat.Text = "Repeat Every ...";
            // 
            // Sa
            // 
            this.Sa.Appearance = System.Windows.Forms.Appearance.Button;
            this.Sa.AutoSize = true;
            this.Sa.Location = new System.Drawing.Point(43, 95);
            this.Sa.Name = "Sa";
            this.Sa.Size = new System.Drawing.Size(35, 30);
            this.Sa.TabIndex = 8;
            this.Sa.Text = "Sa";
            this.Sa.UseVisualStyleBackColor = true;
            // 
            // Fr
            // 
            this.Fr.Appearance = System.Windows.Forms.Appearance.Button;
            this.Fr.AutoSize = true;
            this.Fr.Location = new System.Drawing.Point(6, 95);
            this.Fr.Name = "Fr";
            this.Fr.Size = new System.Drawing.Size(31, 30);
            this.Fr.TabIndex = 7;
            this.Fr.Text = "Fr";
            this.Fr.UseVisualStyleBackColor = true;
            // 
            // Th
            // 
            this.Th.Appearance = System.Windows.Forms.Appearance.Button;
            this.Th.AutoSize = true;
            this.Th.Location = new System.Drawing.Point(177, 59);
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(35, 30);
            this.Th.TabIndex = 6;
            this.Th.Text = "Th";
            this.Th.UseVisualStyleBackColor = true;
            // 
            // We
            // 
            this.We.Appearance = System.Windows.Forms.Appearance.Button;
            this.We.AutoSize = true;
            this.We.Location = new System.Drawing.Point(131, 60);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(40, 30);
            this.We.TabIndex = 5;
            this.We.Text = "We";
            this.We.UseVisualStyleBackColor = true;
            // 
            // Tu
            // 
            this.Tu.Appearance = System.Windows.Forms.Appearance.Button;
            this.Tu.AutoSize = true;
            this.Tu.Location = new System.Drawing.Point(90, 60);
            this.Tu.Name = "Tu";
            this.Tu.Size = new System.Drawing.Size(35, 30);
            this.Tu.TabIndex = 4;
            this.Tu.Text = "Tu";
            this.Tu.UseVisualStyleBackColor = true;
            // 
            // Mo
            // 
            this.Mo.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mo.AutoSize = true;
            this.Mo.Location = new System.Drawing.Point(43, 59);
            this.Mo.Name = "Mo";
            this.Mo.Size = new System.Drawing.Size(41, 30);
            this.Mo.TabIndex = 3;
            this.Mo.Text = "Mo";
            this.Mo.UseVisualStyleBackColor = true;
            // 
            // Su
            // 
            this.Su.Appearance = System.Windows.Forms.Appearance.Button;
            this.Su.AutoSize = true;
            this.Su.Location = new System.Drawing.Point(6, 59);
            this.Su.Name = "Su";
            this.Su.Size = new System.Drawing.Size(35, 30);
            this.Su.TabIndex = 2;
            this.Su.Text = "Su";
            this.Su.UseVisualStyleBackColor = true;
            // 
            // comboTypeRepeat
            // 
            this.comboTypeRepeat.FormattingEnabled = true;
            this.comboTypeRepeat.Location = new System.Drawing.Point(67, 26);
            this.comboTypeRepeat.Name = "comboTypeRepeat";
            this.comboTypeRepeat.Size = new System.Drawing.Size(177, 28);
            this.comboTypeRepeat.TabIndex = 1;
            this.comboTypeRepeat.SelectedIndexChanged += new System.EventHandler(this.comboTypeRepeat_SelectedIndexChanged);
            // 
            // txtRepeatCount
            // 
            this.txtRepeatCount.Location = new System.Drawing.Point(6, 26);
            this.txtRepeatCount.Name = "txtRepeatCount";
            this.txtRepeatCount.Size = new System.Drawing.Size(55, 27);
            this.txtRepeatCount.TabIndex = 0;
            // 
            // timeRemind
            // 
            this.timeRemind.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeRemind.Location = new System.Drawing.Point(462, 386);
            this.timeRemind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeRemind.Name = "timeRemind";
            this.timeRemind.ShowUpDown = true;
            this.timeRemind.Size = new System.Drawing.Size(92, 27);
            this.timeRemind.TabIndex = 40;
            // 
            // timeDueDate
            // 
            this.timeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDueDate.Location = new System.Drawing.Point(462, 327);
            this.timeDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeDueDate.Name = "timeDueDate";
            this.timeDueDate.ShowUpDown = true;
            this.timeDueDate.Size = new System.Drawing.Size(92, 27);
            this.timeDueDate.TabIndex = 38;
            // 
            // dateRemind
            // 
            this.dateRemind.Location = new System.Drawing.Point(205, 386);
            this.dateRemind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateRemind.Name = "dateRemind";
            this.dateRemind.Size = new System.Drawing.Size(250, 27);
            this.dateRemind.TabIndex = 39;
            // 
            // dateDueDate
            // 
            this.dateDueDate.Location = new System.Drawing.Point(205, 327);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(250, 27);
            this.dateDueDate.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Due Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(52, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Remind: ";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 666);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeRemind);
            this.Controls.Add(this.timeDueDate);
            this.Controls.Add(this.dateRemind);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.groupRepeat);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.comboImportant);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.groupRepeat.ResumeLayout(false);
            this.groupRepeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboImportant;
        private Button btnHome;
        private Button btnUpdate;
        private TextBox txtDes;
        private TextBox txtTitle;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnFinish;
        private ComboBox comboCategory;
        private Label label7;
        private GroupBox groupRepeat;
        private CheckBox Su;
        private ComboBox comboTypeRepeat;
        private TextBox txtRepeatCount;
        private CheckBox Sa;
        private CheckBox Fr;
        private CheckBox Th;
        private CheckBox We;
        private CheckBox Tu;
        private CheckBox Mo;
        private DateTimePicker timeRemind;
        private DateTimePicker timeDueDate;
        private DateTimePicker dateRemind;
        private DateTimePicker dateDueDate;
        private Label label3;
        private Label label5;
    }
}
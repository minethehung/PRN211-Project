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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbDueDate = new System.Windows.Forms.Label();
            this.lbRemind = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dateRemind = new System.Windows.Forms.DateTimePicker();
            this.timeDueDate = new System.Windows.Forms.DateTimePicker();
            this.timeRemind = new System.Windows.Forms.DateTimePicker();
            this.lbGroup = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.groupRepeat = new System.Windows.Forms.GroupBox();
            this.ckbSa = new System.Windows.Forms.CheckBox();
            this.ckbFr = new System.Windows.Forms.CheckBox();
            this.ckbTh = new System.Windows.Forms.CheckBox();
            this.ckbWe = new System.Windows.Forms.CheckBox();
            this.ckbTu = new System.Windows.Forms.CheckBox();
            this.ckbMo = new System.Windows.Forms.CheckBox();
            this.ckbSu = new System.Windows.Forms.CheckBox();
            this.cboRepeatType = new System.Windows.Forms.ComboBox();
            this.txtRepeatCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupRepeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(29, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(63, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.Location = new System.Drawing.Point(29, 96);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(136, 31);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "Description:";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDueDate.Location = new System.Drawing.Point(29, 395);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(112, 31);
            this.lbDueDate.TabIndex = 2;
            this.lbDueDate.Text = "Due date:";
            // 
            // lbRemind
            // 
            this.lbRemind.AutoSize = true;
            this.lbRemind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRemind.Location = new System.Drawing.Point(29, 459);
            this.lbRemind.Name = "lbRemind";
            this.lbRemind.Size = new System.Drawing.Size(103, 31);
            this.lbRemind.TabIndex = 4;
            this.lbRemind.Text = "Remind: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(159, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(404, 27);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 99);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(404, 135);
            this.txtDescription.TabIndex = 1;
            // 
            // dateDueDate
            // 
            this.dateDueDate.Location = new System.Drawing.Point(159, 397);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(250, 27);
            this.dateDueDate.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(29, 689);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(162, 39);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(401, 689);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 39);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.Location = new System.Drawing.Point(29, 263);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(117, 31);
            this.lbCategory.TabIndex = 17;
            this.lbCategory.Text = "Category: ";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ItemHeight = 20;
            this.cboCategory.Location = new System.Drawing.Point(159, 269);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 28);
            this.cboCategory.TabIndex = 2;
            // 
            // dateRemind
            // 
            this.dateRemind.Location = new System.Drawing.Point(159, 461);
            this.dateRemind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateRemind.Name = "dateRemind";
            this.dateRemind.Size = new System.Drawing.Size(250, 27);
            this.dateRemind.TabIndex = 6;
            // 
            // timeDueDate
            // 
            this.timeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDueDate.Location = new System.Drawing.Point(416, 397);
            this.timeDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeDueDate.Name = "timeDueDate";
            this.timeDueDate.ShowUpDown = true;
            this.timeDueDate.Size = new System.Drawing.Size(92, 27);
            this.timeDueDate.TabIndex = 5;
            // 
            // timeRemind
            // 
            this.timeRemind.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeRemind.Location = new System.Drawing.Point(416, 461);
            this.timeRemind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timeRemind.Name = "timeRemind";
            this.timeRemind.ShowUpDown = true;
            this.timeRemind.Size = new System.Drawing.Size(92, 27);
            this.timeRemind.TabIndex = 7;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGroup.Location = new System.Drawing.Point(29, 327);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(83, 31);
            this.lbGroup.TabIndex = 17;
            this.lbGroup.Text = "Group:";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.ItemHeight = 20;
            this.cboGroup.Location = new System.Drawing.Point(159, 333);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(250, 28);
            this.cboGroup.TabIndex = 3;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.cboGroup_SelectedIndexChanged);
            // 
            // groupRepeat
            // 
            this.groupRepeat.Controls.Add(this.ckbSa);
            this.groupRepeat.Controls.Add(this.ckbFr);
            this.groupRepeat.Controls.Add(this.ckbTh);
            this.groupRepeat.Controls.Add(this.ckbWe);
            this.groupRepeat.Controls.Add(this.ckbTu);
            this.groupRepeat.Controls.Add(this.ckbMo);
            this.groupRepeat.Controls.Add(this.ckbSu);
            this.groupRepeat.Controls.Add(this.cboRepeatType);
            this.groupRepeat.Controls.Add(this.txtRepeatCount);
            this.groupRepeat.Location = new System.Drawing.Point(159, 528);
            this.groupRepeat.Name = "groupRepeat";
            this.groupRepeat.Size = new System.Drawing.Size(250, 131);
            this.groupRepeat.TabIndex = 36;
            this.groupRepeat.TabStop = false;
            this.groupRepeat.Text = "Every:";
            // 
            // ckbSa
            // 
            this.ckbSa.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbSa.AutoSize = true;
            this.ckbSa.Location = new System.Drawing.Point(43, 93);
            this.ckbSa.Name = "ckbSa";
            this.ckbSa.Size = new System.Drawing.Size(35, 30);
            this.ckbSa.TabIndex = 8;
            this.ckbSa.Text = "Sa";
            this.ckbSa.UseVisualStyleBackColor = true;
            this.ckbSa.CheckedChanged += new System.EventHandler(this.ckbSa_CheckedChanged);
            // 
            // ckbFr
            // 
            this.ckbFr.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbFr.AutoSize = true;
            this.ckbFr.Location = new System.Drawing.Point(6, 93);
            this.ckbFr.Name = "ckbFr";
            this.ckbFr.Size = new System.Drawing.Size(31, 30);
            this.ckbFr.TabIndex = 7;
            this.ckbFr.Text = "Fr";
            this.ckbFr.UseVisualStyleBackColor = true;
            this.ckbFr.CheckedChanged += new System.EventHandler(this.ckbFr_CheckedChanged);
            // 
            // ckbTh
            // 
            this.ckbTh.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTh.AutoSize = true;
            this.ckbTh.Location = new System.Drawing.Point(177, 57);
            this.ckbTh.Name = "ckbTh";
            this.ckbTh.Size = new System.Drawing.Size(35, 30);
            this.ckbTh.TabIndex = 6;
            this.ckbTh.Text = "Th";
            this.ckbTh.UseVisualStyleBackColor = true;
            this.ckbTh.CheckedChanged += new System.EventHandler(this.ckbTh_CheckedChanged);
            // 
            // ckbWe
            // 
            this.ckbWe.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbWe.AutoSize = true;
            this.ckbWe.Location = new System.Drawing.Point(131, 59);
            this.ckbWe.Name = "ckbWe";
            this.ckbWe.Size = new System.Drawing.Size(40, 30);
            this.ckbWe.TabIndex = 5;
            this.ckbWe.Text = "We";
            this.ckbWe.UseVisualStyleBackColor = true;
            this.ckbWe.CheckedChanged += new System.EventHandler(this.ckbWe_CheckedChanged);
            // 
            // ckbTu
            // 
            this.ckbTu.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTu.AutoSize = true;
            this.ckbTu.Location = new System.Drawing.Point(90, 59);
            this.ckbTu.Name = "ckbTu";
            this.ckbTu.Size = new System.Drawing.Size(35, 30);
            this.ckbTu.TabIndex = 4;
            this.ckbTu.Text = "Tu";
            this.ckbTu.UseVisualStyleBackColor = true;
            this.ckbTu.CheckedChanged += new System.EventHandler(this.ckbTu_CheckedChanged);
            // 
            // ckbMo
            // 
            this.ckbMo.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbMo.AutoSize = true;
            this.ckbMo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbMo.Location = new System.Drawing.Point(43, 57);
            this.ckbMo.Name = "ckbMo";
            this.ckbMo.Size = new System.Drawing.Size(41, 30);
            this.ckbMo.TabIndex = 3;
            this.ckbMo.Text = "Mo";
            this.ckbMo.UseVisualStyleBackColor = false;
            this.ckbMo.CheckedChanged += new System.EventHandler(this.ckbMo_CheckedChanged);
            // 
            // ckbSu
            // 
            this.ckbSu.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbSu.AutoSize = true;
            this.ckbSu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbSu.Location = new System.Drawing.Point(6, 57);
            this.ckbSu.Name = "ckbSu";
            this.ckbSu.Size = new System.Drawing.Size(35, 30);
            this.ckbSu.TabIndex = 2;
            this.ckbSu.Text = "Su";
            this.ckbSu.UseVisualStyleBackColor = false;
            this.ckbSu.CheckedChanged += new System.EventHandler(this.ckbSu_CheckedChanged);
            // 
            // cboRepeatType
            // 
            this.cboRepeatType.FormattingEnabled = true;
            this.cboRepeatType.Location = new System.Drawing.Point(67, 27);
            this.cboRepeatType.Name = "cboRepeatType";
            this.cboRepeatType.Size = new System.Drawing.Size(177, 28);
            this.cboRepeatType.TabIndex = 9;
            this.cboRepeatType.SelectedIndexChanged += new System.EventHandler(this.cboRepeatType_SelectedIndexChanged);
            // 
            // txtRepeatCount
            // 
            this.txtRepeatCount.Location = new System.Drawing.Point(6, 27);
            this.txtRepeatCount.Name = "txtRepeatCount";
            this.txtRepeatCount.Size = new System.Drawing.Size(55, 27);
            this.txtRepeatCount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "Repeat: ";
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 757);
            this.Controls.Add(this.groupRepeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeRemind);
            this.Controls.Add(this.timeDueDate);
            this.Controls.Add(this.dateRemind);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbRemind);
            this.Controls.Add(this.lbDueDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbTitle);
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create task";
            this.Load += new System.EventHandler(this.Create_Load);
            this.groupRepeat.ResumeLayout(false);
            this.groupRepeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbDescription;
        private Label lbDueDate;
        private Label lbRemind;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dateDueDate;
        private Button btnCreate;
        private Button btnExit;
        private Label lbCategory;
        private ComboBox cboCategory;
        private DateTimePicker dateRemind;
        private DateTimePicker timeDueDate;
        private DateTimePicker timeRemind;
        private Label lbGroup;
        private ComboBox cboGroup;
        private GroupBox groupRepeat;
        private CheckBox ckbSa;
        private CheckBox ckbFr;
        private CheckBox ckbTh;
        private CheckBox ckbWe;
        private CheckBox ckbTu;
        private CheckBox ckbMo;
        private CheckBox ckbSu;
        private ComboBox cboRepeatType;
        private TextBox txtRepeatCount;
        private Label label6;
    }
}
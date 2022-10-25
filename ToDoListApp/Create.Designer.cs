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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
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
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.Gold;
            this.lbTitle.Location = new System.Drawing.Point(25, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(52, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Title:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.ForeColor = System.Drawing.Color.Gold;
            this.lbDescription.Location = new System.Drawing.Point(25, 72);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(112, 25);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "Description:";
            // 
            // lbDueDate
            // 
            this.lbDueDate.AutoSize = true;
            this.lbDueDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDueDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDueDate.ForeColor = System.Drawing.Color.Gold;
            this.lbDueDate.Location = new System.Drawing.Point(25, 296);
            this.lbDueDate.Name = "lbDueDate";
            this.lbDueDate.Size = new System.Drawing.Size(92, 25);
            this.lbDueDate.TabIndex = 2;
            this.lbDueDate.Text = "Due date:";
            // 
            // lbRemind
            // 
            this.lbRemind.AutoSize = true;
            this.lbRemind.BackColor = System.Drawing.Color.Transparent;
            this.lbRemind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRemind.ForeColor = System.Drawing.Color.Gold;
            this.lbRemind.Location = new System.Drawing.Point(25, 344);
            this.lbRemind.Name = "lbRemind";
            this.lbRemind.Size = new System.Drawing.Size(84, 25);
            this.lbRemind.TabIndex = 4;
            this.lbRemind.Text = "Remind: ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(139, 26);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(354, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(139, 74);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(354, 102);
            this.txtDescription.TabIndex = 1;
            // 
            // dateDueDate
            // 
            this.dateDueDate.Location = new System.Drawing.Point(139, 298);
            this.dateDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(219, 23);
            this.dateDueDate.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(409, 477);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 29);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(316, 477);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Cancel";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.ForeColor = System.Drawing.Color.Gold;
            this.lbCategory.Location = new System.Drawing.Point(25, 197);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(97, 25);
            this.lbCategory.TabIndex = 17;
            this.lbCategory.Text = "Category: ";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.ItemHeight = 15;
            this.cboCategory.Location = new System.Drawing.Point(139, 202);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(219, 23);
            this.cboCategory.TabIndex = 2;
            // 
            // dateRemind
            // 
            this.dateRemind.Location = new System.Drawing.Point(139, 346);
            this.dateRemind.Name = "dateRemind";
            this.dateRemind.Size = new System.Drawing.Size(219, 23);
            this.dateRemind.TabIndex = 6;
            // 
            // timeDueDate
            // 
            this.timeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeDueDate.Location = new System.Drawing.Point(364, 298);
            this.timeDueDate.Name = "timeDueDate";
            this.timeDueDate.ShowUpDown = true;
            this.timeDueDate.Size = new System.Drawing.Size(81, 23);
            this.timeDueDate.TabIndex = 5;
            // 
            // timeRemind
            // 
            this.timeRemind.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeRemind.Location = new System.Drawing.Point(364, 346);
            this.timeRemind.Name = "timeRemind";
            this.timeRemind.ShowUpDown = true;
            this.timeRemind.Size = new System.Drawing.Size(81, 23);
            this.timeRemind.TabIndex = 7;
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.BackColor = System.Drawing.Color.Transparent;
            this.lbGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGroup.ForeColor = System.Drawing.Color.Gold;
            this.lbGroup.Location = new System.Drawing.Point(25, 245);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(69, 25);
            this.lbGroup.TabIndex = 17;
            this.lbGroup.Text = "Group:";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.ItemHeight = 15;
            this.cboGroup.Location = new System.Drawing.Point(139, 250);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(219, 23);
            this.cboGroup.TabIndex = 3;
            // 
            // ckbSa
            // 
            this.ckbSa.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbSa.AutoSize = true;
            this.ckbSa.Location = new System.Drawing.Point(172, 451);
            this.ckbSa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbSa.Name = "ckbSa";
            this.ckbSa.Size = new System.Drawing.Size(29, 25);
            this.ckbSa.TabIndex = 8;
            this.ckbSa.Text = "Sa";
            this.ckbSa.UseVisualStyleBackColor = true;
            this.ckbSa.CheckedChanged += new System.EventHandler(this.ckbSa_CheckedChanged);
            // 
            // ckbFr
            // 
            this.ckbFr.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbFr.AutoSize = true;
            this.ckbFr.Location = new System.Drawing.Point(139, 451);
            this.ckbFr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbFr.Name = "ckbFr";
            this.ckbFr.Size = new System.Drawing.Size(27, 25);
            this.ckbFr.TabIndex = 7;
            this.ckbFr.Text = "Fr";
            this.ckbFr.UseVisualStyleBackColor = true;
            this.ckbFr.CheckedChanged += new System.EventHandler(this.ckbFr_CheckedChanged);
            // 
            // ckbTh
            // 
            this.ckbTh.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTh.AutoSize = true;
            this.ckbTh.Location = new System.Drawing.Point(289, 424);
            this.ckbTh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbTh.Name = "ckbTh";
            this.ckbTh.Size = new System.Drawing.Size(30, 25);
            this.ckbTh.TabIndex = 6;
            this.ckbTh.Text = "Th";
            this.ckbTh.UseVisualStyleBackColor = true;
            this.ckbTh.CheckedChanged += new System.EventHandler(this.ckbTh_CheckedChanged);
            // 
            // ckbWe
            // 
            this.ckbWe.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbWe.AutoSize = true;
            this.ckbWe.Location = new System.Drawing.Point(249, 425);
            this.ckbWe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbWe.Name = "ckbWe";
            this.ckbWe.Size = new System.Drawing.Size(34, 25);
            this.ckbWe.TabIndex = 5;
            this.ckbWe.Text = "We";
            this.ckbWe.UseVisualStyleBackColor = true;
            this.ckbWe.CheckedChanged += new System.EventHandler(this.ckbWe_CheckedChanged);
            // 
            // ckbTu
            // 
            this.ckbTu.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbTu.AutoSize = true;
            this.ckbTu.Location = new System.Drawing.Point(213, 425);
            this.ckbTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbTu.Name = "ckbTu";
            this.ckbTu.Size = new System.Drawing.Size(30, 25);
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
            this.ckbMo.Location = new System.Drawing.Point(172, 424);
            this.ckbMo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbMo.Name = "ckbMo";
            this.ckbMo.Size = new System.Drawing.Size(35, 25);
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
            this.ckbSu.Location = new System.Drawing.Point(139, 424);
            this.ckbSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbSu.Name = "ckbSu";
            this.ckbSu.Size = new System.Drawing.Size(30, 25);
            this.ckbSu.TabIndex = 2;
            this.ckbSu.Text = "Su";
            this.ckbSu.UseVisualStyleBackColor = false;
            this.ckbSu.CheckedChanged += new System.EventHandler(this.ckbSu_CheckedChanged);
            // 
            // cboRepeatType
            // 
            this.cboRepeatType.FormattingEnabled = true;
            this.cboRepeatType.Location = new System.Drawing.Point(193, 401);
            this.cboRepeatType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRepeatType.Name = "cboRepeatType";
            this.cboRepeatType.Size = new System.Drawing.Size(155, 23);
            this.cboRepeatType.TabIndex = 9;
            this.cboRepeatType.SelectedIndexChanged += new System.EventHandler(this.cboRepeatType_SelectedIndexChanged);
            // 
            // txtRepeatCount
            // 
            this.txtRepeatCount.Location = new System.Drawing.Point(139, 401);
            this.txtRepeatCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRepeatCount.Name = "txtRepeatCount";
            this.txtRepeatCount.Size = new System.Drawing.Size(49, 23);
            this.txtRepeatCount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(25, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Repeat: ";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddGroup.Location = new System.Drawing.Point(370, 250);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 37;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(529, 520);
            this.Controls.Add(this.ckbSa);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.ckbFr);
            this.Controls.Add(this.ckbTh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbWe);
            this.Controls.Add(this.timeRemind);
            this.Controls.Add(this.ckbTu);
            this.Controls.Add(this.timeDueDate);
            this.Controls.Add(this.ckbMo);
            this.Controls.Add(this.dateRemind);
            this.Controls.Add(this.ckbSu);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.cboRepeatType);
            this.Controls.Add(this.txtRepeatCount);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create task";
            this.Load += new System.EventHandler(this.Create_Load);
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
        private Button btnAddGroup;
    }
}
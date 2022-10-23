namespace Group9_Project
{
    partial class Home
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
            this.taskList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btbSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAllTask = new System.Windows.Forms.Button();
            this.btnMyDate = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnImportant = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskList.BackgroundColor = System.Drawing.Color.White;
            this.taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskList.Location = new System.Drawing.Point(224, 89);
            this.taskList.MultiSelect = false;
            this.taskList.Name = "taskList";
            this.taskList.RowHeadersWidth = 51;
            this.taskList.RowTemplate.Height = 29;
            this.taskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskList.Size = new System.Drawing.Size(482, 440);
            this.taskList.TabIndex = 38;
            this.taskList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskList_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(-99, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1145, 82);
            this.label1.TabIndex = 34;
            this.label1.Text = "Have a nice day :>>>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(-99, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1145, 84);
            this.label2.TabIndex = 44;
            this.label2.Text = "FPT TO-DO LIST";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 358);
            this.panel1.TabIndex = 45;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(33, 211);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(160, 29);
            this.btnUpdateUser.TabIndex = 47;
            this.btnUpdateUser.Text = "Update my profile";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(33, 161);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(160, 31);
            this.labelUsername.TabIndex = 45;
            this.labelUsername.Text = "Name of User";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(33, 252);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 29);
            this.btnLogout.TabIndex = 46;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(202, 29);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btbSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnAllTask);
            this.panel2.Controls.Add(this.btnMyDate);
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Controls.Add(this.btnImportant);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Location = new System.Drawing.Point(712, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 437);
            this.panel2.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(21, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 29);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btbSearch
            // 
            this.btbSearch.Location = new System.Drawing.Point(141, 13);
            this.btbSearch.Name = "btbSearch";
            this.btbSearch.Size = new System.Drawing.Size(82, 29);
            this.btbSearch.TabIndex = 51;
            this.btbSearch.Text = "Search";
            this.btbSearch.UseVisualStyleBackColor = true;
            this.btbSearch.Click += new System.EventHandler(this.btbSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(21, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 27);
            this.txtSearch.TabIndex = 50;
            // 
            // btnAllTask
            // 
            this.btnAllTask.Location = new System.Drawing.Point(21, 89);
            this.btnAllTask.Name = "btnAllTask";
            this.btnAllTask.Size = new System.Drawing.Size(202, 29);
            this.btnAllTask.TabIndex = 49;
            this.btnAllTask.Text = "All task";
            this.btnAllTask.UseVisualStyleBackColor = true;
            this.btnAllTask.Click += new System.EventHandler(this.btnAllTask_Click);
            // 
            // btnMyDate
            // 
            this.btnMyDate.Location = new System.Drawing.Point(21, 309);
            this.btnMyDate.Name = "btnMyDate";
            this.btnMyDate.Size = new System.Drawing.Size(202, 29);
            this.btnMyDate.TabIndex = 48;
            this.btnMyDate.Text = "My Day";
            this.btnMyDate.UseVisualStyleBackColor = true;
            this.btnMyDate.Click += new System.EventHandler(this.btnMyDate_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(21, 128);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(202, 29);
            this.btnDone.TabIndex = 45;
            this.btnDone.Text = "Complete";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnImportant
            // 
            this.btnImportant.Location = new System.Drawing.Point(21, 274);
            this.btnImportant.Name = "btnImportant";
            this.btnImportant.Size = new System.Drawing.Size(202, 29);
            this.btnImportant.TabIndex = 44;
            this.btnImportant.Text = "Important";
            this.btnImportant.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(21, 198);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(202, 29);
            this.btnView.TabIndex = 43;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(21, 163);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(202, 29);
            this.btnCreate.TabIndex = 42;
            this.btnCreate.Text = "New Task";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView taskList;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Button btnExit;
        private Button btnLogout;
        private Panel panel2;
        private Button btnImportant;
        private Button btnView;
        private Button btnCreate;
        private Button btnDone;
        private Button btnMyDate;
        private Button btnAllTask;
        private Button btbSearch;
        private TextBox txtSearch;
        private Button btnUpdateUser;
        private Button btnDelete;
    }
}
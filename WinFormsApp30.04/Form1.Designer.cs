namespace WinFormsApp8
{
    partial class Form1
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
            txtTitle = new TextBox();
            txtDesc = new TextBox();
            dtpDate = new DateTimePicker();
            cmbPriority = new ComboBox();
            cmbFilterStatus = new ComboBox();
            btnAdd = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnReset = new Button();
            lvTasks = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(395, 121);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(395, 150);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(200, 23);
            txtDesc.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(395, 179);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 2;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(395, 208);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 23);
            cmbPriority.TabIndex = 3;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(37, 279);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(200, 23);
            cmbFilterStatus.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(395, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Додати завдання";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(243, 279);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 23);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(475, 278);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(37, 307);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(558, 23);
            btnReset.TabIndex = 8;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lvTasks
            // 
            lvTasks.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvTasks.FullRowSelect = true;
            lvTasks.GridLines = true;
            lvTasks.Location = new Point(37, 121);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(343, 152);
            lvTasks.TabIndex = 9;
            lvTasks.UseCompatibleStateImageBehavior = false;
            lvTasks.View = View.Details;
            lvTasks.MouseDoubleClick += lvTasks_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Назва";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Опис";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Дата";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Пріорітет";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Статус";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 469);
            Controls.Add(lvTasks);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cmbFilterStatus);
            Controls.Add(btnAdd);
            Controls.Add(cmbPriority);
            Controls.Add(dtpDate);
            Controls.Add(txtDesc);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDesc;
        private DateTimePicker dtpDate;
        private ComboBox cmbPriority;      // priority selector for new task
        private ComboBox cmbFilterStatus;  // filter selector for status
        private Button btnAdd;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnReset;
        private ListView lvTasks;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
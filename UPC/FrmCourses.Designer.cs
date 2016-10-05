namespace UPC
{
    partial class FrmCourses
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
            this.components = new System.ComponentModel.Container();
            this.gbCourseInformation = new System.Windows.Forms.GroupBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCareer = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.cbCareer = new System.Windows.Forms.ComboBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbCourseList = new System.Windows.Forms.GroupBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CareerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.careerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCourseInformation.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCourseInformation
            // 
            this.gbCourseInformation.Controls.Add(this.lblCredits);
            this.gbCourseInformation.Controls.Add(this.lblArea);
            this.gbCourseInformation.Controls.Add(this.lblName);
            this.gbCourseInformation.Controls.Add(this.lblCareer);
            this.gbCourseInformation.Controls.Add(this.lblId);
            this.gbCourseInformation.Controls.Add(this.cbCareer);
            this.gbCourseInformation.Controls.Add(this.txtCredits);
            this.gbCourseInformation.Controls.Add(this.txtArea);
            this.gbCourseInformation.Controls.Add(this.txtName);
            this.gbCourseInformation.Controls.Add(this.txtId);
            this.gbCourseInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCourseInformation.Location = new System.Drawing.Point(0, 0);
            this.gbCourseInformation.Name = "gbCourseInformation";
            this.gbCourseInformation.Size = new System.Drawing.Size(510, 161);
            this.gbCourseInformation.TabIndex = 0;
            this.gbCourseInformation.TabStop = false;
            this.gbCourseInformation.Text = "Course Information";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(6, 127);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 9;
            this.lblCredits.Text = "Credits";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 101);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblCareer
            // 
            this.lblCareer.AutoSize = true;
            this.lblCareer.Location = new System.Drawing.Point(6, 48);
            this.lblCareer.Name = "lblCareer";
            this.lblCareer.Size = new System.Drawing.Size(38, 13);
            this.lblCareer.TabIndex = 6;
            this.lblCareer.Text = "Career";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // cbCareer
            // 
            this.cbCareer.DisplayMember = "Name";
            this.cbCareer.FormattingEnabled = true;
            this.cbCareer.Location = new System.Drawing.Point(51, 45);
            this.cbCareer.Name = "cbCareer";
            this.cbCareer.Size = new System.Drawing.Size(154, 21);
            this.cbCareer.TabIndex = 4;
            this.cbCareer.ValueMember = "Id";
            this.cbCareer.SelectedIndexChanged += new System.EventHandler(this.cbCareer_SelectedIndexChanged);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(51, 124);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(154, 20);
            this.txtCredits.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(51, 98);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(154, 20);
            this.txtArea.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(51, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(51, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 20);
            this.txtId.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnDelete);
            this.gbOptions.Controls.Add(this.btnUpdate);
            this.gbOptions.Controls.Add(this.btnAdd);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOptions.Location = new System.Drawing.Point(0, 161);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(510, 52);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbCourseList
            // 
            this.gbCourseList.Controls.Add(this.dgvCourse);
            this.gbCourseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCourseList.Location = new System.Drawing.Point(0, 213);
            this.gbCourseList.Name = "gbCourseList";
            this.gbCourseList.Size = new System.Drawing.Size(510, 177);
            this.gbCourseList.TabIndex = 2;
            this.gbCourseList.TabStop = false;
            this.gbCourseList.Text = "Course List";
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AutoGenerateColumns = false;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.CareerName,
            this.careerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn});
            this.dgvCourse.DataSource = this.courseBindingSource;
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(3, 16);
            this.dgvCourse.MultiSelect = false;
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersVisible = false;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(504, 158);
            this.dgvCourse.TabIndex = 0;
            this.dgvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourse_CellContentClick);
            this.dgvCourse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourse_CellMouseClick);
            // 
            // ColumnId
            // 
            this.ColumnId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.FillWeight = 25F;
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 41;
            // 
            // CareerName
            // 
            this.CareerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CareerName.DataPropertyName = "CareerName";
            this.CareerName.HeaderText = "CareerName";
            this.CareerName.Name = "CareerName";
            this.CareerName.ReadOnly = true;
            this.CareerName.Width = 91;
            // 
            // careerIdDataGridViewTextBoxColumn
            // 
            this.careerIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.careerIdDataGridViewTextBoxColumn.DataPropertyName = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.careerIdDataGridViewTextBoxColumn.HeaderText = "CareerId";
            this.careerIdDataGridViewTextBoxColumn.Name = "careerIdDataGridViewTextBoxColumn";
            this.careerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.careerIdDataGridViewTextBoxColumn.Width = 72;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            this.creditsDataGridViewTextBoxColumn.FillWeight = 50F;
            this.creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            this.creditsDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditsDataGridViewTextBoxColumn.Width = 64;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(Entities.Course);
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 390);
            this.Controls.Add(this.gbCourseList);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbCourseInformation);
            this.Name = "FrmCourses";
            this.Text = "FrmCourses";
            this.Load += new System.EventHandler(this.FrmCourses_Load);
            this.gbCourseInformation.ResumeLayout(false);
            this.gbCourseInformation.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCourseInformation;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbCourseList;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCareer;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbCareer;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CareerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn careerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
    }
}
namespace StudentRegDatabase
{
    partial class RegisterStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            /*this.studentManSystemDataSet = new StudentRegDatabase.StudentManSystemDataSet();*/
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            /*this.studentTableAdapter = new StudentRegDatabase.StudentManSystemDataSetTableAdapters.StudentTableAdapter();*/
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            /*
            ((System.ComponentModel.ISupportInitialize)(this.studentManSystemDataSet)).BeginInit();
            */
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentAgeDataGridViewTextBoxColumn,
            this.studentGpaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentManSystemDataSet
            // 
            /*this.studentManSystemDataSet.DataSetName = "StudentManSystemDataSet";
            this.studentManSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;*/
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            /*this.studentBindingSource.DataSource = this.studentManSystemDataSet;*/
            // 
            // studentTableAdapter
            // 
            /*this.studentTableAdapter.ClearBeforeFill = true;*/
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentAgeDataGridViewTextBoxColumn
            // 
            this.studentAgeDataGridViewTextBoxColumn.DataPropertyName = "StudentAge";
            this.studentAgeDataGridViewTextBoxColumn.HeaderText = "StudentAge";
            this.studentAgeDataGridViewTextBoxColumn.Name = "studentAgeDataGridViewTextBoxColumn";
            // 
            // studentGpaDataGridViewTextBoxColumn
            // 
            this.studentGpaDataGridViewTextBoxColumn.DataPropertyName = "StudentGpa";
            this.studentGpaDataGridViewTextBoxColumn.HeaderText = "StudentGpa";
            this.studentGpaDataGridViewTextBoxColumn.Name = "studentGpaDataGridViewTextBoxColumn";
            // 
            // ShowAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(469, 372);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowAllStudents";
            this.Text = "ShowAllStudents";
            this.Load += new System.EventHandler(this.ShowAllStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            /*((System.ComponentModel.ISupportInitialize)(this.studentManSystemDataSet)).EndInit();*/
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        /*private StudentManSystemDataSet studentManSystemDataSet;*/
        private System.Windows.Forms.BindingSource studentBindingSource;
        /*private StudentManSystemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;*/
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGpaDataGridViewTextBoxColumn;
    }
}
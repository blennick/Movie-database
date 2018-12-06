namespace MovieApp
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dirFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSetDIR = new MovieApp.MovieDBDataSetDIR();
            this.movieDBDataSet2 = new MovieApp.MovieDBDataSet2();
            this.movieDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.directorTableAdapter = new MovieApp.MovieDBDataSetDIRTableAdapters.DirectorTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetDIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dirFNameDataGridViewTextBoxColumn,
            this.dirLNameDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.directorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(269, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dirFNameDataGridViewTextBoxColumn
            // 
            this.dirFNameDataGridViewTextBoxColumn.DataPropertyName = "dirFName";
            this.dirFNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.dirFNameDataGridViewTextBoxColumn.Name = "dirFNameDataGridViewTextBoxColumn";
            // 
            // dirLNameDataGridViewTextBoxColumn
            // 
            this.dirLNameDataGridViewTextBoxColumn.DataPropertyName = "dirLName";
            this.dirLNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.dirLNameDataGridViewTextBoxColumn.Name = "dirLNameDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dirId";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataMember = "Director";
            this.directorBindingSource.DataSource = this.movieDBDataSetDIR;
            // 
            // movieDBDataSetDIR
            // 
            this.movieDBDataSetDIR.DataSetName = "MovieDBDataSetDIR";
            this.movieDBDataSetDIR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieDBDataSet2
            // 
            this.movieDBDataSet2.DataSetName = "MovieDBDataSet2";
            this.movieDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieDBDataSet2BindingSource
            // 
            this.movieDBDataSet2BindingSource.DataSource = this.movieDBDataSet2;
            this.movieDBDataSet2BindingSource.Position = 0;
            // 
            // movieDBDataSet2BindingSource1
            // 
            this.movieDBDataSet2BindingSource1.DataSource = this.movieDBDataSet2;
            this.movieDBDataSet2BindingSource1.Position = 0;
            // 
            // movieDBDataSet2BindingSource2
            // 
            this.movieDBDataSet2BindingSource2.DataSource = this.movieDBDataSet2;
            this.movieDBDataSet2BindingSource2.Position = 0;
            // 
            // directorTableAdapter
            // 
            this.directorTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filter By Director";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetDIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet2BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MovieDBDataSet2 movieDBDataSet2;
        private System.Windows.Forms.BindingSource movieDBDataSet2BindingSource;
        private System.Windows.Forms.BindingSource movieDBDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource movieDBDataSet2BindingSource2;
        private MovieDBDataSetDIR movieDBDataSetDIR;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private MovieDBDataSetDIRTableAdapters.DirectorTableAdapter directorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
    }
}
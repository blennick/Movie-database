namespace MovieApp
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movieDBDataSetMainActor = new MovieApp.MovieDBDataSetMainActor();
            this.mainActorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainActorTableAdapter = new MovieApp.MovieDBDataSetMainActorTableAdapters.MainActorTableAdapter();
            this.actorFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetMainActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainActorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Filter By Actor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorFNameDataGridViewTextBoxColumn,
            this.actorLNameDataGridViewTextBoxColumn,
            this.actorRoleDataGridViewTextBoxColumn,
            this.actorIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mainActorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 283);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // movieDBDataSetMainActor
            // 
            this.movieDBDataSetMainActor.DataSetName = "MovieDBDataSetMainActor";
            this.movieDBDataSetMainActor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainActorBindingSource
            // 
            this.mainActorBindingSource.DataMember = "MainActor";
            this.mainActorBindingSource.DataSource = this.movieDBDataSetMainActor;
            // 
            // mainActorTableAdapter
            // 
            this.mainActorTableAdapter.ClearBeforeFill = true;
            // 
            // actorFNameDataGridViewTextBoxColumn
            // 
            this.actorFNameDataGridViewTextBoxColumn.DataPropertyName = "actorFName";
            this.actorFNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.actorFNameDataGridViewTextBoxColumn.Name = "actorFNameDataGridViewTextBoxColumn";
            // 
            // actorLNameDataGridViewTextBoxColumn
            // 
            this.actorLNameDataGridViewTextBoxColumn.DataPropertyName = "actorLName";
            this.actorLNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.actorLNameDataGridViewTextBoxColumn.Name = "actorLNameDataGridViewTextBoxColumn";
            // 
            // actorRoleDataGridViewTextBoxColumn
            // 
            this.actorRoleDataGridViewTextBoxColumn.DataPropertyName = "actorRole";
            this.actorRoleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.actorRoleDataGridViewTextBoxColumn.Name = "actorRoleDataGridViewTextBoxColumn";
            // 
            // actorIdDataGridViewTextBoxColumn
            // 
            this.actorIdDataGridViewTextBoxColumn.DataPropertyName = "actorId";
            this.actorIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.actorIdDataGridViewTextBoxColumn.Name = "actorIdDataGridViewTextBoxColumn";
            this.actorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSetMainActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainActorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private MovieDBDataSetMainActor movieDBDataSetMainActor;
        private System.Windows.Forms.BindingSource mainActorBindingSource;
        private MovieDBDataSetMainActorTableAdapters.MainActorTableAdapter mainActorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIdDataGridViewTextBoxColumn;
    }
}
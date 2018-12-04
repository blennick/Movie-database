namespace MovieApp
{
    partial class Form2
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
            this.movieTitleTB = new System.Windows.Forms.TextBox();
            this.movieTitleTxt = new System.Windows.Forms.Label();
            this.releaseDateTxt = new System.Windows.Forms.Label();
            this.releaseDataTB = new System.Windows.Forms.TextBox();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.genreTxt = new System.Windows.Forms.Label();
            this.directorCB = new System.Windows.Forms.ComboBox();
            this.directorTxt = new System.Windows.Forms.Label();
            this.mainActorCB = new System.Windows.Forms.ComboBox();
            this.mainActorTxt = new System.Windows.Forms.Label();
            this.submitBT = new System.Windows.Forms.Button();
            this.cancelBT = new System.Windows.Forms.Button();
            this.createMovieTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieTitleTB
            // 
            this.movieTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleTB.Location = new System.Drawing.Point(159, 52);
            this.movieTitleTB.Name = "movieTitleTB";
            this.movieTitleTB.Size = new System.Drawing.Size(193, 24);
            this.movieTitleTB.TabIndex = 0;
            // 
            // movieTitleTxt
            // 
            this.movieTitleTxt.AutoSize = true;
            this.movieTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleTxt.Location = new System.Drawing.Point(66, 54);
            this.movieTitleTxt.Name = "movieTitleTxt";
            this.movieTitleTxt.Size = new System.Drawing.Size(87, 20);
            this.movieTitleTxt.TabIndex = 1;
            this.movieTitleTxt.Text = "Movie Title:";
            // 
            // releaseDateTxt
            // 
            this.releaseDateTxt.AutoSize = true;
            this.releaseDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDateTxt.Location = new System.Drawing.Point(42, 94);
            this.releaseDateTxt.Name = "releaseDateTxt";
            this.releaseDateTxt.Size = new System.Drawing.Size(111, 20);
            this.releaseDateTxt.TabIndex = 2;
            this.releaseDateTxt.Text = "Release Date:";
            // 
            // releaseDataTB
            // 
            this.releaseDataTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDataTB.Location = new System.Drawing.Point(159, 92);
            this.releaseDataTB.Name = "releaseDataTB";
            this.releaseDataTB.Size = new System.Drawing.Size(193, 24);
            this.releaseDataTB.TabIndex = 3;
            // 
            // genreCB
            // 
            this.genreCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(159, 132);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(193, 26);
            this.genreCB.TabIndex = 4;
            // 
            // genreTxt
            // 
            this.genreTxt.AutoSize = true;
            this.genreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTxt.Location = new System.Drawing.Point(95, 134);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.Size = new System.Drawing.Size(58, 20);
            this.genreTxt.TabIndex = 5;
            this.genreTxt.Text = "Genre:";
            // 
            // directorCB
            // 
            this.directorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorCB.FormattingEnabled = true;
            this.directorCB.Location = new System.Drawing.Point(159, 172);
            this.directorCB.Name = "directorCB";
            this.directorCB.Size = new System.Drawing.Size(193, 26);
            this.directorCB.TabIndex = 6;
            // 
            // directorTxt
            // 
            this.directorTxt.AutoSize = true;
            this.directorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorTxt.Location = new System.Drawing.Point(84, 174);
            this.directorTxt.Name = "directorTxt";
            this.directorTxt.Size = new System.Drawing.Size(69, 20);
            this.directorTxt.TabIndex = 7;
            this.directorTxt.Text = "Director:";
            // 
            // mainActorCB
            // 
            this.mainActorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainActorCB.FormattingEnabled = true;
            this.mainActorCB.Location = new System.Drawing.Point(159, 212);
            this.mainActorCB.Name = "mainActorCB";
            this.mainActorCB.Size = new System.Drawing.Size(193, 26);
            this.mainActorCB.TabIndex = 8;
            // 
            // mainActorTxt
            // 
            this.mainActorTxt.AutoSize = true;
            this.mainActorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainActorTxt.Location = new System.Drawing.Point(64, 214);
            this.mainActorTxt.Name = "mainActorTxt";
            this.mainActorTxt.Size = new System.Drawing.Size(89, 20);
            this.mainActorTxt.TabIndex = 9;
            this.mainActorTxt.Text = "Main Actor:";
            // 
            // submitBT
            // 
            this.submitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBT.Location = new System.Drawing.Point(128, 259);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(103, 47);
            this.submitBT.TabIndex = 10;
            this.submitBT.Text = "Submit";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // cancelBT
            // 
            this.cancelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBT.Location = new System.Drawing.Point(249, 259);
            this.cancelBT.Name = "cancelBT";
            this.cancelBT.Size = new System.Drawing.Size(103, 47);
            this.cancelBT.TabIndex = 11;
            this.cancelBT.Text = "Cancel";
            this.cancelBT.UseVisualStyleBackColor = true;
            // 
            // createMovieTxt
            // 
            this.createMovieTxt.AutoSize = true;
            this.createMovieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMovieTxt.Location = new System.Drawing.Point(116, 9);
            this.createMovieTxt.Name = "createMovieTxt";
            this.createMovieTxt.Size = new System.Drawing.Size(152, 25);
            this.createMovieTxt.TabIndex = 12;
            this.createMovieTxt.Text = "Create Movie";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 333);
            this.Controls.Add(this.createMovieTxt);
            this.Controls.Add(this.cancelBT);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.mainActorTxt);
            this.Controls.Add(this.mainActorCB);
            this.Controls.Add(this.directorTxt);
            this.Controls.Add(this.directorCB);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.releaseDataTB);
            this.Controls.Add(this.releaseDateTxt);
            this.Controls.Add(this.movieTitleTxt);
            this.Controls.Add(this.movieTitleTB);
            this.Name = "Form2";
            this.Text = "Create Movie";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movieTitleTB;
        private System.Windows.Forms.Label movieTitleTxt;
        private System.Windows.Forms.Label releaseDateTxt;
        private System.Windows.Forms.TextBox releaseDataTB;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.Label genreTxt;
        private System.Windows.Forms.ComboBox directorCB;
        private System.Windows.Forms.Label directorTxt;
        private System.Windows.Forms.ComboBox mainActorCB;
        private System.Windows.Forms.Label mainActorTxt;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.Button cancelBT;
        private System.Windows.Forms.Label createMovieTxt;
    }
}
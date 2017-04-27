namespace SDVX_ScoreTracker
{
    partial class EditSongForm
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
            this.SongNameEdit = new System.Windows.Forms.Label();
            this.ScoreEdit = new System.Windows.Forms.TextBox();
            this.GradeEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveEdit = new System.Windows.Forms.Button();
            this.cancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SongNameEdit
            // 
            this.SongNameEdit.AutoSize = true;
            this.SongNameEdit.Location = new System.Drawing.Point(180, 23);
            this.SongNameEdit.Name = "SongNameEdit";
            this.SongNameEdit.Size = new System.Drawing.Size(35, 13);
            this.SongNameEdit.TabIndex = 0;
            this.SongNameEdit.Text = "label1";
            // 
            // ScoreEdit
            // 
            this.ScoreEdit.Location = new System.Drawing.Point(124, 60);
            this.ScoreEdit.Name = "ScoreEdit";
            this.ScoreEdit.Size = new System.Drawing.Size(62, 20);
            this.ScoreEdit.TabIndex = 1;
            // 
            // GradeEdit
            // 
            this.GradeEdit.Location = new System.Drawing.Point(311, 60);
            this.GradeEdit.Name = "GradeEdit";
            this.GradeEdit.Size = new System.Drawing.Size(62, 20);
            this.GradeEdit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grade :";
            // 
            // saveEdit
            // 
            this.saveEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveEdit.Location = new System.Drawing.Point(111, 96);
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Size = new System.Drawing.Size(75, 23);
            this.saveEdit.TabIndex = 5;
            this.saveEdit.Text = "Save";
            this.saveEdit.UseVisualStyleBackColor = true;
            this.saveEdit.Click += new System.EventHandler(this.saveEdit_Click);
            // 
            // cancelEdit
            // 
            this.cancelEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelEdit.Location = new System.Drawing.Point(235, 96);
            this.cancelEdit.Name = "cancelEdit";
            this.cancelEdit.Size = new System.Drawing.Size(75, 23);
            this.cancelEdit.TabIndex = 6;
            this.cancelEdit.Text = "Cancel";
            this.cancelEdit.UseVisualStyleBackColor = true;
            this.cancelEdit.Click += new System.EventHandler(this.cancelEdit_Click);
            // 
            // EditSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 140);
            this.Controls.Add(this.cancelEdit);
            this.Controls.Add(this.saveEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GradeEdit);
            this.Controls.Add(this.ScoreEdit);
            this.Controls.Add(this.SongNameEdit);
            this.Name = "EditSongForm";
            this.Text = "EditSongForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SongNameEdit;
        private System.Windows.Forms.TextBox ScoreEdit;
        private System.Windows.Forms.TextBox GradeEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveEdit;
        private System.Windows.Forms.Button cancelEdit;
    }
}
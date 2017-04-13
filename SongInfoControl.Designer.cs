namespace SDVX_ScoreTracker
{
    partial class SongInfoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Grade = new System.Windows.Forms.Label();
            this.newScore = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Song_Romaji = new System.Windows.Forms.Label();
            this.Song_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(618, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.Location = new System.Drawing.Point(559, 11);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(36, 15);
            this.Grade.TabIndex = 19;
            this.Grade.Text = "Grade";
            // 
            // newScore
            // 
            this.newScore.AutoSize = true;
            this.newScore.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScore.Location = new System.Drawing.Point(470, 11);
            this.newScore.Name = "newScore";
            this.newScore.Size = new System.Drawing.Size(33, 15);
            this.newScore.TabIndex = 18;
            this.newScore.Text = "Score";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficulty.Location = new System.Drawing.Point(386, 11);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(53, 15);
            this.Difficulty.TabIndex = 17;
            this.Difficulty.Text = "Difficulty";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(333, 11);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(32, 15);
            this.Level.TabIndex = 16;
            this.Level.Text = "Level";
            // 
            // Song_Romaji
            // 
            this.Song_Romaji.AutoSize = true;
            this.Song_Romaji.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song_Romaji.Location = new System.Drawing.Point(181, 11);
            this.Song_Romaji.Name = "Song_Romaji";
            this.Song_Romaji.Size = new System.Drawing.Size(67, 15);
            this.Song_Romaji.TabIndex = 15;
            this.Song_Romaji.Text = "Song Romaji";
            // 
            // Song_Name
            // 
            this.Song_Name.AutoSize = true;
            this.Song_Name.Font = new System.Drawing.Font("Bitstream Cyberbit", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song_Name.Location = new System.Drawing.Point(4, 11);
            this.Song_Name.Name = "Song_Name";
            this.Song_Name.Size = new System.Drawing.Size(60, 15);
            this.Song_Name.TabIndex = 14;
            this.Song_Name.Text = "Song Name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.newScore);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Song_Romaji);
            this.Controls.Add(this.Song_Name);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(663, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label newScore;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label Song_Romaji;
        private System.Windows.Forms.Label Song_Name;
    }
}

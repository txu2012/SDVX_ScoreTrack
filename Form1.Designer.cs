namespace SDVX_ScoreTracker
{
    partial class Layout
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calc = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.romajiBox = new System.Windows.Forms.TextBox();
            this.difLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.difBox = new System.Windows.Forms.TextBox();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradeVal = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.scoreVal = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nearLabel = new System.Windows.Forms.Label();
            this.critLabel = new System.Windows.Forms.Label();
            this.errorNum = new System.Windows.Forms.TextBox();
            this.nearNum = new System.Windows.Forms.TextBox();
            this.criticalNum = new System.Windows.Forms.TextBox();
            this.allSongs = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.playedSongs = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.calc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.allSongs.SuspendLayout();
            this.playedSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calc);
            this.tabControl1.Controls.Add(this.allSongs);
            this.tabControl1.Controls.Add(this.playedSongs);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // calc
            // 
            this.calc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.calc.Controls.Add(this.label1);
            this.calc.Controls.Add(this.romajiBox);
            this.calc.Controls.Add(this.difLabel);
            this.calc.Controls.Add(this.levelLabel);
            this.calc.Controls.Add(this.difBox);
            this.calc.Controls.Add(this.levelBox);
            this.calc.Controls.Add(this.saveButton);
            this.calc.Controls.Add(this.songNameLabel);
            this.calc.Controls.Add(this.songName);
            this.calc.Controls.Add(this.pictureBox1);
            this.calc.Controls.Add(this.gradeVal);
            this.calc.Controls.Add(this.gradeLabel);
            this.calc.Controls.Add(this.scoreVal);
            this.calc.Controls.Add(this.scoreLabel);
            this.calc.Controls.Add(this.calcButton);
            this.calc.Controls.Add(this.errorLabel);
            this.calc.Controls.Add(this.nearLabel);
            this.calc.Controls.Add(this.critLabel);
            this.calc.Controls.Add(this.errorNum);
            this.calc.Controls.Add(this.nearNum);
            this.calc.Controls.Add(this.criticalNum);
            this.calc.Location = new System.Drawing.Point(4, 22);
            this.calc.Name = "calc";
            this.calc.Padding = new System.Windows.Forms.Padding(3);
            this.calc.Size = new System.Drawing.Size(702, 501);
            this.calc.TabIndex = 0;
            this.calc.Text = "Score Calculator";
            this.calc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Song Romaji :";
            // 
            // romajiBox
            // 
            this.romajiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romajiBox.Location = new System.Drawing.Point(456, 191);
            this.romajiBox.Name = "romajiBox";
            this.romajiBox.Size = new System.Drawing.Size(131, 20);
            this.romajiBox.TabIndex = 20;
            // 
            // difLabel
            // 
            this.difLabel.AutoSize = true;
            this.difLabel.Location = new System.Drawing.Point(355, 265);
            this.difLabel.Name = "difLabel";
            this.difLabel.Size = new System.Drawing.Size(53, 13);
            this.difLabel.TabIndex = 19;
            this.difLabel.Text = "Difficulty :";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(369, 228);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(39, 13);
            this.levelLabel.TabIndex = 18;
            this.levelLabel.Text = "Level :";
            // 
            // difBox
            // 
            this.difBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difBox.Location = new System.Drawing.Point(456, 265);
            this.difBox.Name = "difBox";
            this.difBox.Size = new System.Drawing.Size(131, 20);
            this.difBox.TabIndex = 17;
            // 
            // levelBox
            // 
            this.levelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.Location = new System.Drawing.Point(456, 228);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(131, 20);
            this.levelBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(409, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Location = new System.Drawing.Point(339, 153);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(69, 13);
            this.songNameLabel.TabIndex = 14;
            this.songNameLabel.Text = "Song Name :";
            // 
            // songName
            // 
            this.songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.Location = new System.Drawing.Point(456, 153);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(131, 20);
            this.songName.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDVX_ScoreTracker.Properties.Resources.sdvx42;
            this.pictureBox1.Location = new System.Drawing.Point(216, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 104);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // gradeVal
            // 
            this.gradeVal.AutoSize = true;
            this.gradeVal.Location = new System.Drawing.Point(406, 410);
            this.gradeVal.Name = "gradeVal";
            this.gradeVal.Size = new System.Drawing.Size(15, 13);
            this.gradeVal.TabIndex = 11;
            this.gradeVal.Text = "D";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(234, 410);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(42, 13);
            this.gradeLabel.TabIndex = 10;
            this.gradeLabel.Text = "Grade :";
            // 
            // scoreVal
            // 
            this.scoreVal.AutoSize = true;
            this.scoreVal.Location = new System.Drawing.Point(406, 378);
            this.scoreVal.Name = "scoreVal";
            this.scoreVal.Size = new System.Drawing.Size(13, 13);
            this.scoreVal.TabIndex = 9;
            this.scoreVal.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(234, 378);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 13);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score :\r\n";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(216, 319);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(52, 228);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 13);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "Errors :";
            // 
            // nearLabel
            // 
            this.nearLabel.AutoSize = true;
            this.nearLabel.Location = new System.Drawing.Point(51, 191);
            this.nearLabel.Name = "nearLabel";
            this.nearLabel.Size = new System.Drawing.Size(41, 13);
            this.nearLabel.TabIndex = 5;
            this.nearLabel.Text = "Nears :";
            // 
            // critLabel
            // 
            this.critLabel.AutoSize = true;
            this.critLabel.Location = new System.Drawing.Point(43, 153);
            this.critLabel.Name = "critLabel";
            this.critLabel.Size = new System.Drawing.Size(49, 13);
            this.critLabel.TabIndex = 4;
            this.critLabel.Text = "Criticals :";
            // 
            // errorNum
            // 
            this.errorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNum.Location = new System.Drawing.Point(160, 228);
            this.errorNum.Name = "errorNum";
            this.errorNum.Size = new System.Drawing.Size(131, 20);
            this.errorNum.TabIndex = 3;
            // 
            // nearNum
            // 
            this.nearNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nearNum.Location = new System.Drawing.Point(160, 191);
            this.nearNum.Name = "nearNum";
            this.nearNum.Size = new System.Drawing.Size(131, 20);
            this.nearNum.TabIndex = 2;
            // 
            // criticalNum
            // 
            this.criticalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalNum.Location = new System.Drawing.Point(160, 153);
            this.criticalNum.Name = "criticalNum";
            this.criticalNum.Size = new System.Drawing.Size(131, 20);
            this.criticalNum.TabIndex = 0;
            // 
            // allSongs
            // 
            this.allSongs.Controls.Add(this.flowLayoutPanel2);
            this.allSongs.Location = new System.Drawing.Point(4, 22);
            this.allSongs.Name = "allSongs";
            this.allSongs.Padding = new System.Windows.Forms.Padding(3);
            this.allSongs.Size = new System.Drawing.Size(702, 501);
            this.allSongs.TabIndex = 1;
            this.allSongs.Text = "All Songs";
            this.allSongs.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(696, 467);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // playedSongs
            // 
            this.playedSongs.Controls.Add(this.flowLayoutPanel1);
            this.playedSongs.Location = new System.Drawing.Point(4, 22);
            this.playedSongs.Name = "playedSongs";
            this.playedSongs.Size = new System.Drawing.Size(702, 501);
            this.playedSongs.TabIndex = 2;
            this.playedSongs.Text = "Played Songs";
            this.playedSongs.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(696, 468);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Layout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 532);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Layout";
            this.Text = "Sound Voltex Score Tracker";
            this.tabControl1.ResumeLayout(false);
            this.calc.ResumeLayout(false);
            this.calc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.allSongs.ResumeLayout(false);
            this.playedSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calc;
        private System.Windows.Forms.TabPage allSongs;
        private System.Windows.Forms.TextBox criticalNum;
        private System.Windows.Forms.TabPage playedSongs;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label nearLabel;
        private System.Windows.Forms.Label critLabel;
        private System.Windows.Forms.TextBox errorNum;
        private System.Windows.Forms.TextBox nearNum;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label scoreVal;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gradeVal;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.TextBox songName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label difLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox difBox;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox romajiBox;
    }
}


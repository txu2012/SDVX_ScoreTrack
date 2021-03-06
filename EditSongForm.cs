﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDVX_ScoreTracker
{
    public partial class EditSongForm : Form
    {
        private long editScore;
        private string editGrade;
        private string songName;

        public EditSongForm()
        {
            editScore = 0;
            editGrade = "D";
            InitializeComponent();
        }

        public long getEditScore()
        {
            return editScore;
        }

        public string getEditGrade()
        {
            return editGrade;
        }

        public void sendName(string name)
        {
            songName = name;
            SongNameEdit.Text = name;
        }

        private void saveEdit_Click(object sender, EventArgs e)
        {

            editScore = Convert.ToInt64(ScoreEdit.Text);
            editGrade = GradeEdit.Text;
            Console.Write(editScore);
            Console.Write(editGrade);
        }

        private void cancelEdit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

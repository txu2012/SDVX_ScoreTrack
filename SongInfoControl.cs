using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDVX_ScoreTracker
{
    public partial class SongInfoControl : UserControl
    {
        //private string name;
        /*public UserControl1(string song, long score, string grade)
        {
            InitializeComponent();
            Console.WriteLine(song);
            Song_Name.Text = song;
            Score.Text = score.ToString();
            Grade.Text = grade;
        }*/

        public SongInfoControl(string song, string romaji, int lvl, string dif, long score, string grade)
        {
            InitializeComponent();
            Song_Name.Text = song;
            newScore.Text = score.ToString();
            Grade.Text = grade;
            Song_Romaji.Text = romaji;
            Level.Text = lvl.ToString();
            Difficulty.Text = dif;
        }

        public void setNewInfo(long score, string grade)
        {
            newScore.Text = score.ToString();
            Grade.Text = grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

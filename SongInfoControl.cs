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
    // Class for song information usercontrol
    public partial class SongInfoControl : UserControl
    {
        // Variables for song information
        private string name;
        private string rom;
        private string difficulty;
        private string gra;
        private int level;
        private long sco;
        private Song currSong;

        // Constructor to create control object
        /**
         * Constructor for creating user control object
         * @param string song - song name
         * @param string romaji - song name in romaji
         * @param int lvl - level of the song
         * @param string dif - difficulty of the song level
         * @param long score - user inputted score
         * @param string grade - Grade received from the score
         * */
        public SongInfoControl(string song, string romaji, int lvl, string dif, long score, string grade)
        {
            InitializeComponent();
            Song_Name.Text = song;
            newScore.Text = score.ToString();
            Grade.Text = grade;
            Song_Romaji.Text = romaji;
            Level.Text = lvl.ToString();
            Difficulty.Text = dif;

            name = song;
            rom = romaji;
            difficulty = dif;
            gra = grade;
            sco = score;
            level = lvl;
            currSong = new SDVX_ScoreTracker.Song(name, rom, level, difficulty, sco, gra);
        }

        // Setters/Getters
        /**
         * Sets the score and grade for the current song/user control
         * @param long score - user inputted score
         * @param string grade - Grade received from the score
         * */
        public void setNewInfo(long score, string grade)
        {
            newScore.Text = score.ToString();
            Grade.Text = grade;
        }

        /**
         * Grabs and returns the song name
         * @return name
         * */
        public string getName() { return this.name; }

        /**
         * Grabs and returns the song name in romaji
         * @return rom
         * */
        public string getRomaji() { return this.rom; }

        /**
         * Grabs and returns the song difficulty
         * @return difficulty
         * */
        public string getDif() { return this.difficulty; }

        /**
         * Grabs and returns the user grade
         * @return gra
         * */
        public string getGrade() { return this.gra; }

        /**
         * Grabs and returns the song level
         * @return level
         * */
        public int getLevel() { return this.level; }

        /**
         * Grabs and returns the user score
         * @return sco
         * */
        public long getScore() { return this.sco; }

        /**
         * Grabs and returns the current song
         * @return currSong
         * */
        public Song getSong() { return currSong; }

        private void button1_Click(object sender, EventArgs e)
        {
            EditSongForm editSong = new EditSongForm();
            editSong.sendName(name);

            DialogResult dialog = editSong.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                sco = editSong.getEditScore();
                gra = editSong.getEditGrade();
                currSong.updateScore(sco);
                currSong.updateGrade(gra);

                Grade.Text = gra;
                newScore.Text = sco.ToString();
                SDVX_ScoreTracker.Layout.saveNewSongInfo(currSong);

                editSong.Dispose();
            }
            else if (dialog == DialogResult.Cancel)
            {
                editSong.Dispose();
            }
        }
    }
}

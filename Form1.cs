using System;
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
    public partial class Layout : Form
    {
        //private float totalNotes;
        //private long totalScore = 10000000;
        private long currentScore;
        private string currentGrade;
        private string currentSongName;
        private string currentDif;
        private string currentRomaji;
        private int currentLevel;
        private CalculatorGrade calcGrade;
        private SongInfoRead songs;
        private Dictionary<string, Song> dictSongs;
        private Dictionary<string, Song> dictPlayedSongs;
        private Dictionary<string, SongInfoControl> allUserControl;
        private Dictionary<string, SongInfoControl> playedUserControl;

        public Layout()
        {
            dictSongs = new Dictionary<string, Song>();
            dictPlayedSongs = new Dictionary<string, Song>();
            allUserControl = new Dictionary<string, SongInfoControl>();
            playedUserControl = new Dictionary<string, SongInfoControl>();

            calcGrade = new CalculatorGrade();
            songs = new SongInfoRead();
            dictSongs = songs.getSongList();
            dictPlayedSongs = songs.getPlayedList();

            InitializeComponent();
            displaySongs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getScoreAndGrade();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(songName.Text == "")
            {
                MessageBox.Show("Must add song name");
            }
            else
            {
                currentSongName = songName.Text;
            }

            if (levelBox.Text == "")
            {
                currentLevel = 0;
            }
            else
            {
                currentLevel = Convert.ToInt32(levelBox.Text);
            }

            if (difBox.Text == "")
            {
                currentDif = "Dif";
            }
            else
            {
                currentDif = difBox.Text;
            }

            if (romajiBox.Text == "")
            {
                currentRomaji = " ";
            }
            else
            {
                currentRomaji = romajiBox.Text;
            }

            getScoreAndGrade();

            Song getAllSong;
            Song getPlayedSong;

            if (dictSongs.TryGetValue(currentSongName.ToLower(), out getAllSong))
            {
                getAllSong.updateScore(currentScore);
                getAllSong.updateGrade(currentGrade);
            }
            else
            {
                getAllSong = new Song(currentSongName, currentRomaji, currentLevel, currentDif, currentScore, currentGrade);
            }
            dictSongs[currentSongName.ToLower()] = getAllSong;


            if (dictPlayedSongs.TryGetValue(currentSongName.ToLower(), out getPlayedSong))
            {
                getPlayedSong.updateScore(currentScore);
                getPlayedSong.updateGrade(currentGrade);
            }
            else
            {
                getPlayedSong = new Song(currentSongName, currentRomaji, currentLevel, currentDif, currentScore, currentGrade);
            }

            dictPlayedSongs[currentSongName.ToLower()] = getPlayedSong;
            updateDisplay(getPlayedSong);

        }

        private void getScoreAndGrade()
        {
            float crit, near, error;

            if (criticalNum.Text == "")
            {
                crit = 0;
            }
            else
            {
                if (!float.TryParse(criticalNum.Text, out crit))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }
                crit = float.Parse(criticalNum.Text);
            }

            if (nearNum.Text == "")
            {
                near = 0;
            }
            else
            {
                if (!float.TryParse(nearNum.Text, out near))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }
                near = float.Parse(nearNum.Text);
            }

            if (errorNum.Text == "")
            {
                error = 0;
            }
            else
            {
                if (!float.TryParse(errorNum.Text, out error))
                {
                    MessageBox.Show("This is a number only field");
                    return;
                }
                error = float.Parse(errorNum.Text);
            }

            reset();
            currentSongName = songName.Text;
            currentScore = calcGrade.scoreCalc(crit, near, error);
            currentGrade = calcGrade.gradeCheck(currentScore);

            scoreVal.Text = currentScore.ToString();
            gradeVal.Text = currentGrade;
        }

        private void reset()
        {
            currentGrade = "D";
            currentScore = 0;
            currentSongName = " ";
        }

        private void displaySongs()
        {
            foreach(var entry in dictPlayedSongs)
            {
                Song songEntry = entry.Value;
                SongInfoControl played = new SongInfoControl(songEntry.getName(), songEntry.getRomaji(), songEntry.getLevel(), songEntry.getDif(), songEntry.getScore(), songEntry.getGrade())
                {
                    Parent = flowLayoutPanel1,
                };

                flowLayoutPanel1.Controls.Add(played);
                playedUserControl.Add(songEntry.getName().ToLower(), played);
                played = null;

            }

            foreach (var entry in dictSongs)
            {
                Song songEntry = entry.Value;
                SongInfoControl played = new SongInfoControl(songEntry.getName(), songEntry.getRomaji(), songEntry.getLevel(), songEntry.getDif(), songEntry.getScore(), songEntry.getGrade())
                {
                    Parent = flowLayoutPanel2,
                };

                flowLayoutPanel2.Controls.Add(played);
                allUserControl.Add(songEntry.getName().ToLower(), played);
                played = null;

            }
            /*
            flowLayoutPanel1.Controls.Add(
                new UserControl1(songName.Text, currentScore, currentGrade)
                {
                    Parent = flowLayoutPanel1
                });*/
        }

        private void updateDisplay(Song updatedSong)
        {
            SongInfoControl updateAllPlayed;

            bool checkUpdatedAll = false;
            if (allUserControl.TryGetValue(updatedSong.getName().ToLower(), out updateAllPlayed))
            {
                updateAllPlayed.setNewInfo(updatedSong.getScore(), updatedSong.getGrade());
                allUserControl[updatedSong.getName().ToLower()] = updateAllPlayed;
                checkUpdatedAll = true;
            }
            else
            {
                SongInfoControl played = new SongInfoControl(updatedSong.getName(), updatedSong.getRomaji(),
                            updatedSong.getLevel(), updatedSong.getDif(), updatedSong.getScore(), updatedSong.getGrade())
                {
                    Parent = flowLayoutPanel2
                };

                flowLayoutPanel2.Controls.Add(played);
                allUserControl.Add(updatedSong.getName().ToLower(), played);
                played = null;
            }

            SongInfoControl updatePlayedSong;
            if (playedUserControl.TryGetValue(updatedSong.getName().ToLower(), out updatePlayedSong))
            {
                updatePlayedSong.setNewInfo(updatedSong.getScore(), updatedSong.getGrade());

                //flowLayoutPanel1.Controls.Add(newControl);
                playedUserControl[updatedSong.getName().ToLower()] = updatePlayedSong;
            }
            else
            {
                if (checkUpdatedAll)
                {
                    allUserControl.TryGetValue(updatedSong.getName().ToLower(), out updateAllPlayed);
                    SongInfoControl newControl = new SongInfoControl(updateAllPlayed.getName(), updateAllPlayed.getRomaji(), updateAllPlayed.getLevel(),
                            updateAllPlayed.getDif(), updatedSong.getScore(), updatedSong.getGrade())
                    { Parent = flowLayoutPanel1 };

                    flowLayoutPanel1.Controls.Add(newControl);
                    playedUserControl.Add(updatedSong.getName().ToLower(), newControl);
                    checkUpdatedAll = false;
                }
                else
                {
                    SongInfoControl played = new SongInfoControl(updatedSong.getName(), updatedSong.getRomaji(),
                                updatedSong.getLevel(), updatedSong.getDif(), updatedSong.getScore(), updatedSong.getGrade())
                    {
                        Parent = flowLayoutPanel1
                    };

                    flowLayoutPanel1.Controls.Add(played);
                    playedUserControl.Add(updatedSong.getName().ToLower(), played);
                    played = null;
                }
            }
            /*
            if(updateAllPlayed != null)
            {
                updateAllPlayed.remove();
            }

            if(updatePlayedSong != null)
            {
                updatePlayedSong.remove();
            }*/
        }
    }
}

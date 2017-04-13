using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVX_ScoreTracker
{
    public class Song
    {
        public string songName;
        public string songRomaji;
        public string difficulty;
        public int level;
        public long score;
        public string grade;

        public Song(string name, string romaji, int lvl, string dif, long sco, string gra)
        {
            this.songRomaji = romaji;
            this.songName = name;
            this.difficulty = dif;
            this.level = lvl;
            this.score = sco;
            this.grade = gra;
        }

        // Getters/setters
        public string getName()
        {
            return this.songName;
        }

        public string getRomaji()
        {
            return this.songRomaji;
        }

        public string getDif()
        {
            return this.difficulty;
        }

        public string getGrade()
        {
            return this.grade;
        }

        public int getLevel()
        {
            return this.level;
        }

        public long getScore()
        {
            return this.score;
        }

        public void updateScore(long newScore)
        {
            this.score = newScore;
        }

        public void updateGrade(string newGrade)
        {
            this.grade = newGrade;
        }
    }
}

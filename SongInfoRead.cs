using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDVX_ScoreTracker
{

    public class SongInfoRead
    {
        public Dictionary<string, Song> allSong;
        public Dictionary<string, Song> playedSong;

        public SongInfoRead()
        {
            allSong = new Dictionary<string, Song>();
            playedSong = new Dictionary<string, Song>();
            readAllSongs();
            readPlayedSongs();
        }

        public void readAllSongs()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"SavedSongs\AllSongs.txt");
            if (File.Exists(path)) {
                string[] songs = System.IO.File.ReadAllLines(path);
                if (songs.Length != 0)
                {
                    foreach (string line in songs)
                    {
                        string[] separated = line.Split(' ');
                        Song eachSong;

                        if (separated.Length == 6)
                        {
                            eachSong = new Song(separated[0], separated[1], Convert.ToInt32(separated[2]), separated[3], Convert.ToInt64(separated[4]), separated[5]);
                            allSong.Add(eachSong.songName.ToLower(), eachSong);
                        }

                        else if (separated.Length == 5)
                        {
                            eachSong = new Song(" ", separated[0], Convert.ToInt32(separated[1]), separated[2], Convert.ToInt64(separated[3]), separated[4]);
                            allSong.Add(eachSong.songName.ToLower(), eachSong);
                        }
                    }
                }
            }
        }

        public void readPlayedSongs()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"SavedSongs\PlayedSongs.txt");
            if (File.Exists(path))
            {
                string[] songs = System.IO.File.ReadAllLines(path);
                if (songs.Length != 0)
                {
                    foreach (string line in songs)
                    {
                        string[] separated = line.Split(' ');
                        Song eachSong = null;

                        if (separated.Length == 6)
                        {
                            eachSong = new Song(separated[0], separated[1], Convert.ToInt32(separated[2]), separated[3], Convert.ToInt64(separated[4]), separated[5]);
                            playedSong.Add(eachSong.songName.ToLower(), eachSong);
                        }

                        else if (separated.Length == 5)
                        {
                            eachSong = new Song(" ", separated[0], Convert.ToInt32(separated[1]), separated[2], Convert.ToInt64(separated[3]), separated[4]);
                            playedSong.Add(eachSong.songName.ToLower(), eachSong);
                        }
                    }
                }
            }
        }

        public Dictionary<string,Song> getSongList()
        {
            return this.allSong;
        }

        public Dictionary<string, Song> getPlayedList()
        {
            return this.playedSong;
        }
    }
}

using System;
using System.Collections.Generic;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songDetails = Console.ReadLine().Split("_");
                Song song = new Song(songDetails[0], songDetails[1], songDetails[2]);
                songs.Add(song);
            }
            string style = Console.ReadLine();
            if (style == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == style)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
        class Song
        {
            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }

            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
    }
}

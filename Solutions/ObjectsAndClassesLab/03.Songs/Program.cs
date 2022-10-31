using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song>  songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                songs.Add(new Song());
                songs[i].TypeList = input[0];
                songs[i].Name = input[1];
                songs[i].Time = input[2];
            }

            string typeList = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].TypeList == typeList)
                {
                    Console.WriteLine(songs[i].Name);
                }
                else if(typeList == "all")
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Classes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Human Andy = new Composer("Andy", "10.10.1990");
            Human Freddy = new Singer("Freddy", "12.12.1987", "Falsetto");
            Song firstSong = Andy.CreateSong("First Song", "Pop", 200);
            //firstSong.SetPerformer(Freddy);
            firstSong.GetInfo();
            Console.WriteLine();

            Song ffirstSong = Freddy.CreateSong("First Song", "Pop", 200);
            //ffirstSong.SetPerformer(Freddy);
            ffirstSong.GetInfo();
            Console.WriteLine();

            List<Song> songs = new List<Song>();
            songs.Add(firstSong);
            Album album = new Album("FirstAlbum", 2018, songs, Freddy);
            Song secondSong = new Song("Second Song", "Pop", 192);
            album.AddSong(secondSong);
            album.GetInfo();
            Console.WriteLine();

            List<Human> humans = new List<Human>();
            humans.Add(Andy);
            humans.Add(Freddy);
            SoundRecordingStudio studio = new SoundRecordingStudio("Studio", 1990);
            studio.CreateContract(firstSong, humans);
            studio.GetContractsInfo();
            Console.Read();
        }
    }
}

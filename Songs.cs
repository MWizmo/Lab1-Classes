using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Classes
{
    class Song
    {
        private string title;
        private string genre;
        private int duration;
        private string text;
        private Human performer;
        private Human wordsAuthor;
        private Human musicAuthor;

        public Song(string title, string genre, int duration)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
            this.text = "";
        }

        public Song(string title, string genre, int duration, Composer composer)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
            this.musicAuthor = composer;
            this.text = "";
        }

        public Song(string title, string genre, int duration, Singer singer)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
            this.performer = singer;
            this.text = "";
        }

        public Song(string title, string genre, int duration, Poet poet)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
            this.wordsAuthor = poet;
            this.text = "";
        }

        public void SetPerformer(Singer singer)
        {
            this.performer = singer;
        }

        public void SetComposer(Composer composer)
        {
            this.musicAuthor = composer;
        }

        public void SetPoet(Poet poet)
        {
            this.wordsAuthor = poet;

        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Title: {title}\nDuration: {duration} sec\nGenre: {genre}");
            if (text == "")
                Console.WriteLine("Text is empty yet");
            else
                Console.WriteLine($"Text: {text}");
            try
            {
                Console.WriteLine($"Performer: {performer.GetInfo()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Song doesn't have a performer yet");
            }
            try
            {
                Console.WriteLine($"Composer: {musicAuthor.GetInfo()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Song doesn't have a composer yet");
            }
            try
            {
                Console.WriteLine($"Author of words: {wordsAuthor.GetInfo()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Song doesn't have an author of words yet");
            }
        }

        public string GetTitle()
        {
            return this.title;
        }

        public Human GetPerformer()
        {
            return this.performer;
        }
    }

    class SongsCollection
    {
        protected List<Song> songs;
        protected string title;
        protected int yearOfRelise;

        public SongsCollection(string title, int year, List<Song> songs)
        {
            this.title = title;
            this.songs = songs;
            this.yearOfRelise = year;
        }

        public void AddSong(Song s)
        {
            this.songs.Add(s);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Collection {this.title}");
            Console.WriteLine("List of Songs:");
            for (int i = 0; i < songs.Count; ++i)
            {
                Console.WriteLine("----------");
                Console.WriteLine($"Song №{i + 1}: {songs[i].GetTitle()}. Performer: {songs[i].GetPerformer().GetName()}");
            }
        }
    }

    class Album : SongsCollection
    {
        private Singer author;

        public Album(string title, int year, List<Song> songs, Singer author)
            : base(title, year, songs)
        {
            this.author = author;
        }

        new public void GetInfo()
        {
            Console.WriteLine($"Collection {this.title}");
            Console.WriteLine($"Author: {this.author.GetName()}");
            Console.WriteLine("List of Songs:");
            for (int i = 0; i < songs.Count; ++i)
            {
                Console.WriteLine("----------");
                Console.WriteLine($"Song №{i + 1}: {songs[i].GetTitle()}");
            }
        }

    }
}

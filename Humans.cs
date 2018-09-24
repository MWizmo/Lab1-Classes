using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Classes
{
    interface IMusician
    {
        Song CreateSong(string title, string genre, int duration);
    }

    abstract class Human
    {
        protected string name;
        protected string birthDate;

        public Human(string name, string birthdate)
        {
            this.name = name;
            this.birthDate = birthdate;
        }

        public virtual Song CreateSong(string title, string genre, int duration)
        {
            return new Song(title, genre, duration);
        }

        public string GetInfo()
        {
            return $"{name}, birthdate: {birthDate}";
        }

        public string GetName()
        {
            return this.name;
        }
    }

    class Singer : Human, IMusician
    {
        private string timbreOfVoice;

        public Singer(string name, string birthdate, string timbre)
            : base(name, birthdate)
        {
            timbreOfVoice = timbre;
        }

    }

    class Composer : Human, IMusician
    {
        public Composer(string name, string birthdate)
            : base(name, birthdate)
        {

        }

        public override Song CreateSong(string title, string genre, int duration)
        {
            return new Song(title, genre, duration, this);
        }
    }

    class Poet : Human, IMusician
    {
        public Poet(string name, string birthdate)
            : base(name, birthdate)
        {

        }

        public override Song CreateSong(string title, string genre, int duration)
        {
            return new Song(title, genre, duration, this);
        }

        public string CreateText()
        {
            return "Some Text";
        }
    }
}

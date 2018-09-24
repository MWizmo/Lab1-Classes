using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Classes
{
    class SoundRecordingStudio
    {
        private string title;
        private int foundationDate;
        private List<Contract> contracts;

        public SoundRecordingStudio(string title, int year)
        {
            this.title = title;
            this.foundationDate = year;
            this.contracts = new List<Contract>();
        }

        public void AddContract(Contract c)
        {
            this.contracts.Add(c);
        }

        public void CreateContract(Song song, List<Human> authors)
        {
            Contract c = new Contract(song, authors, this);
            this.contracts.Add(c);
        }

        public void GetContractsInfo()
        {
            Console.WriteLine($"Contracts of {this.title}:");
            for (int i = 0; i < contracts.Count; ++i)
                Console.WriteLine(contracts[i].GetInfo());
        }
    }

    class Contract
    {
        public Song song { get; set; }
        public List<Human> authors { get; set; }
        public SoundRecordingStudio studio { get; set; }

        public Contract(Song s, List<Human> authors, SoundRecordingStudio st)
        {
            this.song = s;
            this.authors = authors;
            this.studio = st;
        }

        public string GetInfo()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"Song: {song.GetTitle()}\nCreators:\n");
            for (int i = 0; i < authors.Count; ++i)
            {
                s.Append(authors[i].GetName());
                if (i != authors.Count - 1)
                    s.Append(", ");
            }
            return s.ToString();
        }
    }
}

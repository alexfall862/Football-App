using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlaybookMaker
    {
        public List<Plays> _playlist = new List<Plays>();

        public List<Plays> PlayList
        {
            get { return _playlist; }
            set { _playlist = value; }
        }


        public void PlaybookGenerator(string name)
        {
            string filePath = @"C:\Users\alexf\source\repos\Football App\Playbooks\" + name + ".txt";
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                object[] items = line.Split(',');
                Plays p = new Plays(name, Convert.ToString(items[0]), Convert.ToString(items[1]), Convert.ToInt32(items[2]));
                _playlist.Add(p);
            }
            //foreach (Plays play in _playlist)
            //{
            //    Console.WriteLine(play.PlayTeam + play.PlayType + play.PlayName);
            //}
        }
    }
}

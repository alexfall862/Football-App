using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FootballApp
{
    public class Plays
    {
        public Plays(string playTeam, string playType, string playName, int playWeight)
        {
            PlayTeam = playTeam;
            PlayType = playType;
            PlayName = playName;
            PlayWeight = playWeight;
            TotalPlayWeight = 0;
        }

        public string PlayTeam { get; set; }
        public string PlayType { get; set; }
        public string PlayName { get; set; }
        public int PlayWeight { get; set; }
        public int TotalPlayWeight { get; set; }



        //public void ReadPlaybooks(string nameofbook)
        //{
        //    var Playbook = new List<PlayCalls>();
        //    string name = nameofbook;
        //    string file = @"C:\Users\alexf\OneDrive\Documents\FootballApp\"+name+".txt";
        //    foreach(string play in File.ReadAllLines(file))
        //    {
        //        Console.WriteLine(play);
        //    }
        //}
    }
}

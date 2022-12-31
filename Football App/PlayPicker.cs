using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlayPicker
    {
        public Plays PlayCallChooser(List<FootballApp.Plays> a, string playtype, int playid, bool hpossession)
        {

            if (hpossession == true)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<Plays> cfdas = new List<Plays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeOffensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                Plays selectedhplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedhplay = p;
                        //Console.WriteLine("Selected Play is: " + selectedhplay.PlayName);
                        GameValues._hplaycalltype = selectedhplay.PlayType;
                        GameValues._hplaycall = selectedhplay.PlayName;
                        return selectedhplay;

                    }
                }
            }
            else if (hpossession == false)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<Plays> cfdas = new List<Plays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeOffensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                Plays selectedaplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedaplay = p;
                        //Console.WriteLine("Selected Play is: " + selectedaplay.PlayName);
                        GameValues._aplaycalltype = selectedaplay.PlayType;
                        GameValues._aplaycall = selectedaplay.PlayName;
                        return selectedaplay;

                    }
                }
            }
            Console.WriteLine($"PlayID: " + GameValues._playid + "\tHomePlayName: " + GameValues._hplaycall + "\tAwayPlayName: " + GameValues._aplaycall);
            Plays testplay = a.First();
            return testplay;
        }

        public Plays PlayCallReactor(List<FootballApp.Plays> a, string playtype, int playid, bool hpossession)
        {

            if (hpossession == true)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<Plays> cfdas = new List<Plays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "AwayDefensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                Plays selectedaplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedaplay = p;
                        //Console.WriteLine("Selected Play is: " + selectedaplay.PlayName);
                        GameValues._aplaycalltype = selectedaplay.PlayType;
                        GameValues._aplaycall = selectedaplay.PlayName;
                        return selectedaplay;
                    }
                }
            }
            else if (hpossession == false)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<Plays> cfdas = new List<Plays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeDefensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                Plays selectedhplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedhplay = p;
                        //Console.WriteLine("Selected Play is: " + selectedhplay.PlayName);
                        GameValues._hplaycalltype = selectedhplay.PlayType;
                        GameValues._hplaycall = selectedhplay.PlayName;
                        return selectedhplay;

                    }
                }
            }
            Console.WriteLine($"*****************PlayID: " + GameValues._playid + "\tHomePlayName: " + GameValues._hplaycall + "\tAwayPlayName: " + GameValues._aplaycall);
            Plays testplay = a.First();
            return testplay;
        }
    }
}

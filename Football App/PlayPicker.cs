using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlayPicker
    {
        public OffensivePlays PlayCallChooser(List<FootballApp.OffensivePlays> a, string playtype, int playid, bool hpossession)
        {

            if (hpossession == true)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<OffensivePlays> cfdas = new List<OffensivePlays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeOffensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                OffensivePlays selectedhplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedhplay = p;
                        GameValues._passer = selectedhplay.Specialist;
                        GameValues._rusher = selectedhplay.Runner;
                        GameValues._hplaycalltype = selectedhplay.PlayType;
                        GameValues._hplaycall = selectedhplay.PlayName;
                        //Console.WriteLine("Selected Play is: " + selectedhplay.PlayName);
                        //Console.WriteLine("Passer is: " + selectedhplay.Specialist + "and Runner is: " + selectedhplay.Runner);
                        return selectedhplay;

                    }
                }
            }
            else if (hpossession == false)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<OffensivePlays> cfdas = new List<OffensivePlays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeOffensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                OffensivePlays selectedaplay;
                foreach (var p in cfdas)
                {
                    if (_randomNumber < p.TotalPlayWeight)
                    {
                        selectedaplay = p;
                        //Console.WriteLine("Selected Play is: " + selectedaplay.PlayName);
                        GameValues._passer = selectedaplay.Specialist;
                        GameValues._rusher = selectedaplay.Runner;
                        GameValues._aplaycalltype = selectedaplay.PlayType;
                        GameValues._aplaycall = selectedaplay.PlayName;
                        return selectedaplay;

                    }
                }
            }
            Console.WriteLine($"PlayID: " + GameValues._playid + "\tHomePlayName: " + GameValues._hplaycall + "\tAwayPlayName: " + GameValues._aplaycall);
            OffensivePlays testplay = a.First();
            return testplay;
        }

        public DefensivePlays PlayCallReactor(List<FootballApp.DefensivePlays> a, string playtype, int playid, bool hpossession)
        {

            if (hpossession == true)
            {
                Random _rand = new Random();
                int playtotalweight = 0;
                List<DefensivePlays> cfdas = new List<DefensivePlays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "AwayDefensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                DefensivePlays selectedaplay;
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
                List<DefensivePlays> cfdas = new List<DefensivePlays>();
                foreach (var p in a.Where(p => p.PlayType == playtype & p.PlayTeam == "HomeDefensivePlays"))
                {
                    playtotalweight += p.PlayWeight;
                    p.TotalPlayWeight = playtotalweight;
                    cfdas.Add(p);
                }

                //Console.WriteLine("Total Play Weight is: " + playtotalweight);
                int _randomNumber = _rand.Next(0, playtotalweight);
                //Console.WriteLine("Random number is: " + _randomNumber);
                DefensivePlays selectedhplay;
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
            Console.WriteLine($"No Play Selected!!!*****************PlayID: " + GameValues._playid + "\tHomePlayName: " + GameValues._hplaycall + "\tAwayPlayName: " + GameValues._aplaycall);
            DefensivePlays testplay = a.First();
            return testplay;
        }
    }
}

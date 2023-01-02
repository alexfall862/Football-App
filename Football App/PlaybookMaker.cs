using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlaybookMaker
    {
        public List<OffensivePlays> _oplaylist = new List<OffensivePlays>();
        public List<DefensivePlays> _dplaylist = new List<DefensivePlays>();


        public List<OffensivePlays> OPlayList
        {
            get { return _oplaylist; }
            set { _oplaylist = value; }
        }

        public List<DefensivePlays> DPlayList
        {
            get { return _dplaylist; }
            set { _dplaylist = value; }
        }

        public void OffensivePlaybookGenerator(string name)
        {
            string filePath = @"C:\Users\alexf\source\repos\Football App\Playbooks\" + name + ".txt";
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).Skip(1).ToList();
            foreach (string line in lines)
            {
                object[] items = line.Split(',');
                OffensivePlays p = new OffensivePlays (
                    name, 
                    Convert.ToString(items[0]) ?? "", 
                    Convert.ToString(items[1]) ?? "", 
                    Convert.ToString(items[2]) ?? "", 
                    Convert.ToString(items[3]) ?? "",
                    Convert.ToInt32(items[4]),
                    Convert.ToInt32(items[5]),
                    Convert.ToInt32(items[6]),
                    Convert.ToInt32(items[7]),
                    Convert.ToBoolean(items[8]),
                    Convert.ToString(items[9]) ?? "",
                    Convert.ToString(items[10]) ?? "",
                    Convert.ToString(items[11]) ?? "",
                    Convert.ToString(items[12]) ?? "",
                    Convert.ToString(items[13]) ?? "",
                    Convert.ToString(items[14]) ?? "",
                    Convert.ToString(items[15]) ?? "",
                    Convert.ToString(items[16]) ?? "",
                    Convert.ToString(items[17]) ?? "",
                    Convert.ToString(items[18]) ?? "",
                    Convert.ToString(items[19]) ?? "",
                    Convert.ToString(items[20]) ?? "",
                    Convert.ToInt32(items[21]),
                    Convert.ToString(items[22]) ?? "",
                    Convert.ToString(items[23]) ?? "",
                    Convert.ToString(items[24]) ?? "",
                    Convert.ToString(items[25]) ?? "",
                    Convert.ToString(items[26]) ?? "",
                    Convert.ToString(items[27]) ?? "",
                    Convert.ToString(items[28]) ?? "",
                    Convert.ToString(items[29]) ?? "",
                    Convert.ToString(items[30]) ?? "",
                    Convert.ToString(items[31]) ?? "",
                    Convert.ToString(items[32]) ?? "",
                    Convert.ToString(items[33]) ?? "",
                    Convert.ToString(items[34]) ?? "",
                    Convert.ToString(items[35]) ?? "",
                    Convert.ToString(items[36]) ?? "",
                    Convert.ToString(items[37]) ?? "",
                    Convert.ToString(items[38]) ?? "",
                    Convert.ToString(items[39]) ?? "",
                    Convert.ToString(items[40]) ?? ""
                    );
                _oplaylist.Add(p);
            }
            //foreach (Plays play in _playlist)
            //{
            //    Console.WriteLine(play.PlayTeam + play.PlayType + play.PlayName);
            //}
        }

        public void DefensivePlaybookGenerator(string name)
        {
            string filePath = @"C:\Users\alexf\source\repos\Football App\Playbooks\" + name + ".txt";
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).Skip(1).ToList();
            foreach (string line in lines)
            {
                object[] items = line.Split(',');
                DefensivePlays p = new DefensivePlays(
                    name, 
                    Convert.ToString(items[0]) ?? "", 
                    Convert.ToString(items[1]) ?? "",
                    Convert.ToString(items[2]) ?? "",
                    Convert.ToString(items[3]) ?? "",
                    Convert.ToInt32(items[4]),
                    Convert.ToInt32(items[5]),
                    Convert.ToString(items[6]) ?? "",
                    Convert.ToString(items[7]) ?? "",
                    Convert.ToString(items[8]) ?? "",
                    Convert.ToString(items[9]) ?? "",
                    Convert.ToString(items[10]) ?? "",
                    Convert.ToString(items[11]) ?? "",
                    Convert.ToString(items[12]) ?? "",
                    Convert.ToString(items[13]) ?? "",
                    Convert.ToString(items[14]) ?? "",
                    Convert.ToString(items[15]) ?? "",
                    Convert.ToString(items[16]) ?? "",
                    Convert.ToString(items[17]) ?? "",
                    Convert.ToString(items[18]) ?? "",
                    Convert.ToString(items[19]) ?? "",
                    Convert.ToString(items[20]) ?? "",
                    Convert.ToString(items[21]) ?? "",
                    Convert.ToString(items[22]) ?? "",
                    Convert.ToString(items[23]) ?? "",
                    Convert.ToString(items[24]) ?? "",
                    Convert.ToString(items[25]) ?? "",
                    Convert.ToString(items[26]) ?? "",
                    Convert.ToString(items[27]) ?? "",
                    Convert.ToString(items[28]) ?? "",
                    Convert.ToString(items[29]) ?? "",
                    Convert.ToString(items[30]) ?? "",
                    Convert.ToString(items[31]) ?? "",
                    Convert.ToString(items[32]) ?? "",
                    Convert.ToString(items[33]) ?? "",
                    Convert.ToString(items[34]) ?? "",
                    Convert.ToString(items[35]) ?? "",
                    Convert.ToString(items[36]) ?? "",
                    Convert.ToString(items[37]) ?? "",
                    Convert.ToString(items[38]) ?? "",
                    Convert.ToString(items[39]) ?? "",
                    Convert.ToString(items[40]) ?? "",
                    Convert.ToString(items[41]) ?? "",
                    Convert.ToString(items[42]) ?? "",
                    Convert.ToString(items[43]) ?? "",
                    Convert.ToString(items[44]) ?? "",
                    Convert.ToString(items[45]) ?? "",
                    Convert.ToString(items[46]) ?? "",
                    Convert.ToString(items[47]) ?? "",
                    Convert.ToString(items[48]) ?? "",
                    Convert.ToString(items[49]) ?? "",
                    Convert.ToString(items[50]) ?? "",
                    Convert.ToString(items[51]) ?? "",
                    Convert.ToString(items[52]) ?? "",
                    Convert.ToString(items[53]) ?? "",
                    Convert.ToString(items[54]) ?? "",
                    Convert.ToString(items[55]) ?? "",
                    Convert.ToString(items[56]) ?? "",
                    Convert.ToString(items[57]) ?? "",
                    Convert.ToString(items[58]) ?? ""
                    );
                    
                _dplaylist.Add(p);
            }
            //foreach (Plays play in _playlist)
            //{
            //    Console.WriteLine(play.PlayTeam + play.PlayType + play.PlayName);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class DefensivePlays
    {
        public DefensivePlays(
            string playTeam, 
            string playType, 
            string playFormation,
            string playCategory,
            string playName, 
            int wrCount,
            int playWeight,
            string[] blitzers,
            //string blitzer2,
            //string blitzer3,
            //string blitzer4,
            //string blitzer5,
            //string blitzer6,
            //string blitzer7,
            //string blitzer8,
            //string blitzer9,
            //string blitzer10,
            //string blitzer11,
            string[] manlist,
            //string man1,
            //string man2,
            //string man3,
            //string man4,
            //string man5,
            string qbSpy,
            string[,] fieldArray
            )
        {
            PlayTeam = playTeam;
            PlayType = playType;
            PlayFormation = playFormation;
            PlayCategory = playCategory;
            PlayName = playName;
            WrCount = wrCount;
            PlayWeight = playWeight;
            Blitzer1 = blitzers;
            //Blitzer2 = blitzer2;
            //Blitzer3 = blitzer3;
            //Blitzer4 = blitzer4;
            //Blitzer5 = blitzer5;
            //Blitzer6 = blitzer6;
            //Blitzer7 = blitzer7;
            //Blitzer8 = blitzer8;
            //Blitzer9 = blitzer9;
            //Blitzer10 = blitzer10;
            //Blitzer11 = blitzer11;
            ManList = manlist;
            //Man1 = man1;
            //Man2 = man2;
            //Man3 = man3;
            //Man4 = man4;
            //Man5 = man5;
            QbSpy = qbSpy;
            FieldArray = fieldArray;
            TotalPlayWeight = 0;
        }


        public string PlayFormation  { get; set; }
        public string PlayCategory { get; set; }
        public int WrCount  { get; set; }

        public string[] Blitzer1  { get; set; }
        //public string Blitzer2  { get; set; } 
        //public string Blitzer3  { get; set; } 
        //public string Blitzer4  { get; set; } 
        //public string Blitzer5  { get; set; } 
        //public string Blitzer6  { get; set; } 
        //public string Blitzer7  { get; set; } 
        //public string Blitzer8  { get; set; } 
        //public string Blitzer9  { get; set; } 
        //public string Blitzer10  { get; set; } 
        //public string Blitzer11  { get; set; }
        
        public string[] ManList { get; set; }
        //public string Man1  { get; set; } 
        //public string Man2  { get; set; } 
        //public string Man3  { get; set; } 
        //public string Man4  { get; set; } 
        //public string Man5  { get; set; } 
        public string QbSpy  { get; set; } 
        public string[,] FieldArray { get; set; }

        public string PlayTeam { get; set; }
        public string PlayType { get; set; }
        public string PlayName { get; set; }
        public int PlayWeight { get; set; }
        public int TotalPlayWeight { get; set; }
    }
}

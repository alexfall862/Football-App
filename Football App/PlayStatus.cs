using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApp
{
    public class PlayStatus
    {
        public int _playID;
        public int _yardage;
        public bool _homePossession;
        public int _down;
        public int _htscore;
        public int _atscore;
        public bool _turnoverondowns = false;
        public bool _interception = false;
        public bool _fumble = false;
        public int _yardstogo;
        public bool _firstdownachieved = false;
        public int _los;
        public bool _td = false;
        public bool _dtd = false;
        public bool _safety = false;
        public bool _dsafety = false;
        public bool _fggood = false;
        public bool _fgbad = false;
        public bool _xpgood = false;
        public bool _xpbad = false;
        public bool _twoconv = false;
        public bool _dtwoconvreturned = false;
        public int _quarter;
        public int _time;
        public bool _extrapointtry;
        public bool _kickoff;
        public string _playtype = "";
        public bool _punt = false;
        public bool _safetypunt = false;
        public bool _puntattempt = false;
        public bool _touchback = false;
        public string _hplaycall = "";
        public string _aplaycall = "";
        public int _presnaprunoff = 0;
        public int _playlength = 0;
        public int _kpreturnyards = 0;
        public int _dreturnyards = 0;
        public int _kickyards = 0;
        public int KickYards
        {
            get { return _kickyards; }
            set { _kickyards = value; }
        }
        public int DReturnYards
        {
            get { return _dreturnyards; }
            set { _dreturnyards = value; }
        }

        public int KPReturnYards
        {
            get { return _kpreturnyards; }
            set { _kpreturnyards = value; }
        }

        public int PlayLength
        {
            get { return _playlength; }
            set { _playlength = value; }
        }
        public int PreSnapRunoff
        {
            get { return _presnaprunoff; }
            set { _presnaprunoff = value; }
        }

        public string HPlayCall
        {
            get { return _hplaycall; }
            set { _hplaycall = value; }
        }
        public string APlayCall
        {
            get { return _aplaycall; }
            set { _aplaycall = value; }
        }

        public bool Touchback
        {
            get { return _touchback; }
            set { _touchback = value; }
        }
        public bool PuntAttempt
        {
            get { return _puntattempt; }
            set { _puntattempt = value; }
        }

        public bool Punt
        {
            get { return _punt; }
            set { _punt = value; }
        }

        public bool SafetyPunt
        {
            get { return _safetypunt; }
            set { _punt = value; }
        }

        public string PlayType
        {
            get { return _playtype; }
            set { _playtype = value; }
        }

        public bool Kickoff
        {
            get { return _kickoff; }
            set { _kickoff = value; }
        }

        public bool ExtraPointTry
        {
            get { return _extrapointtry; }
            set { _extrapointtry = value; }
        }

        public int Time
        {
            get { return _time; }   
            set { _time = value; } 
        }
        public int Quarter
        {
            get { return _quarter; }
            set { _quarter = value; }
        }

        public bool TwoConv
        {
            get { return _twoconv; }
            set { _twoconv = value; }
        }
        public bool TwoConvReturned
        {
            get { return _dtwoconvreturned; }
            set { _dtwoconvreturned = value; }
        }
        public bool Td
        {
            get { return _td; }
            set { _td = value; }
        }
        public bool DTd
        {
            get { return _dtd; }
            set { _dtd = value; }
        }
        public bool Safety
        {
            get { return _safety; }
            set { _safety = value; }
        }
        public bool DSafety
        {
            get { return _dsafety; }
            set { _dsafety = value; }
        }
        public bool FgGood
        {
            get { return _fggood; }
            set { _fggood = value; }
        }
        public bool FgBad
        {
            get { return _fgbad; }
            set { _fgbad = value; }
        }
        public bool XpGood
        {
            get { return _xpgood; }
            set { _xpgood = value; }
        }
        public bool XpBad
        {
            get { return _xpbad; }
            set { _xpbad = value; }
        }
        public int Los
        {
            get { return _los; }
            set { _los = value; }
        }
        public bool FirstDownAchieved
        {
            get { return _firstdownachieved; }
            set { _firstdownachieved = value; }
        }
        public int PlayID
        {
            get { return _playID; }
            set { _playID = value; }
        }
        public int YardsToGo
        {
            get { return _yardstogo; }
            set { _yardstogo = value; }
        }
        public int Yardage
        {
            get { return _yardage; }
            set { _yardage = value; }
        }
        public bool HomePossession
        {
            get { return _homePossession; }
            set { _homePossession = value; }
        }
        public int Down
        {
            get { return _down; }
            set { _down = value; }
        }
        public int HtScore
        {
            get { return _htscore; }
            set { _htscore = value; }
        }
        public int AtScore
        {
            get { return _atscore; }
            set { _atscore = value; }
        }
        public bool TurnoverOnDowns
        {
            get { return _turnoverondowns; }
            set { _turnoverondowns = value; }
        }
        public bool Interception
        {
            get { return _interception; }
            set { _interception = value; }
        }
        public bool Fumble
        {
            get { return _fumble; }
            set { _fumble = value; }
        }
        public PlayStatus(
            int playID,
            int yardage,
            bool homePossession,
            int down,
            int htscore,
            int atscore,
            int yardstogo,
            bool turnoverondowns,
            bool firstdownachieved,
            int los,
            bool td,
            bool dtd,
            bool fggood,
            bool safety,
            bool dsafety,
            bool xpgood,
            bool twoxp,
            bool twoxpreturned,
            int quarter,
            int time,
            bool extrapointtry,
            bool kickoff,
            string playtype,
            bool xpbad,
            bool punt,
            bool safetypunt,
            bool puntattempt,
            bool touchback,
            string hplaycall,
            string aplaycall,
            int presnaprunoff,
            int playlength,
            int kpreturnyards,
            int dreturnyards,
            int kickyards,
            bool fgbad
            )
        {
            this._playID = playID;
            this._yardage = yardage;
            this._homePossession = homePossession;
            this._down = down;
            this._htscore = htscore;
            this._atscore = atscore;
            this._yardstogo = yardstogo;
            this._turnoverondowns = turnoverondowns;
            this._firstdownachieved = firstdownachieved;
            this._los = los;
            this._td = td;
            this._dtd = dtd;
            this._fggood = fggood;
            this._safety = safety;
            this._dsafety = dsafety;
            this._xpgood = xpgood;
            this._twoconv = twoxp;
            this._dtwoconvreturned = twoxpreturned;
            this._quarter = quarter;
            this._time = time;
            this._extrapointtry = extrapointtry;
            this._kickoff = kickoff;
            this._playtype = playtype;
            this._xpbad = xpbad;
            this._punt = punt;
            this._safetypunt = safetypunt;
            this._puntattempt = puntattempt;
            this._touchback = touchback;
            this._hplaycall = hplaycall;
            this._aplaycall = aplaycall;
            this._presnaprunoff = presnaprunoff;
            this._playlength = playlength;
            this._kpreturnyards = kpreturnyards;
            this._dreturnyards = dreturnyards;
            this._kickyards = kickyards;
            this._fgbad = fgbad;
        }
    }
}

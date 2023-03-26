using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Team
    {
        public string teamName;
        public string teamCountry;
        public string teamCity;
        protected List<Player> playerslist;
        public List<Player> Playerslist
        {
            set { playerslist = value; }
            get { return playerslist; }
        }
    }
   


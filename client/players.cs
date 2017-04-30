using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace avalon
{
    class players   // game extensions in use
    {
        public players()
        {
        }
       
        public Tuple<string, string, bool> check()
        { 
            bool player_new = false;
            string s = "s";
            string d = "d";
            Tuple<string, string, bool> check_ret = new Tuple<string, string, bool>(s,d,player_new);
            return (check_ret);
        }

    }
}
     


using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace avalon
{

    class Program
    {
        static void Main(string[] args)
        {
            comm c = new comm();

            // GET a JSON document back from a collection in the DB 

            coll get1 = c.GET("Boards", "test_coll");
            // this option below will print all the Board json document with all the data and statused etc:
            string json = JsonConvert.SerializeObject(get1);
            Console.WriteLine(json);
            // this can get more details parameters from the json document:
            Console.WriteLine(get1.players_role.player2);
            Console.WriteLine(get1.status);

            coll get2 = c.GET("Players", "eden");
            string json2 = JsonConvert.SerializeObject(get2);
            // print all eden player:
            Console.WriteLine(json2);
            // or just some specific details:
            Console.WriteLine(get2.location);
            Console.WriteLine(get2.active_game);

            //coll get3 = c.GET("Missions", "game1m1");
            //Console.WriteLine(get3.leader);
            //Console.WriteLine(get3.team_count);
            //Console.WriteLine(get3.team[1]);
            //// or even :   Console.WriteLine(string.Join(",", get3.team.ToArray()));

            Console.Read();


            ////// GET a string back from DB that match query from "collection", where "key" = "value"

            //string getf = c.GETF("Players", "\"quests.m1q\"", "false");
            //Console.WriteLine(getf);
            //Console.Read();
            //Console.Read();

            //// POST a JSON document data to a collection in the DB

            //coll data = new coll();
            //data.name = "stamTESTgame";
            //data.status = "login";
            //data.players = new List<string> { "Arthur", "Betty", "koren", "yakov" };
            //data.variant = new Variant { mordred = true, lady = true, morgana = true, percival = true, excalibur = false };
            //data.game_password = "new-password";
            //string post = c.POST("Games", data);
            //Console.WriteLine(post);
            //Console.Read();
            //Console.Read();

            //// DELETE a document from a collection in the DB

            //string del = c.DELETE("Games", "stamTESTgame");
            //Console.WriteLine(del);
            //Console.Read();
            //Console.Read();

            //// UPDATE (PATCH) a document in a collection in the DB

            //coll update = new coll();
            //update.status = "game";
            //update.players = new List<string> { "me", "update", "Arthur", "Betty", "koren", "yakov" };
            //update.variant = new Variant { mordred = true, lady = true, morgana = true, percival = true, excalibur = true };
            //string patch = c.PATCH("Games", "demo-game", update);
            //Console.WriteLine(patch);
            //Console.Read();
            //Console.Read();
        }
       
    }
}

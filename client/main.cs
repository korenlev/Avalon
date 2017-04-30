using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace avalon
{
    class main
    {
        static void Main(string[] args)
        {
            // this is for test ...
            comm g = new comm();
            generic c = new generic("what do you think? test", "y", "");
            Console.WriteLine(c.gg());
            coll stam_game = g.GET("Games", "g");
            Console.WriteLine(stam_game.players[3]);
            Console.Read();
            // test ends here ...

            players p = new players();
            Tuple<string, string, bool> player = p.check();
            Console.WriteLine(player.Item1);
            Console.WriteLine(player.Item2);
            Console.WriteLine(player.Item3);
            Console.Read();
            Console.Read();



        }
    }
}

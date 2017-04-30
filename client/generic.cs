using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace avalon
{
    public class generic   // game extensions in use
    {

        public string q, def, answer;
        public generic(string q, string def, string answer)
        {
            this.q = q;
            this.def = def;
            this.answer = answer;
        }
        public string GetQuestion()
        {
            if (def.ToLower() == "n")
                return q + ("(y/N)");
            else if (def.ToLower() == "y") return q + ("(Y/n)");
            else return q + "(y/n)";
        }
        public void setAnswer()
        {
            answer = Console.ReadLine();
        }
        public bool ans()
        {
            if (answer.ToLower() == "n")
                return false;
            else if (answer.ToLower() == "y")
                return true;
            else if (answer == "")
            {
                if (def.ToLower() == "n")
                    return false;
                if (def.ToLower() == "y")
                    return true;
            }
            return false;
        }
        public bool gg()
        {
            Console.WriteLine(GetQuestion());
            do
            {
                answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                    return false;
                else if (answer.ToLower() == "y")
                    return true;
                else if (answer == "")
                {
                    if (def.ToLower() == "n")
                        return false;
                    if (def.ToLower() == "y")
                        return true;
                }
                else
                    Console.WriteLine(GetQuestion());
            } while (answer.ToLower() != "n" || answer.ToLower() != "y" || answer.ToLower() != "");


            return false;
        }
    }
}

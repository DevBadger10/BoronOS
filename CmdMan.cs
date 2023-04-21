using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;

namespace BoronOS
{
    public class CmdMan
    {
        public static void command(string str)
        {
            string[] cmd = str.Split(" ");
            switch (cmd[0])
            {
                case "help" or "man" or "manual":
                    Cmd.help(cmd);
                    break;
                case "about":
                    Cmd.about(cmd);
                    break;
                case "echo":
                    Cmd.echo(cmd);
                    break;
            }

        }
    }

    class Cmd 
    { 
        public static void help(string[] com) 
        { 
            BoronOS.CMD_Help.help(com);
        }

        public static void about(string[] com)
        {
            Console.WriteLine("BoronOS is an OS made by DaringBadger.");
        }

        public static void echo(string[] com)
        {
            string[] ccom = com;
            ccom[0] = BoronOS.Global.BOSAppend;
            foreach (string arg in ccom)
            {
                Console.Write(arg);
                Console.Write(" ");
            }
            Console.WriteLine("");
        }
    }
}

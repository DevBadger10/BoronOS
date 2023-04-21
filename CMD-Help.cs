using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using static Cosmos.HAL.BlockDevice.ATA_PIO;
using Sys = Cosmos.System;

namespace BoronOS
{
    public class CMD_Help
    {
        public static void help(string[] str)
        {
            if (str.Length == 1)
            {
                Console.Write(
                    "This is a list of all commands contained in BoronOS. \n\r" +
                    "The help command you have just ran has a specific syntax. For more information on this syntax, please run !help help! for info on the syntax used. \n\r" +
                    "For more information on a specific command, please execute !help <command>!. \n\r \n\r" +

                    "!help |command|! - Gain help on the usage of things in BoronOS while allowing you to specify a specific command. \n\r" +
                    "!about! - Gain information about BoronOS. \n\r" +
                    "!echo <Text>! - Copy text into the console. \n\r");
            }
            else
            {
                writeCommand(str);
            }
        }

        static void writeCommand(string[] str)
        {
            switch (str[1])
            {
                case "help" or "man" or "manual":
                    Console.WriteLine("The syntax of the !help |command|! command is an interesting one. \n\rCommands are specified with !command!. \n\rMandatory variables are specified with <parameter>. \n\rOptional variables, such as |command|, are specified with |parameter|. \n\r|command| is a command you can run, such as !help |command|!.");
                    break;
                case "about":
                    Console.WriteLine("This command gives you information about BoronOS.");
                    break;
                case "echo":
                    Console.WriteLine("!echo <text>! echoes <text> back to you in the console, prefaced by " + BoronOS.Global.BOSAppend + ". In the event of <text> being absent, it echoes back only " + BoronOS.Global.BOSAppend + ".");
                    break;
                default:
                    Console.WriteLine("The command specified is not valid.");
                    break;
            }
        }
    }
}
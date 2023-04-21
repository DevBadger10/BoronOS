using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks.Dataflow;
using Sys = Cosmos.System;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        string dStart = "User@bOS";
        protected override void BeforeRun()
        {
            Console.SetWindowSize(120, 90);
            Console.Clear();
            dStart += BoronOS.Global.BOSAppend;
            dStart += " ";
            Console.WriteLine("BoronOS v" + BoronOS.Global.BOSVersion);
        }

        protected override void Run()
        {
            Console.Write(dStart);
            var input = Console.ReadLine();
            BoronOS.CmdMan.command(input);
        }

        protected override void AfterRun()
        {
            Console.WriteLine("Exiting...");
        }
    }
}
using Cosmos.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosKernel1
{
    public class Kernel : Sys.Kernel
    {
        string cStart = "User@bOS]- ";
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("BoronOS v" + BoronOS.Global.BOSVersion);
        }

        protected override void Run()
        {
            Console.Write(cStart);
            var input = Console.ReadLine();
            BoronOS.ComCall.command(input);
        }

        protected override void AfterRun()
        {
            Console.WriteLine("Exiting...");
        }
    }
}
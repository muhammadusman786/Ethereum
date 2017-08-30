using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nethereum.Tutorials;

namespace TestDeployment
{
    class Program
    {
        static void Main(string[] args)
        {
            Deployment dep = new Deployment();
            dep.ShouldBeAbleToDeployAContract().Wait();
        }
    }
}

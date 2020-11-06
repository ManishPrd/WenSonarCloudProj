using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenSonarCloudProj
{
    public class SonarDemo
    {
        public static void DoSomething()
        {
            // Do nothing because of X and Y.
            //Console.WriteLine("Do Work");
        }
        public static void GetGuid(byte[] bytes)
        {
            //var g1 = Guid.Empty;
            //var g2 = Guid.NewGuid();
            //var g3 = new Guid(bytes);

            var g = new Guid();
        }
    }
}

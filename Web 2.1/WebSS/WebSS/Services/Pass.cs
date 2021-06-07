using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;
namespace WebSS.Services
{
    public class Pass
    {
        public double f { get; set; }
        public double s { get; set; }
        public Pass()
        {
            Random rnd = new Random();
            f = rnd.Next(0, 10);
            s = rnd.Next(0, 10);
        }

        public string format(string symbol, double result)
        {
            return f + symbol + s + " = " + result; 
        }
        public string add()
        {
            return format(" + ", f + s);
        }
        public string sub()
        {
            return format(" - ", f - s);
        }

        public string mult()
        {
            return format(" * ", f * s);
        }

        public string div()
        {
            return format(" / ", Math.Round(f / s,2));     
        }
    }
}

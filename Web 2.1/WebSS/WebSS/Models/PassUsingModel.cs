
using System;

namespace WebSS.Models
{
    public class PassUsingModel
    {

        public double FirstRand { get; set; }
        public double SecondRand { get; set; }

        public PassUsingModel()
        {
            Random rnd = new Random();
            FirstRand = rnd.Next(0, 10);
            SecondRand = rnd.Next(0, 10);
        }

        public string format(string symbol, double result)
        {
            return FirstRand + symbol + SecondRand + " = " + result;
        }
        public string add()
        {
            return format(" + ", FirstRand + SecondRand);
        }
        public string sub()
        {
            return format(" - ", FirstRand + SecondRand);
        }

        public string mult()
        {
            return format(" * ", FirstRand + SecondRand);
        }

        public string div()
        {
            try
            {
                return format(" / ", Math.Round(FirstRand / SecondRand, 2));
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

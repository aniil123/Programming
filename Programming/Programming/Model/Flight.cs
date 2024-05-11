using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        private string beginning { get; set; }
        private string end { get; set; }
        private int minuts;
        public int Minuts
        {
            get
            {
                return minuts;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                minuts = value;
            }
        }
        public Flight()
        {
            beginning = "nach";
            end = "kon";
            minuts = 60;
        }
        public Flight(string beginning, string end, int minuts)
        {
            this.beginning = beginning;
            this.end = end;
            Minuts = minuts;
        }
    }
}

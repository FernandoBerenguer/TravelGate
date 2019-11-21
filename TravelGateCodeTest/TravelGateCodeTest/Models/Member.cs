using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGateCodeTest.Models
{
    public class Member
    {
        public IEnumerable<string> Subordinates { get; set; }
        public string Boss { get; set; }
        public string Name { get; set; }
        public int Seniority { get; set; }
    }
}

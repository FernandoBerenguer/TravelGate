﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGateCodeTest.Models
{
    public class Main
    {
        public Main()
        {
            // fill the member list
            var memberList = new List<Member>()
            {
                new Member()
                {
                    Name = "Jhon",
                    Boss = "Andy",
                    Seniority = 4,
                    Subordinates = new List<string>()
                    {
                      "Francis",
                      "Pascual"
                    }
                },
                new Member()
                {
                    Name = "Francis",
                    Boss = "Jhon",
                    Seniority = 1,
                    Subordinates = new List<string>()
                    { }
                },
                new Member()
                {
                    Name = "Pascual",
                    Boss = "Jhon",
                    Seniority = 3,
                    Subordinates = new List<string>()
                    { }
                },
                new Member()
                {
                    Name = "Petrucci",
                    Boss = "Carl",
                    Seniority = 2,
                    Subordinates = new List<string>()
                    { }
                },
                new Member()
                {
                    Name = "Cole",
                    Boss = "Carl",
                    Seniority = 1,
                    Subordinates = new List<string>()
                    { }                    
                },
                new Member()
                {
                    Name = "Carl",
                    Boss = "Andy",
                    Seniority = 3,
                    Subordinates = new List<string>()
                    {
                      "Petrucci","Cole"
                    }
                },
                new Member()
                {
                    Name = "Andy",
                    Boss = String.Empty,
                    Seniority = 5,
                    Subordinates = new List<string>()
                    {
                      "Jhon","Carl"
                    }
                },
            };

            // new Jail instance
            var inJail = new Jail();
            // find the member and got him to jail
            var memberToJail = memberList.FirstOrDefault(x => x.Name == "Jhon");
            inJail.GetInJail(memberToJail);
            //get a new one to reassing the subordinates
            var reorderSub = memberList.FirstOrDefault(x => x.Seniority.Equals(5));
            reorderSub.Subordinates.Add(memberToJail.Subordinates);
            //simulamos una aplicacion de consola
            Console.WriteLine(memberList.OrderByDescending(x => x.Seniority));

            // get out a member of the jail
            inJail.GetOutJail(memberToJail);
            //get the list order by oldest
            Console.WriteLine(memberList.OrderByDescending(x => x.Seniority));
            //get the oldest one
            var boss = memberList.OrderByDescending(x => x.Seniority).FirstOrDefault();
            Console.WriteLine(boss.Name);
            //and got him to jail
            inJail.GetInJail(boss);

            //get out him of jail
            inJail.GetOutJail(boss);






        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_suskevits
{
    public class Group
    {
        public List<string> names = new List<string> { "Emersyn Lynn", "Zechariah Evans", "Eliana Pope", "Gunnar Gonzales", "Hadley Douglas", "Derek Stevens", "Katherine Murphy", "Cameron Harrington", "Legacy Bass", "Landen Curtis" };
        public List<string> raceList = new List<string> { "American Indian", "Asian", " Latino", "Pacific Islander", "White" };
        public List<Liie> Members = new List<Liie>();
        private readonly int _maxAmount;

        public Group(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public bool AddMember(Liie member)
        {

            if (Members.Any(m => m.Nimi == member.Nimi)) return false;
            if (Members.Count >= _maxAmount) return false;
            Members.Add(member);
            return true;
        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liie member)
        {
            return (Members.Any(m => m.Nimi == member.Nimi));
        }

        public  Liie GenerateLiie(Liie m2)
        {
            Random rnd = new Random();
            
            int Age = rnd.Next(16, 41);
            int elmentforfoundingrandomname = rnd.Next(0, 9);
            int elmentforfoundingrandomrace = rnd.Next(0, 4);
            string Name = names[elmentforfoundingrandomname];
            string Race = raceList[elmentforfoundingrandomrace];
            Liie m1 = new Liie(Name, Age,Race) ;
            
            return m1;
        }
        public static int Generate_group_size()
        {
        Random rnd = new Random();
        int counter = rnd.Next(2, 10);
            Console.WriteLine("Group size is {0}",counter);
            Console.WriteLine();
            return counter;
        }
    }

}

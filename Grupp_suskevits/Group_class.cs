using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public Group()
        {
        }



        public void AddMember(Liie member)
        {

            if (Members.Count >= _maxAmount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Grupp on tais");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (Members.Any(m => m.Nimi == member.Nimi && m.Age == member.Age && m.Race == member.Race))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ruhmas on juba mees selle nime, vanuse ja rassiga");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Members.Add(member);
                Console.WriteLine("Isik on lisatud gruppi");
                Console.ForegroundColor = ConsoleColor.Gray;
            }



        }

        public int GetMembersCount()
        {
            return Members.Count;
        }

        public bool HasMember(Liie member)
        {
            return (Members.Any(m => m.Nimi == member.Nimi));
        }

        public Liie GenerateLiie(Liie m2)
        {
            Random rnd = new Random();

            int Age = rnd.Next(16, 41);
            int elmentforfoundingrandomname = rnd.Next(0, 10);
            int elmentforfoundingrandomrace = rnd.Next(0, 5);
            string Name = names[elmentforfoundingrandomname];
            string Race = raceList[elmentforfoundingrandomrace];
            m2.Nimi = Name;
            m2.Age = Age;
            m2.Race = Race;


            return m2;
        }
        public static int Generate_group_size()
        {
            Random rnd = new Random();
            int counter = rnd.Next(2, 10);
            Console.WriteLine("Group size is {0}", counter);
            Console.WriteLine();
            return counter;
        }



        public static void Read_key(ConsoleKeyInfo keyInfo, List<Liie> Members)
        {

            if (keyInfo.KeyChar == 'w')
            {

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("All group members: ");

                foreach (Liie item in Members)
                {
                    item.readinfo();
                }
                Console.WriteLine();
                Group.foundoldest(Members);
                Group.foundyoungest(Members);
                Group.DestroyProgram();

            }
            Console.WriteLine();
        }
        public static void DestroyProgram()
        {
            Console.ReadKey();
            Environment.Exit(30);
        }

        public static  void foundoldest (List<Liie> Members)
        {
            Liie m1 = new Liie("Fill",0,"Fill");
            foreach (Liie item in Members)
            {
                if (item.Age > m1.Age)
                {
                    m1 = item;
                }   
            }
            Console.WriteLine("Oldest member is {0} and he/is {1}",m1.Nimi,m1.Age);
            Console.WriteLine();

        }

        public static void foundyoungest(List<Liie> Members)
        {
            Liie m1 = new Liie("Fill", 100, "Fill");
            foreach (Liie item in Members)
            {
                if (item.Age < m1.Age)
                {
                    m1 = item;
                }
            }
            Console.WriteLine("Youngest member is {0} and he/is {1}", m1.Nimi, m1.Age);
            Console.WriteLine();
        }
    }

}

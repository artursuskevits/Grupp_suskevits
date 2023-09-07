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

            if (Members.Any(m => m.Nimi == member.Nimi))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Ruhmas on uks mees selle nimega");
                Console.ForegroundColor = ConsoleColor.Gray;
            } 
            else if (Members.Count >= _maxAmount)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Grupp on tais");
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

        public  Liie GenerateLiie(Liie m2)
        {
            Random rnd = new Random();
            
            int Age = rnd.Next(16, 41);
            int elmentforfoundingrandomname = rnd.Next(0, 9);
            int elmentforfoundingrandomrace = rnd.Next(0, 4);
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
            Console.WriteLine("Group size is {0}",counter);
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
                Group.DestroyProgram();
                
            }
            Console.WriteLine();
        }
        public static void DestroyProgram()
        {   
            Console.ReadKey();
            Environment.Exit(30);
        }
    }

}

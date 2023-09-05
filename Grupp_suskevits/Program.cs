using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_suskevits
{

    public class Program
    {
        public static void Main()
        {
            
            Group group = new Group(Group.Generate_group_size());
            //Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
            //Console.WriteLine(group.GetMembersCount());  // 3

            while (true)
            {
                Liie m1 = new Liie();
               group.GenerateLiie(m1);
                Console.WriteLine(group.AddMember(m1));
                m1.readinfo();
                Console.ReadLine();
            }
            
        }
    }
}
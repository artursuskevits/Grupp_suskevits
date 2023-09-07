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
            
            while (true)
            {
                Liie m1 = new Liie();
                group.GenerateLiie(m1);
                m1.readinfo();
                group.AddMember(m1);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Group.Read_key(keyInfo,group.Members);
                

            }

        }

    }
}
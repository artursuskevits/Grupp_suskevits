using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_suskevits
{

    public class Liie

    {
        private readonly string _nimi;
        private readonly int _age;
        private readonly string _race;
        public Liie(string nimi, int age, string status)
        {
            this._nimi = nimi;
            this._age = age;
            this._race = status;
        }
        public Liie() { }
        public string Nimi { get => _nimi; }
        public int Age { get => _age; }
        public string Race { get => _race; }

        public void readinfo()
        {
            Console.WriteLine();
            Console.WriteLine("text = " + Nimi);
            Console.WriteLine("Age = " + Age);
            Console.WriteLine("Race= " + Race);
        }

       
    }
}

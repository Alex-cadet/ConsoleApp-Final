using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Coach : POM //тренер
    {
        public int Clubs;    //количество клубов, которые тренировал
        public Coach(string st, string n, int a, int Cl) : base(st, n, a)
        {
            Clubs = Cl;
        }
        public override void About()
        {
            Console.WriteLine("Старший тренер команды - {0}", Name);
        }
    }
}

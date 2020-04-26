using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Reffery : POM  //судья матча
    {
        int yellowC; //жёлтые карточки
        int RedC;    //красные карточки
        int falls;  //число зафиксированных судьёй фолов
        public string Rang; // Ранг судьи: главный, на линии, резервный, Var
        public Reffery(string st, string n, int a, string R) : base(st, n, a)
        {
            Rang = R;
        }
        public override void About()
        {
            Console.WriteLine("{0} судья матча - {1}", Rang, Name);
        }
        public bool Accesss()
        {
            bool wow;
            this.Age = Age;
            if (Age < 45)
            {
                wow = true;
                Console.WriteLine("Допускается к судейству");
                return wow;
            }
            else
            {
                wow = false;
                Console.WriteLine("К сожалению, доступ к судейству закрыт");
                return wow;
            }
        }
    }
}

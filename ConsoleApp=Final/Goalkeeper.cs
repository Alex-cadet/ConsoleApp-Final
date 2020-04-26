using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    [OutG(offG = 5)]//атрибут для проверки истинности по пропущенным мячам (offG)
    public class Goalkeeper : Player
    {
        public string Qu;  //страшинство: первый или второй вратарь
        public int shoots; //всего нанесённых ударов
        public int offG;   //пропущенные мячи
        public int Saves;  //сэйвы
        public Goalkeeper(string st, string n, int a, int N, string q) : base(st, n, a, N)
        {
            Qu = q;
        }

        public override void About()
        {
            Console.WriteLine("{3} {0} выручил {1} раз, пропустил {2} мячей", Name, Saves, offG, Qu);
            double abshur = (double)Saves / offG * 100;
            double relshur = (double)Saves / shoots * 100;
            Console.WriteLine("Абсолютная надёжность вратаря - {0}%", abshur);
            Console.WriteLine("Относительная надёжность вратаря - {0}%", relshur);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using NLog;

namespace ConsoleApp4
{
    class Program
    {
       private static Logger logger = LogManager.GetCurrentClassLogger();
        //Использование атрибута в классе Goalkeeper через метод Zam
        static bool Zam(Goalkeeper gl) //метод для определения замены вратаря на другого
        {
            Type t = typeof(Goalkeeper);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (OutG ut in attrs)
            {
                if (gl.offG >= ut.offG) return false;
                else return true;
            }
            return true;
        }
            static void Main(string[] args)
                
        {
            /*
                            ↓↓↓↓↓↓↓  § ООП    ↓↓↓↓↓↓↓             
            Reffery rf = new Reffery("Судит", "Иванов", 39, "Главный");
            rf.About();
            rf.Accesss();
            Coach tre = new Coach("Тренирует", "Говоров", 51, 18);
            tre.About();
            Player pl = new Player("Играет", "Судокин", 27, 6);
            pl.About();
            FieldPl fi = new FieldPl("Играет", "Пименов", 23, 9, "Полузащитник");
            fi.goals = 5;
            fi.pass = 10;
            fi.golpas = 8;
            fi.About();
            Goalkeeper gl = new Goalkeeper("Играет", "Субботин", 32, 13, "Запасной вратарь");
            gl.shoots = 27;
            gl.offG = 9;
            gl.Saves = 15;
            gl.About();
                           ↑↑↑↑↑↑↑↑ § ООП  ↑↑↑↑↑↑↑↑↑↑             
             */
            //═════════════════════════════════════════════════════════════════════
            //             ↓↓↓↓↓↓↓↓ § КОЛЛЕКЦИИ    ↓↓↓↓↓↓↓↓↓↓↓ ☺
            List<FieldPl> g1 = new List<FieldPl>();
            g1.Add(new FieldPl("Играет", "Строков", 22, 2, "Защитник"){});
            g1.Add(new FieldPl("Играет", "Фёдоров", 29, 33, "Защитник"){});
            g1.Add(new FieldPl("Играет", "Ерохин", 18, 15,"Защитник"){});
            g1.Add(new FieldPl("Играет", "Протасов", 32, 10, "Полузащитник"){});
            g1.Add(new FieldPl("Играет", "Милевский", 28, 4, "Защитник"){});
            g1.Add(new FieldPl("Играет", "Башуа", 31, 7, "Полузащитник"){});
            g1.Add(new FieldPl("Играет", "Банчелли", 25 ,16, "Нападающий"){});
            g1.Add(new FieldPl("Играет", "Чунин", 26, 5, "Защитник"){});
            g1.Add(new FieldPl("Играет", "Иняков", 27, 11, "Нападающий"){});
            Console.WriteLine("\t\t\tПолевые игроки:");
            var gamer1 = g1.OrderBy(z => z.Name);//сортировка списка по фамилии
            foreach (var g in gamer1)
            Console.WriteLine($"{g.Name} - {g.Age}");
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\tОтбор техничных защитников от 25 до 30 лет:");
            //выборка по параметрам и сортировка списка по возрасту
            var gamer = g1.Where(g=>g.Age > 25 && g.Age < 30 && g.Amplua == "Защитник").OrderBy(g=>g.Age);
            foreach(FieldPl m in gamer) 
            Console.WriteLine($"{m.Name} - {m.Age}");
            Console.WriteLine("\n\n");
            //    ↑↑↑↑↑↑↑↑     § КОЛЛЕКЦИИ    ↑↑↑↑↑↑↑↑    
            //════════════════════════════════════════════════════════════════════

            //    ↓↓↓↓↓↓↓↓     § ИСКЛЮЧЕНИЯ    &&    § АТРУБУТЫ  ↓↓↓↓↓↓↓↓
            /*
            Goalkeeper gl = new Goalkeeper("Играет", "Субботин", 32, 13, "Запасной вратарь");
            try
            {
                Console.WriteLine("Сколько раз ударить по воротам?");
                gl.shoots = int.Parse(Console.ReadLine());
                Console.WriteLine("Число голов");
                gl.offG = int.Parse(Console.ReadLine());
                Console.WriteLine("Спасения вратаря");
                gl.Saves = int.Parse(Console.ReadLine());
                int ind = gl.Saves / gl.shoots;
                Console.WriteLine("Рейтинг голкипера - {0}", ind);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ни разу не ударили по воротам |:(((");
                Console.WriteLine("Ошибка: деление на нуль. Число ударов не должно равняться нулю!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Это не цифры !!!");
            }
            gl.About();
            bool vrt = Zam(gl); //результат проверки вратаря
            Console.WriteLine($"Реультат аттестации вратаря на надёжность: {vrt}");
            */
            //════════════════════════════════════════════════════════════════════

            // ↓↓↓↓↓↓↓↓  § Логирование   ↓↓↓↓↓↓↓↓
            logger.Trace("trace message");
            logger.Debug("debug message");
            logger.Info("info message");
            logger.Warn("warn message");
            logger.Error("error message");
            logger.Fatal("fatal message");
        }
    }
}

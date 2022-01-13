using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_19._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Id=1, Marka="Asus", TipProcessora ="Intel Core i5", ChastotaProcessora=3, ObjomPamjati=16, ObjomHdd=500, ObjomVideokarti=4, Cena=85000, Kolichestvo = 50},
                new Computer(){Id=2, Marka="Lenovo", TipProcessora ="Intel Core i7", ChastotaProcessora=2, ObjomPamjati=8, ObjomHdd=256, ObjomVideokarti=1, Cena=50000, Kolichestvo = 15},
                new Computer(){Id=3, Marka="Dell", TipProcessora ="AMD", ChastotaProcessora=2, ObjomPamjati=8, ObjomHdd=500, ObjomVideokarti=2, Cena=75000, Kolichestvo = 5},
                new Computer(){Id=4, Marka="Asus", TipProcessora ="Intel Core i7", ChastotaProcessora=2, ObjomPamjati=8, ObjomHdd=500, ObjomVideokarti=1, Cena=55000, Kolichestvo = 20},
                new Computer(){Id=5, Marka="HP", TipProcessora ="Intel Core i5", ChastotaProcessora=2, ObjomPamjati=16, ObjomHdd=500, ObjomVideokarti=4, Cena=77000, Kolichestvo = 23},
                new Computer(){Id=6, Marka="Acer", TipProcessora ="AMD", ChastotaProcessora=2, ObjomPamjati=4, ObjomHdd=256, ObjomVideokarti=1, Cena=45000, Kolichestvo = 37},
                new Computer(){Id=7, Marka="HP", TipProcessora ="Intel Core i7", ChastotaProcessora=3, ObjomPamjati=32, ObjomHdd=1000, ObjomVideokarti=8, Cena=145000, Kolichestvo = 3},
                new Computer(){Id=8, Marka="Lenovo", TipProcessora ="Intel Core i3", ChastotaProcessora=2, ObjomPamjati=4, ObjomHdd=256, ObjomVideokarti=1, Cena=50000, Kolichestvo = 18},
            };

            Console.WriteLine("Введите название процессора");
            string tipProcessora = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.TipProcessora == tipProcessora).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем ОЗУ");
            int objomPamjati = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.ObjomPamjati >= objomPamjati).ToList();
            Print(computers2);

            Console.WriteLine("Сортировка списка компьютеров по возрастанию цены");
            List<Computer> computers3 = computers.OrderBy(x => x.Cena).ToList();
            Print(computers3);

            Console.WriteLine("Группировка компьютеров по типу процессора");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.TipProcessora);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer a in gr)
                {
                    Console.WriteLine($"{a.Id} {a.Marka} {a.TipProcessora} {a.ChastotaProcessora} {a.ObjomPamjati} {a.ObjomHdd} {a.ObjomVideokarti} {a.Cena} {a.Kolichestvo}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер");
            Computer computers5 = computers.OrderByDescending(x => x.Cena).FirstOrDefault();
            Console.WriteLine($"{computers5.Id} {computers5.Marka} {computers5.TipProcessora} {computers5.ChastotaProcessora} {computers5.ObjomPamjati} {computers5.ObjomHdd} {computers5.ObjomVideokarti} {computers5.Cena} {computers5.Kolichestvo}");

            Console.WriteLine(computers.Any(x => x.Cena > 140000));
            Console.WriteLine();

            Console.WriteLine("Самый бюджетный компьютер");
            Computer computers6 = computers.OrderBy(x => x.Cena).FirstOrDefault();
            Console.WriteLine($"{computers6.Id} {computers6.Marka} {computers6.TipProcessora} {computers6.ChastotaProcessora} {computers6.ObjomPamjati} {computers6.ObjomHdd} {computers6.ObjomVideokarti} {computers6.Cena} {computers6.Kolichestvo}");

            Console.WriteLine(computers.Any(x => x.Cena <= 50000));
            Console.WriteLine();

            Console.WriteLine("Наименование компьютеров в количестве более 30 штук");
            int kolichestvo = 30;
            List<Computer> computers7 = computers.Where(x => x.Kolichestvo >= kolichestvo).ToList();
            Print(computers7);
            

            Console.WriteLine("Для выхода из программы нажмите любую клавишу");

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer a in computers)
            {
                Console.WriteLine($"{a.Id} {a.Marka} {a.TipProcessora} {a.ChastotaProcessora} {a.ObjomPamjati} {a.ObjomHdd} {a.ObjomVideokarti} {a.Cena} {a.Kolichestvo}");
            }
            Console.WriteLine();
        }
        
    }
}

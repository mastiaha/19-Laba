using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Door> listDoor = new List<Door>()
            {
                new Door(){id=1, Width=1000, Height=2000, Cost=10000, Manufacturer= "Заря", Material = "Металл", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли", "Глазок", "Замок"} },
                new Door(){id=2, Width=400, Height=1000, Cost=700, Manufacturer= "Красный луч", Material = "Дерево", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли"} },
                new Door(){id=3, Width=700, Height=1950, Cost=7200, Manufacturer= "Оконный завод", Material = "Пластик", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли", "Замок"} },
                new Door(){id=4, Width=1000, Height=2050, Cost=1500, Manufacturer= "Заветы Ильича", Material = "Дерево", Composition= new List<string> (){ "Полотно", "Коробка"} },
                new Door(){id=5, Width=1100, Height=2000, Cost=1600, Manufacturer= "Заря", Material = "Металл", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли", "Глазок", "Замок"} },
                new Door(){id=6, Width=800, Height=1900, Cost=900, Manufacturer= "Оконный завод", Material = "Пластик", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли"} },
                new Door(){id=7, Width=1500, Height=2500, Cost=11000, Manufacturer= "Восход", Material = "Металл", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли", "Глазок"} },
                new Door(){id=8, Width=900, Height=2100, Cost=6500, Manufacturer= "Красный луч", Material = "Дерево", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли"} },
                new Door(){id=9, Width=1200, Height=2100, Cost=1700, Manufacturer= "Заря", Material = "Металл", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли", "Замок"} },
                new Door(){id=10, Width=1100, Height=1950, Cost=3000, Manufacturer= "Красный луч", Material = "Дерево", Composition= new List<string> (){ "Полотно", "Коробка", "Ручка", "Петли"} },

            };
            List<Door> doors = (from d in listDoor
                                      where d.Material == "Дерево"
                                      select d).ToList();
            //IEnumerable<Door> doors = from d in listDoor
            //                   where d.Material == "Дерево"
            //                   select d;
            //либо
            //List<Door> doors = new List<Door>();
            //foreach (Door d in listDoor)
            //{
            //    if (d.Material == "Дерево")
            //    {
            //        doors.Add(d);
            //    }
            //}
            foreach (Door d in doors)
                Console.WriteLine( $"{d.id} {d.Width} {d.Height} {d.Cost} {d.Manufacturer} {d.Material}");
            Console.ReadKey();
        }
    }

    internal class Door
    {
        public int id { get; set; }
        public int Width { get; set; }
        public int Height { get; set;}
        public int Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Material { get; set; }
        public List<string> Composition { get; set; }

    }
}

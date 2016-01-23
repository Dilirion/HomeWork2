using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var lada = new Car("Лада", 'D') { Color = Color.DarkViolet };
            try
            {
                Console.WriteLine("Владелец: {0}", lada.CarPassport.Owner.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("У автомобиля еще нет водителя. Сообщение: " + e.Message);
            }

            var instructor = new Driver(new DateTime(1985, 7, 13), "Вольдемар");

            instructor.Category += "BC";

            try
            {
                lada.ChangeOwner(instructor, "o777ooo");
            }
            catch (CategoryException e)
            {
                Console.WriteLine("Не получилось изменить владельца. Сообщение: " + e.Message);
            }

            instructor.Category += "D";

            try
            {
                lada.ChangeOwner(instructor, "o777ooo");
            }
            catch (CategoryException e)
            {
                Console.WriteLine("Не получилось изменить владельца. Сообщение: " + e.Message);
            }

            Console.WriteLine(instructor.Car.CarNumber);

            Console.WriteLine(lada.CarPassport.Owner.Name);

            Console.ReadKey();
        }
    }
}

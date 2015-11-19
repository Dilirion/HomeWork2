using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime date, string name)
        {
            LisenceDate = date;
            Name = name;
        }

        public DateTime LisenceDate { get; }

        public string Name { get; }

        public int Experience => (DateTime.Today).Year - LisenceDate.Year;

        public string Category { get; set; }

        public void OwnCar(Car car)
        {
            try
            {
                if (Category.Contains(car.Category)) Car = car;
                else
                {
                    throw new CategoryException();
                }

            }
            catch (CategoryException e)
            {
                Console.WriteLine("Не получилось закрепить автомобиль. Сообщение: " + e.Message);
            }
        }

        public Car Car { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryException: Exception
    {
        public override string Message => "У водителя нет прав на вождение данным автомобилем!";
    }
}

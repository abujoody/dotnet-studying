using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; ++i)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }
        
        // Вернуть стандартный конструктор, который будет устанавливать
        // для всех членов данных стандартные значения.
        public Motorcycle() { }

        // Специальный конструктор,
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }

        // Новые члены для представления имени водителя,
        public string name;
        public void SetDriverName(string name)
        { this.name = name; }
    }
}

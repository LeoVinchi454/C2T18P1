using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrackt
{
    abstract class AClass
    {
        public void Metod1()
        {
            Console.WriteLine("Обстрактный метод Metod1 из AClass) ");
        }

        public virtual void Metod2()
        {
            Console.WriteLine("Виртуальный метод Metod2 из AClass ");
        }
        public abstract void Metod3();
        public abstract void Metod4();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrackt
{
    class DerivedClass : AClass
    {
        public override void Metod2()
        {

            base.Metod2();
            Console.WriteLine("Метод Metod2 из AClass реализован в Delivedclass");
        }
        public override void Metod3()
        {
            Console.WriteLine("Метод Metod3 из кл AClass ");
        }
        public override void Metod4()
        {
        }
    }
}

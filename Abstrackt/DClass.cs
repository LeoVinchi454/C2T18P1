using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrackt
{
    class DClass:CClass1
    {
        /// <summary>
        /// переопределенный метод из AClass
        /// </summary>
        public override void Metod()
        {
            
        }
        public override int Summ(int a, int b)
        {
            return a + b;
        }
        public override string Say(string Heloy)
        {
            return Heloy;
        }
        public void Name(string name)
        {
            Console.WriteLine($"name = {name}");
        }
    }
}

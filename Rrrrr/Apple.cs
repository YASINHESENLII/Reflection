using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrrrr
{
    internal class Apple : Fruit
    {
        private int _vitaminA;
        private int _vitaminB;

        public int VitaminA { get
            {
                return _vitaminA;
            } 
            set { _vitaminA = value; }
        }

        public int VitaminB {
            get
            {
                 return _vitaminB;
            }
            set 
            { 
                _vitaminB = value;
            }
            }
       
        public override void Taste()
        {
            Console.WriteLine("Bu alma tursdur.");
        }
    }
}

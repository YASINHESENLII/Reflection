using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrrrr
{
    internal class Orange:Fruit
    {
        private int _vitaminC;
        
        public int VitaminC
        {
            get
            {
                return _vitaminC;
            }
            set
            {
                _vitaminC = value;
            }
        }
        

        public override void Taste()
        {
            Console.WriteLine("Bu ananas sirin ve suludur.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrrrr
{
    internal class Pinapple : Fruit
    
    {

        private int _vitaminE;
        private int _vitaminD;

        public int VitaminE
        {
            get
            {
                return _vitaminE;
            }
            set { _vitaminE = value; }
        }

        public int VitaminD
        {
            get
            {
                return _vitaminD;
            }
            set
            {
                _vitaminD = value;
            }
        }

        public override void Taste()
        {
            Console.WriteLine("Bu ananas şirindir.");
        }
    }
}

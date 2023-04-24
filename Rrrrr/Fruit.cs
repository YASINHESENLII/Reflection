using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rrrrr
{
    internal abstract class Fruit
    {
        private int _price;
        private string _sort;
        public int Price {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Sort {
            get
            {
                return _sort;
            }
            set
            {
                _sort = value;
            }
                }

        
        public abstract void Taste();
    }
}

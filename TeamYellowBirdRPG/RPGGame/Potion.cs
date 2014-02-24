using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public abstract class Potion : Item
    {
        public override int bonusTo
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override Coordinates Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Weapon : Item
    {
        public int modifier;

        public Weapon(int modifier)
        {
            this.modifier = modifier;
        }

        public void SetModifier(int modifier)
        {
            this.modifier = modifier;
        }
    }
}

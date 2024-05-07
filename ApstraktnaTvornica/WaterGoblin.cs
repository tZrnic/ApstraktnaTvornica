using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class WaterGoblin : Goblin
    {
        public override void DoDamage()
        {
            Console.WriteLine("Water damage");
        }
    }
}

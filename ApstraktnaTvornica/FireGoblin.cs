using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class FireGoblin : Goblin
    {
        public override void DoDamage()
        {
            Console.WriteLine("Fire damage");
        }
    }
}

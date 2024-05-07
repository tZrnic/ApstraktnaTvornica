using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class WaterCharacterFactory : CharacterFactory
    {
        public override Wizard CreateWizard()
        {
            return new WaterWizard();
        }
        public override Goblin CreateGoblin()
        {
            return new WaterGoblin();
        }
    }
}

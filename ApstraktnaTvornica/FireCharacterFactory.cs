using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class FireCharacterFactory : CharacterFactory
    {
        public override Wizard CreateWizard()
        {
            return new FireWizard();
        }
        public override Goblin CreateGoblin()
        {
            return new FireGoblin();
        }
    }
}

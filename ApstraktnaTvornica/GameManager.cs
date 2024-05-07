using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class GameManager
    {
        public void Play(CharacterFactory characterFactory)
        {
            characterFactory.CreateGoblin().DoDamage();
            characterFactory.CreateWizard().DoMagic();
        }
    }
}

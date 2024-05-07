using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornica
{
    public class ClientCode
    {
        static void Main(string[] args)
        {
            CharacterFactory fireCharacterFactory = new FireCharacterFactory();
            CharacterFactory waterCharacterFactory = new WaterCharacterFactory();

            GameManager waterGameManager = new GameManager();
            GameManager fireGameManager = new GameManager();

            waterGameManager.Play(fireCharacterFactory);
            fireGameManager.Play(waterCharacterFactory);
        }
    }
}

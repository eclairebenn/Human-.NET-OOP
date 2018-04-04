using System;

namespace Human
{
    class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            Health = 200;
        }

        public void DeathBlow(Human enemy)
        {
            if(enemy.Health < 50)
            {
                enemy.Health = 0;
            }
        }

        public void Meditate()
        {
            Health = 200;
        }


    }

}
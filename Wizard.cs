using System;

namespace Human
{
    class Wizard : Human
    {

        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }

        public void Heal()
        {
            Health =+ Intelligence*10;
        }

        public void Fireball(Human enemy)
        {
            Random rand = new Random();
            enemy.Health -= rand.Next(20, 51);
            
        }

    }

}
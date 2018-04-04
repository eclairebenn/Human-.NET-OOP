using System;

namespace Human
{
    class Ninja : Human
    {

        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public void Steal(Human enemy)
        {
            Health += 10;
        }

        public void GetAway()
        {
            Health -= 15;
        }



    }

}
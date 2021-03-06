﻿using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human myPerson = new Human("Billy");
            Human myPerson2 = new Human("Sally", 4, 4, 2, 85);
            myPerson.Attack(myPerson2);
            Human sam1 = new Samurai("Sam");
            Human ninj1 = new Ninja("Nick");
            Human wiz1 = new Wizard("Willy");
            (wiz1 as Wizard).Fireball(ninj1);
        }

    }

}

//  Wizard should have a default health of 50 and intelligence of 25

//  Wizard should have a method called heal, which when invoked, 
//heals the Wizard by 10 * intelligence

//  Wizard should have a method called fireball, which when invoked, 
//decreases the health of whichever object it attacked by some 
//random integer between 20 and 50

//  Ninja should have a default dexterity of 175

//  Ninja should have a steal method, which when invoked, 
//attacks an object and increases the Ninjas health by 10

//  Ninja should have a get_away method, which when invoked, 
//decreases its health by 15

//  Samurai should have a default health of 200

//  Samurai should have a method called death_blow, 
//which when invoked should attack an object and 
//decreases its health to 0 if it has less than 50 health

//  Samurai should have a method called meditate, which when invoked, 
//heals the Samurai back to full health

//  (optional) Samurai should have a class method called 
//how_many, which when invoked, displays how many Samurai's 
//there are. Hint you may have to use the static keyword
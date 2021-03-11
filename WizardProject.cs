using System;

namespace WizardProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Harry", "Unlocking charm");
          
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Draco", "Babbling Curse");

            wizard02.CastSpell();

            Console.ReadKey();


        }
    }
    
    
    class Wizard
    {

        private string name;
        private string favoriteSpell;
        private int spellToken;
        private int experience;




        public void CastSpell()
        {
            if (spellToken > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellToken--;
                experience += 1;
            }
            else
            {
                Console.WriteLine(name + " is out of spell tokens");
            }
        }

        public void PracticeSpells()
        {
            Console.WriteLine(name + " practices to regain spell tokens");
            spellToken = 2;
        }

        // constructor
        public Wizard()
        {
            spellToken = 2;
            experience = 0;
        }

        public Wizard(string name, string favoriteSpell)
        {
            this.name = name;
            this.favoriteSpell = favoriteSpell;
            spellToken = 2;
            experience = 0;
        }

    }
}

    
    
    
}

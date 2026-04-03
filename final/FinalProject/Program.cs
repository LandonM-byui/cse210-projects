using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        DicePool d = new DicePool();
        Enemy drake = new Enemy("Drake", 50, ["peircing", "cold"]);
        drake.setInitiative(20);
        Enemy caster = new Enemy("Spellcaster", 30, []);
        Spellcaster wizard = new([2,1]);
        caster.AddSpells(wizard);
        caster.setInitiative(15);
        Tracker initiative = new Tracker("Initiative");
        PlayerCharacter jim = new PlayerCharacter("Jim", 45, 30, 16);
        LegendaryEnemy vick = new LegendaryEnemy("Vick", 100, ["fire"], 3, 3, "List of actions", 90, 2);
        initiative.add(drake);
        initiative.add(caster);
        initiative.add(vick);
        initiative.add(jim);
        initiative.order();
        Console.Clear();
        bool run = true;
        do
        {
            initiative.order();
            initiative.display();
            Console.WriteLine("");
            Console.WriteLine("1: Roll Dice, 2: Do Action, 3: Add Character, 4: Remove Character, 5: Quit");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("What dice to roll? (#d#): ");
                    string[] list = Console.ReadLine().Split('d');
                    Console.WriteLine("What modifier? (#)");
                    int mod = int.Parse(Console.ReadLine());
                    Console.WriteLine("Advantage? (y or n)");
                    bool adv = false;
                    if (Console.ReadLine() == "y")
                    {
                        adv = true;
                    }
                    Console.Clear();
                    Console.WriteLine($"{d.GetDice(int.Parse(list[1])).roll(int.Parse(list[0]), mod, adv)}");
                    break;
                case 2:
                    Console.WriteLine("1: Deal damage, 2: Heal, 3: Cast enemy spell, 4: Use enemy legendary reactions");
                    int act = int.Parse(Console.ReadLine());
                    Console.WriteLine("Select the initiative order of Character:");
                    int pos = int.Parse(Console.ReadLine()) - 1;
                    switch (act)
                    {
                        case 1:
                            Console.WriteLine("How much damage?");
                            int dmg = int.Parse(Console.ReadLine());
                            initiative.returnCharacter(pos).takeDamage(dmg);
                            break;

                        case 2:
                            Console.WriteLine("How much health?");
                            int heal = int.Parse(Console.ReadLine());
                            initiative.returnCharacter(pos).heal(heal);
                            break;
                        case 3:
                            if (initiative.returnCharacter(pos).GetType() == typeof(Enemy) || initiative.returnCharacter(pos).GetType() == typeof(LegendaryEnemy))
                            {
                                Console.WriteLine("What level of spell?");
                                int spell = int.Parse(Console.ReadLine());
                                ((Enemy)initiative.returnCharacter(pos)).doSpell(spell);
                            }
                            else
                            {
                                Console.WriteLine("Not an enemy.");
                            }
                            break;
                        case 4:
                            if (initiative.returnCharacter(pos).GetType() == typeof(LegendaryEnemy))
                            {
                                Console.WriteLine("How many legendary actions used?");
                                int legend = int.Parse(Console.ReadLine());
                                for (int i = 0; i < legend; i++)
                                {
                                    ((LegendaryEnemy) initiative.returnCharacter(pos)).useAction();
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid result. Try again.");
                            break;
                    }
                    break;
                
                case 3: 
                    Console.WriteLine("What type of character to add? (Player, Enemy, Legendary Enemy)");
                    string option = Console.ReadLine().ToLower();
                    List<string> chara = [];
                    List<string> resist = [];
                    if (option == "player" || option == "enemy" || option == "legendary enemy")
                    {
                        Console.WriteLine("What is the character name?");
                        chara.Add(Console.ReadLine());
                        Console.WriteLine("What is the maximum hp?");
                        chara.Add(Console.ReadLine());
                        Console.WriteLine("What is the current HP?");
                        chara.Add(Console.ReadLine());
                        Console.WriteLine("What is the initiative?");
                        chara.Add(Console.ReadLine());

                        if (option == "enemy" || option == "legendary enemy")
                        {
                            Console.WriteLine("What are the resistances? (fire,cold,acid)");
                            string [] resistances = Console.ReadLine().ToLower().Split(",");
                            foreach (string res in resistances)
                            {
                                resist.Add(res);
                            }
                            if (option == "legendary enemy")
                            {
                                Console.WriteLine("What is the current legendary actions used?");
                                chara.Add(Console.ReadLine());
                                Console.WriteLine("what is the maximum legendary actions?");
                                chara.Add(Console.ReadLine());
                                Console.WriteLine("Describe the different Legendary Actions:");
                                chara.Add(Console.ReadLine());
                            }
                        }
                        switch (option)
                        {
                            case "player":
                                PlayerCharacter p = new PlayerCharacter(chara[0],int.Parse(chara[1]),int.Parse(chara[2]),int.Parse(chara[3]));
                                initiative.add(p);
                                initiative.order();
                                break;
                            case "enemy":
                                Enemy e = new Enemy(chara[0],int.Parse(chara[1]),(List<string>)resist,int.Parse(chara[2]),int.Parse(chara[3]));
                                Console.WriteLine("Do they have spells? (y, n)");
                                if (Console.ReadLine() == "y")
                                {
                                    Console.WriteLine("Add their spell slots in this format: (spell-level,#-of-slots,....)");
                                    string [] sps = Console.ReadLine().Split(",");
                                    List<int> slots = [];
                                    foreach (string s in sps)
                                    {
                                        slots.Add(int.Parse(s));
                                    }
                                    Spellcaster sc = new Spellcaster(slots);
                                    e.AddSpells(sc);
                                }
                                initiative.add(e);
                                initiative.order();
                                break;
                            case "legendary enemy":
                                LegendaryEnemy l = new LegendaryEnemy(chara[0],int.Parse(chara[1]),(List<string>)resist,int.Parse(chara[4]), int.Parse(chara[5]),chara[6],int.Parse(chara[2]),int.Parse(chara[3]));
                                Console.WriteLine("Do they have spells? (y, n)");
                                if (Console.ReadLine() == "y")
                                {
                                    Console.WriteLine("Add their spell slots in this format: (#-of-Lv1, #-of-Lv2, #....)");
                                    string [] sps = Console.ReadLine().Split(",");
                                    List<int> slots = [];
                                    foreach (string s in sps)
                                    {
                                        slots.Add(int.Parse(s));
                                    }
                                    Spellcaster sc = new Spellcaster(slots);
                                    l.AddSpells(sc);
                                }
                                initiative.add(l);
                                initiative.order();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    break;
                    
                case 4:
                    Console.WriteLine("Select the initiative order of the character you wish to remove.");
                    initiative.remove(int.Parse(Console.ReadLine()) - 1);
                    break;
                case 5:
                    run = false;
                    break;
            }
            Thread.Sleep(2000);
            Console.Clear();

        }
        while(run);
    }
}
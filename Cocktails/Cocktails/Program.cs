using System;
using System.Collections.Generic;
using System.Linq;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var x = new CocktailContext())
            {
                IEnumerable<Garnish> garnishes = x.Garnishes.Where(g => g.GarnishName != null);
                foreach (Garnish item in garnishes)
                {
                    Console.WriteLine(item.GarnishName);
                }
            }
            while (true)
            {
                Console.WriteLine("Welcome to the DrinkMaster5000!");
                Console.WriteLine("You have the following choices");
                Console.WriteLine("1. Add a drink");
                Console.WriteLine("2. View added drinks");
                Console.WriteLine("3. Search for a drink");
                Console.WriteLine("4. Remove a drink");
                Console.WriteLine("5. Change a drink");
                Console.WriteLine("6. exit");
                Console.Write("Please enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddDrink();
                        break;
                    case 2:
                        GetDrinks();
                        break;
                    case 3:
                        SearchDrink();
                        break;
                    case 4:
                        RemoveDrink();
                        break;
                    case 5:
                        ChangeDrink();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }

        static void AddDrink()
        {
            while (true)
            {
                Console.Write("Please enter the name of the drink: ");
                string drinkName = Console.ReadLine();

                using (var ctx = new CocktailContext())
                {
                    Drink drink = new Drink() { DrinkName = drinkName };
                    ctx.Drinks.Add(drink);
                    ctx.SaveChanges();
                }

                while (true)
                {
                    Console.WriteLine("You now have the following choices");
                    Console.WriteLine("1. Add Garnish");
                    Console.WriteLine("2. Add Alcohol");
                    Console.WriteLine("3. Add Mixer");
                    Console.WriteLine("4. Exit");
                    Console.Write("Please enter your choice: ");
                    
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            while (true)
                            {
                                Console.WriteLine("Please enter the name of the garnish");
                                string garnishName = Console.ReadLine();

                                Console.WriteLine("Please enter the amount of the garnish");
                                string garnishAmount = Console.ReadLine();

                                Console.WriteLine("Is the garnish edible? y/n");
                                string edibleChoice = Console.ReadLine();
                                bool garnishEdible;
                                if (edibleChoice == "y")
                                    garnishEdible = true;
                                else
                                    garnishEdible = false;
                                
                                using (var ctx = new CocktailContext())
                                {
                                    Garnish garnish = new Garnish() { GarnishName = garnishName, GarnishAmount = garnishAmount, GarnishEdible = garnishEdible };
                                    ctx.Garnishes.Add(garnish);
                                    ctx.SaveChanges();
                                }

                                Console.WriteLine("Do you wish to add another garnish? y/n");
                                string keepLooping = Console.ReadLine();

                                if (keepLooping == "n")
                                    break;
                            }
                            break;
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("Please enter the name of the alcohol");
                                string alcoholName = Console.ReadLine();

                                Console.WriteLine("Please enter the amount of alcohol");
                                string alcoholAmount = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    Alcohol alcohol = new Alcohol() { AlcoholName = alcoholName, AlcoholAmount = alcoholAmount };
                                    ctx.Alcohols.Add(alcohol);
                                    ctx.SaveChanges();
                                }
                                
                                Console.WriteLine("Do you wish to add more alcohol? y/n");
                                string keepLooping = Console.ReadLine();

                                if (keepLooping == "n")
                                    break;
                            }
                            break;
                        case 3:
                            while (true)
                            {
                                Console.WriteLine("Please enter the name of the mixer");
                                string mixerName = Console.ReadLine();

                                Console.WriteLine("Please enter the amount of the mixer");
                                string mixerAmount = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    Mixer mixer = new Mixer() { MixerName = mixerName, MixerAmount = mixerAmount };
                                    ctx.Mixers.Add(mixer);
                                    ctx.SaveChanges();
                                }
                                
                                Console.WriteLine("Do you wish to add more mixer? y/n");
                                string keepLooping = Console.ReadLine();

                                if (keepLooping == "n")
                                    break;
                            }
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                    break;
                }
                
                Console.WriteLine("Do you wish to add anoth drink? y/n");
                string keepLooping1 = Console.ReadLine();

                if (keepLooping1 == "n")
                    break;
            }
        }

        static void GetDrinks()
        {
            using (var ctx = new CocktailContext())
            {
                IEnumerable<Drink> drinks = ctx.Drinks.Where(d => d.DrinkName.Length > 0);
                foreach (Drink item in drinks)
                {
                    Console.WriteLine(item.DrinkName);
                }
            }
        }

        static void SearchDrink()
        {
            while (true)
            {
                Console.Write("Please enter the name of the drink you are searching for: ");
                string search = Console.ReadLine();

                using (var ctx = new CocktailContext())
                {
                    IEnumerable<Drink> drinks = ctx.Drinks.Where(d => d.DrinkName.Contains(search));
                    foreach (Drink item in drinks)
                    {
                        Console.WriteLine(item.DrinkName);
                    }
                }

                Console.WriteLine("Do you wish to search for another drink? y/n");
                string choice = Console.ReadLine();

                if (choice == "n")
                    break;
            }
        }

        static void RemoveDrink()
        {
            while (true)
            {
                Console.Write("Please enter the name of the drink you wish to remove: ");
                string search = Console.ReadLine();
                
                using (var ctx = new CocktailContext())
                {
                    IEnumerable<Drink> drink = ctx.Drinks.Where(d => d.DrinkName.Contains(search));
                    foreach (Drink item in drink)
                    {
                        ctx.Drinks.Remove(item);
                    }
                    ctx.SaveChanges();
                }
                Console.WriteLine("Do you wish to remove more drinks? y/n");
                string choice = Console.ReadLine();

                if (choice == "n")
                    break;
            }
        }

        static void ChangeDrink()
        {
            while (true)
            {
                Console.WriteLine("Please enter the name of the drink you want to change");
                string drinkChange = Console.ReadLine();
                int drinkID = 0;

                using (var ctx = new CocktailContext())
                {
                    IEnumerable<Drink> drinks = ctx.Drinks.Where(d => d.DrinkName.Contains(drinkChange));
                    if (drinks.Count() < 2 && drinks.Count() > 0)
                    {
                        foreach (Drink item in drinks)
                        {
                            drinkID = item.DrinkID;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("You now have the following choices");
                Console.WriteLine("1. Change the name of the drink");
                Console.WriteLine("2. Change the garnish");
                Console.WriteLine("3. Change the alcohol");
                Console.WriteLine("4. Change the mixer");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter the new name for the drink");
                        string newName = Console.ReadLine();

                        using (var ctx = new CocktailContext())
                        {
                            IEnumerable<Drink> drinks = ctx.Drinks.Where(d => d.DrinkID == drinkID);
                            foreach (Drink item in drinks)
                            {
                                item.DrinkName = newName;
                            }
                            ctx.SaveChanges();
                        }
                        break;
                    case 2:
                        Console.WriteLine("You now have the following choices");
                        Console.WriteLine("1. Change the garnish name");
                        Console.WriteLine("2. Change the garnish amount");
                        Console.WriteLine("3. Change if the garnish is edible");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("Please enter your choice");
                        int choiceGarnish = Convert.ToInt32(Console.ReadLine());

                        switch (choiceGarnish)
                        {
                            case 1:
                                Console.WriteLine("Please enter the name of the garnish you wish to change");
                                string garnishChange = Console.ReadLine();
                                Console.WriteLine("Please enter the new name for the garnish");
                                string garnishNew = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Garnish> garnishes = ctx.Garnishes.Where(d => d.Drink.DrinkID == drinkID && d.GarnishName.Contains(garnishChange));
                                    foreach (Garnish item in garnishes)
                                    {
                                        item.GarnishName = garnishNew;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Please enter the name of the garnish you wish to change");
                                string garnishAmount = Console.ReadLine();
                                Console.WriteLine("Please enter the new amount for the garnish");
                                string garnishNewAmount = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Garnish> garnishes = ctx.Garnishes.Where(d => d.Drink.DrinkID == drinkID && d.GarnishName.Contains(garnishAmount));
                                    foreach (Garnish item in garnishes)
                                    {
                                        item.GarnishAmount = garnishNewAmount;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 3:
                                Console.WriteLine("Please enter the name of the garnish you wish to change");
                                string garnishEdible = Console.ReadLine();
                                Console.WriteLine("Is the garnish edible? y/n");
                                string garnishChoice = Console.ReadLine();
                                bool garnishBool;
                                if (garnishChoice == "y")
                                    garnishBool = true;
                                else
                                    garnishBool = false;
                                

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Garnish> garnishes = ctx.Garnishes.Where(d => d.Drink.DrinkID == drinkID && d.GarnishName.Contains(garnishEdible));
                                    foreach (Garnish item in garnishes)
                                    {
                                        item.GarnishEdible = garnishBool;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 4:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("You now have the following choices");
                        Console.WriteLine("1. Change the name of the alcohol");
                        Console.WriteLine("2. Change the amount of alcohol");
                        Console.WriteLine("3. Exit");
                        Console.WriteLine("Please enter your choice");
                        int choiceAlcohol = Convert.ToInt32(Console.ReadLine());
                        switch (choiceAlcohol)
                        {
                            case 1:
                                Console.WriteLine("Please enter the name of the alcohol you wish to change");
                                string alcoholName = Console.ReadLine();

                                Console.WriteLine("Please enter the new name for the alcohol");
                                string alcoholNewName = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Alcohol> alcohols = ctx.Alcohols.Where(a => a.AlcoholName.Contains(alcoholName) && a.Drink.DrinkID == drinkID);
                                    foreach (Alcohol item in alcohols)
                                    {
                                        item.AlcoholName = alcoholNewName;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Please enter the name of the alcohol you wish to change");
                                string alcoholAmountName = Console.ReadLine();

                                Console.WriteLine("Please enter the new amount");
                                string alcoholAmountNew = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Alcohol> alcoholsAmo = ctx.Alcohols.Where(a => a.AlcoholName.Contains(alcoholAmountName) && a.Drink.DrinkID == drinkID);
                                    foreach (Alcohol item in alcoholsAmo)
                                    {
                                        item.AlcoholAmount = alcoholAmountNew;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("You now have the following choices");
                        Console.WriteLine("1. Change the name of the mixer");
                        Console.WriteLine("2. Change the amount of mixer");
                        Console.WriteLine("3. Exit");
                        Console.WriteLine("Please enter your choice");
                        int choiceMixer = Convert.ToInt32(Console.ReadLine());
                        switch (choiceMixer)
                        {
                            case 1:
                                Console.WriteLine("Please enter the name of the mixer you wish to change");
                                string mixerName = Console.ReadLine();

                                Console.WriteLine("Please enter the new name for the mixer");
                                string mixerNewName = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Mixer> mixers = ctx.Mixers.Where(a => a.MixerName.Contains(mixerName) && a.Drink.DrinkID == drinkID);
                                    foreach (Mixer item in mixers)
                                    {
                                        item.MixerName = mixerNewName;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 2:
                                Console.WriteLine("Please enter the name of the mixer you wish to change");
                                string mixerAmountName = Console.ReadLine();

                                Console.WriteLine("Please enter the new amount");
                                string mixerAmountNew = Console.ReadLine();

                                using (var ctx = new CocktailContext())
                                {
                                    IEnumerable<Mixer> mixerAmo = ctx.Mixers.Where(a => a.MixerName.Contains(mixerAmountName) && a.Drink.DrinkID == drinkID);
                                    foreach (Mixer item in mixerAmo)
                                    {
                                        item.MixerAmount = mixerAmountNew;
                                    }
                                    ctx.SaveChanges();
                                }
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

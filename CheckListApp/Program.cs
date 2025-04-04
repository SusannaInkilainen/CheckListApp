// See https://aka.ms/new-console-template for more information

/*Toteuta konsolisovellus, joka toimii yksinkertaisena tehtävälistana. Sen tulee:

Näyttää valikon, jossa käyttäjä voi valita:

1: Lisää uusi tehtävä

2: Näytä kaikki tehtävät

3: Poista tehtävä numeron perusteella

4: Merkitse tehtävä tehdyksi

5: Poistu ohjelmasta

Käyttäjän syötteiden perusteella ohjelman tulee lisätä, poistaa tai merkitä tehtäviä tehdyiksi.

    Tehtävän lisäämisen yhteydessä käyttäjä syöttää tehtävän kuvauksen (esim. "Osta maitoa").

    Kun tehtävä merkitään tehdyksi, se tulostuu listassa eri tavalla (esim. [X]).

    Jos käyttäjä yrittää poistaa tai merkitä tehtäväksi numeron, jota ei ole olemassa, ohjelma näyttää virheilmoituksen.

    Ohjelma jatkaa toimintaansa, kunnes käyttäjä valitsee "5" (poistu).*/

using CheckListApp;

using Task = CheckListApp.Task;



class Program
{
    static Task manager = new Task();

    static void Main()
    {
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            ShowMenu();
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.Write("Anna tehtävän kuvaus: ");
                    string desc = Console.ReadLine();
                    manager.AddTask(desc);
                    break;
                case "2":
                    manager.ShowTasks();
                    break;
                case "3":
                    manager.ShowTasks();
                    Console.Write("Anna poistettavan tehtävän numero: ");
                    TryParseAndExecute(manager.RemoveTask);
                    break;
                case "4":
                    manager.ShowTasks();
                    Console.Write("Anna tehtävän numero: ");
                    TryParseAndExecute(manager.CompleteTask);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
            Console.WriteLine("Paina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("VALITSE");
        // Kysytään vaihtoehdot
        Console.WriteLine("\t1. Lisää uusi tehtävä");
        Console.WriteLine("\t2. Näytä kaikki tehtävät");
        Console.WriteLine("\t3. Poista tehtävä numeron perusteella");
        Console.WriteLine("\t4. Merkitse tehtävä tehdyksi");
        Console.WriteLine("\t5. Poistu ohjelmasta");
        Console.WriteLine("Kirjoita valintasi:");
    }
    static void TryParseAndExecute(Action<int> action)
    {
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            action(id);
        }
        else
        {
            Console.WriteLine("Virheellinen syöte.");
        }
    }


}

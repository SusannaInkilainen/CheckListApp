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

    Kun tehtävä merkitään tehdyksi, se tulostuu listassa eri tavalla (esim. ✔ tai [X]).

    Jos käyttäjä yrittää poistaa tai merkitä tehtäväksi numeron, jota ei ole olemassa, ohjelma näyttää virheilmoituksen.

    Ohjelma jatkaa toimintaansa, kunnes käyttäjä valitsee "5" (poistu).*/

using CheckListApp;

using Task = CheckListApp.Task;


    
{
        Console.WriteLine("Valitse vaihtoehdoista");
        // Kysytään vaihtoehdot
        Console.WriteLine("\t1. Lisää uusi tehtävä");
        Console.WriteLine("\t2. Näytä kaikki tehtävät");
        Console.WriteLine("\t3. Poista tehtävä numeron perusteella");
        Console.WriteLine("\t4. Merkitse tehtävä tehdyksi");
        Console.WriteLine("\t5. Poistu ohjelmasta");
        Console.WriteLine("Kirjoita valintasi:");
        
        // Luetaan annettu vaihtoehto ja tallennetaan se op-muuttujaan
        string? op = Console.ReadLine();
   
        while (true)
        {
                try
                {
                    switch (op)
                    {
                        case "1": Task.AddTask(); break;
                        case "2": Task.ShowTasks(); break;
                        case "3": Task.RemoveTask(); break;
                        case "4": Task.CompleteTask(); break;
                        case "5": return;
                        default: Console.WriteLine("Virheellinen valinta, yritä uudelleen."); break;
                    }
                    Console.WriteLine("Paina Enter jatkaaksesi...");
                    Console.ReadLine();
                

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }

}

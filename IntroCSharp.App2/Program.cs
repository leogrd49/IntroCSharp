using System.Reflection.Emit;
using System;

internal class Program
{
    // Liste element de la classe
    internal static List<string> classMember = new List<string>();

    /// <summary>
    /// Point d'entée de l'application
    /// </summary>
    /// <param name="args">arguements</param>
    private static void Main(string[] args)
    {
        Start();
        ShowMenu();
    }

    private static void Start()
    {
        classMember.Add("Toto");
        classMember.Add("Titi");
        classMember.Add("Tata");
        classMember.Add("Tonton");
        classMember.Add("Tutu");
    }

    /// <summary>
    /// Affiche le Menu
    /// </summary>
    private static void ShowMenu()
    {
        bool isFinished = false;
        do
        {
            Console.WriteLine("Saisiez une action");
            Console.WriteLine("1 - Ajouter");
            Console.WriteLine("2 - Modifier");
            Console.WriteLine("3 - Supprimer");
            Console.WriteLine("4 - Lister");
            Console.WriteLine("0 - Sortir");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddClassMember();
                    break;
                case "2":
                    Modifier();
                    break;
                case "3":
                    Supprimer();
                    break;
                case "0":
                    isFinished = true;
                    break;
                case "4":
                    Lister();
                    break;
                default:
                    Console.WriteLine("Saisie Incorect, Please retry");
                    break;
            }


        } while (!isFinished);
    }

    /// <summary>
    /// Ajout d'un membre à la classe.
    /// </summary>
    private static void AddClassMember()
    {
        Console.WriteLine("Indiquez le nom et le prénom de la personne à ajouter");
        string? userInput = Console.ReadLine();
        
        // On ajouter userInput à la fin de la notre liste
        classMember.Add(userInput ?? "Inconue");
    }

    /// <summary>
    /// Lister (Afficher) la classe.
    /// </summary>
    private static void Lister()
    {
        Console.WriteLine("Liste des membre: ");
        foreach (string name in classMember)
        {
            Console.WriteLine($" -> {name}");
        }
    }

    /// <summary>
    /// Modifier la liste
    /// </summary>
    private static void Modifier()
    {
        Console.WriteLine("Indiquez le nom et le prénom de la personne à Modifier");
        string? toEdit = Console.ReadLine();

        classMember.Remove(toEdit);

        Console.WriteLine("Quel est son nouveau nom ?: ");
        string? newName = Console.ReadLine();

        classMember.Add(newName);

    }

    /// <summary>
    /// Supprimer un element de la liste
    /// </summary>
    private static void Supprimer()
    {
        Console.WriteLine("Indiquez le nom et prénom de la personne à Supprimer");
        string? toSupprimer = Console.ReadLine();

        classMember.Remove(toSupprimer);
    }
}
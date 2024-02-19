using IntroCSharp.App2.Model;
using System.Net.NetworkInformation;

internal class Program
{
    /// <summary>
    /// Liste des membres de la classe
    /// </summary>
    internal static List<ClassMember> classMember = new List<ClassMember>();
    /// <summary>
    /// Point d'entrée de l'application
    /// </summary>
    /// <param name="args">arguments</param>
    private static void Main(string[] args)
    {
        ShowMenu();
    }

    /// <summary>
    /// Affiche le menu
    /// </summary>
    private static void ShowMenu()
    {
        bool isFinished = false;
        do
        {
            Console.WriteLine("Saisissez une action : ");
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
                case "4":
                    Lister();
                    break;
                case "0":
                    isFinished = true;
                    break;
                default:
                    {
                        Console.WriteLine("La saisie est incorrecte");
                        break;
                    }
            }
        } while (!isFinished);
    }

    /// <summary>
    /// Ajouter un membre
    /// </summary>
    private static void AddClassMember()
    {
        Console.WriteLine("Indquez le nom de la personne à ajouter : ");
        string? userInputLastName = Console.ReadLine();

        Console.WriteLine("Indquez le prénom de la personne à ajouter : ");
        string? userInputFirstName = Console.ReadLine();

        ClassMember classmate = new ClassMember(userInputLastName, userInputFirstName);
        //On ajout userInput à la fin de notre liste.
        classMember.Add(classmate);


    }

    /// <summary>
    /// Supprimer un membre
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    private static void Supprimer()
    {
        ClassMember selectedClassMember = null;
        do
        {
            Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
            string? searchLastName = Console.ReadLine();
            Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
            string? searchFirstName = Console.ReadLine();

            foreach (ClassMember classmate in classMember)
            {
                if (classmate.FirstName == searchFirstName && classmate.LastName == searchLastName)
                {
                    selectedClassMember = classmate;
                }
            }
        } while (selectedClassMember == null);

        classMember.Remove(selectedClassMember);
    }

    /// <summary>
    /// Modifier un membre
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    private static void Modifier()
    {
        ClassMember selectedClassMember = null;
        do
        {
            Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
            string? searchLastName = Console.ReadLine();
            Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
            string? searchFirstName = Console.ReadLine();

            foreach (ClassMember classmate in classMember)
            {
                if (classmate.FirstName == searchFirstName && classmate.LastName == searchLastName)
                {
                    selectedClassMember = classmate;
                }
            }
        } while (selectedClassMember == null);

        Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
        selectedClassMember.LastName = Console.ReadLine() ?? "non renseigné";
        Console.WriteLine("Indquez le nom et le prénom de la personne à modifier : ");
        selectedClassMember.FirstName = Console.ReadLine() ?? "non renseigné";
    }

    /// <summary>
    /// Lister les membres de la classe
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    private static void Lister()
    {
        Console.WriteLine("Liste des membres : ");

        foreach (ClassMember classmate in classMember)
        {
            Console.WriteLine($" -> {classmate.Fullname}");
        }
    }
}
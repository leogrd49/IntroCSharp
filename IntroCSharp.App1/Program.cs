// Init Var
Random random = new Random();
int nb_secret = -1;
int vie = 3;

// Select level difficulty
int level = SelectDifficulty(random, ref nb_secret, ref vie);

// Affichage niveau choisi
Console.WriteLine($"Votre niveau: {level}.");

// Boucle principale du jeu
while (true)
{
    // Affichage du message demandant de deviner le nombre
    Console.WriteLine("Devine le nombre que j'ai généré ?");

    // Lecture et traitement du nombre choisi par le joueur
    int nb_choisi_int = GetNumberFromUser();

    // Comparaison du nombre choisi avec le nombre secret
    if (nb_choisi_int > nb_secret)
    {
        Console.WriteLine("Plus Petit !");
    }
    else if (nb_choisi_int < nb_secret)
    {
        Console.WriteLine("Plus Grand !");
    }
    else
    {
        Console.WriteLine("gg");
        break; // Sortie de la boucle si le nombre est deviné
    }

    // Décrémentation du nombre de vies et vérification si le joueur a perdu
    vie--;
    if (vie == 0)
    {
        Console.WriteLine("Ta pu de vie ");
        break;
    }

    // Affichage du nombre de vies restantes
    Console.WriteLine($"Il te reste {vie} vie(s)");
}

// Méthode pour sélectionner la difficulté du jeu
static int SelectDifficulty(Random random, ref int nb_secret, ref int vie)
{
Console.WriteLine("Difficulté ? 1:Easy | 2:Normal | 3: Hard ");
string level_difficulty = Console.ReadLine();
int level = 0;

switch (level_difficulty)
{
    case "1":
        nb_secret = random.Next(0, 10);
        vie = 3;
        level = 1;
        break;
    case "2":
        nb_secret = random.Next(0, 50);
        vie = 5;
        level = 2;
        break;
    case "3":
        nb_secret = random.Next(0, 100);
        vie = 10;
        level = 3;
        break;
    case "69":
        nb_secret = random.Next(0, 100);
        vie = 1;
        level = 69;
        break;
}

return level;
}

// Méthode pour obtenir et valider le nombre choisi par le joueur
static int GetNumberFromUser()
{
while (true)
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        return result;
    }
    else
    {
        Console.WriteLine("Invalide ! ");
    }
}
}

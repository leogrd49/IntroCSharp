//Generation nb aléatoire entre 0 - 10
Random random = new Random();
int nb_secret = random.Next(0, 0);


//get et traitement nb
string? nb_choisi = null; Console.ReadLine();
int nb_choisi_int = -1;

//Booléen qui verif le jeu
bool iswon = false;

//Life
int? vie = 3;


//DEBUT GAME
Console.WriteLine("Difficulté ? 1:Easy | 2:Normal | 3: Hard ");
string? level_difficulty = Console.ReadLine();
int level = 0;


//DIFFUCULTY
switch (level_difficulty)
{
    case "1":
        //Easy
        nb_secret = random.Next(0, 10);
        vie = 3;
        level = 1;
        break;

    case "2":
        //Normal
        nb_secret = random.Next(0, 50);
        vie = 5;
        level = 2;
        break;

    case "3":
        //Hard
        nb_secret = random.Next(0, 100);
        vie = 10;
        level = 3;
        break;

    case "69":
        //SECRET
        nb_secret = random.Next(0, 100);
        vie = 1;
        level = 69;
        break;
}


Console.WriteLine($"Votre niveau: {level}.");


while (iswon == false || vie != 0)
{
    //print début du jeu
    Console.WriteLine("Devine le nombre que j'ai généré ?"); 

    //TRAITEMENT NB str en INT
    //NULL ERROR
    try
    {
        nb_choisi = Console.ReadLine();
        nb_choisi_int = int.Parse(nb_choisi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalide ! ");

    }


    // PLUS PETIT | GRAND
    if (nb_choisi_int > nb_secret)
    {
        Console.WriteLine("Plus Petit !");
    }

    if (nb_choisi_int < nb_secret)
    {
        Console.WriteLine("Plus Grand !");
    }


    //GG | LOOSE
    if (nb_choisi_int == nb_secret)
    {
        Console.WriteLine("gg");
        iswon = true;
        break;
    }
    else
    {
        Console.WriteLine($"Noob");
        vie -= 1;
        Console.WriteLine($"Il te reste {vie} vie(s)");
    }


    // LIFE COUNTER
    if (vie == 0)
    {
        Console.WriteLine("Ta pu de vie ");
        break;
    }


}
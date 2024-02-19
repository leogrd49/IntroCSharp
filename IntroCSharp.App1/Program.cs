//Generation nb aléatoire entre 0 - 10
Random random = new Random();
int nb_secret = random.Next(0, 10);

//get et traitement nb
string? nb_choisi = null; Console.ReadLine();
int nb_choisi_int = -1;

//Booléen qui verif le jeu
bool iswon = false;

//Life
int? vie = 3;

while (iswon == false || vie == 0)
{
    //print début du jeu
    Console.WriteLine("Devine le nombre que j'ai généré ?");

    if (nb_choisi == null)
    {
        nb_choisi = "0";
    }

    nb_choisi = Console.ReadLine();
    nb_choisi_int = int.Parse(nb_choisi);


    if (nb_choisi_int == nb_secret)
    {
        Console.WriteLine("gg");
        iswon = true;
    }
    else
    {
        Console.WriteLine($"Noob");
        vie -= 1;
        Console.WriteLine($"Il te reste {vie} vie(s)");
    }

    if (vie == 0)
    {
        Console.WriteLine("Ta pu de vie ");
    }
}
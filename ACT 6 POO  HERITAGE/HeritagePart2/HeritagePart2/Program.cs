// See https://aka.ms/new-console-template for more information
using HeritagePart2;

Console.WriteLine("Hello, World!");

Animaux[] mesAnimaux = new Animaux[5];

mesAnimaux[0] = new Chat("logobi", DateTime.Parse("20/09/2007"), 1, 179, true);
mesAnimaux[1] = new Chien("logobi", DateTime.Parse("20/09/2007"), 1, 179, true);
mesAnimaux[2] = new Chat("logobi", DateTime.Parse("20/09/2007"), 1, 179, true);
mesAnimaux[3] = new Lapin("logobi", DateTime.Parse("20/09/2007"), 1, 179, true);
mesAnimaux[4] = new Lapin("logobi", DateTime.Parse("20/09/2007"), 1, 179, true );

for (int i = 0; i < mesAnimaux.Length; i++)
{
    Console.WriteLine(mesAnimaux[i].AfficheInfo());
    Console.WriteLine(mesAnimaux[i].Nom + mesAnimaux[i].Manger());

    if (mesAnimaux[i] is Chat chat)
    {
        Console.WriteLine(chat.Miauler());
    }

    else if (mesAnimaux[i] is Chien chien)
    {
        Console.WriteLine(chien.Aboyer());
    }

    else if (mesAnimaux[i] is Lapin lapin)
    {
        Console.WriteLine(lapin.FaireBonds());
    }
}


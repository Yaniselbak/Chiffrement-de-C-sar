using System;

class Program
{
    static string ChiffrementCesar(string texte, int decalage)
    {
        string texteChiffre = "";

        foreach (char caractere in texte)
        {
            if (char.IsLetter(caractere))
            {
                // Détermine si le caractère est majuscule ou minuscule
                char debutAlphabet = char.IsUpper(caractere) ? 'A' : 'a';
                // Applique le décalage en tenant compte de la casse
                char nouveauCaractere = (char)(((caractere + decalage - debutAlphabet) % 26) + debutAlphabet);
                texteChiffre += nouveauCaractere;
            }
            else
            {
                texteChiffre += caractere; // Conserve les caractères non alphabétiques inchangés
            }
        }

        return texteChiffre;
    }

    static void Main(string[] args)
    {
        string texte = "Bonjour, comment allez-vous ?";
        int decalage = 3;
        string texteChiffre = ChiffrementCesar(texte, decalage);
        Console.WriteLine("Texte chiffré: " + texteChiffre);
    }
}

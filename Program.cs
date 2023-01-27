using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //preparation des variables
            string trueWord = "chat";
            string userWriteWord;

            do
            {
                Console.WriteLine("Bonjour, voici une petite énigme :\n"
                                + "\n"
                                + "Je suis un animal de compagnie proche des humains \n"
                                + "Nous n'aimons pas l'eau. à la fois agile et aimant le calme, j'aime dormir \n"
                                +"\n"
                                + "Qui suis-je ?\n"
                                + "(Saisissez le nom de l'animal en minuscules)" );
                userWriteWord = Console.ReadLine();
                Console.WriteLine("Vous avez saisi : " + userWriteWord );
            } while (userWriteWord != trueWord);

            Console.WriteLine("Bravo c'etait bien le chat !! \n"
                              + "\n"
                              + "                   ~ Merci d'avoir joué et à la prochaine ! ~ ");

        }
    }
}
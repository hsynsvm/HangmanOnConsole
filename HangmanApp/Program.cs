using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangmanApp();
        }

        private static void HangmanApp()
        {
            Console.WriteLine("Welcome To Our Hangman Game");
            Console.WriteLine("\nPlease Enter The Player's Name!");
            string ilkOyuncu = Console.ReadLine(); // Konsoldan oyuncu ismini alır - Gets player name from console
            Console.WriteLine();
            Console.WriteLine(ilkOyuncu + "\tPlease Select Level");
            Console.WriteLine("\n Easy = 1 *** Middle = 2 *** Hard = 3 *** Impossible = 4 ");
            string seviyeler = Console.ReadLine(); // Konsoldan seçilen seviyeleri alır - Gets selected levels from console

            string[] adamAsmaca = new string[] { "MERCURY", "VENUS", "WORLD", "ANTHEM", "JUPITER", "SATURN", "URANUS", "NEPTUNE"}; // Adamasmaca için kullanılacak kelimeler - Words to use for Hangman
            Random rastgele = new Random(); 
            int rastgeleIndex = rastgele.Next(0, adamAsmaca.Length); // Kelimelerin random hale getirilmesi - Randomization of words
            string secilenKelime = adamAsmaca[rastgeleIndex]; // secilenKelime'nin adamAsmaca listesi içinden rastgele seçilmesi - Random selection of the selectedWord from the Hangman list

            char[] karakter = new char[secilenKelime.Length]; // Doğru girilen tahminler - Correctly entered predictions

            for (int i = 0; i < secilenKelime.Length; i++) // secilenKelime uzunluğunda '_' işareti yerleştirmesi - Placement of '_' sign on selectedWord length
            {
                karakter[i] = '_';
            }

            // Hakların belirlenmesi - Determination of rights
            int kolayHak = 20; 
            int ortaHak = 15;
            int zorHak = 12;
            int imkansız = 9;

            while (seviyeler == "1" && kolayHak > 0)
            {
                Console.WriteLine("Remaining Guesses: " + kolayHak);
                string tahminEdilenKelime = new string(karakter);
                Console.WriteLine("Guessed Word: " + tahminEdilenKelime);

                Console.WriteLine("Please enter a letter!");
                char girilenTahmin = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                if (!char.IsLetter(girilenTahmin))
                {
                    Console.WriteLine("Invalid input! Please enter a valid letter.");
                    continue;
                }

                bool dogruTahmin = false;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == girilenTahmin)
                    {
                        karakter[i] = girilenTahmin;
                        dogruTahmin = true;
                    }
                }
                if (!dogruTahmin)
                {
                    Console.WriteLine("Wrong Guess!");
                    kolayHak--;
                }
                if (new string(karakter) == secilenKelime)
                {
                    Console.WriteLine("Congratulations! You Won! :) Correct Word: " + secilenKelime);
                    break;
                }
            }
            if (kolayHak == 0)
            {
                Console.WriteLine("Game Over! :( Correct Word: " + secilenKelime);
            }

            while (seviyeler == "2" && ortaHak > 0)
            {
                Console.WriteLine("Remaining Guesses: " + ortaHak);
                string tahminEdilenKelime = new string(karakter);
                Console.WriteLine("Guessed Word: " + tahminEdilenKelime);

                Console.WriteLine("Please enter a letter!");
                char girilenTahmin = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                if (!char.IsLetter(girilenTahmin))
                {
                    Console.WriteLine("Invalid input! Please enter a valid letter.");
                    continue;
                }

                bool dogruTahmin = false;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == girilenTahmin)
                    {
                        karakter[i] = girilenTahmin;
                        dogruTahmin = true;
                    }
                }
                if (!dogruTahmin)
                {
                    Console.WriteLine("Wrong Guess!");
                    ortaHak--;
                }
                if (new string(karakter) == secilenKelime)
                {
                    Console.WriteLine("Congratulations! You Won! :) Correct Word: " + secilenKelime);
                    break;
                }
            }
            if (ortaHak == 0)
            {
                Console.WriteLine("Game Over! :( Correct Word: " + secilenKelime);
            }

            while (seviyeler == "3" && zorHak > 0)
            {
                Console.WriteLine("Remaining Guesses: " + zorHak);
                string tahminEdilenKelime = new string(karakter);
                Console.WriteLine("Guessed Word: " + tahminEdilenKelime);

                Console.WriteLine("Please enter a letter!");
                char girilenTahmin = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                if (!char.IsLetter(girilenTahmin))
                {
                    Console.WriteLine("Invalid input! Please enter a valid letter.");
                    continue;
                }

                bool dogruTahmin = false;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == girilenTahmin)
                    {
                        karakter[i] = girilenTahmin;
                        dogruTahmin = true;
                    }
                }
                if (!dogruTahmin)
                {
                    Console.WriteLine("Wrong Guess!");
                    zorHak--;
                }
                if (new string(karakter) == secilenKelime)
                {
                    Console.WriteLine("Congratulations! You Won! :) Correct Word: " + secilenKelime);
                    break;
                }
            }
            if (zorHak == 0)
            {
                Console.WriteLine("Game Over! :( Correct Word: " + secilenKelime);
            }

            while (seviyeler == "4" && imkansız > 0)
            {
                Console.WriteLine("Remaining Guesses: " + imkansız);
                string tahminEdilenKelime = new string(karakter);
                Console.WriteLine("Guessed Word: " + tahminEdilenKelime);

                Console.WriteLine("Please enter a letter!");
                char girilenTahmin = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine();

                if (!char.IsLetter(girilenTahmin))
                {
                    Console.WriteLine("Invalid input! Please enter a valid letter.");
                    continue;
                }

                bool dogruTahmin = false;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == girilenTahmin)
                    {
                        karakter[i] = girilenTahmin;
                        dogruTahmin = true;
                    }
                }
                if (!dogruTahmin)
                {
                    Console.WriteLine("Wrong Guess!");
                    imkansız--;
                }
                if (new string(karakter) == secilenKelime)
                {
                    Console.WriteLine("Congratulations! You Won! :) Correct Word: " + secilenKelime);
                    break;
                }

            }
            if (imkansız == 0)
            {
                Console.WriteLine("Game Over! :( Correct Word: " + secilenKelime);
            }
        } //  <== Kodlar Burada (Codes are here)
    }
}

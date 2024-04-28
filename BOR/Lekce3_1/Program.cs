using System.Security.Cryptography.X509Certificates;

namespace Lekce3_1
{



    internal class Program
    {
        /*   //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
           //string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

           static void Main(string[] args)
           {
               string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

               //převedu string na pole znaků

               char[] pismeno = capsLock.ToCharArray();


               //kontrola každého znaku z řetězce

               for (int i = 0; i < pismeno.Length; i++)
               {
                   //pokud je znak písmeno, převádím na malé/velké, pokud není, nechám beze změny

                   if (char.IsLetter(pismeno[i]))
                   {
                       if (char.IsLower(pismeno[i]))
                       {
                           pismeno[i] = char.ToUpper(pismeno[i]);
                       }
                       else
                       {
                           pismeno[i] = char.ToLower(pismeno[i]);
                       }
                   }
               }

               //vrátím nový string sestavený z převedených písmen

               string opravenyText = new string(pismeno);
               Console.WriteLine(opravenyText);
        

        //Ukol - rozsifrujte tuto zpravu - capsLock byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
        //string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
        static void Main()
        {
            string zasifrovanyText = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";
            char[] poleZnaku = zasifrovanyText.ToCharArray();

            for (int i = 0; i < zasifrovanyText.Length; i++)
            {
                //pro každý znak pole provedu posunutí o jedno doleva, tj. musím ho zmenšit o 1
                
                char znak = poleZnaku[i];
                char posunutyZnak = (char)(znak - 1);
                poleZnaku[i] = posunutyZnak;
            }

            string desifrovanyText = new string(poleZnaku);
            Console.WriteLine(desifrovanyText);
        }
       

        //Ukol - Obratte poradi stringu
        //string palindrom = "Kuna nese nanuk"; 
        static void Main()
        {
            string palindrom = "Kuna nese nanuk";

            char[] poleZnaku = palindrom.ToCharArray();
            // Převedení stringu na pole znaků

            // Ukazatele pro první(i) a poslední(j) znak v poli
            int i = 0;
            int j = poleZnaku.Length - 1;

            // Prohození znaků 
            while (i < j)
            {
                char mezipamet = poleZnaku[i];
                poleZnaku[i] = poleZnaku[j];
                poleZnaku[j] = mezipamet;

                i++;
                j--;
            }

            // Vytvoření nového stringu z obráceného pole znaků
            string obracenyPalindrom = new string(poleZnaku);

            Console.WriteLine($"Obrácený palindrom:{obracenyPalindrom}");
        }
        */


        //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
        //string[] poleSlov = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" }; 

        static void Main()
        {

            string[] poleSlov = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

            //pro každé poleSlov zjistím, jesli je v původní a převrácené podobě stejné, resp. jesli se shoduje do poloviny 
            //poduk ano
            //vypsat palindromy

            Console.WriteLine($"Palindromy z daných slov jsou:");

            for (int i = 0; i < poleSlov.Length; i++)
            {
                string aktualniSlovo = poleSlov[i];
                bool JePalindrom = true;

                int poradiPismenkaZacatekSlova = 0;
                int poradiPismenkaKonecSlova = aktualniSlovo.Length - 1;

                while (poradiPismenkaZacatekSlova < poradiPismenkaKonecSlova)
                {
                    if (char.ToUpper(aktualniSlovo[poradiPismenkaZacatekSlova]) != char.ToUpper(aktualniSlovo[poradiPismenkaKonecSlova]))
                    {
                        JePalindrom = false;
                        break;
                    }
                    poradiPismenkaZacatekSlova++;
                    poradiPismenkaKonecSlova--;
                }
                if (JePalindrom)
                {
                    Console.WriteLine(aktualniSlovo);
                }


            }

        }
    }
}
      





 
  

    



﻿namespace Lekce3_1
{
    //Ukol - Obratte poradi stringu
    //string palindrom = "Kuna nese nanuk"; 

    //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
    //string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" }; 

    //Ukol - rozsifrujte tuto zpravu - capsLock byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
    //string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";

    internal class Program
    {
        //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
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

        }
    }
}
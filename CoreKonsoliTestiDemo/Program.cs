
using CoreKonsoliTestiDemo;

bool jatketaanko = true;

while(jatketaanko == true)
{
    Laskuri laskuri = new Laskuri();

    Console.WriteLine("Anna kertolaskun kaava (esim. 1 * 2) ja paina enter");

    string kaava = Console.ReadLine();
    Console.WriteLine(laskuri.kerro(kaava));

    Console.WriteLine("Lopeta Q tai jatka painamalla jotain muuta näppäintä.");
    string valinta = Console.ReadLine();
    if (valinta.ToUpper() == "Q") {
        jatketaanko = false;
    }
    else
    {
        jatketaanko = true;
    }
 }



using System.IO; /*operacje na plikach*/
using System.Windows.Forms; /* okienka dialogowe dla Windows Forms*/

namespace KlasaPliki /*brak pomysłu, aże klasa się nazywa pliki, więc taką nazwę dostała*/
{
 class pliki
 /*klasa, której zadanie jest:
  * zapisywanie_dopliku:
  * - zapisywanie plikow w zaleznosci od parametru podane do klasy: 
  * -- 0 - pliki tekstowe txt
  * -- inne wszystkie możliwe stany liczby - strona internetowa o rozszerzeniu HTML
  * -- możliwość rozszerzenia funkcjonalności klasy do innych rozszerzeń za pomoca CASE. 
  * --Zastosowałem If'a mając na myśli zastosowanie, krótkigoe i bardziej intuincyjnego zapisu
  * - wyświetlenie komunikatu dla uzytkownika, że pomyślnie zapisano w danej ścieżcę jego plik. Dodanie tego komunikatu
  * za myślą ochronionych przed zapisanem nośników. Zastosowanie MessageBox.Show wymaga bibliotek System.Windows.Forms
  * Metoda zapisywanie_dopliku zakłada, że dostanie dane w formie takiej, jakiej ma być zapisane. Ta metoda zakłada,
  * że już nie będzie musiała modyfikować stringa, a tylko zapisać jego w danej lokalizacji oraz nazwie wskazanej przez 
  * przez użytkownika. Takie rozwiązanie zastosowałem, z myślą o uniwersalności klasy. 
  * 
  * Dalsza część użyteczności klasy będzie opisywana dalej.
  */
 {
  public pliki() { }
  public void zapisywanie_dopliku(string s, int i)
  {
   SaveFileDialog okienko = new SaveFileDialog();
   if (i == 0) okienko.Filter = "Pliki textowe (txt)|*.txt";
   else okienko.Filter = "Strona internetowa (html)|*.html";
   if (okienko.ShowDialog() == DialogResult.OK)
   {
    File.WriteAllText(okienko.FileName, s);
    MessageBox.Show("Pomyślnie zapisano plik w lokalizacji " + okienko.FileName);
   }
  }
  /*
   * odczytywanie_z_pliku
   * metoda, która odpowiada za odczytanie danego pliku w zależności od parametru. 
   * wskazanie ścieżki spoczywa na barkach użytkownika
   */

  public string odczytywanie_z_pliku(int i)
  {
   string s;
   OpenFileDialog okienko = new OpenFileDialog();
   if (i == 0) okienko.Filter = "Pliki textowe (txt)|*.txt";
   else okienko.Filter = "Strona internetowa (html)|*.html";
   if (okienko.ShowDialog() == DialogResult.OK)
   {
    string wejsciowystring = File.ReadAllText(okienko.FileName);
    MessageBox.Show("Pomyślnie odczytano plik w lokalizacji " + okienko.FileName);
    return s = wejsciowystring;
   }
   return s = "-1";
  }
 }
}

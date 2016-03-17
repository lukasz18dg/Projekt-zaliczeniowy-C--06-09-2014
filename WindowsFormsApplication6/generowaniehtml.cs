namespace GPliku /*skrot od Generowania pliku o danym rozszerzeniu.
                  * Klasa, służy jednej rzeczy tworzeniu nowego pliku HTML.
                  * W przyszłości jest możliwe dodanie następnych metod, które będą tworzyły dane pliki, 
                  * potrzebne do pracy użytkownika. Możliwe przyszłe kierunki rozwoju to: PHP, JavaScript+HTML+CSS*/
{
 class gpliku
 {
  public gpliku() { }
  public void tworzenie_pliku_html(dane_faktury zbiordanych)
  {
   KlasaPliki.pliki pliki = new KlasaPliki.pliki();
   string wejsciowystring = pliki.odczytywanie_z_pliku(1);
   if (wejsciowystring != "-1")
   {
    /*Na konsultacjach zaproponowano mi utworzenie takiego pliku za pomocą XML, ale niestety przerosło mnie to, ponieważ
     nie wiem jak utworzyć i jak wsadzić dane do takiego pliku od poziomu programu. Zastosowałem rozwiązanie pośrednie, które
     daje użytkownikowi, pole do manerwu plikiem HTML.*/
    /*Zakładam, że użytkownik stworzy schemat w którym będą odpowiednie słowa, kluczowe. Które program automatycznie zmieni
     w procesie produkcji. Wraz z programem, będzie dołączony schemat. 
     Program wyszukuje danego słowa kluczowego*/
    int a = wejsciowystring.IndexOf("<!--data_wystawienia-->");
    /*Wartość zwracana, przez powyższą instrukcję będzie dodatnia, kiedy odnajdzie w danym pliku dane słowo kluczowe
     jeśli jest ujemna, funkcja nie znalazła danego kluczowego słowa i program nie wiem gdzie umieścić dane*/
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 23, zbiordanych.dzienwystawienia);
    /*^^ Gdzy a nie jest ujemna, to program po słowie kluczowym umieszcza naszą dane przechowywaną w odpowiedniej części
     struktury
     Dalsze instrukcje są analogiczne i zostanie pominięty komentarz.*/
    a = wejsciowystring.IndexOf("<!--data_wplaty1-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 19, zbiordanych.Data_wpłaty1);
    a = wejsciowystring.IndexOf("<!--metoda_platnosci1-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 24, zbiordanych.metoda_platnosci1);
    a = wejsciowystring.IndexOf("<!--zamowienie_dane-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 22, zbiordanych.zamowienie_dane);
    a = wejsciowystring.IndexOf("<!--suma_brutto-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 18, zbiordanych.suma_brutto);

    a = wejsciowystring.IndexOf("<!--nazwafirmy_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 25, zbiordanych.nabywca.nazwa_firmy);
    a = wejsciowystring.IndexOf("<!--adresfirmy_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 25, zbiordanych.nabywca.adres_firmy);
    a = wejsciowystring.IndexOf("<!--kod_pocztowy_1_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 29, zbiordanych.nabywca.kod_pocztowy_1);
    a = wejsciowystring.IndexOf("<!--nip_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 18, zbiordanych.nabywca.nip);
    a = wejsciowystring.IndexOf("<!--kod_pocztowy_2_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 29, zbiordanych.nabywca.kod_pocztowy_2);
    a = wejsciowystring.IndexOf("<!--nazwa_banku_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 26, zbiordanych.nabywca.nazwa_banku);
    a = wejsciowystring.IndexOf("<!--numer_bankowy_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 28, zbiordanych.nabywca.numer_bankowy);
    a = wejsciowystring.IndexOf("<!--pesel_nabywca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 20, zbiordanych.nabywca.pesel);

    a = wejsciowystring.IndexOf("<!--nazwafirmy_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 28, zbiordanych.sprzedawca.nazwa_firmy);
    a = wejsciowystring.IndexOf("<!--adresfirmy_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 28, zbiordanych.sprzedawca.adres_firmy);
    a = wejsciowystring.IndexOf("<!--kod_pocztowy_1_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 32, zbiordanych.sprzedawca.kod_pocztowy_1);
    a = wejsciowystring.IndexOf("<!--kod_pocztowy_2_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 32, zbiordanych.sprzedawca.kod_pocztowy_2);
    a = wejsciowystring.IndexOf("<!--nazwa_banku_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 29, zbiordanych.sprzedawca.nazwa_banku);
    a = wejsciowystring.IndexOf("<!--nip_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 21, zbiordanych.sprzedawca.nip);
    a = wejsciowystring.IndexOf("<!--numer_bankowy_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 31, zbiordanych.sprzedawca.numer_bankowy);
    a = wejsciowystring.IndexOf("<!--pesel_sprzedawca-->");
    if (a != -1) wejsciowystring = wejsciowystring.Insert(a + 23, zbiordanych.sprzedawca.pesel);

    /*Zakładam, także że dane o nazwie, cenie brutto, cenie netto towaru. Będą w jakieś formie, która pozwala na kopiowanie
     i umieszczenia tych danych pod sobą. Przykładem takiego zapisu jest np tabela i jej następne wiersze
     program pierw oczekuje, że znajdzie fragment do skopiowania i usunięcia i wniej będą słowa kluczowe dla nazwy, cenny 
     brutto, cenie towru netto. */
    a = wejsciowystring.IndexOf("<!--wiersz_do_kopiowania-->"); //Początek  
    int b = wejsciowystring.IndexOf("<!--/wiersz_do_kopiowania-->"); //i koniec wierszu do kopiowania
    if (((a != -1) && (b != -1)) && (zbiordanych.iloscwartosci_faktur != 1)) /*Musi być początek oraz koniec, ostatnia
                                                                              wartość odpowiada za ilosc elementow w tabeli*/
    {
     string tmp1 = wejsciowystring.Substring(a, (b + 28) - a);  /*kopiowanie wiersza do zmiennej lokalnej*/
     wejsciowystring = wejsciowystring.Remove(a, (b + 28) - a); /*usuwanie wiersza*/
     string tmp = tmp1; int c;   /*Zmienne pomocnicze potrzebne do pracy*/
     for (int i = zbiordanych.iloscwartosci_faktur - 1; i > -1; i--) /*Zaczynamy pracę od tyłu dla pozostawienia chronologi
                                                                      * takiej samej jak w programie*/
     {
      /*Tak samo jak wcześniej, czyli program oczekuje słowa kluczowego, jeśli jest znalezione to program koło słowa kluczowego
       dopisuje dane z formy, jeśli nie, dana zostanie pominięta.*/
      c = tmp.IndexOf("<!--nazwa-->");
      if (c != -1) tmp = tmp.Insert(c + 12, zbiordanych.daneowartoscifaktury[i].nazwa);
      c = tmp.IndexOf("<!--ilosc-->");
      if (c != -1) tmp = tmp.Insert(c + 12, zbiordanych.daneowartoscifaktury[i].ilosc);
      c = tmp.IndexOf("<!--cennanettozasztuke-->");
      if (c != -1) tmp = tmp.Insert(c + 25, zbiordanych.daneowartoscifaktury[i].cennanettozasztuke);
      c = tmp.IndexOf("<!--stawka-->");
      if (c != -1) tmp = tmp.Insert(c + 13, zbiordanych.daneowartoscifaktury[i].stawka);
      c = tmp.IndexOf("<!--cennabrutto-->");
      if (c != -1) tmp = tmp.Insert(c + 18, zbiordanych.daneowartoscifaktury[i].cennabrutto);
      c = tmp.IndexOf("<!--wartoscnetto-->");
      if (c != -1) tmp = tmp.Insert(c + 19, zbiordanych.daneowartoscifaktury[i].wartoscnetto);
      c = tmp.IndexOf("<!--wartoscbrutto-->");
      if (c != -1) tmp = tmp.Insert(c + 20, zbiordanych.daneowartoscifaktury[i].wartoscbrutto);
      wejsciowystring = wejsciowystring.Insert(a, tmp); /*Powrót go głównej zmiennej w której jest przechowywany cały kod HTLM
                                                       (działaliśmy na zmiennej tymczasowej), zostanie dopisane tam, gdzie 
                                                       znalezlismy znacznik*/
      tmp = tmp1; /*Przywrócenie wzoru*/
     }
    }
    pliki.zapisywanie_dopliku(wejsciowystring, 1); /*Przekazanie do klasy, która odpowiadania za zapisywanie stringa na dysku*/
   }
  }
 }
}


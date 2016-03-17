using System;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
 public partial class Glowne_okno : Form
 {
  public Glowne_okno()
  {
   InitializeComponent();
   MessageBox.Show(@"                      Łukasz Tworus
                     Informatyka Licencjacka
                     2013/2014
                     I rok semestr letni");
  }
  /*Zdazenia, wywołują tylko jedną metodę z casem. O powodach zastosowania tego pomysłu jest wytłumaczone przy centrum
   * dowodzenia.*/
  private void Wyjście_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(0); }
  private void wczytanie_z_pliku_nabywcy_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(1); }
  private void wczytanie_z_pliku_sprzedajacym_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(2); }
  private void zapisanie_danych_o_nabywcy_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(3); }
  private void zapisanie_danych_o_sprzedajacym_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(4); }
  private void generowanie_pliku_html_Click(object sender, EventArgs e) { CENTRUM_DOWODZENIA(5); }
  private void wartosci_faktury_CellValueChanged(object sender, DataGridViewCellEventArgs e) { CENTRUM_DOWODZENIA(6); }
  dane_faktury zbiordanych; /* struktura, która będzie wykorzystywana w zbieraniu wszystkich informacji z formy i przekazaniu
                             * dalszej obróbce*/
  private bool sprawdzczypoprawnytyp(string a, int i) //0 - int, wszystko inne double
  /*sprawdzanie czy podana liczba w stringu jest liczba odpowiadająca danemu typowi, który wymagam w dalszym programie
    * możliwosc dołozenia nastepnych typow za pomoca case. Z powodu intuincyjnego zapisu został zastosowany IF*/
  {
   bool zbadaj;
   if (i == 0) { int result; zbadaj = int.TryParse(a, out result); }
   else { double result; zbadaj = double.TryParse(a, out result); }
   if (zbadaj == true) return true; else return false;
  }

  private void generowanie_stringa_sluzacego_do_zapisu(string nazwafirmy, string adresfirmy, string kodpocztow1, string kodpocztowy2, string nip, string nazwabanku, string numerbankowy, string PESEL)
  /*Przygotowanie danych do zapisu na podstawie danych przesłanych przez Centrum dowodzenia. Dodanie specjalnych liter
     * ma byc ogranicznikiem pomiędzy danymi oraz łatwiejszym jego rozdzieleniu przez program. 
     * W przyszlosci mozna dodac ograniczenie dotyczace szyfrowania, zeby zeby zaden nie powolany uzytkownik
     * nie mial dostepu do waznych danych o kontrachetnach oraz zmiany rozszerzenia, na mniej rozpoznowalny
     * Wykonuje to w metodzie, o troske uniwersalnosci klasy KlasaPliki.*/
  {
   string s = "";
   s += (nazwafirmy + "A@#$A"); s += (adresfirmy + "A@#$A"); s += (kodpocztow1 + "A@#$A"); s += (kodpocztowy2 + "A@#$A");
   s += (nip + "A@#$A"); s += (nazwabanku + "A@#$A"); s += (numerbankowy + "A@#$A"); s += (PESEL + "A@#$A");
   KlasaPliki.pliki zapis = new KlasaPliki.pliki();
   zapis.zapisywanie_dopliku(s, 0);
  }

  private void wczytanie_z_pliku(int i)
  /* Metoda czysto stricte polegają na wywołaniu odpowiedniej klasy oraz otrzymaniu jakiegoś stringa. W celu ochrony przed
   * pustym stringiem, owa zmienna nie może zawierać wartości -1. Następnym etapem, jest rozdzielenie według specjalnego
   * słowa i umieszczenie w interfejsie danych wczytanch z pliku. 
   */
  {
   KlasaPliki.pliki odczyt = new KlasaPliki.pliki();
   string wejsciowystring = odczyt.odczytywanie_z_pliku(0);
   if (wejsciowystring != "-1")
   {
    string[] danezpliku = wejsciowystring.Split(new string[] { "A@#$A" }, StringSplitOptions.None);
    if (i == 0)
    {
     nazwa_firmy_sprzedajacego.Text = danezpliku[0]; adres_firmy_sprzedajacego.Text = danezpliku[1];
     kod_pocztowy1_sprzedajacego.Text = danezpliku[2]; kod_pocztowy2_sprzedajacego.Text = danezpliku[3];
     nip_sprzedajacego.Text = danezpliku[4]; nazwa_banku_sprzedajacego.Text = danezpliku[5];
     numer_bankowy_sprzedajacego.Text = danezpliku[6]; PESELsprzedawcy.Text = danezpliku[7];
    }
    else
    {
     nazwa_firmy_kupujacego.Text = danezpliku[0]; adres_firmy_kupujacego.Text = danezpliku[1];
     kod_pocztowy1_kupujacego.Text = danezpliku[2]; kod_pocztowy2_kupujacego.Text = danezpliku[3];
     nip_kupujacego.Text = danezpliku[4]; nazwa_banku_kupujacego.Text = danezpliku[5];
     numer_bankowy_kupujacego.Text = danezpliku[6]; PESELnabywcy.Text = danezpliku[7];
    }
   }
  }

  private void CENTRUM_DOWODZENIA(int i)
  /*
   * Tutaj się wszystko zaczyna i kończy. Jest to centrum kontrolne pomiędzy logiką aplikacji, czyli klasami. 
   * A pomiędzy "Widokiem" czyli, częścią wizualną programu oraz tym co wpisuje użytkownik do programu. 
   * Funkcja, która ma za zadanie:
   * - odciazeniu metod
   * - przygotowanie oraz zebranie danych z różnych kontrolek/textbox dla klas(Tutaj miałem problem z probleme: Czy tworzyć
   * klasy, które w założeniu mogą być wykorzystane w innych programach czy tworzyć klasę tylko specjalnie wyspecjalizowaną 
   * dla tego programu)
   * - aktualizowanie widoku
   * - łatwość edytowania funkcji za pomocą dodawanie lub odejmowania danych funkcji programu
   * */
  {
   switch (i)
   {
    case 0: /*Okienko z pytaniem o wyłączenie programu*/
     {
      if (MessageBox.Show("Czy na pewno chcesz wyłączyć program?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) Close();
      break;
     }
    case 1: /* wywołanie okienka dla wczytywanie nabywcy z pliku, zapisanie danych do interfejsu programu*/
     { wczytanie_z_pliku(1); break; }
    case 2: /* wywolanie okienka dla wczytywania kupujacego z pliku, zapisanie danych do interfejsu programu */
     { wczytanie_z_pliku(0); break; }
    case 3:
     /*Na barkach tej części programu, jest odpowiednie zebranie danych i wysłanie do metody,która to odpowiednio przetworzy
        * i wyśle następnie do logiki aplikacji, gdzie zostanie faktyczne zapisanie danych o kupujących.
        Tutaj także następuje prosta walidacja danych*/
     {
      if (sprawdzczypoprawnytyp(kod_pocztowy1_kupujacego.Text, 0) && sprawdzczypoprawnytyp(kod_pocztowy2_kupujacego.Text, 0))
      {
       if (sprawdzczypoprawnytyp(nazwa_banku_kupujacego.Text, 0))
        generowanie_stringa_sluzacego_do_zapisu(nazwa_firmy_kupujacego.Text, adres_firmy_kupujacego.Text, kod_pocztowy1_kupujacego.Text, kod_pocztowy2_kupujacego.Text, nip_kupujacego.Text, nazwa_banku_kupujacego.Text, numer_bankowy_kupujacego.Text, PESELnabywcy.Text);
       else MessageBox.Show("Podany numer bankowy nie jest liczbą, proszę wpisać ponownie. ");
      }
      else MessageBox.Show("Podany kod pocztowy u nabywcy jest nie poprawny, proszę go ponownie wpisać");
      break;
     }
    case 4: /* tak samo jak case 3 */
     {
      if (sprawdzczypoprawnytyp(kod_pocztowy1_sprzedajacego.Text, 0) && sprawdzczypoprawnytyp(kod_pocztowy2_sprzedajacego.Text, 0))
      {
       if (sprawdzczypoprawnytyp(nazwa_banku_sprzedajacego.Text, 0))
        generowanie_stringa_sluzacego_do_zapisu(nazwa_firmy_sprzedajacego.Text, adres_firmy_sprzedajacego.Text, kod_pocztowy1_sprzedajacego.Text, kod_pocztowy2_sprzedajacego.Text, nip_sprzedajacego.Text, nazwa_banku_sprzedajacego.Text, numer_bankowy_sprzedajacego.Text, PESELsprzedawcy.Text);
       else MessageBox.Show("Podany numer bankowy nie jest liczbą, proszę wpisać ponownie. ");
      }
      else MessageBox.Show("Podany kod pocztowy u nabywcy jest nie poprawny, proszę go ponownie wpisać");
      break;
     }
    case 5:
     /*Najpotężnieszy kolos, ale niestety każdą danę musiałem zebrać pojedynczo. Niestety nie znam innego sposobu.
      Ten CASE odpowiada, za zebranie wszystkich danych znajdujących się w formie wpisanych odpowiednio przez użytkownika
      i zapisanie tych danych do wyspecjalizowanej struktury, która przechowa wszystkie dane, a następnie odpowiedno
      prześle dane dalej do klasy, która będzie operowała na nich. W CASE się zdecydowałem na strukturę, ponieważ
      łatwiej przesłać odpowiednio wielkie dane przez parametr. */
     {
      /*dane z górnych kontrolek*/
      zbiordanych.dzienwystawienia = dzienwystawienia.Text; zbiordanych.Data_wpłaty1 = Data_wpłaty1.Text;
      zbiordanych.metoda_platnosci1 = metoda_platnosci1.Text; zbiordanych.zamowienie_dane = zamowienie_dane.Text;
      zbiordanych.suma_brutto = suma_brutto.Text;
      /*Dane o  kliencie*/
      zbiordanych.nabywca.nazwa_firmy = nazwa_firmy_kupujacego.Text; zbiordanych.nabywca.adres_firmy = adres_firmy_kupujacego.Text;
      zbiordanych.nabywca.kod_pocztowy_1 = kod_pocztowy1_kupujacego.Text; zbiordanych.nabywca.nip = nip_kupujacego.Text;
      zbiordanych.nabywca.kod_pocztowy_2 = kod_pocztowy2_kupujacego.Text; zbiordanych.nabywca.nazwa_banku = nazwa_banku_kupujacego.Text;
      zbiordanych.nabywca.numer_bankowy = numer_bankowy_kupujacego.Text; zbiordanych.nabywca.pesel = PESELnabywcy.Text;
      /*Dane o sprzedawcy*/
      zbiordanych.sprzedawca.nazwa_firmy = nazwa_firmy_sprzedajacego.Text; zbiordanych.sprzedawca.adres_firmy = adres_firmy_sprzedajacego.Text;
      zbiordanych.sprzedawca.kod_pocztowy_1 = kod_pocztowy1_sprzedajacego.Text; zbiordanych.sprzedawca.kod_pocztowy_2 = kod_pocztowy2_sprzedajacego.Text;
      zbiordanych.sprzedawca.nazwa_banku = nazwa_banku_sprzedajacego.Text; zbiordanych.sprzedawca.nip = nip_sprzedajacego.Text;
      zbiordanych.sprzedawca.numer_bankowy = numer_bankowy_sprzedajacego.Text; zbiordanych.sprzedawca.pesel = PESELsprzedawcy.Text;
      /*Dane o nazwie, cenie, stawce towru itp.
       Zastosowanie struktury ma na celu łatwiejsze je zastosowanie oraz z listą były problemy w dostaniu się do 
       struktury "wartosc_faktura"*/
      zbiordanych.daneowartoscifaktury = new wartosc_faktury[wartosci_faktury.Rows.Count];
      zbiordanych.iloscwartosci_faktur = wartosci_faktury.Rows.Count;
      for (i = 0; i < wartosci_faktury.Rows.Count; i++) zbiordanych.daneowartoscifaktury[i] = new wartosc_faktury();
      for (i = 0; i < wartosci_faktury.Rows.Count; i++)
      {
       zbiordanych.daneowartoscifaktury[i].nazwa = Convert.ToString(wartosci_faktury[0, i].Value);
       zbiordanych.daneowartoscifaktury[i].ilosc = Convert.ToString(wartosci_faktury[1, i].Value);
       zbiordanych.daneowartoscifaktury[i].cennanettozasztuke = Convert.ToString(wartosci_faktury[2, i].Value);
       zbiordanych.daneowartoscifaktury[i].stawka = Convert.ToString(wartosci_faktury[3, i].Value);
       zbiordanych.daneowartoscifaktury[i].cennabrutto = Convert.ToString(wartosci_faktury[4, i].Value);
       zbiordanych.daneowartoscifaktury[i].wartoscnetto = Convert.ToString(wartosci_faktury[5, i].Value);
       zbiordanych.daneowartoscifaktury[i].wartoscbrutto = Convert.ToString(wartosci_faktury[6, i].Value);
      }
      GPliku.gpliku nowyplik = new GPliku.gpliku(); /*Tworzenie nowego obiektu klasy*/
      nowyplik.tworzenie_pliku_html(zbiordanych); /* Przeniesienie pracy do klasy*/
      break;
     }
    case 6:
     /* Metoda ma służyć tylko do akualizacji wyglądu oraz automatycznego generowania: - Cenny brutto, - wartosc netto
          * -wartosc brutto. Aplikacja generuje, kiedy ma wpisane trzy dane: - ilosc, - cenna netto za sztuke
          - stawka. Wtedy i tylko wtedy zostanie wygenerowane wczesniejsze dane. 
          Metoda jest potrzebna do pozniejszej generacji plikow*/
     {
      double sumawartoscibrutto = 0;
      for (int j = 0; j < wartosci_faktury.Rows.Count; j++)
      {
       if ((sprawdzczypoprawnytyp(Convert.ToString(wartosci_faktury[1, j].Value), 1)) &&
        (sprawdzczypoprawnytyp(Convert.ToString(wartosci_faktury[2, j].Value), 1)) &&
        (sprawdzczypoprawnytyp(Convert.ToString(wartosci_faktury[3, j].Value), 1)))
       {
        wartosci_faktury[4, j].Value = Convert.ToString(Convert.ToDouble(wartosci_faktury[2, j].Value) * (Convert.ToDouble(wartosci_faktury[3, j].Value) * 0.01) + Convert.ToDouble(wartosci_faktury[2, j].Value));
        wartosci_faktury[5, j].Value = Convert.ToString(Convert.ToDouble(wartosci_faktury[1, j].Value) * Convert.ToDouble(wartosci_faktury[2, j].Value));
        wartosci_faktury[6, j].Value = Convert.ToString(Convert.ToDouble(wartosci_faktury[1, j].Value) * Convert.ToDouble(wartosci_faktury[4, j].Value));
       }
       sumawartoscibrutto += Convert.ToDouble(wartosci_faktury[6, j].Value);
      }
      suma_brutto.Text = Convert.ToString(sumawartoscibrutto);
      break;
     }
   }
  }
 }
}

struct dane_faktury
/* struktura, która przechowuje dane z całego programu. Dostęp poprzez właściwości, w przyszłośći można wprowadzić ochronę
 danych przed wpisywaniem wbłednie wprowadzony. Jak litery w polach numerycznych. */
{
 private string _dzienwystawienia;
 private string _Data_wpłaty1;
 private string _zamowienie_dane;
 private string _metoda_platnosci1;
 private string _suma_brutto;

 public string dzienwystawienia { get { return _dzienwystawienia; } set { _dzienwystawienia = value; } }
 public string zamowienie_dane { get { return _zamowienie_dane; } set { _zamowienie_dane = value; } }
 public string Data_wpłaty1 { get { return _Data_wpłaty1; } set { _Data_wpłaty1 = value; } }
 public string metoda_platnosci1 { get { return _metoda_platnosci1; } set { _metoda_platnosci1 = value; } }
 public string suma_brutto { get { return _suma_brutto; } set { _suma_brutto = value; } }
 public daneoklincie nabywca;
 public daneoklincie sprzedawca;
 public wartosc_faktury[] daneowartoscifaktury;
 public int iloscwartosci_faktur;
}

struct daneoklincie
/*Zakładam, że program będzie korzystany w większości przez firmy, ukłon w stronę osoby fizycznej zrobiłem 
 * poprzez dodanie PESELU
 Struktura w zamierzeniu ma przechowywać dane o kliencie*/
{
 private string _nazwa_firmy;
 private string _adres_firmy;
 private string _kod_pocztowy_1;
 private string _kod_pocztowy_2;
 private string _nip;
 private string _nazwa_banku;
 private string _numer_bankowy;
 private string _pesel;

 public string nazwa_firmy { get { return _nazwa_firmy; } set { _nazwa_firmy = value; } }
 public string adres_firmy { get { return _adres_firmy; } set { _adres_firmy = value; } }
 public string kod_pocztowy_1 { get { return _kod_pocztowy_1; } set { _kod_pocztowy_1 = value; } }
 public string kod_pocztowy_2 { get { return _kod_pocztowy_2; } set { _kod_pocztowy_2 = value; } }
 public string nip { get { return _nip; } set { _nip = value; } }
 public string nazwa_banku { get { return _nazwa_banku; } set { _nazwa_banku = value; } }
 public string numer_bankowy { get { return _numer_bankowy; } set { _numer_bankowy = value; } }
 public string pesel { get { return _pesel; } set { _pesel = value; } }
}

struct wartosc_faktury
/* Ta struktura za to przechowuja najmniejsze składniki każdej faktury, czyli usługi/produkty zakupione. Dostęp poprzez 
 * właściwości, w przyszłośći można wprowadzić ochronę danych przed wpisywaniem wbłednie wprowadzony. Jak litery w polach
 * numerycznych. */
{
 private string _nazwa;
 private string _ilosc;
 private string _cennanettozasztuke;
 private string _stawka;
 private string _cennabrutto;
 private string _wartoscnetto;
 private string _wartoscbrutto;

 public string nazwa { get { return _nazwa; } set { _nazwa = value; } }
 public string ilosc { get { return _ilosc; } set { _ilosc = value; } }
 public string cennanettozasztuke { get { return _cennanettozasztuke; } set { _cennanettozasztuke = value; } }
 public string stawka { get { return _stawka; } set { _stawka = value; } }
 public string cennabrutto { get { return _cennabrutto; } set { _cennabrutto = value; } }
 public string wartoscnetto { get { return _wartoscnetto; } set { _wartoscnetto = value; } }
 public string wartoscbrutto { get { return _wartoscbrutto; } set { _wartoscbrutto = value; } }
}

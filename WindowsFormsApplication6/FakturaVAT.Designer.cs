namespace WindowsFormsApplication6
{
    partial class Glowne_okno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
   this.Data_wystawienia = new System.Windows.Forms.Label();
   this.dzienwystawienia = new System.Windows.Forms.DateTimePicker();
   this.zamowienie_dane = new System.Windows.Forms.TextBox();
   this.Zamówienie = new System.Windows.Forms.Label();
   this.Wyjście = new System.Windows.Forms.Button();
   this.Data_wpłaty = new System.Windows.Forms.Label();
   this.Data_wpłaty1 = new System.Windows.Forms.DateTimePicker();
   this.metoda_platnosci = new System.Windows.Forms.Label();
   this.metoda_platnosci1 = new System.Windows.Forms.TextBox();
   this.podstawowe_dane = new System.Windows.Forms.GroupBox();
   this.kod_pocztowy2_kupujacego = new System.Windows.Forms.TextBox();
   this.kod_pocztowy1_kupujacego = new System.Windows.Forms.TextBox();
   this.adres_firmy_kupujacego = new System.Windows.Forms.TextBox();
   this.nazwa_firmy_kupujacego = new System.Windows.Forms.TextBox();
   this.nazwa_firmy = new System.Windows.Forms.Label();
   this.adres_firmy = new System.Windows.Forms.Label();
   this.kod_pocztowy = new System.Windows.Forms.Label();
   this.nip = new System.Windows.Forms.Label();
   this.nip_kupujacego = new System.Windows.Forms.TextBox();
   this.znak = new System.Windows.Forms.Label();
   this.nazwa_banku_kupujacego = new System.Windows.Forms.TextBox();
   this.numer_bankowy_kupujacego = new System.Windows.Forms.TextBox();
   this.nazwa_banku = new System.Windows.Forms.Label();
   this.numer_bankowy = new System.Windows.Forms.Label();
   this.dane_o_nabywcy = new System.Windows.Forms.GroupBox();
   this.labelPESELnabywcy = new System.Windows.Forms.Label();
   this.PESELnabywcy = new System.Windows.Forms.TextBox();
   this.dane_o_sprzedawcy = new System.Windows.Forms.GroupBox();
   this.labelPESELsprzedawcy = new System.Windows.Forms.Label();
   this.PESELsprzedawcy = new System.Windows.Forms.TextBox();
   this.nazwa_firmy_label = new System.Windows.Forms.Label();
   this.numer_bankowy_sprzedajacego = new System.Windows.Forms.TextBox();
   this.numer_bankowy_label = new System.Windows.Forms.Label();
   this.nazwa_banku_sprzedajacego = new System.Windows.Forms.TextBox();
   this.nazwa_firmy_sprzedajacego = new System.Windows.Forms.TextBox();
   this.nip_sprzedajacego = new System.Windows.Forms.TextBox();
   this.label4 = new System.Windows.Forms.Label();
   this.nazwa_banku_label = new System.Windows.Forms.Label();
   this.adres_firmy_label = new System.Windows.Forms.Label();
   this.kod_pocztowy2_sprzedajacego = new System.Windows.Forms.TextBox();
   this.kod_pocztowy1_sprzedajacego = new System.Windows.Forms.TextBox();
   this.adres_firmy_sprzedajacego = new System.Windows.Forms.TextBox();
   this.kod_pocztowy_label = new System.Windows.Forms.Label();
   this.nip_label = new System.Windows.Forms.Label();
   this.tekst = new System.Windows.Forms.Label();
   this.wartosci_faktury = new System.Windows.Forms.DataGridView();
   this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.cennanettozasztuke = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.stawka = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.cennabrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.wartoscnetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.wartoscbrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.podsumowanie_zamowienia = new System.Windows.Forms.Label();
   this.razem = new System.Windows.Forms.Label();
   this.suma_brutto = new System.Windows.Forms.TextBox();
   this.podsumowanie_faktury = new System.Windows.Forms.GroupBox();
   this.grupujacy_zamowienie = new System.Windows.Forms.GroupBox();
   this.generowanie_pliku_html = new System.Windows.Forms.Button();
   this.zapisanie_danych_o_sprzedajacym = new System.Windows.Forms.Button();
   this.wczytanie_z_pliku_nabywcy = new System.Windows.Forms.Button();
   this.zapisanie_danych_o_nabywcy = new System.Windows.Forms.Button();
   this.wczytanie_z_pliku_sprzedajacym = new System.Windows.Forms.Button();
   this.zapisywanie_danych = new System.Windows.Forms.GroupBox();
   this.podstawowe_dane.SuspendLayout();
   this.dane_o_nabywcy.SuspendLayout();
   this.dane_o_sprzedawcy.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.wartosci_faktury)).BeginInit();
   this.podsumowanie_faktury.SuspendLayout();
   this.grupujacy_zamowienie.SuspendLayout();
   this.zapisywanie_danych.SuspendLayout();
   this.SuspendLayout();
   // 
   // Data_wystawienia
   // 
   this.Data_wystawienia.AutoSize = true;
   this.Data_wystawienia.Location = new System.Drawing.Point(6, 22);
   this.Data_wystawienia.Name = "Data_wystawienia";
   this.Data_wystawienia.Size = new System.Drawing.Size(90, 13);
   this.Data_wystawienia.TabIndex = 2;
   this.Data_wystawienia.Text = "Data wystawienia";
   // 
   // dzienwystawienia
   // 
   this.dzienwystawienia.Location = new System.Drawing.Point(102, 16);
   this.dzienwystawienia.Name = "dzienwystawienia";
   this.dzienwystawienia.Size = new System.Drawing.Size(152, 20);
   this.dzienwystawienia.TabIndex = 4;
   // 
   // zamowienie_dane
   // 
   this.zamowienie_dane.Location = new System.Drawing.Point(336, 45);
   this.zamowienie_dane.Name = "zamowienie_dane";
   this.zamowienie_dane.Size = new System.Drawing.Size(152, 20);
   this.zamowienie_dane.TabIndex = 5;
   // 
   // Zamówienie
   // 
   this.Zamówienie.AutoSize = true;
   this.Zamówienie.Location = new System.Drawing.Point(266, 48);
   this.Zamówienie.Name = "Zamówienie";
   this.Zamówienie.Size = new System.Drawing.Size(64, 13);
   this.Zamówienie.TabIndex = 6;
   this.Zamówienie.Text = "Zamówienie";
   // 
   // Wyjście
   // 
   this.Wyjście.Location = new System.Drawing.Point(757, 634);
   this.Wyjście.Name = "Wyjście";
   this.Wyjście.Size = new System.Drawing.Size(75, 23);
   this.Wyjście.TabIndex = 7;
   this.Wyjście.Text = "Wyjście";
   this.Wyjście.UseVisualStyleBackColor = true;
   this.Wyjście.Click += new System.EventHandler(this.Wyjście_Click);
   // 
   // Data_wpłaty
   // 
   this.Data_wpłaty.AutoSize = true;
   this.Data_wpłaty.Location = new System.Drawing.Point(265, 22);
   this.Data_wpłaty.Name = "Data_wpłaty";
   this.Data_wpłaty.Size = new System.Drawing.Size(65, 13);
   this.Data_wpłaty.TabIndex = 8;
   this.Data_wpłaty.Text = "Data wpłaty";
   // 
   // Data_wpłaty1
   // 
   this.Data_wpłaty1.Location = new System.Drawing.Point(336, 16);
   this.Data_wpłaty1.Name = "Data_wpłaty1";
   this.Data_wpłaty1.Size = new System.Drawing.Size(152, 20);
   this.Data_wpłaty1.TabIndex = 9;
   // 
   // metoda_platnosci
   // 
   this.metoda_platnosci.AutoSize = true;
   this.metoda_platnosci.Location = new System.Drawing.Point(6, 48);
   this.metoda_platnosci.Name = "metoda_platnosci";
   this.metoda_platnosci.Size = new System.Drawing.Size(93, 13);
   this.metoda_platnosci.TabIndex = 10;
   this.metoda_platnosci.Text = "Metoda płatności:";
   // 
   // metoda_platnosci1
   // 
   this.metoda_platnosci1.Location = new System.Drawing.Point(102, 45);
   this.metoda_platnosci1.Name = "metoda_platnosci1";
   this.metoda_platnosci1.Size = new System.Drawing.Size(152, 20);
   this.metoda_platnosci1.TabIndex = 11;
   // 
   // podstawowe_dane
   // 
   this.podstawowe_dane.Controls.Add(this.Data_wystawienia);
   this.podstawowe_dane.Controls.Add(this.metoda_platnosci1);
   this.podstawowe_dane.Controls.Add(this.zamowienie_dane);
   this.podstawowe_dane.Controls.Add(this.Zamówienie);
   this.podstawowe_dane.Controls.Add(this.dzienwystawienia);
   this.podstawowe_dane.Controls.Add(this.metoda_platnosci);
   this.podstawowe_dane.Controls.Add(this.Data_wpłaty1);
   this.podstawowe_dane.Controls.Add(this.Data_wpłaty);
   this.podstawowe_dane.Location = new System.Drawing.Point(159, 3);
   this.podstawowe_dane.Name = "podstawowe_dane";
   this.podstawowe_dane.Size = new System.Drawing.Size(517, 80);
   this.podstawowe_dane.TabIndex = 12;
   this.podstawowe_dane.TabStop = false;
   this.podstawowe_dane.Text = "Podstawowe dane faktury VAT";
   // 
   // kod_pocztowy2_kupujacego
   // 
   this.kod_pocztowy2_kupujacego.Location = new System.Drawing.Point(218, 73);
   this.kod_pocztowy2_kupujacego.Name = "kod_pocztowy2_kupujacego";
   this.kod_pocztowy2_kupujacego.Size = new System.Drawing.Size(139, 20);
   this.kod_pocztowy2_kupujacego.TabIndex = 14;
   // 
   // kod_pocztowy1_kupujacego
   // 
   this.kod_pocztowy1_kupujacego.Location = new System.Drawing.Point(116, 73);
   this.kod_pocztowy1_kupujacego.Name = "kod_pocztowy1_kupujacego";
   this.kod_pocztowy1_kupujacego.Size = new System.Drawing.Size(80, 20);
   this.kod_pocztowy1_kupujacego.TabIndex = 15;
   // 
   // adres_firmy_kupujacego
   // 
   this.adres_firmy_kupujacego.Location = new System.Drawing.Point(116, 39);
   this.adres_firmy_kupujacego.Name = "adres_firmy_kupujacego";
   this.adres_firmy_kupujacego.Size = new System.Drawing.Size(241, 20);
   this.adres_firmy_kupujacego.TabIndex = 16;
   // 
   // nazwa_firmy_kupujacego
   // 
   this.nazwa_firmy_kupujacego.Location = new System.Drawing.Point(116, 13);
   this.nazwa_firmy_kupujacego.Name = "nazwa_firmy_kupujacego";
   this.nazwa_firmy_kupujacego.Size = new System.Drawing.Size(241, 20);
   this.nazwa_firmy_kupujacego.TabIndex = 17;
   // 
   // nazwa_firmy
   // 
   this.nazwa_firmy.AutoSize = true;
   this.nazwa_firmy.Location = new System.Drawing.Point(6, 16);
   this.nazwa_firmy.Name = "nazwa_firmy";
   this.nazwa_firmy.Size = new System.Drawing.Size(64, 13);
   this.nazwa_firmy.TabIndex = 18;
   this.nazwa_firmy.Text = "Nazwa firmy";
   // 
   // adres_firmy
   // 
   this.adres_firmy.AutoSize = true;
   this.adres_firmy.Location = new System.Drawing.Point(6, 46);
   this.adres_firmy.Name = "adres_firmy";
   this.adres_firmy.Size = new System.Drawing.Size(58, 13);
   this.adres_firmy.TabIndex = 19;
   this.adres_firmy.Text = "Adres firmy";
   // 
   // kod_pocztowy
   // 
   this.kod_pocztowy.AutoSize = true;
   this.kod_pocztowy.Location = new System.Drawing.Point(6, 80);
   this.kod_pocztowy.Name = "kod_pocztowy";
   this.kod_pocztowy.Size = new System.Drawing.Size(74, 13);
   this.kod_pocztowy.TabIndex = 20;
   this.kod_pocztowy.Text = "Kod pocztowy";
   // 
   // nip
   // 
   this.nip.AutoSize = true;
   this.nip.Location = new System.Drawing.Point(6, 106);
   this.nip.Name = "nip";
   this.nip.Size = new System.Drawing.Size(25, 13);
   this.nip.TabIndex = 21;
   this.nip.Text = "NIP";
   // 
   // nip_kupujacego
   // 
   this.nip_kupujacego.Location = new System.Drawing.Point(116, 99);
   this.nip_kupujacego.Name = "nip_kupujacego";
   this.nip_kupujacego.Size = new System.Drawing.Size(241, 20);
   this.nip_kupujacego.TabIndex = 23;
   // 
   // znak
   // 
   this.znak.AutoSize = true;
   this.znak.Location = new System.Drawing.Point(202, 80);
   this.znak.Name = "znak";
   this.znak.Size = new System.Drawing.Size(10, 13);
   this.znak.TabIndex = 24;
   this.znak.Text = "-";
   this.znak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // nazwa_banku_kupujacego
   // 
   this.nazwa_banku_kupujacego.Location = new System.Drawing.Point(116, 125);
   this.nazwa_banku_kupujacego.Name = "nazwa_banku_kupujacego";
   this.nazwa_banku_kupujacego.Size = new System.Drawing.Size(241, 20);
   this.nazwa_banku_kupujacego.TabIndex = 25;
   // 
   // numer_bankowy_kupujacego
   // 
   this.numer_bankowy_kupujacego.Location = new System.Drawing.Point(116, 151);
   this.numer_bankowy_kupujacego.Name = "numer_bankowy_kupujacego";
   this.numer_bankowy_kupujacego.Size = new System.Drawing.Size(241, 20);
   this.numer_bankowy_kupujacego.TabIndex = 26;
   // 
   // nazwa_banku
   // 
   this.nazwa_banku.AutoSize = true;
   this.nazwa_banku.Location = new System.Drawing.Point(6, 132);
   this.nazwa_banku.Name = "nazwa_banku";
   this.nazwa_banku.Size = new System.Drawing.Size(73, 13);
   this.nazwa_banku.TabIndex = 27;
   this.nazwa_banku.Text = "Nazwa banku";
   // 
   // numer_bankowy
   // 
   this.numer_bankowy.AutoSize = true;
   this.numer_bankowy.Location = new System.Drawing.Point(6, 154);
   this.numer_bankowy.Name = "numer_bankowy";
   this.numer_bankowy.Size = new System.Drawing.Size(84, 13);
   this.numer_bankowy.TabIndex = 28;
   this.numer_bankowy.Text = "Numer bankowy";
   // 
   // dane_o_nabywcy
   // 
   this.dane_o_nabywcy.Controls.Add(this.labelPESELnabywcy);
   this.dane_o_nabywcy.Controls.Add(this.PESELnabywcy);
   this.dane_o_nabywcy.Controls.Add(this.nazwa_firmy);
   this.dane_o_nabywcy.Controls.Add(this.numer_bankowy_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.numer_bankowy);
   this.dane_o_nabywcy.Controls.Add(this.nazwa_banku_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.nazwa_firmy_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.nip_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.znak);
   this.dane_o_nabywcy.Controls.Add(this.nazwa_banku);
   this.dane_o_nabywcy.Controls.Add(this.adres_firmy);
   this.dane_o_nabywcy.Controls.Add(this.kod_pocztowy2_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.kod_pocztowy1_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.adres_firmy_kupujacego);
   this.dane_o_nabywcy.Controls.Add(this.kod_pocztowy);
   this.dane_o_nabywcy.Controls.Add(this.nip);
   this.dane_o_nabywcy.Location = new System.Drawing.Point(464, 89);
   this.dane_o_nabywcy.Name = "dane_o_nabywcy";
   this.dane_o_nabywcy.Size = new System.Drawing.Size(368, 208);
   this.dane_o_nabywcy.TabIndex = 12;
   this.dane_o_nabywcy.TabStop = false;
   this.dane_o_nabywcy.Text = "Nabywca";
   // 
   // labelPESELnabywcy
   // 
   this.labelPESELnabywcy.AutoSize = true;
   this.labelPESELnabywcy.Location = new System.Drawing.Point(6, 181);
   this.labelPESELnabywcy.Name = "labelPESELnabywcy";
   this.labelPESELnabywcy.Size = new System.Drawing.Size(41, 13);
   this.labelPESELnabywcy.TabIndex = 31;
   this.labelPESELnabywcy.Text = "PESEL";
   // 
   // PESELnabywcy
   // 
   this.PESELnabywcy.Location = new System.Drawing.Point(116, 178);
   this.PESELnabywcy.Name = "PESELnabywcy";
   this.PESELnabywcy.Size = new System.Drawing.Size(241, 20);
   this.PESELnabywcy.TabIndex = 29;
   // 
   // dane_o_sprzedawcy
   // 
   this.dane_o_sprzedawcy.Controls.Add(this.labelPESELsprzedawcy);
   this.dane_o_sprzedawcy.Controls.Add(this.PESELsprzedawcy);
   this.dane_o_sprzedawcy.Controls.Add(this.nazwa_firmy_label);
   this.dane_o_sprzedawcy.Controls.Add(this.numer_bankowy_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.numer_bankowy_label);
   this.dane_o_sprzedawcy.Controls.Add(this.nazwa_banku_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.nazwa_firmy_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.nip_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.label4);
   this.dane_o_sprzedawcy.Controls.Add(this.nazwa_banku_label);
   this.dane_o_sprzedawcy.Controls.Add(this.adres_firmy_label);
   this.dane_o_sprzedawcy.Controls.Add(this.kod_pocztowy2_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.kod_pocztowy1_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.adres_firmy_sprzedajacego);
   this.dane_o_sprzedawcy.Controls.Add(this.kod_pocztowy_label);
   this.dane_o_sprzedawcy.Controls.Add(this.nip_label);
   this.dane_o_sprzedawcy.Location = new System.Drawing.Point(16, 89);
   this.dane_o_sprzedawcy.Name = "dane_o_sprzedawcy";
   this.dane_o_sprzedawcy.Size = new System.Drawing.Size(368, 208);
   this.dane_o_sprzedawcy.TabIndex = 13;
   this.dane_o_sprzedawcy.TabStop = false;
   this.dane_o_sprzedawcy.Text = "Sprzedawca";
   // 
   // labelPESELsprzedawcy
   // 
   this.labelPESELsprzedawcy.AutoSize = true;
   this.labelPESELsprzedawcy.Location = new System.Drawing.Point(6, 181);
   this.labelPESELsprzedawcy.Name = "labelPESELsprzedawcy";
   this.labelPESELsprzedawcy.Size = new System.Drawing.Size(41, 13);
   this.labelPESELsprzedawcy.TabIndex = 30;
   this.labelPESELsprzedawcy.Text = "PESEL";
   // 
   // PESELsprzedawcy
   // 
   this.PESELsprzedawcy.Location = new System.Drawing.Point(116, 178);
   this.PESELsprzedawcy.Name = "PESELsprzedawcy";
   this.PESELsprzedawcy.Size = new System.Drawing.Size(241, 20);
   this.PESELsprzedawcy.TabIndex = 29;
   // 
   // nazwa_firmy_label
   // 
   this.nazwa_firmy_label.AutoSize = true;
   this.nazwa_firmy_label.Location = new System.Drawing.Point(6, 16);
   this.nazwa_firmy_label.Name = "nazwa_firmy_label";
   this.nazwa_firmy_label.Size = new System.Drawing.Size(64, 13);
   this.nazwa_firmy_label.TabIndex = 18;
   this.nazwa_firmy_label.Text = "Nazwa firmy";
   // 
   // numer_bankowy_sprzedajacego
   // 
   this.numer_bankowy_sprzedajacego.Location = new System.Drawing.Point(116, 151);
   this.numer_bankowy_sprzedajacego.Name = "numer_bankowy_sprzedajacego";
   this.numer_bankowy_sprzedajacego.Size = new System.Drawing.Size(241, 20);
   this.numer_bankowy_sprzedajacego.TabIndex = 26;
   // 
   // numer_bankowy_label
   // 
   this.numer_bankowy_label.AutoSize = true;
   this.numer_bankowy_label.Location = new System.Drawing.Point(6, 154);
   this.numer_bankowy_label.Name = "numer_bankowy_label";
   this.numer_bankowy_label.Size = new System.Drawing.Size(84, 13);
   this.numer_bankowy_label.TabIndex = 28;
   this.numer_bankowy_label.Text = "Numer bankowy";
   // 
   // nazwa_banku_sprzedajacego
   // 
   this.nazwa_banku_sprzedajacego.Location = new System.Drawing.Point(116, 125);
   this.nazwa_banku_sprzedajacego.Name = "nazwa_banku_sprzedajacego";
   this.nazwa_banku_sprzedajacego.Size = new System.Drawing.Size(241, 20);
   this.nazwa_banku_sprzedajacego.TabIndex = 25;
   // 
   // nazwa_firmy_sprzedajacego
   // 
   this.nazwa_firmy_sprzedajacego.Location = new System.Drawing.Point(116, 13);
   this.nazwa_firmy_sprzedajacego.Name = "nazwa_firmy_sprzedajacego";
   this.nazwa_firmy_sprzedajacego.Size = new System.Drawing.Size(241, 20);
   this.nazwa_firmy_sprzedajacego.TabIndex = 17;
   // 
   // nip_sprzedajacego
   // 
   this.nip_sprzedajacego.Location = new System.Drawing.Point(116, 99);
   this.nip_sprzedajacego.Name = "nip_sprzedajacego";
   this.nip_sprzedajacego.Size = new System.Drawing.Size(241, 20);
   this.nip_sprzedajacego.TabIndex = 23;
   // 
   // label4
   // 
   this.label4.AutoSize = true;
   this.label4.Location = new System.Drawing.Point(202, 80);
   this.label4.Name = "label4";
   this.label4.Size = new System.Drawing.Size(10, 13);
   this.label4.TabIndex = 24;
   this.label4.Text = "-";
   this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   // 
   // nazwa_banku_label
   // 
   this.nazwa_banku_label.AutoSize = true;
   this.nazwa_banku_label.Location = new System.Drawing.Point(6, 132);
   this.nazwa_banku_label.Name = "nazwa_banku_label";
   this.nazwa_banku_label.Size = new System.Drawing.Size(73, 13);
   this.nazwa_banku_label.TabIndex = 27;
   this.nazwa_banku_label.Text = "Nazwa banku";
   // 
   // adres_firmy_label
   // 
   this.adres_firmy_label.AutoSize = true;
   this.adres_firmy_label.Location = new System.Drawing.Point(6, 46);
   this.adres_firmy_label.Name = "adres_firmy_label";
   this.adres_firmy_label.Size = new System.Drawing.Size(58, 13);
   this.adres_firmy_label.TabIndex = 19;
   this.adres_firmy_label.Text = "Adres firmy";
   // 
   // kod_pocztowy2_sprzedajacego
   // 
   this.kod_pocztowy2_sprzedajacego.Location = new System.Drawing.Point(218, 73);
   this.kod_pocztowy2_sprzedajacego.Name = "kod_pocztowy2_sprzedajacego";
   this.kod_pocztowy2_sprzedajacego.Size = new System.Drawing.Size(139, 20);
   this.kod_pocztowy2_sprzedajacego.TabIndex = 14;
   // 
   // kod_pocztowy1_sprzedajacego
   // 
   this.kod_pocztowy1_sprzedajacego.Location = new System.Drawing.Point(116, 73);
   this.kod_pocztowy1_sprzedajacego.Name = "kod_pocztowy1_sprzedajacego";
   this.kod_pocztowy1_sprzedajacego.Size = new System.Drawing.Size(80, 20);
   this.kod_pocztowy1_sprzedajacego.TabIndex = 15;
   // 
   // adres_firmy_sprzedajacego
   // 
   this.adres_firmy_sprzedajacego.Location = new System.Drawing.Point(116, 39);
   this.adres_firmy_sprzedajacego.Name = "adres_firmy_sprzedajacego";
   this.adres_firmy_sprzedajacego.Size = new System.Drawing.Size(241, 20);
   this.adres_firmy_sprzedajacego.TabIndex = 16;
   // 
   // kod_pocztowy_label
   // 
   this.kod_pocztowy_label.AutoSize = true;
   this.kod_pocztowy_label.Location = new System.Drawing.Point(6, 80);
   this.kod_pocztowy_label.Name = "kod_pocztowy_label";
   this.kod_pocztowy_label.Size = new System.Drawing.Size(74, 13);
   this.kod_pocztowy_label.TabIndex = 20;
   this.kod_pocztowy_label.Text = "Kod pocztowy";
   // 
   // nip_label
   // 
   this.nip_label.AutoSize = true;
   this.nip_label.Location = new System.Drawing.Point(6, 106);
   this.nip_label.Name = "nip_label";
   this.nip_label.Size = new System.Drawing.Size(25, 13);
   this.nip_label.TabIndex = 21;
   this.nip_label.Text = "NIP";
   // 
   // tekst
   // 
   this.tekst.AutoSize = true;
   this.tekst.Location = new System.Drawing.Point(375, 16);
   this.tekst.Name = "tekst";
   this.tekst.Size = new System.Drawing.Size(64, 13);
   this.tekst.TabIndex = 15;
   this.tekst.Text = "Zamówienie";
   // 
   // wartosci_faktury
   // 
   this.wartosci_faktury.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.wartosci_faktury.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwa,
            this.ilosc,
            this.cennanettozasztuke,
            this.stawka,
            this.cennabrutto,
            this.wartoscnetto,
            this.wartoscbrutto});
   this.wartosci_faktury.Location = new System.Drawing.Point(17, 32);
   this.wartosci_faktury.Name = "wartosci_faktury";
   this.wartosci_faktury.Size = new System.Drawing.Size(745, 212);
   this.wartosci_faktury.TabIndex = 16;
   this.wartosci_faktury.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.wartosci_faktury_CellValueChanged);
   // 
   // nazwa
   // 
   this.nazwa.HeaderText = "Nazwa";
   this.nazwa.Name = "nazwa";
   // 
   // ilosc
   // 
   this.ilosc.HeaderText = "Ilość";
   this.ilosc.Name = "ilosc";
   // 
   // cennanettozasztuke
   // 
   this.cennanettozasztuke.HeaderText = "Cenna netto za sztukę";
   this.cennanettozasztuke.Name = "cennanettozasztuke";
   // 
   // stawka
   // 
   this.stawka.HeaderText = "Stawka          (w formacie XXX) ";
   this.stawka.Name = "stawka";
   // 
   // cennabrutto
   // 
   this.cennabrutto.HeaderText = "Cenna brutto";
   this.cennabrutto.Name = "cennabrutto";
   this.cennabrutto.ReadOnly = true;
   // 
   // wartoscnetto
   // 
   this.wartoscnetto.HeaderText = "Wartość netto";
   this.wartoscnetto.Name = "wartoscnetto";
   this.wartoscnetto.ReadOnly = true;
   // 
   // wartoscbrutto
   // 
   this.wartoscbrutto.HeaderText = "Wartość brutto";
   this.wartoscbrutto.Name = "wartoscbrutto";
   this.wartoscbrutto.ReadOnly = true;
   // 
   // podsumowanie_zamowienia
   // 
   this.podsumowanie_zamowienia.AutoSize = true;
   this.podsumowanie_zamowienia.Location = new System.Drawing.Point(16, 16);
   this.podsumowanie_zamowienia.Name = "podsumowanie_zamowienia";
   this.podsumowanie_zamowienia.Size = new System.Drawing.Size(137, 13);
   this.podsumowanie_zamowienia.TabIndex = 17;
   this.podsumowanie_zamowienia.Text = "Podsumowanie zamówienia";
   // 
   // razem
   // 
   this.razem.AutoSize = true;
   this.razem.Location = new System.Drawing.Point(16, 49);
   this.razem.Name = "razem";
   this.razem.Size = new System.Drawing.Size(40, 13);
   this.razem.TabIndex = 18;
   this.razem.Text = "Razem";
   // 
   // suma_brutto
   // 
   this.suma_brutto.Location = new System.Drawing.Point(62, 46);
   this.suma_brutto.Name = "suma_brutto";
   this.suma_brutto.ReadOnly = true;
   this.suma_brutto.Size = new System.Drawing.Size(143, 20);
   this.suma_brutto.TabIndex = 19;
   // 
   // podsumowanie_faktury
   // 
   this.podsumowanie_faktury.Controls.Add(this.podsumowanie_zamowienia);
   this.podsumowanie_faktury.Controls.Add(this.razem);
   this.podsumowanie_faktury.Controls.Add(this.suma_brutto);
   this.podsumowanie_faktury.Location = new System.Drawing.Point(620, 543);
   this.podsumowanie_faktury.Name = "podsumowanie_faktury";
   this.podsumowanie_faktury.Size = new System.Drawing.Size(212, 81);
   this.podsumowanie_faktury.TabIndex = 20;
   this.podsumowanie_faktury.TabStop = false;
   // 
   // grupujacy_zamowienie
   // 
   this.grupujacy_zamowienie.Controls.Add(this.tekst);
   this.grupujacy_zamowienie.Controls.Add(this.wartosci_faktury);
   this.grupujacy_zamowienie.Location = new System.Drawing.Point(12, 293);
   this.grupujacy_zamowienie.Name = "grupujacy_zamowienie";
   this.grupujacy_zamowienie.Size = new System.Drawing.Size(820, 250);
   this.grupujacy_zamowienie.TabIndex = 21;
   this.grupujacy_zamowienie.TabStop = false;
   // 
   // generowanie_pliku_html
   // 
   this.generowanie_pliku_html.Location = new System.Drawing.Point(17, 42);
   this.generowanie_pliku_html.Name = "generowanie_pliku_html";
   this.generowanie_pliku_html.Size = new System.Drawing.Size(150, 23);
   this.generowanie_pliku_html.TabIndex = 22;
   this.generowanie_pliku_html.Text = "Generowanie pliku HTML";
   this.generowanie_pliku_html.UseVisualStyleBackColor = true;
   this.generowanie_pliku_html.Click += new System.EventHandler(this.generowanie_pliku_html_Click);
   // 
   // zapisanie_danych_o_sprzedajacym
   // 
   this.zapisanie_danych_o_sprzedajacym.Location = new System.Drawing.Point(375, 15);
   this.zapisanie_danych_o_sprzedajacym.Name = "zapisanie_danych_o_sprzedajacym";
   this.zapisanie_danych_o_sprzedajacym.Size = new System.Drawing.Size(227, 23);
   this.zapisanie_danych_o_sprzedajacym.TabIndex = 23;
   this.zapisanie_danych_o_sprzedajacym.Text = "Zapisanie do pliku danych o sprzedajacym";
   this.zapisanie_danych_o_sprzedajacym.UseVisualStyleBackColor = true;
   this.zapisanie_danych_o_sprzedajacym.Click += new System.EventHandler(this.zapisanie_danych_o_sprzedajacym_Click);
   // 
   // wczytanie_z_pliku_nabywcy
   // 
   this.wczytanie_z_pliku_nabywcy.Location = new System.Drawing.Point(406, 42);
   this.wczytanie_z_pliku_nabywcy.Name = "wczytanie_z_pliku_nabywcy";
   this.wczytanie_z_pliku_nabywcy.Size = new System.Drawing.Size(196, 23);
   this.wczytanie_z_pliku_nabywcy.TabIndex = 24;
   this.wczytanie_z_pliku_nabywcy.Text = "Wczytanie z pliku danych o nabywcy";
   this.wczytanie_z_pliku_nabywcy.UseVisualStyleBackColor = true;
   this.wczytanie_z_pliku_nabywcy.Click += new System.EventHandler(this.wczytanie_z_pliku_nabywcy_Click);
   // 
   // zapisanie_danych_o_nabywcy
   // 
   this.zapisanie_danych_o_nabywcy.Location = new System.Drawing.Point(173, 15);
   this.zapisanie_danych_o_nabywcy.Name = "zapisanie_danych_o_nabywcy";
   this.zapisanie_danych_o_nabywcy.Size = new System.Drawing.Size(196, 23);
   this.zapisanie_danych_o_nabywcy.TabIndex = 25;
   this.zapisanie_danych_o_nabywcy.Text = "Zapisanie do pliku danych o nabywcy";
   this.zapisanie_danych_o_nabywcy.UseVisualStyleBackColor = true;
   this.zapisanie_danych_o_nabywcy.Click += new System.EventHandler(this.zapisanie_danych_o_nabywcy_Click);
   // 
   // wczytanie_z_pliku_sprzedajacym
   // 
   this.wczytanie_z_pliku_sprzedajacym.Location = new System.Drawing.Point(173, 42);
   this.wczytanie_z_pliku_sprzedajacym.Name = "wczytanie_z_pliku_sprzedajacym";
   this.wczytanie_z_pliku_sprzedajacym.Size = new System.Drawing.Size(227, 23);
   this.wczytanie_z_pliku_sprzedajacym.TabIndex = 26;
   this.wczytanie_z_pliku_sprzedajacym.Text = "Wczytanie z pliku danych o sprzedającym";
   this.wczytanie_z_pliku_sprzedajacym.UseVisualStyleBackColor = true;
   this.wczytanie_z_pliku_sprzedajacym.Click += new System.EventHandler(this.wczytanie_z_pliku_sprzedajacym_Click);
   // 
   // zapisywanie_danych
   // 
   this.zapisywanie_danych.Controls.Add(this.zapisanie_danych_o_sprzedajacym);
   this.zapisywanie_danych.Controls.Add(this.generowanie_pliku_html);
   this.zapisywanie_danych.Controls.Add(this.wczytanie_z_pliku_nabywcy);
   this.zapisywanie_danych.Controls.Add(this.zapisanie_danych_o_nabywcy);
   this.zapisywanie_danych.Controls.Add(this.wczytanie_z_pliku_sprzedajacym);
   this.zapisywanie_danych.Location = new System.Drawing.Point(12, 592);
   this.zapisywanie_danych.Name = "zapisywanie_danych";
   this.zapisywanie_danych.Size = new System.Drawing.Size(602, 65);
   this.zapisywanie_danych.TabIndex = 27;
   this.zapisywanie_danych.TabStop = false;
   // 
   // Glowne_okno
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
   this.AutoSize = true;
   this.ClientSize = new System.Drawing.Size(844, 664);
   this.Controls.Add(this.zapisywanie_danych);
   this.Controls.Add(this.grupujacy_zamowienie);
   this.Controls.Add(this.podsumowanie_faktury);
   this.Controls.Add(this.dane_o_sprzedawcy);
   this.Controls.Add(this.dane_o_nabywcy);
   this.Controls.Add(this.podstawowe_dane);
   this.Controls.Add(this.Wyjście);
   this.Name = "Glowne_okno";
   this.Text = "Faktura VAT";
   this.podstawowe_dane.ResumeLayout(false);
   this.podstawowe_dane.PerformLayout();
   this.dane_o_nabywcy.ResumeLayout(false);
   this.dane_o_nabywcy.PerformLayout();
   this.dane_o_sprzedawcy.ResumeLayout(false);
   this.dane_o_sprzedawcy.PerformLayout();
   ((System.ComponentModel.ISupportInitialize)(this.wartosci_faktury)).EndInit();
   this.podsumowanie_faktury.ResumeLayout(false);
   this.podsumowanie_faktury.PerformLayout();
   this.grupujacy_zamowienie.ResumeLayout(false);
   this.grupujacy_zamowienie.PerformLayout();
   this.zapisywanie_danych.ResumeLayout(false);
   this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Data_wystawienia;
        private System.Windows.Forms.DateTimePicker dzienwystawienia;
        private System.Windows.Forms.TextBox zamowienie_dane;
        private System.Windows.Forms.Label Zamówienie;
        private System.Windows.Forms.Button Wyjście;
        private System.Windows.Forms.Label Data_wpłaty;
        private System.Windows.Forms.DateTimePicker Data_wpłaty1;
        private System.Windows.Forms.Label metoda_platnosci;
        private System.Windows.Forms.TextBox metoda_platnosci1;
        private System.Windows.Forms.GroupBox podstawowe_dane;
        private System.Windows.Forms.TextBox kod_pocztowy2_kupujacego;
        private System.Windows.Forms.TextBox kod_pocztowy1_kupujacego;
        private System.Windows.Forms.TextBox adres_firmy_kupujacego;
        private System.Windows.Forms.TextBox nazwa_firmy_kupujacego;
        private System.Windows.Forms.Label nazwa_firmy;
        private System.Windows.Forms.Label adres_firmy;
        private System.Windows.Forms.Label kod_pocztowy;
        private System.Windows.Forms.Label nip;
        private System.Windows.Forms.TextBox nip_kupujacego;
        private System.Windows.Forms.Label znak;
        private System.Windows.Forms.TextBox nazwa_banku_kupujacego;
        private System.Windows.Forms.TextBox numer_bankowy_kupujacego;
        private System.Windows.Forms.Label nazwa_banku;
        private System.Windows.Forms.Label numer_bankowy;
        private System.Windows.Forms.GroupBox dane_o_nabywcy;
        private System.Windows.Forms.GroupBox dane_o_sprzedawcy;
        private System.Windows.Forms.Label nazwa_firmy_label;
        private System.Windows.Forms.TextBox numer_bankowy_sprzedajacego;
        private System.Windows.Forms.Label numer_bankowy_label;
        private System.Windows.Forms.TextBox nazwa_banku_sprzedajacego;
        private System.Windows.Forms.TextBox nazwa_firmy_sprzedajacego;
        private System.Windows.Forms.TextBox nip_sprzedajacego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nazwa_banku_label;
        private System.Windows.Forms.Label adres_firmy_label;
        private System.Windows.Forms.TextBox kod_pocztowy2_sprzedajacego;
        private System.Windows.Forms.TextBox kod_pocztowy1_sprzedajacego;
        private System.Windows.Forms.TextBox adres_firmy_sprzedajacego;
        private System.Windows.Forms.Label kod_pocztowy_label;
        private System.Windows.Forms.Label nip_label;
        private System.Windows.Forms.Label tekst;
        private System.Windows.Forms.DataGridView wartosci_faktury;
        private System.Windows.Forms.Label podsumowanie_zamowienia;
        private System.Windows.Forms.Label razem;
        private System.Windows.Forms.TextBox suma_brutto;
        private System.Windows.Forms.GroupBox podsumowanie_faktury;
        private System.Windows.Forms.GroupBox grupujacy_zamowienie;
        private System.Windows.Forms.Button generowanie_pliku_html;
        private System.Windows.Forms.Button zapisanie_danych_o_sprzedajacym;
        private System.Windows.Forms.Button wczytanie_z_pliku_nabywcy;
        private System.Windows.Forms.Button zapisanie_danych_o_nabywcy;
        private System.Windows.Forms.Button wczytanie_z_pliku_sprzedajacym;
        private System.Windows.Forms.GroupBox zapisywanie_danych;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cennanettozasztuke;
        private System.Windows.Forms.DataGridViewTextBoxColumn stawka;
        private System.Windows.Forms.DataGridViewTextBoxColumn cennabrutto;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscnetto;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscbrutto;
        private System.Windows.Forms.Label labelPESELnabywcy;
        private System.Windows.Forms.TextBox PESELnabywcy;
        private System.Windows.Forms.Label labelPESELsprzedawcy;
        private System.Windows.Forms.TextBox PESELsprzedawcy;
    }
}


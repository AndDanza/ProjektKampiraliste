namespace Kampiraliste
{
    partial class PrijavaGostaForma
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
            this.components = new System.ComponentModel.Container();
            this.odabirSmjestajaLabela = new System.Windows.Forms.Label();
            this.odabirSmjestajaUnos = new System.Windows.Forms.ComboBox();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.unosBrojDoc = new System.Windows.Forms.TextBox();
            this.unosDrzavaRod = new System.Windows.Forms.ComboBox();
            this.drzavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unosStatus = new System.Windows.Forms.ComboBox();
            this.statusosobeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unosDatumDolaska = new System.Windows.Forms.DateTimePicker();
            this.datumDolaskaLabela = new System.Windows.Forms.Label();
            this.unosDatumOdlaska = new System.Windows.Forms.DateTimePicker();
            this.datumOdlaskaLabela = new System.Windows.Forms.Label();
            this.unosAgencijski = new System.Windows.Forms.RadioButton();
            this.unosOsobno = new System.Windows.Forms.RadioButton();
            this.orgDolaskaLabela = new System.Windows.Forms.Label();
            this.podaciPrijava = new System.Windows.Forms.GroupBox();
            this.statusOsobe = new System.Windows.Forms.Label();
            this.pokreniUnosSmjestaj = new System.Windows.Forms.Button();
            this.potvrdiPrijavu = new System.Windows.Forms.Button();
            this.unosDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.datumRodjenja = new System.Windows.Forms.Label();
            this.drzavaStanovanja = new System.Windows.Forms.Label();
            this.unosDrzavaStan = new System.Windows.Forms.ComboBox();
            this.drzavaRodjenja = new System.Windows.Forms.Label();
            this.brojDocLabela = new System.Windows.Forms.Label();
            this.unosVrstaDoc = new System.Windows.Forms.ComboBox();
            this.vrstadokumentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vrstaDocLabela = new System.Windows.Forms.Label();
            this.unosSpolZenski = new System.Windows.Forms.RadioButton();
            this.unosSpolMuski = new System.Windows.Forms.RadioButton();
            this.spolLabela = new System.Windows.Forms.Label();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.prezimeLabela = new System.Windows.Forms.Label();
            this.imeLabela = new System.Windows.Forms.Label();
            this.podaciGost = new System.Windows.Forms.GroupBox();
            this.odustaniPrijavaGosta = new System.Windows.Forms.Button();
            this.smjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusosobeBindingSource)).BeginInit();
            this.podaciPrijava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstadokumentaBindingSource)).BeginInit();
            this.podaciGost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // odabirSmjestajaLabela
            // 
            this.odabirSmjestajaLabela.AutoSize = true;
            this.odabirSmjestajaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odabirSmjestajaLabela.Location = new System.Drawing.Point(42, 92);
            this.odabirSmjestajaLabela.Name = "odabirSmjestajaLabela";
            this.odabirSmjestajaLabela.Size = new System.Drawing.Size(123, 18);
            this.odabirSmjestajaLabela.TabIndex = 0;
            this.odabirSmjestajaLabela.Text = "Odabir smještaja:";
            // 
            // odabirSmjestajaUnos
            // 
            this.odabirSmjestajaUnos.DataSource = this.smjestajBindingSource;
            this.odabirSmjestajaUnos.DisplayMember = "id";
            this.odabirSmjestajaUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odabirSmjestajaUnos.FormattingEnabled = true;
            this.odabirSmjestajaUnos.Location = new System.Drawing.Point(179, 89);
            this.odabirSmjestajaUnos.Name = "odabirSmjestajaUnos";
            this.odabirSmjestajaUnos.Size = new System.Drawing.Size(200, 26);
            this.odabirSmjestajaUnos.TabIndex = 13;
            this.odabirSmjestajaUnos.ValueMember = "id";
            // 
            // unosPrezime
            // 
            this.unosPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosPrezime.Location = new System.Drawing.Point(593, 75);
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(251, 24);
            this.unosPrezime.TabIndex = 4;
            // 
            // unosBrojDoc
            // 
            this.unosBrojDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosBrojDoc.Location = new System.Drawing.Point(593, 120);
            this.unosBrojDoc.Name = "unosBrojDoc";
            this.unosBrojDoc.Size = new System.Drawing.Size(251, 24);
            this.unosBrojDoc.TabIndex = 6;
            // 
            // unosDrzavaRod
            // 
            this.unosDrzavaRod.DataSource = this.drzavaBindingSource;
            this.unosDrzavaRod.DisplayMember = "naziv";
            this.unosDrzavaRod.DropDownHeight = 250;
            this.unosDrzavaRod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDrzavaRod.FormattingEnabled = true;
            this.unosDrzavaRod.IntegralHeight = false;
            this.unosDrzavaRod.Location = new System.Drawing.Point(593, 165);
            this.unosDrzavaRod.Name = "unosDrzavaRod";
            this.unosDrzavaRod.Size = new System.Drawing.Size(251, 26);
            this.unosDrzavaRod.TabIndex = 8;
            this.unosDrzavaRod.ValueMember = "id";
            // 
            // drzavaBindingSource
            // 
            this.drzavaBindingSource.DataSource = typeof(Kampiraliste.drzava);
            // 
            // unosStatus
            // 
            this.unosStatus.DataSource = this.statusosobeBindingSource;
            this.unosStatus.DisplayMember = "naziv";
            this.unosStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosStatus.FormattingEnabled = true;
            this.unosStatus.Location = new System.Drawing.Point(593, 212);
            this.unosStatus.Name = "unosStatus";
            this.unosStatus.Size = new System.Drawing.Size(251, 26);
            this.unosStatus.TabIndex = 10;
            this.unosStatus.ValueMember = "id";
            // 
            // statusosobeBindingSource
            // 
            this.statusosobeBindingSource.DataSource = typeof(Kampiraliste.status_osobe);
            // 
            // unosDatumDolaska
            // 
            this.unosDatumDolaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDatumDolaska.Location = new System.Drawing.Point(593, 42);
            this.unosDatumDolaska.MaxDate = new System.DateTime(2090, 1, 1, 0, 0, 0, 0);
            this.unosDatumDolaska.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.unosDatumDolaska.Name = "unosDatumDolaska";
            this.unosDatumDolaska.Size = new System.Drawing.Size(166, 24);
            this.unosDatumDolaska.TabIndex = 11;
            // 
            // datumDolaskaLabela
            // 
            this.datumDolaskaLabela.AutoSize = true;
            this.datumDolaskaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumDolaskaLabela.Location = new System.Drawing.Point(468, 47);
            this.datumDolaskaLabela.Name = "datumDolaskaLabela";
            this.datumDolaskaLabela.Size = new System.Drawing.Size(112, 18);
            this.datumDolaskaLabela.TabIndex = 22;
            this.datumDolaskaLabela.Text = "Datum dolaska:";
            // 
            // unosDatumOdlaska
            // 
            this.unosDatumOdlaska.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDatumOdlaska.Location = new System.Drawing.Point(593, 87);
            this.unosDatumOdlaska.MaxDate = new System.DateTime(2090, 1, 1, 0, 0, 0, 0);
            this.unosDatumOdlaska.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.unosDatumOdlaska.Name = "unosDatumOdlaska";
            this.unosDatumOdlaska.Size = new System.Drawing.Size(164, 24);
            this.unosDatumOdlaska.TabIndex = 12;
            // 
            // datumOdlaskaLabela
            // 
            this.datumOdlaskaLabela.AutoSize = true;
            this.datumOdlaskaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumOdlaskaLabela.Location = new System.Drawing.Point(468, 92);
            this.datumOdlaskaLabela.Name = "datumOdlaskaLabela";
            this.datumOdlaskaLabela.Size = new System.Drawing.Size(112, 18);
            this.datumOdlaskaLabela.TabIndex = 24;
            this.datumOdlaskaLabela.Text = "Datum odlaska:";
            // 
            // unosAgencijski
            // 
            this.unosAgencijski.AutoSize = true;
            this.unosAgencijski.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosAgencijski.Location = new System.Drawing.Point(287, 46);
            this.unosAgencijski.Name = "unosAgencijski";
            this.unosAgencijski.Size = new System.Drawing.Size(92, 22);
            this.unosAgencijski.TabIndex = 15;
            this.unosAgencijski.TabStop = true;
            this.unosAgencijski.Text = "Agencijski";
            this.unosAgencijski.UseVisualStyleBackColor = true;
            // 
            // unosOsobno
            // 
            this.unosOsobno.AutoSize = true;
            this.unosOsobno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosOsobno.Location = new System.Drawing.Point(179, 46);
            this.unosOsobno.Name = "unosOsobno";
            this.unosOsobno.Size = new System.Drawing.Size(80, 22);
            this.unosOsobno.TabIndex = 14;
            this.unosOsobno.TabStop = true;
            this.unosOsobno.Text = "Osobno";
            this.unosOsobno.UseVisualStyleBackColor = true;
            // 
            // orgDolaskaLabela
            // 
            this.orgDolaskaLabela.AutoSize = true;
            this.orgDolaskaLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orgDolaskaLabela.Location = new System.Drawing.Point(15, 48);
            this.orgDolaskaLabela.Name = "orgDolaskaLabela";
            this.orgDolaskaLabela.Size = new System.Drawing.Size(150, 18);
            this.orgDolaskaLabela.TabIndex = 20;
            this.orgDolaskaLabela.Text = "Organizacija dolaska:";
            // 
            // podaciPrijava
            // 
            this.podaciPrijava.BackColor = System.Drawing.Color.Wheat;
            this.podaciPrijava.Controls.Add(this.pokreniUnosSmjestaj);
            this.podaciPrijava.Controls.Add(this.unosAgencijski);
            this.podaciPrijava.Controls.Add(this.unosDatumOdlaska);
            this.podaciPrijava.Controls.Add(this.unosOsobno);
            this.podaciPrijava.Controls.Add(this.datumOdlaskaLabela);
            this.podaciPrijava.Controls.Add(this.orgDolaskaLabela);
            this.podaciPrijava.Controls.Add(this.unosDatumDolaska);
            this.podaciPrijava.Controls.Add(this.datumDolaskaLabela);
            this.podaciPrijava.Controls.Add(this.odabirSmjestajaUnos);
            this.podaciPrijava.Controls.Add(this.odabirSmjestajaLabela);
            this.podaciPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podaciPrijava.Location = new System.Drawing.Point(48, 303);
            this.podaciPrijava.Name = "podaciPrijava";
            this.podaciPrijava.Size = new System.Drawing.Size(873, 142);
            this.podaciPrijava.TabIndex = 2;
            this.podaciPrijava.TabStop = false;
            this.podaciPrijava.Text = "Podaci o prijavi";
            // 
            // statusOsobe
            // 
            this.statusOsobe.AutoSize = true;
            this.statusOsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOsobe.Location = new System.Drawing.Point(487, 215);
            this.statusOsobe.Name = "statusOsobe";
            this.statusOsobe.Size = new System.Drawing.Size(100, 18);
            this.statusOsobe.TabIndex = 40;
            this.statusOsobe.Text = "Status osobe:";
            // 
            // pokreniUnosSmjestaj
            // 
            this.pokreniUnosSmjestaj.BackColor = System.Drawing.Color.Peru;
            this.pokreniUnosSmjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pokreniUnosSmjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokreniUnosSmjestaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pokreniUnosSmjestaj.Location = new System.Drawing.Point(385, 89);
            this.pokreniUnosSmjestaj.Name = "pokreniUnosSmjestaj";
            this.pokreniUnosSmjestaj.Size = new System.Drawing.Size(45, 26);
            this.pokreniUnosSmjestaj.TabIndex = 3;
            this.pokreniUnosSmjestaj.Text = "+";
            this.pokreniUnosSmjestaj.UseVisualStyleBackColor = false;
            this.pokreniUnosSmjestaj.Click += new System.EventHandler(this.pokreniUnosSmjestaj_Click);
            // 
            // potvrdiPrijavu
            // 
            this.potvrdiPrijavu.BackColor = System.Drawing.Color.Peru;
            this.potvrdiPrijavu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potvrdiPrijavu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.potvrdiPrijavu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.potvrdiPrijavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.potvrdiPrijavu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.potvrdiPrijavu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.potvrdiPrijavu.Location = new System.Drawing.Point(623, 468);
            this.potvrdiPrijavu.Name = "potvrdiPrijavu";
            this.potvrdiPrijavu.Size = new System.Drawing.Size(142, 38);
            this.potvrdiPrijavu.TabIndex = 16;
            this.potvrdiPrijavu.Text = "Potvrdi prijavu";
            this.potvrdiPrijavu.UseVisualStyleBackColor = false;
            // 
            // unosDatumRodenja
            // 
            this.unosDatumRodenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDatumRodenja.Location = new System.Drawing.Point(179, 210);
            this.unosDatumRodenja.MaxDate = new System.DateTime(2090, 1, 1, 0, 0, 0, 0);
            this.unosDatumRodenja.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.unosDatumRodenja.Name = "unosDatumRodenja";
            this.unosDatumRodenja.Size = new System.Drawing.Size(170, 24);
            this.unosDatumRodenja.TabIndex = 9;
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.AutoSize = true;
            this.datumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumRodjenja.Location = new System.Drawing.Point(64, 215);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(109, 18);
            this.datumRodjenja.TabIndex = 38;
            this.datumRodjenja.Text = "Datum rođenja:";
            // 
            // drzavaStanovanja
            // 
            this.drzavaStanovanja.AutoSize = true;
            this.drzavaStanovanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drzavaStanovanja.Location = new System.Drawing.Point(39, 168);
            this.drzavaStanovanja.Name = "drzavaStanovanja";
            this.drzavaStanovanja.Size = new System.Drawing.Size(134, 18);
            this.drzavaStanovanja.TabIndex = 37;
            this.drzavaStanovanja.Text = "Država stanovanja:";
            // 
            // unosDrzavaStan
            // 
            this.unosDrzavaStan.DataSource = this.drzavaBindingSource;
            this.unosDrzavaStan.DisplayMember = "naziv";
            this.unosDrzavaStan.DropDownHeight = 250;
            this.unosDrzavaStan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosDrzavaStan.FormattingEnabled = true;
            this.unosDrzavaStan.IntegralHeight = false;
            this.unosDrzavaStan.ItemHeight = 18;
            this.unosDrzavaStan.Location = new System.Drawing.Point(179, 165);
            this.unosDrzavaStan.MaxDropDownItems = 5;
            this.unosDrzavaStan.Name = "unosDrzavaStan";
            this.unosDrzavaStan.Size = new System.Drawing.Size(251, 26);
            this.unosDrzavaStan.TabIndex = 7;
            this.unosDrzavaStan.ValueMember = "id";
            // 
            // drzavaRodjenja
            // 
            this.drzavaRodjenja.AutoSize = true;
            this.drzavaRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drzavaRodjenja.Location = new System.Drawing.Point(475, 168);
            this.drzavaRodjenja.Name = "drzavaRodjenja";
            this.drzavaRodjenja.Size = new System.Drawing.Size(112, 18);
            this.drzavaRodjenja.TabIndex = 35;
            this.drzavaRodjenja.Text = "Država rođenja:";
            // 
            // brojDocLabela
            // 
            this.brojDocLabela.AutoSize = true;
            this.brojDocLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojDocLabela.Location = new System.Drawing.Point(474, 123);
            this.brojDocLabela.Name = "brojDocLabela";
            this.brojDocLabela.Size = new System.Drawing.Size(113, 18);
            this.brojDocLabela.TabIndex = 34;
            this.brojDocLabela.Text = "Broj dokumenta";
            // 
            // unosVrstaDoc
            // 
            this.unosVrstaDoc.DataSource = this.vrstadokumentaBindingSource;
            this.unosVrstaDoc.DisplayMember = "naziv";
            this.unosVrstaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosVrstaDoc.FormattingEnabled = true;
            this.unosVrstaDoc.Location = new System.Drawing.Point(179, 118);
            this.unosVrstaDoc.Name = "unosVrstaDoc";
            this.unosVrstaDoc.Size = new System.Drawing.Size(251, 26);
            this.unosVrstaDoc.TabIndex = 5;
            this.unosVrstaDoc.ValueMember = "id";
            // 
            // vrstadokumentaBindingSource
            // 
            this.vrstadokumentaBindingSource.DataSource = typeof(Kampiraliste.vrsta_dokumenta);
            // 
            // vrstaDocLabela
            // 
            this.vrstaDocLabela.AutoSize = true;
            this.vrstaDocLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vrstaDocLabela.Location = new System.Drawing.Point(49, 121);
            this.vrstaDocLabela.Name = "vrstaDocLabela";
            this.vrstaDocLabela.Size = new System.Drawing.Size(124, 18);
            this.vrstaDocLabela.TabIndex = 32;
            this.vrstaDocLabela.Text = "Vrsta dokumenta:";
            // 
            // unosSpolZenski
            // 
            this.unosSpolZenski.AutoSize = true;
            this.unosSpolZenski.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosSpolZenski.Location = new System.Drawing.Point(251, 36);
            this.unosSpolZenski.Name = "unosSpolZenski";
            this.unosSpolZenski.Size = new System.Drawing.Size(70, 22);
            this.unosSpolZenski.TabIndex = 2;
            this.unosSpolZenski.TabStop = true;
            this.unosSpolZenski.Tag = "Ž";
            this.unosSpolZenski.Text = "Ženski";
            this.unosSpolZenski.UseVisualStyleBackColor = true;
            // 
            // unosSpolMuski
            // 
            this.unosSpolMuski.AutoSize = true;
            this.unosSpolMuski.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosSpolMuski.Location = new System.Drawing.Point(179, 36);
            this.unosSpolMuski.Name = "unosSpolMuski";
            this.unosSpolMuski.Size = new System.Drawing.Size(66, 22);
            this.unosSpolMuski.TabIndex = 1;
            this.unosSpolMuski.TabStop = true;
            this.unosSpolMuski.Tag = "M";
            this.unosSpolMuski.Text = "Muški";
            this.unosSpolMuski.UseVisualStyleBackColor = true;
            // 
            // spolLabela
            // 
            this.spolLabela.AutoSize = true;
            this.spolLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spolLabela.Location = new System.Drawing.Point(131, 38);
            this.spolLabela.Name = "spolLabela";
            this.spolLabela.Size = new System.Drawing.Size(42, 18);
            this.spolLabela.TabIndex = 29;
            this.spolLabela.Text = "Spol:";
            // 
            // unosIme
            // 
            this.unosIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosIme.Location = new System.Drawing.Point(179, 75);
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(252, 24);
            this.unosIme.TabIndex = 3;
            // 
            // prezimeLabela
            // 
            this.prezimeLabela.AutoSize = true;
            this.prezimeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezimeLabela.Location = new System.Drawing.Point(520, 78);
            this.prezimeLabela.Name = "prezimeLabela";
            this.prezimeLabela.Size = new System.Drawing.Size(67, 18);
            this.prezimeLabela.TabIndex = 27;
            this.prezimeLabela.Text = "Prezime:";
            // 
            // imeLabela
            // 
            this.imeLabela.AutoSize = true;
            this.imeLabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeLabela.Location = new System.Drawing.Point(137, 78);
            this.imeLabela.Name = "imeLabela";
            this.imeLabela.Size = new System.Drawing.Size(36, 18);
            this.imeLabela.TabIndex = 26;
            this.imeLabela.Text = "Ime:";
            // 
            // podaciGost
            // 
            this.podaciGost.BackColor = System.Drawing.Color.Wheat;
            this.podaciGost.Controls.Add(this.statusOsobe);
            this.podaciGost.Controls.Add(this.unosDatumRodenja);
            this.podaciGost.Controls.Add(this.unosStatus);
            this.podaciGost.Controls.Add(this.datumRodjenja);
            this.podaciGost.Controls.Add(this.unosDrzavaRod);
            this.podaciGost.Controls.Add(this.drzavaStanovanja);
            this.podaciGost.Controls.Add(this.unosBrojDoc);
            this.podaciGost.Controls.Add(this.unosDrzavaStan);
            this.podaciGost.Controls.Add(this.unosPrezime);
            this.podaciGost.Controls.Add(this.drzavaRodjenja);
            this.podaciGost.Controls.Add(this.spolLabela);
            this.podaciGost.Controls.Add(this.brojDocLabela);
            this.podaciGost.Controls.Add(this.imeLabela);
            this.podaciGost.Controls.Add(this.unosVrstaDoc);
            this.podaciGost.Controls.Add(this.prezimeLabela);
            this.podaciGost.Controls.Add(this.vrstaDocLabela);
            this.podaciGost.Controls.Add(this.unosIme);
            this.podaciGost.Controls.Add(this.unosSpolZenski);
            this.podaciGost.Controls.Add(this.unosSpolMuski);
            this.podaciGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podaciGost.Location = new System.Drawing.Point(48, 23);
            this.podaciGost.Name = "podaciGost";
            this.podaciGost.Size = new System.Drawing.Size(873, 257);
            this.podaciGost.TabIndex = 1;
            this.podaciGost.TabStop = false;
            this.podaciGost.Text = "Podaci o gostu";
            // 
            // odustaniPrijavaGosta
            // 
            this.odustaniPrijavaGosta.BackColor = System.Drawing.Color.Peru;
            this.odustaniPrijavaGosta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odustaniPrijavaGosta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odustaniPrijavaGosta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.odustaniPrijavaGosta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.odustaniPrijavaGosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.odustaniPrijavaGosta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.odustaniPrijavaGosta.Location = new System.Drawing.Point(779, 468);
            this.odustaniPrijavaGosta.Name = "odustaniPrijavaGosta";
            this.odustaniPrijavaGosta.Size = new System.Drawing.Size(142, 38);
            this.odustaniPrijavaGosta.TabIndex = 17;
            this.odustaniPrijavaGosta.Text = "Odustani";
            this.odustaniPrijavaGosta.UseVisualStyleBackColor = false;
            // 
            // smjestajBindingSource
            // 
            this.smjestajBindingSource.DataSource = typeof(Kampiraliste.smjestaj);
            // 
            // PrijavaGostaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kampiraliste.Properties.Resources.WvftUC;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 526);
            this.Controls.Add(this.odustaniPrijavaGosta);
            this.Controls.Add(this.podaciPrijava);
            this.Controls.Add(this.potvrdiPrijavu);
            this.Controls.Add(this.podaciGost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrijavaGostaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava gosta";
            this.Load += new System.EventHandler(this.PrijavaGostaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drzavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusosobeBindingSource)).EndInit();
            this.podaciPrijava.ResumeLayout(false);
            this.podaciPrijava.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstadokumentaBindingSource)).EndInit();
            this.podaciGost.ResumeLayout(false);
            this.podaciGost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smjestajBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label odabirSmjestajaLabela;
        private System.Windows.Forms.ComboBox odabirSmjestajaUnos;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.TextBox unosBrojDoc;
        private System.Windows.Forms.ComboBox unosDrzavaRod;
        private System.Windows.Forms.ComboBox unosStatus;
        private System.Windows.Forms.DateTimePicker unosDatumDolaska;
        private System.Windows.Forms.Label datumDolaskaLabela;
        private System.Windows.Forms.DateTimePicker unosDatumOdlaska;
        private System.Windows.Forms.Label datumOdlaskaLabela;
        private System.Windows.Forms.RadioButton unosAgencijski;
        private System.Windows.Forms.RadioButton unosOsobno;
        private System.Windows.Forms.Label orgDolaskaLabela;
        private System.Windows.Forms.GroupBox podaciPrijava;
        private System.Windows.Forms.Label statusOsobe;
        private System.Windows.Forms.DateTimePicker unosDatumRodenja;
        private System.Windows.Forms.Label datumRodjenja;
        private System.Windows.Forms.Label drzavaStanovanja;
        private System.Windows.Forms.ComboBox unosDrzavaStan;
        private System.Windows.Forms.Label drzavaRodjenja;
        private System.Windows.Forms.Label brojDocLabela;
        private System.Windows.Forms.ComboBox unosVrstaDoc;
        private System.Windows.Forms.Label vrstaDocLabela;
        private System.Windows.Forms.RadioButton unosSpolZenski;
        private System.Windows.Forms.RadioButton unosSpolMuski;
        private System.Windows.Forms.Label spolLabela;
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.Label prezimeLabela;
        private System.Windows.Forms.Label imeLabela;
        private System.Windows.Forms.GroupBox podaciGost;
        private System.Windows.Forms.Button potvrdiPrijavu;
        private System.Windows.Forms.Button pokreniUnosSmjestaj;
        private System.Windows.Forms.BindingSource drzavaBindingSource;
        private System.Windows.Forms.BindingSource vrstadokumentaBindingSource;
        private System.Windows.Forms.BindingSource statusosobeBindingSource;
        private System.Windows.Forms.Button odustaniPrijavaGosta;
        private System.Windows.Forms.BindingSource smjestajBindingSource;
    }
}
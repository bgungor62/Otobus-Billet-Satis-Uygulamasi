namespace BiletSistemi
{
    partial class frm_sefer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sefer));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.CmbKaptan = new System.Windows.Forms.ComboBox();
            this.CmbOtobus = new System.Windows.Forms.ComboBox();
            this.CmbVaris = new System.Windows.Forms.ComboBox();
            this.CmbKalkis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.CmbMuavin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.chkAraDurak = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtNeredenNereye = new System.Windows.Forms.TextBox();
            this.txtAraDurak = new System.Windows.Forms.TextBox();
            this.tenlem1 = new System.Windows.Forms.TextBox();
            this.tboylam1 = new System.Windows.Forms.TextBox();
            this.txtenlem = new System.Windows.Forms.TextBox();
            this.txtboylam = new System.Windows.Forms.TextBox();
            this.lblkm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(845, 317);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(174, 56);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "                 Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(848, 397);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(170, 60);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "                A-Z";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(1023, 316);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(196, 59);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "                  Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(1034, 398);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(178, 58);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "                   Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 212);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(1096, 660);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(28, 27);
            this.txtId.TabIndex = 1000;
            this.txtId.Visible = false;
            // 
            // CmbKaptan
            // 
            this.CmbKaptan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.CmbKaptan.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKaptan.ForeColor = System.Drawing.Color.Red;
            this.CmbKaptan.FormattingEnabled = true;
            this.CmbKaptan.Location = new System.Drawing.Point(96, 381);
            this.CmbKaptan.Margin = new System.Windows.Forms.Padding(2);
            this.CmbKaptan.Name = "CmbKaptan";
            this.CmbKaptan.Size = new System.Drawing.Size(330, 26);
            this.CmbKaptan.TabIndex = 3;
            // 
            // CmbOtobus
            // 
            this.CmbOtobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.CmbOtobus.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbOtobus.ForeColor = System.Drawing.Color.Red;
            this.CmbOtobus.FormattingEnabled = true;
            this.CmbOtobus.Location = new System.Drawing.Point(96, 344);
            this.CmbOtobus.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOtobus.Name = "CmbOtobus";
            this.CmbOtobus.Size = new System.Drawing.Size(330, 26);
            this.CmbOtobus.TabIndex = 2;
            // 
            // CmbVaris
            // 
            this.CmbVaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.CmbVaris.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbVaris.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CmbVaris.FormattingEnabled = true;
            this.CmbVaris.Location = new System.Drawing.Point(96, 309);
            this.CmbVaris.Margin = new System.Windows.Forms.Padding(2);
            this.CmbVaris.Name = "CmbVaris";
            this.CmbVaris.Size = new System.Drawing.Size(139, 26);
            this.CmbVaris.TabIndex = 1;
            this.CmbVaris.SelectedIndexChanged += new System.EventHandler(this.CmbVaris_SelectedIndexChanged);
            // 
            // CmbKalkis
            // 
            this.CmbKalkis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.CmbKalkis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbKalkis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CmbKalkis.FormattingEnabled = true;
            this.CmbKalkis.Location = new System.Drawing.Point(96, 277);
            this.CmbKalkis.Margin = new System.Windows.Forms.Padding(2);
            this.CmbKalkis.Name = "CmbKalkis";
            this.CmbKalkis.Size = new System.Drawing.Size(139, 26);
            this.CmbKalkis.TabIndex = 0;
            this.CmbKalkis.SelectedIndexChanged += new System.EventHandler(this.CmbKalkis_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Kaptan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 118;
            this.label3.Text = "Otobüs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Varış:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Kalkış:";
            // 
            // MskSaat
            // 
            this.MskSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.MskSaat.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSaat.Location = new System.Drawing.Point(98, 519);
            this.MskSaat.Margin = new System.Windows.Forms.Padding(2);
            this.MskSaat.Mask = "90:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(67, 27);
            this.MskSaat.TabIndex = 7;
            this.MskSaat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskSaat_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(39, 522);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 138;
            this.label8.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 488);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.TxtUcret.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUcret.Location = new System.Drawing.Point(96, 453);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(78, 27);
            this.TxtUcret.TabIndex = 5;
            this.TxtUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUcret_KeyPress);
            // 
            // CmbMuavin
            // 
            this.CmbMuavin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.CmbMuavin.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbMuavin.ForeColor = System.Drawing.Color.Red;
            this.CmbMuavin.FormattingEnabled = true;
            this.CmbMuavin.Location = new System.Drawing.Point(96, 416);
            this.CmbMuavin.Margin = new System.Windows.Forms.Padding(2);
            this.CmbMuavin.Name = "CmbMuavin";
            this.CmbMuavin.Size = new System.Drawing.Size(330, 28);
            this.CmbMuavin.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(28, 491);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 134;
            this.label7.Text = "Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 133;
            this.label6.Text = "Ücret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(9, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 132;
            this.label5.Text = "Muavin:";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(1096, 616);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(28, 30);
            this.btnTemizle.TabIndex = 1001;
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Visible = false;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // chkAraDurak
            // 
            this.chkAraDurak.CheckOnClick = true;
            this.chkAraDurak.FormattingEnabled = true;
            this.chkAraDurak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkAraDurak.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.chkAraDurak.Location = new System.Drawing.Point(5, 20);
            this.chkAraDurak.Margin = new System.Windows.Forms.Padding(2);
            this.chkAraDurak.MultiColumn = true;
            this.chkAraDurak.Name = "chkAraDurak";
            this.chkAraDurak.Size = new System.Drawing.Size(382, 259);
            this.chkAraDurak.TabIndex = 1002;
            this.chkAraDurak.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkAraDurak_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAraDurak);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(448, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 284);
            this.groupBox1.TabIndex = 1003;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara Durak Seçimi";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(7, 217);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(198, 23);
            this.metroButton1.TabIndex = 1010;
            this.metroButton1.Text = "Aktif Serferdekiler";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(211, 217);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(198, 23);
            this.metroButton2.TabIndex = 1011;
            this.metroButton2.Text = "Excele Aktar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtNeredenNereye
            // 
            this.txtNeredenNereye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.txtNeredenNereye.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNeredenNereye.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNeredenNereye.Location = new System.Drawing.Point(1056, 542);
            this.txtNeredenNereye.Margin = new System.Windows.Forms.Padding(2);
            this.txtNeredenNereye.Name = "txtNeredenNereye";
            this.txtNeredenNereye.Size = new System.Drawing.Size(78, 27);
            this.txtNeredenNereye.TabIndex = 1012;
            this.txtNeredenNereye.Visible = false;
            // 
            // txtAraDurak
            // 
            this.txtAraDurak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(194)))), ((int)(((byte)(211)))));
            this.txtAraDurak.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraDurak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAraDurak.Location = new System.Drawing.Point(1056, 577);
            this.txtAraDurak.Margin = new System.Windows.Forms.Padding(2);
            this.txtAraDurak.Name = "txtAraDurak";
            this.txtAraDurak.Size = new System.Drawing.Size(78, 27);
            this.txtAraDurak.TabIndex = 1013;
            this.txtAraDurak.Visible = false;
            // 
            // tenlem1
            // 
            this.tenlem1.Location = new System.Drawing.Point(299, 582);
            this.tenlem1.Name = "tenlem1";
            this.tenlem1.Size = new System.Drawing.Size(136, 22);
            this.tenlem1.TabIndex = 1014;
            // 
            // tboylam1
            // 
            this.tboylam1.AcceptsReturn = true;
            this.tboylam1.Location = new System.Drawing.Point(466, 580);
            this.tboylam1.Name = "tboylam1";
            this.tboylam1.Size = new System.Drawing.Size(136, 22);
            this.tboylam1.TabIndex = 1015;
            // 
            // txtenlem
            // 
            this.txtenlem.Location = new System.Drawing.Point(817, 218);
            this.txtenlem.Name = "txtenlem";
            this.txtenlem.Size = new System.Drawing.Size(136, 22);
            this.txtenlem.TabIndex = 1017;
            // 
            // txtboylam
            // 
            this.txtboylam.Location = new System.Drawing.Point(817, 257);
            this.txtboylam.Name = "txtboylam";
            this.txtboylam.Size = new System.Drawing.Size(136, 22);
            this.txtboylam.TabIndex = 1016;
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblkm.Location = new System.Drawing.Point(578, 236);
            this.lblkm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(0, 20);
            this.lblkm.TabIndex = 1018;
            // 
            // frm_sefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1257, 751);
            this.Controls.Add(this.lblkm);
            this.Controls.Add(this.txtenlem);
            this.Controls.Add(this.txtboylam);
            this.Controls.Add(this.tboylam1);
            this.Controls.Add(this.tenlem1);
            this.Controls.Add(this.txtAraDurak);
            this.Controls.Add(this.txtNeredenNereye);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.MskSaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.CmbMuavin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbKaptan);
            this.Controls.Add(this.CmbOtobus);
            this.Controls.Add(this.CmbVaris);
            this.Controls.Add(this.CmbKalkis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_sefer";
            this.Text = "Sefer Paneli";
            this.Load += new System.EventHandler(this.frm_sefer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox CmbKaptan;
        private System.Windows.Forms.ComboBox CmbOtobus;
        private System.Windows.Forms.ComboBox CmbVaris;
        private System.Windows.Forms.ComboBox CmbKalkis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.ComboBox CmbMuavin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private System.Windows.Forms.CheckedListBox chkAraDurak;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtNeredenNereye;
        private System.Windows.Forms.TextBox txtAraDurak;
        private System.Windows.Forms.TextBox tenlem1;
        private System.Windows.Forms.TextBox tboylam1;
        private System.Windows.Forms.TextBox txtenlem;
        private System.Windows.Forms.TextBox txtboylam;
        private System.Windows.Forms.Label lblkm;
    }
}
namespace PresentationLayer
{
    partial class Form1
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
            this.dataGridViewPutniNalozi = new System.Windows.Forms.DataGridView();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta_prijevoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polazište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odrediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_odlaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_povratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewZaposlenici = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_putnih_naloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxOdredista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutniNalozi)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPutniNalozi
            // 
            this.dataGridViewPutniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPutniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prezime,
            this.ime,
            this.vrsta_prijevoza,
            this.polazište,
            this.odrediste,
            this.datum_odlaska,
            this.datum_povratka,
            this.trajanje});
            this.dataGridViewPutniNalozi.Location = new System.Drawing.Point(147, 6);
            this.dataGridViewPutniNalozi.Name = "dataGridViewPutniNalozi";
            this.dataGridViewPutniNalozi.Size = new System.Drawing.Size(861, 336);
            this.dataGridViewPutniNalozi.TabIndex = 0;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "PrezimeZaposlenika";
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            // 
            // ime
            // 
            this.ime.DataPropertyName = "ImeZaposlenika";
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            // 
            // vrsta_prijevoza
            // 
            this.vrsta_prijevoza.DataPropertyName = "VrstaPrijevoza";
            this.vrsta_prijevoza.HeaderText = "Vrsta prijevoza";
            this.vrsta_prijevoza.Name = "vrsta_prijevoza";
            // 
            // polazište
            // 
            this.polazište.DataPropertyName = "GradPolaziste";
            this.polazište.HeaderText = "Polazište";
            this.polazište.Name = "polazište";
            // 
            // odrediste
            // 
            this.odrediste.DataPropertyName = "GradOdrediste";
            this.odrediste.HeaderText = "Odredište ";
            this.odrediste.Name = "odrediste";
            // 
            // datum_odlaska
            // 
            this.datum_odlaska.DataPropertyName = "DatumOdlaska";
            this.datum_odlaska.HeaderText = "Datum odlaska";
            this.datum_odlaska.Name = "datum_odlaska";
            // 
            // datum_povratka
            // 
            this.datum_povratka.DataPropertyName = "DatumPovratka";
            this.datum_povratka.HeaderText = "Datum povratka";
            this.datum_povratka.Name = "datum_povratka";
            // 
            // trajanje
            // 
            this.trajanje.DataPropertyName = "Trajanje";
            this.trajanje.HeaderText = "Trajanje";
            this.trajanje.Name = "trajanje";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 422);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewPutniNalozi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxOdredista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonFilter);
            this.groupBox1.Controls.Add(this.textBoxPrezime);
            this.groupBox1.Controls.Add(this.textBoxIme);
            this.groupBox1.Location = new System.Drawing.Point(4, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upiši prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Upiši ime";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(14, 220);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(123, 44);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filtriraj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(14, 113);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(123, 20);
            this.textBoxPrezime.TabIndex = 1;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(13, 51);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(124, 20);
            this.textBoxIme.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewZaposlenici);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewZaposlenici
            // 
            this.dataGridViewZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ime1,
            this.Prezime1,
            this.broj_putnih_naloga});
            this.dataGridViewZaposlenici.Location = new System.Drawing.Point(10, 9);
            this.dataGridViewZaposlenici.Name = "dataGridViewZaposlenici";
            this.dataGridViewZaposlenici.Size = new System.Drawing.Size(828, 317);
            this.dataGridViewZaposlenici.TabIndex = 0;
            this.dataGridViewZaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewZaposlenici_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            // 
            // Ime1
            // 
            this.Ime1.DataPropertyName = "Ime";
            this.Ime1.HeaderText = "Ime";
            this.Ime1.Name = "Ime1";
            // 
            // Prezime1
            // 
            this.Prezime1.DataPropertyName = "Prezime";
            this.Prezime1.HeaderText = "Prezime";
            this.Prezime1.Name = "Prezime1";
            // 
            // broj_putnih_naloga
            // 
            this.broj_putnih_naloga.DataPropertyName = "BrojPutnihNaloga";
            this.broj_putnih_naloga.HeaderText = "Broj putnih naloga";
            this.broj_putnih_naloga.Name = "broj_putnih_naloga";
            // 
            // comboBoxOdredista
            // 
            this.comboBoxOdredista.FormattingEnabled = true;
            this.comboBoxOdredista.Location = new System.Drawing.Point(14, 183);
            this.comboBoxOdredista.Name = "comboBoxOdredista";
            this.comboBoxOdredista.Size = new System.Drawing.Size(123, 21);
            this.comboBoxOdredista.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odaberi odredište";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPutniNalozi)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPutniNalozi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta_prijevoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazište;
        private System.Windows.Forms.DataGridViewTextBoxColumn odrediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_odlaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_povratka;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanje;
        private System.Windows.Forms.DataGridView dataGridViewZaposlenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_putnih_naloga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOdredista;
    }
}


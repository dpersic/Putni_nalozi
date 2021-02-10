namespace PresentationLayer
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VrstaPrijevoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradPolaziste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odredište = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdlaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPovratka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaPrijevoza,
            this.GradPolaziste,
            this.Odredište,
            this.DatumOdlaska,
            this.DatumPovratka});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // VrstaPrijevoza
            // 
            this.VrstaPrijevoza.DataPropertyName = "VrstaPrijevoza";
            this.VrstaPrijevoza.HeaderText = "Vrsta prijevoza";
            this.VrstaPrijevoza.Name = "VrstaPrijevoza";
            // 
            // GradPolaziste
            // 
            this.GradPolaziste.DataPropertyName = "GradPolaziste";
            this.GradPolaziste.HeaderText = "Polazište";
            this.GradPolaziste.Name = "GradPolaziste";
            // 
            // Odredište
            // 
            this.Odredište.DataPropertyName = "GradOdrediste";
            this.Odredište.HeaderText = "Odredište";
            this.Odredište.Name = "Odredište";
            // 
            // DatumOdlaska
            // 
            this.DatumOdlaska.DataPropertyName = "DatumOdlaska";
            this.DatumOdlaska.HeaderText = "Datum odlaska";
            this.DatumOdlaska.Name = "DatumOdlaska";
            // 
            // DatumPovratka
            // 
            this.DatumPovratka.DataPropertyName = "DatumPovratka";
            this.DatumPovratka.HeaderText = "DatumPovratka";
            this.DatumPovratka.Name = "DatumPovratka";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 286);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaPrijevoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradPolaziste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odredište;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdlaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPovratka;
    }
}
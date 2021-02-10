using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.ViewModels;
using DataAccessLayer.Entities;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private PutniNaloziRepository _putninaloziRepository = new PutniNaloziRepository();

        public BindingSource _tableBindingSource = new BindingSource();
        public BindingSource _tableBindingSourceZaposlenici = new BindingSource();
        public BindingSource _tableBindingSourceOdrediste = new BindingSource();



        public Form1()
        {
            
            _tableBindingSource.DataSource = _putninaloziRepository.PutniNalozi();
            _tableBindingSourceZaposlenici.DataSource = _putninaloziRepository.DajZaposlenike();
            _tableBindingSourceOdrediste.DataSource = _putninaloziRepository.DajOdrediste();
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPutniNalozi.DataSource = _tableBindingSource;
            dataGridViewZaposlenici.DataSource = _tableBindingSourceZaposlenici;
            comboBoxOdredista.DataSource = _tableBindingSourceOdrediste;

            DataGridViewImageColumn oViewButton = new DataGridViewImageColumn();
            oViewButton.Image = Image.FromFile("C:\\Users\\Kruno\\Downloads\\iconfinder_system-search_118797.png");
            oViewButton.Width = 20;
            oViewButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewZaposlenici.Columns.Insert(4, oViewButton);
            dataGridViewZaposlenici.Columns[4].HeaderText = "Pogledaj putne naloge";

            dataGridViewZaposlenici.AutoGenerateColumns = false;
        }

        private void dataGridViewZaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewZaposlenici.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                var zaposlenikId = Convert.ToInt32(dataGridViewZaposlenici.Rows[e.RowIndex].Cells[0].Value);

                var putniNalog = _putninaloziRepository.GetPutniNalogById(zaposlenikId);

                Form2 Form2 = new Form2(putniNalog); //kreirali objekt naše nove forme... konstruktor prima parametre objekt klase user
                Form2.Show();
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            dataGridViewPutniNalozi.DataSource = _putninaloziRepository.Filter(textBoxIme.Text, textBoxPrezime.Text, comboBoxOdredista.Text);
           
            
        }
    }
}

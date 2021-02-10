using DataAccessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{  
    public partial class Form2 : Form
    {
        public BindingSource _tableBindingSource = new BindingSource(); 
        PutniNaloziVM _putniNalog = new PutniNaloziVM();

        public Form2(PutniNaloziVM putniNalog)
        {
            _putniNalog = putniNalog;            
            _tableBindingSource.DataSource = _putniNalog.putniNaloziZaposlenika;
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _tableBindingSource;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataView Поставщики_и_товарыDataView;

        private void button1_Click(object sender, EventArgs e)
        {
            поставщики_и_товарыTableAdapter1.Fill(rbProductDataSet1.Поставщики_и_товары);
            Поставщики_и_товарыDataView = new DataView(rbProductDataSet1.Поставщики_и_товары);
            dataGridView1.DataSource = Поставщики_и_товарыDataView;
            Поставщики_и_товарыDataView.Sort = "Наименование";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Поставщики_и_товарыDataView.Sort = SortTextBox.Text;
            Поставщики_и_товарыDataView.RowFilter = FilterTextBox.Text;
        }
    }
}

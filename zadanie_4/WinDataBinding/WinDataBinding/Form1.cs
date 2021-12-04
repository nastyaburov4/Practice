using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource sortBindingSourse;

        private void Form1_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            sortBindingSourse = new BindingSource(rbProductDataSet1, "Поставщики");
            CodetextBox.DataBindings.Add("Text", sortBindingSourse, "Код поставщика");
            NametextBox.DataBindings.Add("Text", sortBindingSourse, "Поставщик");
            AddresstextBox.DataBindings.Add("Text", sortBindingSourse, "Адрес поставщика");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sortBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sortBindingSourse.MoveNext();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsov
{
    public partial class Form3 : Form
    {
        private Form1 f1 = null;
        private Form3 f3 = null;
        private int a = 0;
        public Form3()
        {
            InitializeComponent();
        }
        public void Per(Form1 a1, Form3 a2)
        {
            f1 = a1;
            f3 = a2;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Kyrier". При необходимости она может быть перемещена или удалена.
            this.kyrierTableAdapter.Fill(this.bazaDataSet.Kyrier);
            

        }

        public void button1_Click(object sender, EventArgs e)
        {

            this.Validate();
            kyrierBindingSource.EndEdit();
            kyrierTableAdapter.Adapter.Update(bazaDataSet.Kyrier);

        }

    }
}

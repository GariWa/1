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
    public partial class Form2 : Form
    {
        private Form1 f1 = null;
        private Form2 f2 = null;
        public Form2()
        {
            InitializeComponent();
        }
        public void Per(Form1 a1, Form2 a2)
        {
            f1 = a1;
            f2 = a2;
        }
        public void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Kyrier". При необходимости она может быть перемещена или удалена.
            this.kyrierTableAdapter.Fill(this.bazaDataSet.Kyrier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Assortiment". При необходимости она может быть перемещена или удалена.
            this.assortimentTableAdapter.Fill(this.bazaDataSet.Assortiment);
            comboBox1.DataSource = bazaDataSet.Kyrier;
            comboBox1.DisplayMember = "Name_kyrier";
            comboBox1.ValueMember = "ID_kyrier";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox3.Text) ==0 )  MessageBox.Show("неуказано количество", "Ошибка");
            else
            if (Convert.ToInt32(dataGridView2.CurrentRow.Cells["kolvovnalichDataGridViewTextBoxColumn"].Value) - Convert.ToInt32(textBox3.Text) >= 0)
            {
                dataGridView1.Rows.Add(dataGridView2.CurrentRow.Cells[0].Value, dataGridView2.CurrentRow.Cells[1].Value, Convert.ToInt32(textBox3.Text), Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value) * Convert.ToInt32(textBox3.Text));
                dataGridView2.CurrentRow.Cells["kolvovnalichDataGridViewTextBoxColumn"].Value = Convert.ToInt32(dataGridView2.CurrentRow.Cells["kolvovnalichDataGridViewTextBoxColumn"].Value) - Convert.ToInt32(textBox3.Text);
                this.Validate();
                assortimentBindingSource.EndEdit();
                assortimentTableAdapter.Update(bazaDataSet);
            }
            else
            {
                MessageBox.Show( "Недостаточно товара в наличии" , "Ошибка");
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            int a = dataGridView1.Rows.Count-1;
            float price = 0;
            for (int i=0;i<a;i++)
            {
                f1.addtov(f1.zakaznom(), Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value));
                price += Convert.ToInt32( dataGridView1.Rows[i].Cells[3].Value);
            }
            a = Convert.ToInt32(comboBox1.SelectedValue);
            f1.addr(textBox1.Text, textBox2.Text, price, a) ;
            clear();
            MessageBox.Show("Заказ добавлен", "Готово");
        }
        //метод очистки полей после добавления заказа
        private void clear()
        {
            dataGridView1.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            comboBox1.SelectedIndex = 0;
            

        }
       
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0) textBox3.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text =dataGridView1.CurrentCell.RowIndex.ToString();
        }

    }
}

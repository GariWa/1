using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazDataSet.Table1". При необходимости она может быть перемещена или удалена.
            this.table1TableAdapter.Fill(this.bazDataSet.Table1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.bazDataSet.Table);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //добавление
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                table1TableAdapter.Insert(textBox1.Text, Convert.ToInt32(comboBox1.Text));
                table1TableAdapter.Update(bazDataSet);
                this.table1TableAdapter.Fill(bazDataSet.Table1);
                dataGridView1.Refresh();
            }
            catch { MessageBox.Show("такие данные уже есть", "ошибка"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tableTableAdapter.Insert( comboBox2.Text, textBox2.Text);
                tableTableAdapter.Update(bazDataSet);
                this.tableTableAdapter.Fill(bazDataSet.Table);
                dataGridView2.Refresh();
            }
            catch { MessageBox.Show("такие данные уже есть", "ошибка"); }
        }
        //удаление
        private void button4_Click(object sender, EventArgs e)
        {
            try { table1BindingSource.RemoveCurrent();
                this.Validate();
                this.table1BindingSource.EndEdit();
                this.table1TableAdapter.Update(this.bazDataSet);
                dataGridView1.Refresh(); }
            catch { MessageBox.Show("Элементы отсутствуют"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                tableBindingSource.RemoveCurrent();
                this.Validate();
                this.table1BindingSource.EndEdit();
                this.table1TableAdapter.Update(this.bazDataSet);
                dataGridView2.Refresh(); }
            catch { MessageBox.Show("Элементы отсутствуют"); }
        }
        //изменение
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 1) //Проверяем базу на пустоту
            {
                MessageBox.Show("В базе данных нет не одного клиента!");
            }
            else
            {
                if (textBox1.Text != "" && comboBox1.Text != "")
                {
                    try
                    {
                        dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text; //Заносим значение в 1 ячейку
                        dataGridView1.CurrentRow.Cells[1].Value = comboBox1.Text; //Заносим значение во 2 ячейку
                        table1BindingSource.EndEdit();
                        table1TableAdapter.Update(bazDataSet.Table1); //Обновление базы данных
                        table1TableAdapter.Fill(this.bazDataSet.Table1); //Заполнение новым набором
                        dataGridView1.Refresh();
                    }
                    catch { MessageBox.Show("такие данные уже есть", "ошибка"); }
                }
                else
                {
                    MessageBox.Show("Поля не заполнены!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount == 1) //Проверяем базу на пустоту
            {
                MessageBox.Show("В базе данных нет не одного клиента!");
            }
            else
            {
                if (textBox2.Text != "" && comboBox2.Text != "")
                {
                    try
                    {
                        dataGridView2.CurrentRow.Cells[0].Value = comboBox2.Text; //Заносим значение в 1 ячейку
                        dataGridView2.CurrentRow.Cells[1].Value = textBox2.Text; //Заносим значение во 2 ячейку
                        tableBindingSource.EndEdit();
                        tableTableAdapter.Update(bazDataSet.Table); //Обновление базы данных
                        tableTableAdapter.Fill(this.bazDataSet.Table); //Заполнение новым набором
                        dataGridView2.Refresh();
                    }
                    catch { MessageBox.Show("такие данные уже есть", "ошибка"); }
                }
                else
                {
                    MessageBox.Show("Поля не заполнены!");
                }
            }
        }
        public SqlConnection constr = new SqlConnection(@"Data Source = C:\USERS\TERMINAL#35\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\KR1\KR1\BAZ.MDF");
        private void button7_Click(object sender, EventArgs e)
        {
            
            SqlCommand con = new SqlCommand("Select * From Table",constr);
            SqlDataAdapter adapter = new SqlDataAdapter(con);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            dataGridView3.DataSource = tbl;
        }
    }
}

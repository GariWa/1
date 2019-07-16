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
    public partial class Form1 : Form
    {
        public Form2 form2 = new Form2();
        public Form3 form3 = new Form3();
        private Form1 f1 = null;
        private Form2 f2 = null;
        private Form3 f3 = null;
        public Form1()
        {
            InitializeComponent();
            заказToolStripMenuItem.Tag = 1;
            
        }
        public void Per(Form2 a2, Form1 a1)
        {
            f1 = a1;
            f2 = a2;
        }
        public void Per1(Form3 a2, Form1 a1)
        {
            f1 = a1;
            f3 = a2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.Assortiment". При необходимости она может быть перемещена или удалена.
            this.assortimentTableAdapter.Fill(this.bazaDataSet.Assortiment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.Kyrier". При необходимости она может быть перемещена или удалена.
            this.kyrierTableAdapter.Fill(this.bazaDataSet.Kyrier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.Tovar_zakaz". При необходимости она может быть перемещена или удалена.
            this.tovar_zakazTableAdapter.Fill(this.bazaDataSet1.Tovar_zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Tovar_zakaz". При необходимости она может быть перемещена или удалена.
            this.tovar_zakazTableAdapter.Fill(this.bazaDataSet.Tovar_zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.bazaDataSet.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.bazaDataSet.Klient);
            form2.Per(this, form2);
            Per(form2, this);
            form3.Per(this, form3);
            Per1(form3, this);
            

        }
        //метод добавления нового клиента и заказа
        public void addr(string a,string b,float c,int d)
        {
            // a - имя клиента   b - адресс c - стоимость d - id курьера 
            //добавляем и обновляем таблицу клиентов
            int i = dataGridView1.Rows.Count - 1;
            //добавляем новую строку с указанными значениями i, a , b
            klientTableAdapter.Insert(i, a,b);
            klientTableAdapter.Update(bazaDataSet);
            this.klientTableAdapter.Fill(this.bazaDataSet.Klient);
            //добовляем и обновляем таблицу заказов
            zakazTableAdapter.Insert(dataGridView2.Rows.Count-1,i,c,d);
            zakazTableAdapter.Update(bazaDataSet.Zakaz);
            this.zakazTableAdapter.Fill(this.bazaDataSet.Zakaz);
            dataGridView5.Refresh();
        }
        //метод проверки номера заказа
        public int zakaznom()
        {            
          return dataGridView1.Rows.Count - 1;
        }
    

        //метод добавления товара в список заказа
        public void addtov(int a,int b, string c , int d)
        {
            tovar_zakazTableAdapter.Insert(a,b,c,d);
            tovar_zakazTableAdapter.Update(bazaDataSet1);

            this.tovar_zakazTableAdapter.Fill(this.bazaDataSet1.Tovar_zakaz);
            this.assortimentTableAdapter.Fill(this.bazaDataSet1.Assortiment);

        } //метод добавления товара в список заказа

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            assortimentBindingSource.EndEdit();
            assortimentTableAdapter.Update(bazaDataSet1);
            kyrierBindingSource.EndEdit();
            kyrierTableAdapter.Update(bazaDataSet1);
            this.kyrierTableAdapter.Fill(this.bazaDataSet1.Kyrier);
           
            if (form2.ShowDialog() == DialogResult.OK)
                form2.button1_Click(this, EventArgs.Empty);
        }

        private void заказToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

            tabControl1.SelectTab(0);
            if (dataGridView2.RowCount > 1)
            {


                DialogResult res = MessageBox.Show("Удалить зказ?", "Удаление", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    int a = dataGridView3.Rows.Count - 1;
                    for (int i = 0; i < a; i++)
                    {
                        if (Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value) == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value))
                        {

                            tovarzakazBindingSource.RemoveAt(i);
                            a -= 1;
                            i -= 1;
                            //dataGridView3.Rows.RemoveAt(i);


                        }
                    }
                    dataGridView3.EndEdit();
                    Validate();
                    tovar_zakazTableAdapter.Update(bazaDataSet.Tovar_zakaz);
                    this.tovar_zakazTableAdapter.Fill(this.bazaDataSet.Tovar_zakaz);
                    dataGridView3.Refresh();
                    klientBindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
                    klientTableAdapter.Update(bazaDataSet1.Klient);
                    zakazBindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
                    //del.Delete();

                    zakazTableAdapter.Update(bazaDataSet);
                    this.zakazTableAdapter.Fill(this.bazaDataSet.Zakaz);
                    this.klientTableAdapter.Fill(this.bazaDataSet1.Klient);
                }
            }
            else
            {
                MessageBox.Show("нет строк на удаление", "Ошибка");
            }
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void курьераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (form3.ShowDialog() == DialogResult.OK)
                form3.button1_Click(this, EventArgs.Empty);
            
            this.kyrierTableAdapter.Fill(this.bazaDataSet1.Kyrier);
        }

    }
}

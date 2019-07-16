using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ivanova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //обработка события загрузки файла в программу и вывода ее в textbox1
        private void button1_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }
        //обработка события анализа кода программы
        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            int temp = 1; // защелки
            int temp2 = 1;// защелки
            int i;
            int q; //для прохождения массива и поиска совпадений
            int z = 10; // хранит занчение свободной ячейки
            string token2 = "";
            int token3 = 0;
            string[] vari = new string[100];
            textBox2.Text = textBox3.Text = textBox4.Text = "";

            //Конструкция для разделения всех лексем пробелами
            str = str.Replace("\r\n", " ");
            str= str.Replace("=", " = ");
            str=str.Replace(",", " , ");
            str= str.Replace("++", " ++ ");
            str= str.Replace("+", " + ");
            str = str.Replace(";", " ; ");
            str = str.Replace(":", " : ");
            
            //Конструкция для поиска данных разделенных пробелами

            string[] tok;
            string token="";
            tok = str.Split(' ');
            int cnt = tok.Length;

            //token = strtok(str.c_str(), seps.c_str());
            // далее идет сам анализ

            for (int k = 0; k < cnt; k++)
            {
                token = tok[k];
                
                    if (token == "var")
                    {
                        token2 = ":SystemLexem";
                        token3 = 1;
                        temp = 0;
                    }
                    if (token == "do")
                    {
                        token2 = ":SystemLexem";
                        token3 = 2;
                        temp = 0;
                    }
                    if (token == "begin")
                    {
                        token2 = ":SystemLexem";
                        token3 = 3;
                        temp = 0;
                    }
                    if (token == "end")
                    {
                        token2 = ":SystemLexem";
                        token3 = 4;
                        temp = 0;
                    }
                    if (token == "integer")
                    {
                        token2 = ":SystemLexem";
                        token3 = 5;
                        temp = 0;
                    }
                    if (token == "write")
                    {
                        token2 = ":SystemLexem";
                        token3 = 5;
                        temp = 0;
                    }
                    if (token == ";")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 100;
                        temp = 0;
                    }
                    if (token == ",")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 101;
                        temp = 0;
                    }
                    if (token == "=")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 102;
                        temp = 0;
                    }
                    if (token == "(")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 103;
                        temp = 0;
                    }
                    if (token == ")")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 104;
                        temp = 0;
                    }
                    if (token == "++")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 105;
                        temp = 0;
                    }
                    if (token == "+")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 106;
                        temp = 0;
                    }
                    if (token == ":")
                    {
                        token2 = ":OperatorLexem";
                        token3 = 107;
                        temp = 0;
                    }
                if (token == "For")
                {
                    token2 = ":SystemLexem";
                    token3 = 7;
                    temp = 0;
                }
                if (token == " ")
                {
                    break;
                }
                try
                {
                    i = Convert.ToInt32(token);
                    token2 = ":ConstantLexem";
                    token3 = 300;
                    temp = 0;
                }
                catch
                {
                    Exception ex;
                }
                   /*if (TryStrToInt(token, i))
                    {

                        token2 = ":ConstantLexem";
                        token3 = 300;
                        temp = 0;
                    }*/

                    if (temp != 0)
                    {
                        token2 = ":VariableLexem";
                        for (q = 10; q < 100; q++)
                        {
                            if (vari[q] == token)
                            {
                                token3 = q;
                                temp2 = 0;
                                break;
                            }
                        }
                        if (temp2 != 0)
                        {
                            vari[z] = token;
                            token3 = z;
                            z = z + 1;
                        }

                        temp2 = 1;
                    }
                textBox2.Text += token + "\r\n";
                textBox3.Text += token2 + "\r\n";
                textBox4.Text +=token3.ToString() + "\r\n";

                temp = 1;
            }
               

                //Конструкция для разделения всех лексем пробелами
            
        }
        //событие нажатие на кнопку выхода
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

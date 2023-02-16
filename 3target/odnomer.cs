using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3target
{
    public partial class odnomer : Form
    {
        public odnomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    MessageBox.Show("Выберите тип суммы!!!");
                    return;
                }
                textBox2.Text = "";
                Random rnd = new Random();
                int sum = 0;
                int k = Convert.ToInt32(textBox1.Text);
                int[] array = new int[k];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(0, 10);
                    listBox1.Items.Add(String.Format($"a[{i}]= {array[i]}"));
                }
                if (radioButton1.Checked)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            sum += array[i];
                        }
                    }
                }
                else if (radioButton2.Checked)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 != 0)
                        {
                            sum += array[i];
                        }
                    }
                }
                else if (radioButton3.Checked)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                }
                textBox2.Text = $"{sum}";
            }
            catch
            {
                if (textBox1.Text != "")
                {
                    MessageBox.Show("Введите целое число!!");
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}

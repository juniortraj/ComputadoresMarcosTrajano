using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputadoresMarcosTrajano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float valor;
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                valor = 4790;
                pictureBox1.Image = Properties.Resources.pcc;
                listBox1.Items.Add("Computador: " + comboBox1.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                valor = 5290;
                pictureBox1.Image = Properties.Resources.noteboook;
                listBox1.Items.Add("Computador: " + comboBox1.Text);
            }
            else
            {
                valor = 0; listBox1.Items.Add("Computador: " + comboBox1.Text);
            }
            if (radioButton1.Checked == true)
            {
                valor += 0; listBox1.Items.Add("Processador: " + radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                valor += 1738; listBox1.Items.Add("Processador: " + radioButton2.Text);
            }
            if (radioButton4.Checked == true)
            {
                valor += 0; listBox1.Items.Add("Memória: " + radioButton4.Text);
            }
            if (radioButton3.Checked == true)
            {
                valor += 467; listBox1.Items.Add("Memória: " + radioButton3.Text);
            }
            if (radioButton9.Checked == true)
            {
                valor += 829; listBox1.Items.Add("Memória: " + radioButton9.Text);
            }
            if (radioButton6.Checked == true)
            {
                valor += 0; listBox1.Items.Add("HD: " + radioButton6.Text);
            }
            if (radioButton5.Checked == true)
            {
                valor += 415; listBox1.Items.Add("HD: " + radioButton5.Text);
            }
            if (checkBox1.Checked == true)
            {
                valor += 1980; listBox1.Items.Add("Sistema Operacional: " + checkBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                valor += 80; listBox1.Items.Add("AntiVírus: " + checkBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                valor += 200; listBox1.Items.Add("Microsoft Office:: " + checkBox3.Text);
            }
            textBox1.Text = Convert.ToDouble(valor).ToString("R$ ###,###,##0.00");
            listBox1.Items.Add("__________________________________________");
            listBox1.Items.Add("Total:  " + textBox1.Text);
        }
    

    private void button2_Click(object sender, EventArgs e)
    {
        comboBox1.SelectedIndex = -1;
        radioButton1.Checked = false;
        radioButton2.Checked = false;
        radioButton3.Checked = false;
        radioButton4.Checked = false;
        radioButton5.Checked = false;
        radioButton6.Checked = false;
        radioButton9.Checked = false;
        checkBox1.Checked = false;
        checkBox2.Checked = false;
        checkBox3.Checked = false;
        textBox1.Clear();
        listBox1.Items.Clear();
        pictureBox1.Image = null;
       
        }
}
}

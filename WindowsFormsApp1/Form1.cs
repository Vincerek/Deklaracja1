using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Deklaracja : Form
    {
        public Deklaracja()
        {
            InitializeComponent();
            
        }
        int walidacja = 0;
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            label13.Text = "";
            comboBox2.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox2.Items.Insert(0, "INF.02");
            comboBox2.Items.Insert(1, "INF.03");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            label13.Text = "";
            comboBox2.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox2.Items.Insert(0, "INF.03");
            comboBox2.Items.Insert(1, "INF.04");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void toolTip2_Draw(object sender, DrawToolTipEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.SelectionStart = textBox4.Text.Length;
            textBox4.Text = textBox4.Text.ToUpper();
            textBox4.BackColor = Color.White;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.SelectionStart = textBox6.Text.Length;
            textBox6.Text = textBox6.Text.ToUpper();
            textBox6.BackColor = Color.White;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.SelectionStart = textBox9.Text.Length;
            textBox9.Text = textBox9.Text.ToUpper();
            textBox9.BackColor = Color.White;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.SelectionStart = textBox7.Text.Length;
            textBox7.Text = textBox7.Text.ToUpper();
            textBox7.BackColor = Color.White;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == "INF.02")
            {
                label13.Text = "Administracja i eksploatacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych";
            }
            if (comboBox2.SelectedItem == "INF.03")
            {
                label13.Text = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz bazami danych,";
            }
            if (comboBox2.SelectedItem == "INF.04")
            {
                label13.Text = "Projektowanie, programowanie i testowanie aplikacji";
            }
        }

        private void Deklaracja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string last;
            last = textBox2.Text.Substring(textBox2.TextLength - 1);
            string liczba;
            liczba = maskedTextBox2.Text.Substring(maskedTextBox2.TextLength - 2);
            
            richTextBox1.Text = "";
            //Sprawdzamy nazwisko
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawne nazwisko");
            }
            else walidacja++;
            //Sprawdzamy imię
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawne imię");
            }
            else walidacja++;
            //Sprawdzamy miejsce urodzenia
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawne miejsce urodzenia");
            }
            else walidacja++;
            //Sprawdzamy miejsocowość
            if (textBox6.Text == "")
            { 
                textBox6.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawną miejscowość");
            }
            else walidacja++;
            //Sprawdzamy pocztę
            if (textBox9.Text == "")
            {
                textBox9.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawną pocztę");
            }
            else walidacja++;
            if (textBox11.Text == "" || !textBox11.Text.Contains("@") )
            {
                textBox9.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawną pocztę");
            }
            else walidacja++;
            //Sprawdzamy pesel
            if (!maskedTextBox1.MaskCompleted)
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            else if (last == "a" && int.Parse(liczba) % 2 != 0)
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            else if (last != "a" && int.Parse(liczba) % 2 == 0)
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            else walidacja++;
            //Sprawdzamy date urodzenia
            if (!maskedTextBox2.MaskCompleted) {
                maskedTextBox2.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawną date urodzenia");
            } else walidacja++;
            //Sprawdzamy kod pocztowy
            if (!maskedTextBox3.MaskCompleted) {
                maskedTextBox3.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawny kod pocztowy");
            } else walidacja++;
            //Sprawdzamy kod nr tel
            if (!maskedTextBox4.MaskCompleted)
             {
                maskedTextBox4.BackColor = Color.Red;
                MessageBox.Show("Wprowadź poprawny numer telefonu");
            } else walidacja++;



        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox2.BackColor = Color.White;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox1.BackColor = Color.White;
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox3.BackColor = Color.White;
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            maskedTextBox4.BackColor = Color.White;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

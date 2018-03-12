using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = button2.Text;
            button2.BackColor = Color.Red;
            button2.Enabled = false;

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label12.Text = button1.Text;
            button1.BackColor = Color.Red;
            button1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label14.Text = button3.Text;
            button3.BackColor = Color.Red;
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label15.Text = button4.Text;
            button4.BackColor = Color.Red;
            button4.Enabled = false;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            label16.Text = button5.Text;
            button5.BackColor = Color.Red;
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label17.Text = button6.Text;
            button6.BackColor = Color.Red;
            button6.Enabled = false;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            label18.Text = button7.Text;
            button7.BackColor = Color.Red;
            button7.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label19.Text = button8.Text;
            button8.BackColor = Color.Red;
            button8.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label20.Text = button9.Text;
            button9.BackColor = Color.Red;
            button9.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label21.Text = button10.Text;
            button10.BackColor = Color.Red;
            button10.Enabled = false;

        }

       

        

        private void button17_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(comboBox2.Text);
            listBox4.Items.Add(comboBox3.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox4.Text);

           
            listBox7.Items.Add(label12.Text + " " + label13.Text + " " + label14.Text + " " + label15.Text + " " + label16.Text + " " + label17.Text + " " + label18.Text + " " + label19.Text + " " + label20.Text + " " + label21.Text);

            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox4.Items.Clear();
            if (comboBox3.SelectedItem == "15:00")
            {
                comboBox4.Items.Add("5 manat");

            }
            else if (comboBox3.SelectedItem == "20:00")
            {
                comboBox4.Items.Add("7 manat");
            }
            else if (comboBox3.SelectedItem == "10:00")
            {
                comboBox4.Items.Add("3 manat");
            }
        }
    }
}

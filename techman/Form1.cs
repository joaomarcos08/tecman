using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numero = 0;
        private void clickNumber()
        {
            senhaBox.Text = senhaBox.Text +numero + "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            numero = 1;
            clickNumber();
            habilitarEnter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero = 2;
            clickNumber();
            habilitarEnter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero = 3;
            clickNumber();
            habilitarEnter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero = 4;
            clickNumber();
            habilitarEnter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero = 5;
            clickNumber();
            habilitarEnter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero = 6;
            clickNumber();
            habilitarEnter();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero = 7;
            clickNumber();
            habilitarEnter();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero = 8;
            clickNumber();
            habilitarEnter();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero = 9;
            clickNumber();
            habilitarEnter();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero = 0;
            clickNumber();
            habilitarEnter();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            senhaBox.Text = "";
            habilitarEnter();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=SNBBLLAB02-12\JOAO;Initial Catalog=techman;Integrated Security=True");
            c.Open();
            SqlCommand login = new SqlCommand("select * from usuarios where senha = '"+senhaBox.Text+"'",c);
            SqlDataReader reader = login.ExecuteReader();

            if (reader.Read())
            {
                Form3 form = new Form3(reader[2].ToString());
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERRO: Senha incorreta");
                senhaBox.Text = "";
            }


            c.Close();
        
        }
        private void habilitarEnter()
        {
            if (senhaBox.Text.Length >= 6)
            {
                button12.Enabled = true;
            }
            else
            {
                button12.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            senhaBox.Enabled = false;
            habilitarEnter();
        }


    }
}

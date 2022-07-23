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
    public partial class Form2 : Form
    {
        string perfil;
        public Form2(string p)
        {
            InitializeComponent();
            perfil = p;

            if (int.Parse(perfil) == 2)
            {
                label1.Show();
                pictureBox7.Show();
                pictureBox8.Show();
                pictureBox10.Show();
            }
            else
            {
                label1.Hide();
                pictureBox7.Hide();
                pictureBox8.Hide();
                pictureBox10.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int id = 1;id <= 3; id++)
            {
            SqlConnection c = new SqlConnection(@"Data Source=SNBBLLAB02-12\JOAO;Initial Catalog=techman;Integrated Security=True");
            c.Open();
            SqlCommand login = new SqlCommand("select * from equipamentos where id = " + id + "", c);
            SqlDataReader reader = login.ExecuteReader();

                while (reader.Read())
                {
                label2.Text = reader[1].ToString();
                richTextBox1.Text = reader[3].ToString();
                }
            c.Close();                
            id++;
            }
        }
        private void exclusao()
        {
            MessageBox.Show("Atenção! Tem certeza que deseja excluir o equipamento? Essa ação não poderá ser desfeita.","Exclusão de equipamento", MessageBoxButtons.OK);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            exclusao();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            exclusao();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            exclusao();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void comentarioForm()
        {
            Form4 myForm = new Form4();
            myForm.Text = "My Form";
            myForm.SetBounds(10, 10, 200, 200);

            myForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            comentarioForm();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            comentarioForm();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            comentarioForm();
        }
    }
}
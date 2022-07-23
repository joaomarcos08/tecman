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
    public partial class Form3 : Form
    {       

        public Form3(string p)
        {
            string perfil;
            InitializeComponent();
            perfil = p;

            if (int.Parse(perfil) == 2)
            {
                label1.Show();
                tela.Columns["Excluir"].Visible = true;
            }
            else
            {
                label1.Hide();
                tela.Columns["Excluir"].Visible = false;
            }

        }        

        private void Form3_Load(object sender, EventArgs e)
        {
            ListaComentarios.Visible = false;
            int i = 0;
             SqlConnection c = new SqlConnection(@"Data Source=SNBBLLAB02-12\JOAO;Initial Catalog=techman;Integrated Security=True");

            c.Open();

             SqlCommand alimentar = new SqlCommand("select * from equipamentos where ativo = 1", c);
             SqlDataReader reader = alimentar.ExecuteReader();


            while (reader.Read())
             {
               tela.Rows.Add();

              tela.Rows[i].Cells[0].Value = Image.FromFile("C:/Users/SN00091501/Desktop/Estudante/Imagens_Equipamentos/" + reader[2].ToString() + "");
              tela.Rows[i].Cells[1].Value = reader[1].ToString();
              tela.Rows[i].Cells[2].Value = reader[3].ToString();
              i++;

            }
            c.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void tela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nome = tela.CurrentRow.Cells[1].Value.ToString();
            
            if (tela.CurrentCell.ColumnIndex.Equals(4))
            {
                if (
                MessageBox.Show
                ("Atenção! Tem certeza quedeseja excluir o equipamento ? " +
                "Essa ação não poderá ser desfeita.",
                "Exclusão de equipamentos", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                SqlConnection c = new SqlConnection(@"Data Source=SNBBLLAB02-12\JOAO;Initial Catalog=techman;Integrated Security=True");
                c.Open();
                SqlCommand delete = new SqlCommand("delete from equipamentos where equipamento = '" + nome + "'",c);
                int resultado = delete.ExecuteNonQuery();

                    if (resultado == 1)
                    {
                        MessageBox.Show("Equipamento deletado");
                    }
                    else
                    {
                        MessageBox.Show("Erro de Exclusão");
                    }
                c.Close();
                }

            }
            if (tela.CurrentCell.ColumnIndex == 3)
            {
                telaComentario.DataSource = null;
                telaComentario.Rows.Clear();
                int i = 0;

                ListaComentarios.Visible = true;
                SqlConnection c = new SqlConnection(@"Data Source=SNBBLLAB02-12\JOAO;Initial Catalog=techman;Integrated Security=True");
                c.Open();
                SqlCommand comentarios = new SqlCommand("select * from comentarios where idEquipamento =(select id from equipamentos where equipamento = '" + nome + "') order by daata asc", c);
                SqlDataReader r = comentarios.ExecuteReader();
                while (r.Read())
                {
                    string nomePerfil;
                    if (int.Parse(r[3].ToString()) == 1)
                    {
                        nomePerfil = "Comum";
                    }
                    else
                    {
                        if (int.Parse(r[3].ToString()) == 2)
                        {
                            nomePerfil = "Administrador";
                        }
                        else
                        {
                            if (int.Parse(r[3].ToString()) == 3)
                            {
                                nomePerfil = "Tecnico";
                            }
                            else
                            {
                                nomePerfil = "Gerente";
                            }
                        }
                    }
                    telaComentario.Rows.Add();
                    telaComentario.Rows[i].Cells[0].Value = nomePerfil;
                    telaComentario.Rows[i].Cells[1].Value = r[4].ToString();
                    telaComentario.Rows[i].Cells[2].Value = r[1].ToString();
                    i++;
                }
                i = 0;
                c.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaComentarios.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textoComentario.Text) == false)
            {
                cadastrarComentario.Enabled = true;
            }
            else
            {
                cadastrarComentario.Enabled = false;
            }
        }
    }
}

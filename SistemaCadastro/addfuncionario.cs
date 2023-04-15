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

namespace SistemaCadastro
{
    public partial class addfuncionario : Form
    {
        public addfuncionario()
        {
            InitializeComponent();

            txt_nome.Enabled = false;
            txt_tel.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cel.Enabled = false;
            txt_cpf.Enabled = false;
            txt_email.Enabled = false;
            txt_endereco.Enabled = false;
            txt_nome.Enabled = false;
            txt_rg.Enabled = false;
            txt_n.Enabled = false;
            txt_pesqnome.Enabled = false;

        }
        SqlConnection sqlcon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=db_sistemacadastro;Data Source=RYAN";
        private string strSql = string.Empty;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into tb_cadastro (Nome,Telefone,Celular,Email,Endereco,Numero,Bairro,RG,CPF) values(@Nome,@Telefone,@Celular, @Email, @Endereco,@Numero,@Bairro,@RG,@CPF)";

            SqlConnection sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);


            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_n.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_pesqnome.Enabled = true;

            txt_nome.Clear();
            txt_tel.Clear();
            txt_bairro.Clear();
            txt_cel.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_rg.Clear();
            txt_n.Clear();



        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            txt_nome.Enabled = true;
            txt_tel.Enabled = true;
            txt_bairro.Enabled = true;
            txt_cel.Enabled = true;
            txt_cpf.Enabled = true;
            txt_email.Enabled = true;
            txt_endereco.Enabled = true;
            txt_nome.Enabled = true;
            txt_rg.Enabled = true;
            txt_n.Enabled = true;
            txt_pesqnome.Enabled = false;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            strSql = "select * from tb_cadastro where Nome=@pesqnome";

            SqlConnection sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesqnome", SqlDbType.VarChar).Value = txt_pesqnome.Text;

            try
            {
                if (txt_pesqnome.Text == string.Empty)
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU UM NOME");
                }
                sqlCon.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTÁ CADASTRADO");
                }
                dr.Read();

                txt_nome.Text = Convert.ToString(dr["Nome"]);
                txt_tel.Text = Convert.ToString(dr["Telefone"]);
                txt_bairro.Text = Convert.ToString(dr["Bairro"]);
                txt_cel.Text = Convert.ToString(dr["Celular"]);
                txt_cpf.Text = Convert.ToString(dr["CPF"]);
                txt_email.Text = Convert.ToString(dr["Email"]);
                txt_endereco.Text = Convert.ToString(dr["Endereco"]);
                txt_rg.Text = Convert.ToString(dr["RG"]);
                txt_n.Text = Convert.ToString(dr["Numero"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_pesqnome.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            strSql = "update tb_cadastro set Nome =@Nome,Telefone=@Telefone,Celular=@Celular,Email=@Email,Endereco=@Endereco,Numero=@Numero,Bairro=@Bairro,RG=@RG,CPF=@CPF WHERE Nome = @Nome";

            SqlConnection sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_n.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            txt_tel.Clear();
            txt_bairro.Clear();
            txt_cel.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_rg.Clear();
            txt_n.Clear();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            strSql = "delete from tb_cadastro where Nome =@Nome";

            SqlConnection sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("CADASTRO DELETADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            txt_tel.Clear();
            txt_bairro.Clear();
            txt_cel.Clear();
            txt_cpf.Clear();
            txt_email.Clear();
            txt_endereco.Clear();
            txt_nome.Clear();
            txt_rg.Clear();
            txt_n.Clear();
        }
    }
}

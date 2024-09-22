using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Forms
{
    public partial class FormConsultar : Form
    {
        public FormConsultar()
        {
            InitializeComponent();
        }
        private void BTN_Procurar_Click(object sender, EventArgs e)
        {
            string busca = TXT_Procurar.Text.Trim();

            if (string.IsNullOrWhiteSpace(busca))
            {
                MessageBox.Show("Por favor, insira o nome ou CPF para buscar.");
                return;
            }

            ConsultarClientes(busca);
        }
        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if (DGRID_Procurar.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGRID_Procurar.Rows)
                {

                    if (row.IsNewRow) continue;

                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    string nome = row.Cells["Nome"].Value.ToString();
                    string cpf = row.Cells["CPF"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();
                    string telefone = row.Cells["Telefone"].Value.ToString();
                    string endereco = row.Cells["Endereco"].Value.ToString();

                    AtualizarCliente(id, nome, cpf, email, telefone, endereco);
                }

                MessageBox.Show("Alterações salvas com sucesso.");
            }
            else
            {
                MessageBox.Show("Não há dados para salvar.");
            }
        }
    

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            if (DGRID_Procurar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DGRID_Procurar.SelectedRows[0].Cells["Id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExcluirCliente(id);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.");
            }
        }
        private void ConsultarClientes(string busca)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;

            string query = "SELECT Id, Nome, CPF, Email, Telefone, Endereco FROM Clientes WHERE Nome LIKE @Busca OR CPF = @Cpf";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Busca", "%" + busca + "%");
                        cmd.Parameters.AddWithValue("@Cpf", busca);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        da.Fill(dt);


                        if (dt.Rows.Count > 0)
                        {

                            DGRID_Procurar.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum cliente encontrado com essa busca.");
                            DGRID_Procurar.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar clientes: " + ex.Message);
                }
            }
        }
        private void ExcluirCliente(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;
            string query = "DELETE FROM Clientes WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente excluído com sucesso.");

                        ConsultarClientes(TXT_Procurar.Text.Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + ex.Message);
                }
            }
        }
        private void AtualizarCliente(int id, string nome, string cpf, string email, string telefone, string endereco)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;
            string query = "UPDATE Clientes SET Nome = @Nome, CPF = @CPF, Email = @Email, Telefone = @Telefone, Endereco = @Endereco WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.Parameters.AddWithValue("@Endereco", endereco);
                        cmd.Parameters.AddWithValue("@Id", id);

                        cmd.ExecuteNonQuery(); // Executa a atualização
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cliente: " + ex.Message);
                }
            }
        }
    }
}
    



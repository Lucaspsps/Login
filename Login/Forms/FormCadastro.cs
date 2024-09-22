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
    public partial class FormCadastro : Form
    {
        private Cliente cliente;
        public FormCadastro()
        {
            InitializeComponent();
            cliente = new Cliente();
        }
        private void FormCadastro_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            cliente.Nome = TXT_Nome.Text;
            cliente.CPF = TXT_CPF.Text;
            cliente.Email = TXT_Email.Text;
            cliente.Telefone = TXT_Telefone.Text;
            cliente.Endereco = TXT_Endereco.Text;

            if (string.IsNullOrWhiteSpace(cliente.Nome) ||
               string.IsNullOrWhiteSpace(cliente.CPF) ||
               string.IsNullOrWhiteSpace(cliente.Email) ||
               string.IsNullOrWhiteSpace(cliente.Telefone) ||
               string.IsNullOrWhiteSpace(cliente.Endereco))
            {
                MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(cliente.CPF, out _))
            {
                MessageBox.Show("O CPF deve conter apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(cliente.Telefone, out _))
            {
                MessageBox.Show("O Telefone deve conter apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cliente.Nome.Any(char.IsDigit))
            {
                MessageBox.Show("O Nome não deve conter números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                SalvarClienteNoBanco(cliente);

                LoadData();
        }

            private void BTN_Cancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void BTN_Limpar_Click(object sender, EventArgs e)
            {
                LimparCampos();
            }
            private void LimparCampos()
            {
                TXT_Nome.Text = "";
                TXT_CPF.Text = "";
                TXT_Email.Text = "";
                TXT_Telefone.Text = "";
                TXT_Endereco.Text = "";
            }
            private void SalvarClienteNoBanco(Cliente cliente)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;


                string query = "INSERT INTO Clientes (Nome, CPF, Email, Telefone, Endereco) " +
                               "VALUES (@Nome, @CPF, @Email, @Telefone, @Endereco)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nome", cliente.Nome);
                            command.Parameters.AddWithValue("@CPF", cliente.CPF);
                            command.Parameters.AddWithValue("@Email", cliente.Email);
                            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            private void LoadData()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConexaoDB"].ConnectionString;
                string query = "SELECT * FROM Clientes";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        DGRID_Cadastro.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }
    }


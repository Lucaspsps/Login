namespace Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
        private void BTN_Login_Click(object sender, EventArgs e)
        {

            if (TXT_Usuario.Text == "admin" && TXT_Senha.Text == "123")
            {
                MessageBox.Show("Bem Vindo!!");
                FormMenu formMain = new FormMenu();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }
        private void LBL_EsqSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu Usuario é admin e a Senha é 123");
        }
    }
}

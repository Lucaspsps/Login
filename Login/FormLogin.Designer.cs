namespace Login
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            TXT_Usuario = new Guna.UI2.WinForms.Guna2TextBox();
            TXT_Senha = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            BTN_Login = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            LBL_EsqSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(415, 513);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Gill Sans Ultra Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(466, 55);
            label3.Name = "label3";
            label3.Size = new Size(148, 51);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // TXT_Usuario
            // 
            TXT_Usuario.BorderRadius = 20;
            TXT_Usuario.CustomizableEdges = customizableEdges1;
            TXT_Usuario.DefaultText = "";
            TXT_Usuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TXT_Usuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TXT_Usuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TXT_Usuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TXT_Usuario.FillColor = SystemColors.ControlLight;
            TXT_Usuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Usuario.Font = new Font("Segoe UI", 9F);
            TXT_Usuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Usuario.Location = new Point(470, 193);
            TXT_Usuario.Margin = new Padding(3, 4, 3, 4);
            TXT_Usuario.Name = "TXT_Usuario";
            TXT_Usuario.PasswordChar = '\0';
            TXT_Usuario.PlaceholderText = "";
            TXT_Usuario.SelectedText = "";
            TXT_Usuario.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TXT_Usuario.Size = new Size(200, 47);
            TXT_Usuario.TabIndex = 5;
            TXT_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // TXT_Senha
            // 
            TXT_Senha.BorderRadius = 20;
            TXT_Senha.CustomizableEdges = customizableEdges3;
            TXT_Senha.DefaultText = "";
            TXT_Senha.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TXT_Senha.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TXT_Senha.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TXT_Senha.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TXT_Senha.FillColor = SystemColors.ControlLight;
            TXT_Senha.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Senha.Font = new Font("Segoe UI", 9F);
            TXT_Senha.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Senha.Location = new Point(470, 269);
            TXT_Senha.Margin = new Padding(3, 4, 3, 4);
            TXT_Senha.Name = "TXT_Senha";
            TXT_Senha.PasswordChar = '\0';
            TXT_Senha.PlaceholderText = "";
            TXT_Senha.SelectedText = "";
            TXT_Senha.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TXT_Senha.Size = new Size(200, 44);
            TXT_Senha.TabIndex = 5;
            TXT_Senha.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ControlLight;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(480, 207);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ControlLight;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(480, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // BTN_Login
            // 
            BTN_Login.BorderRadius = 24;
            BTN_Login.CustomizableEdges = customizableEdges5;
            BTN_Login.DisabledState.BorderColor = Color.DarkGray;
            BTN_Login.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_Login.FillColor = Color.FromArgb(44, 79, 151);
            BTN_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Login.ForeColor = Color.White;
            BTN_Login.Location = new Point(482, 376);
            BTN_Login.Name = "BTN_Login";
            BTN_Login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BTN_Login.Size = new Size(180, 45);
            BTN_Login.TabIndex = 9;
            BTN_Login.Text = "Login";
            BTN_Login.Click += BTN_Login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(32, 114, 188);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(81, 118);
            label1.Name = "label1";
            label1.Size = new Size(356, 100);
            label1.TabIndex = 10;
            label1.Text = "BEM VINDO \r\nNOVAMENTE !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(470, 109);
            label2.Name = "label2";
            label2.Size = new Size(327, 44);
            label2.TabIndex = 4;
            label2.Text = "Bem vindo de volta! Por favor, faça o login da sua \r\nconta. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(470, 174);
            label4.Name = "label4";
            label4.Size = new Size(59, 22);
            label4.TabIndex = 4;
            label4.Text = "Usuário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(470, 250);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 4;
            label5.Text = "Senha";
            // 
            // LBL_EsqSenha
            // 
            LBL_EsqSenha.AutoSize = true;
            LBL_EsqSenha.Font = new Font("Century Gothic", 9.75F);
            LBL_EsqSenha.ForeColor = Color.Red;
            LBL_EsqSenha.Location = new Point(483, 352);
            LBL_EsqSenha.Name = "LBL_EsqSenha";
            LBL_EsqSenha.Size = new Size(179, 21);
            LBL_EsqSenha.TabIndex = 11;
            LBL_EsqSenha.Text = "Esqueceu a Senha ?";
            LBL_EsqSenha.Click += LBL_EsqSenha_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(807, 491);
            Controls.Add(LBL_EsqSenha);
            Controls.Add(label1);
            Controls.Add(BTN_Login);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox4);
            Controls.Add(TXT_Senha);
            Controls.Add(TXT_Usuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormLogin";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TXT_Usuario;
        private Guna.UI2.WinForms.Guna2TextBox TXT_Senha;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2CheckBox LBL_EsqSenhaa;
        private Guna.UI2.WinForms.Guna2Button BTN_Login;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label LBL_EsqSenha;
    }
}

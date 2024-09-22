namespace Login
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            BTN_Sair = new Button();
            BTN_Consultar = new Button();
            BTN_Cadastrar = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelTitulo = new Panel();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            PICBOX_HOME = new PictureBox();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PICBOX_HOME).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(BTN_Sair);
            panelMenu.Controls.Add(BTN_Consultar);
            panelMenu.Controls.Add(BTN_Cadastrar);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 643);
            panelMenu.TabIndex = 0;
            // 
            // BTN_Sair
            // 
            BTN_Sair.Dock = DockStyle.Top;
            BTN_Sair.FlatAppearance.BorderSize = 0;
            BTN_Sair.FlatStyle = FlatStyle.Flat;
            BTN_Sair.ForeColor = SystemColors.ControlLight;
            BTN_Sair.Image = (Image)resources.GetObject("BTN_Sair.Image");
            BTN_Sair.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Sair.Location = new Point(0, 275);
            BTN_Sair.Margin = new Padding(3, 4, 3, 4);
            BTN_Sair.Name = "BTN_Sair";
            BTN_Sair.Padding = new Padding(14, 0, 0, 0);
            BTN_Sair.Size = new Size(251, 84);
            BTN_Sair.TabIndex = 3;
            BTN_Sair.Text = "  Sair";
            BTN_Sair.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Sair.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Sair.UseVisualStyleBackColor = true;
            BTN_Sair.Click += BTN_Sair_Click;
            // 
            // BTN_Consultar
            // 
            BTN_Consultar.Dock = DockStyle.Top;
            BTN_Consultar.FlatAppearance.BorderSize = 0;
            BTN_Consultar.FlatStyle = FlatStyle.Flat;
            BTN_Consultar.ForeColor = SystemColors.ControlLight;
            BTN_Consultar.Image = (Image)resources.GetObject("BTN_Consultar.Image");
            BTN_Consultar.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Consultar.Location = new Point(0, 191);
            BTN_Consultar.Margin = new Padding(3, 4, 3, 4);
            BTN_Consultar.Name = "BTN_Consultar";
            BTN_Consultar.Padding = new Padding(14, 0, 0, 0);
            BTN_Consultar.Size = new Size(251, 84);
            BTN_Consultar.TabIndex = 2;
            BTN_Consultar.Text = "  Consultar Cliente";
            BTN_Consultar.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Consultar.UseVisualStyleBackColor = true;
            BTN_Consultar.Click += BTN_Consultar_Click;
            // 
            // BTN_Cadastrar
            // 
            BTN_Cadastrar.Dock = DockStyle.Top;
            BTN_Cadastrar.FlatAppearance.BorderSize = 0;
            BTN_Cadastrar.FlatStyle = FlatStyle.Flat;
            BTN_Cadastrar.ForeColor = SystemColors.ControlLight;
            BTN_Cadastrar.Image = (Image)resources.GetObject("BTN_Cadastrar.Image");
            BTN_Cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Cadastrar.Location = new Point(0, 107);
            BTN_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cadastrar.Name = "BTN_Cadastrar";
            BTN_Cadastrar.Padding = new Padding(14, 0, 0, 0);
            BTN_Cadastrar.Size = new Size(251, 84);
            BTN_Cadastrar.TabIndex = 1;
            BTN_Cadastrar.Text = "  Cadastrar Cliente";
            BTN_Cadastrar.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Cadastrar.UseVisualStyleBackColor = true;
            BTN_Cadastrar.Click += BTN_Cadastrar_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(14, 0, 0, 0);
            panelLogo.Size = new Size(251, 107);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(45, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Menu de Opções";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelTitulo.Controls.Add(lblTitle);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(251, 0);
            panelTitulo.Margin = new Padding(3, 4, 3, 4);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(679, 107);
            panelTitulo.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Cooper Black", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(307, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Controls.Add(PICBOX_HOME);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(251, 107);
            panelDesktopPane.Margin = new Padding(3, 4, 3, 4);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(679, 536);
            panelDesktopPane.TabIndex = 2;
            // 
            // PICBOX_HOME
            // 
            PICBOX_HOME.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PICBOX_HOME.BackColor = Color.Transparent;
            PICBOX_HOME.Image = (Image)resources.GetObject("PICBOX_HOME.Image");
            PICBOX_HOME.Location = new Point(59, 44);
            PICBOX_HOME.Margin = new Padding(0);
            PICBOX_HOME.Name = "PICBOX_HOME";
            PICBOX_HOME.Size = new Size(581, 438);
            PICBOX_HOME.SizeMode = PictureBoxSizeMode.Zoom;
            PICBOX_HOME.TabIndex = 0;
            PICBOX_HOME.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 643);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "FormMenu";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PICBOX_HOME).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button BTN_Cadastrar;
        private Button BTN_Sair;
        private Button BTN_Consultar;
        private Panel panelTitulo;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private PictureBox PICBOX_HOME;
    }
}
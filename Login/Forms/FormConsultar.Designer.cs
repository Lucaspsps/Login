namespace Login.Forms
{
    partial class FormConsultar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultar));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TXT_Procurar = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            DGRID_Procurar = new DataGridView();
            BTN_Excluir = new Button();
            BTN_Editar = new Button();
            BTN_Procurar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGRID_Procurar).BeginInit();
            SuspendLayout();
            // 
            // TXT_Procurar
            // 
            TXT_Procurar.BorderRadius = 20;
            TXT_Procurar.CustomizableEdges = customizableEdges1;
            TXT_Procurar.DefaultText = "";
            TXT_Procurar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TXT_Procurar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TXT_Procurar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TXT_Procurar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TXT_Procurar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Procurar.Font = new Font("Segoe UI", 9F);
            TXT_Procurar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TXT_Procurar.IconLeft = (Image)resources.GetObject("TXT_Procurar.IconLeft");
            TXT_Procurar.IconLeftSize = new Size(15, 15);
            TXT_Procurar.Location = new Point(91, 116);
            TXT_Procurar.Margin = new Padding(3, 5, 3, 5);
            TXT_Procurar.Name = "TXT_Procurar";
            TXT_Procurar.PasswordChar = '\0';
            TXT_Procurar.PlaceholderText = "";
            TXT_Procurar.SelectedText = "";
            TXT_Procurar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TXT_Procurar.Size = new Size(791, 63);
            TXT_Procurar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 85);
            label1.Name = "label1";
            label1.Size = new Size(177, 24);
            label1.TabIndex = 1;
            label1.Text = "Procurar Cliente :";
            // 
            // DGRID_Procurar
            // 
            DGRID_Procurar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGRID_Procurar.BackgroundColor = Color.FromArgb(51, 51, 76);
            DGRID_Procurar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGRID_Procurar.Location = new Point(113, 264);
            DGRID_Procurar.Margin = new Padding(3, 4, 3, 4);
            DGRID_Procurar.Name = "DGRID_Procurar";
            DGRID_Procurar.RowHeadersWidth = 51;
            DGRID_Procurar.Size = new Size(769, 124);
            DGRID_Procurar.TabIndex = 2;
            // 
            // BTN_Excluir
            // 
            BTN_Excluir.Cursor = Cursors.Hand;
            BTN_Excluir.FlatAppearance.BorderColor = SystemColors.ControlLight;
            BTN_Excluir.ForeColor = Color.FromArgb(0, 150, 136);
            BTN_Excluir.Image = (Image)resources.GetObject("BTN_Excluir.Image");
            BTN_Excluir.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Excluir.Location = new Point(285, 203);
            BTN_Excluir.Margin = new Padding(3, 4, 3, 4);
            BTN_Excluir.Name = "BTN_Excluir";
            BTN_Excluir.Size = new Size(86, 40);
            BTN_Excluir.TabIndex = 3;
            BTN_Excluir.Text = "Excluir";
            BTN_Excluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Excluir.UseVisualStyleBackColor = true;
            // 
            // BTN_Editar
            // 
            BTN_Editar.Cursor = Cursors.Hand;
            BTN_Editar.FlatAppearance.BorderColor = SystemColors.ControlLight;
            BTN_Editar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Editar.ForeColor = Color.FromArgb(0, 150, 136);
            BTN_Editar.Image = (Image)resources.GetObject("BTN_Editar.Image");
            BTN_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Editar.Location = new Point(193, 203);
            BTN_Editar.Margin = new Padding(3, 4, 3, 4);
            BTN_Editar.Name = "BTN_Editar";
            BTN_Editar.Size = new Size(86, 40);
            BTN_Editar.TabIndex = 3;
            BTN_Editar.Text = "Editar";
            BTN_Editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Editar.UseVisualStyleBackColor = true;
            BTN_Editar.Click += BTN_Editar_Click;
            // 
            // BTN_Procurar
            // 
            BTN_Procurar.Cursor = Cursors.Hand;
            BTN_Procurar.FlatAppearance.BorderColor = SystemColors.ControlLight;
            BTN_Procurar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Procurar.ForeColor = Color.FromArgb(0, 150, 136);
            BTN_Procurar.Image = (Image)resources.GetObject("BTN_Procurar.Image");
            BTN_Procurar.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Procurar.Location = new Point(97, 203);
            BTN_Procurar.Margin = new Padding(3, 4, 3, 4);
            BTN_Procurar.Name = "BTN_Procurar";
            BTN_Procurar.Size = new Size(90, 40);
            BTN_Procurar.TabIndex = 4;
            BTN_Procurar.Text = "Procurar";
            BTN_Procurar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Procurar.UseVisualStyleBackColor = true;
            BTN_Procurar.Click += BTN_Procurar_Click;
            // 
            // FormConsultar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BTN_Procurar);
            Controls.Add(BTN_Editar);
            Controls.Add(BTN_Excluir);
            Controls.Add(DGRID_Procurar);
            Controls.Add(label1);
            Controls.Add(TXT_Procurar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConsultar";
            Text = "CONSULTA";
            ((System.ComponentModel.ISupportInitialize)DGRID_Procurar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TxtProcurar;
        private Label label1;
        private DataGridView DGRID_Procurar;
        private Button btnExc;
        private Button btnEdit;
        private Guna.UI2.WinForms.Guna2TextBox TXT_Procurar;
        private Button BTN_Excluir;
        private Button BTN_Editar;
        private Button BTN_Procurar;
    }
}
namespace SistemaCadastro
{
    partial class addfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addfuncionario));
            label_nome = new Label();
            txt_nome = new TextBox();
            btn_add = new Button();
            txt_tel = new MaskedTextBox();
            label12 = new Label();
            txt_email = new TextBox();
            label2 = new Label();
            label66 = new Label();
            txt_cel = new MaskedTextBox();
            txt_endereco = new TextBox();
            label4 = new Label();
            txt_n = new TextBox();
            txt_num = new Label();
            txt_bairro = new TextBox();
            label5 = new Label();
            txt_cpf = new TextBox();
            label6 = new Label();
            txt_rg = new TextBox();
            label7 = new Label();
            txt_pesqnome = new TextBox();
            label8 = new Label();
            btn_salvar = new Button();
            btn_buscar = new Button();
            btn_editar = new Button();
            btn_apagar = new Button();
            SuspendLayout();
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_nome.Location = new Point(51, 148);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(41, 15);
            label_nome.TabIndex = 0;
            label_nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(118, 148);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(457, 23);
            txt_nome.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.Location = new Point(51, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 86);
            btn_add.TabIndex = 2;
            btn_add.Text = "Adicionar";
            btn_add.TextAlign = ContentAlignment.BottomCenter;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(118, 188);
            txt_tel.Mask = "(00)0000-0000";
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(118, 23);
            txt_tel.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(51, 191);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 4;
            label12.Text = "Telefone:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(118, 226);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(457, 23);
            txt_email.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 226);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "E-mail:";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label66.Location = new Point(266, 196);
            label66.Name = "label66";
            label66.Size = new Size(48, 15);
            label66.TabIndex = 8;
            label66.Text = "Celular:";
            // 
            // txt_cel
            // 
            txt_cel.Location = new Point(334, 188);
            txt_cel.Mask = "(00)00000-0000";
            txt_cel.Name = "txt_cel";
            txt_cel.Size = new Size(122, 23);
            txt_cel.TabIndex = 7;
            // 
            // txt_endereco
            // 
            txt_endereco.Location = new Point(118, 272);
            txt_endereco.Name = "txt_endereco";
            txt_endereco.Size = new Size(457, 23);
            txt_endereco.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 272);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Endereço:";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(118, 315);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(154, 23);
            txt_n.TabIndex = 12;
            // 
            // txt_num
            // 
            txt_num.AutoSize = true;
            txt_num.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_num.Location = new Point(67, 318);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(24, 15);
            txt_num.TabIndex = 11;
            txt_num.Text = "N°:";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(395, 318);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(129, 23);
            txt_bairro.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(334, 321);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 13;
            label5.Text = "Bairro:";
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(395, 373);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(129, 23);
            txt_cpf.TabIndex = 18;
            txt_cpf.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(334, 376);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 17;
            label6.Text = "CPF:";
            // 
            // txt_rg
            // 
            txt_rg.Location = new Point(118, 370);
            txt_rg.Name = "txt_rg";
            txt_rg.Size = new Size(154, 23);
            txt_rg.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(67, 378);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 15;
            label7.Text = "RG:";
            // 
            // txt_pesqnome
            // 
            txt_pesqnome.Location = new Point(151, 113);
            txt_pesqnome.Name = "txt_pesqnome";
            txt_pesqnome.Size = new Size(424, 23);
            txt_pesqnome.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 116);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 19;
            label8.Text = "Pesquisar Nome";
            // 
            // btn_salvar
            // 
            btn_salvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.Location = new Point(161, 2);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(91, 86);
            btn_salvar.TabIndex = 21;
            btn_salvar.Text = "Salvar";
            btn_salvar.TextAlign = ContentAlignment.BottomCenter;
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.BackgroundImage = (Image)resources.GetObject("btn_buscar.BackgroundImage");
            btn_buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_buscar.Location = new Point(272, 2);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(92, 86);
            btn_buscar.TabIndex = 22;
            btn_buscar.Text = "Buscar";
            btn_buscar.TextAlign = ContentAlignment.BottomCenter;
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackgroundImage = (Image)resources.GetObject("btn_editar.BackgroundImage");
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_editar.Location = new Point(383, 2);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(92, 86);
            btn_editar.TabIndex = 23;
            btn_editar.Text = "Editar";
            btn_editar.TextAlign = ContentAlignment.BottomCenter;
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_apagar
            // 
            btn_apagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_apagar.Image = (Image)resources.GetObject("btn_apagar.Image");
            btn_apagar.Location = new Point(483, -2);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new Size(92, 90);
            btn_apagar.TabIndex = 24;
            btn_apagar.Text = "Apagar";
            btn_apagar.TextAlign = ContentAlignment.BottomCenter;
            btn_apagar.UseVisualStyleBackColor = true;
            btn_apagar.Click += btn_apagar_Click;
            // 
            // addfuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 409);
            Controls.Add(btn_apagar);
            Controls.Add(btn_editar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_salvar);
            Controls.Add(txt_pesqnome);
            Controls.Add(label8);
            Controls.Add(txt_cpf);
            Controls.Add(label6);
            Controls.Add(txt_rg);
            Controls.Add(label7);
            Controls.Add(txt_bairro);
            Controls.Add(label5);
            Controls.Add(txt_n);
            Controls.Add(txt_num);
            Controls.Add(txt_endereco);
            Controls.Add(label4);
            Controls.Add(label66);
            Controls.Add(txt_cel);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(txt_tel);
            Controls.Add(btn_add);
            Controls.Add(txt_nome);
            Controls.Add(label_nome);
            Name = "addfuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_nome;
        private TextBox txt_nome;
        private Button btn_add;
        private MaskedTextBox txt_tel;
        private Label label12;
        private TextBox txt_email;
        private Label label2;
        private Label label66;
        private MaskedTextBox txt_cel;
        private TextBox txt_endereco;
        private Label label4;
        private TextBox txt_n;
        private Label txt_num;
        private TextBox txt_bairro;
        private Label label5;
        private TextBox txt_cpf;
        private Label label6;
        private TextBox txt_rg;
        private Label label7;
        private TextBox txt_pesqnome;
        private Label label8;
        private Button btn_salvar;
        private Button btn_buscar;
        private Button btn_editar;
        private Button btn_apagar;
    }
}
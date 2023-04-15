namespace SistemaCadastro
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            adicionarFuncionarioToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btn_adc = new Button();
            btn_sair = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarFuncionarioToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // adicionarFuncionarioToolStripMenuItem
            // 
            adicionarFuncionarioToolStripMenuItem.Name = "adicionarFuncionarioToolStripMenuItem";
            adicionarFuncionarioToolStripMenuItem.Size = new Size(186, 22);
            adicionarFuncionarioToolStripMenuItem.Text = "adicionarFuncionario";
            adicionarFuncionarioToolStripMenuItem.Click += adicionarFuncionarioToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btn_adc
            // 
            btn_adc.BackgroundImage = (Image)resources.GetObject("btn_adc.BackgroundImage");
            btn_adc.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_adc.Location = new Point(103, 140);
            btn_adc.Name = "btn_adc";
            btn_adc.Size = new Size(202, 213);
            btn_adc.TabIndex = 1;
            btn_adc.Text = "Adicionar Funcionario";
            btn_adc.TextAlign = ContentAlignment.BottomCenter;
            btn_adc.UseVisualStyleBackColor = true;
            btn_adc.Click += btn_adc_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackgroundImage = (Image)resources.GetObject("btn_sair.BackgroundImage");
            btn_sair.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ImageAlign = ContentAlignment.BottomCenter;
            btn_sair.Location = new Point(404, 149);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(234, 204);
            btn_sair.TabIndex = 2;
            btn_sair.Text = "Sair";
            btn_sair.TextAlign = ContentAlignment.BottomCenter;
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sair);
            Controls.Add(btn_adc);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem adicionarFuncionarioToolStripMenuItem;
        private Button btn_adc;
        private Button btn_sair;
    }
}
namespace SisAulasOpusDei
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mnuSistema = new System.Windows.Forms.MenuStrip();
            this.mnuColaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmnuColaboradores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submnuCadastrarColaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuListColaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmnuMaterias = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submnuCadastrarMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuListMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuListTurmas = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuCadastrarNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmnuRelatorios = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuSistema.SuspendLayout();
            this.ctxmnuColaboradores.SuspendLayout();
            this.ctxmnuMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSistema
            // 
            this.mnuSistema.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColaboradores,
            this.matériasToolStripMenuItem,
            this.mnuRelatorios,
            this.mnuSair});
            this.mnuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuSistema.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuSistema.Size = new System.Drawing.Size(756, 24);
            this.mnuSistema.TabIndex = 0;
            this.mnuSistema.Text = "menuStrip1";
            // 
            // mnuColaboradores
            // 
            this.mnuColaboradores.DropDown = this.ctxmnuColaboradores;
            this.mnuColaboradores.Name = "mnuColaboradores";
            this.mnuColaboradores.Size = new System.Drawing.Size(96, 20);
            this.mnuColaboradores.Text = "Colaboradores";
            // 
            // ctxmnuColaboradores
            // 
            this.ctxmnuColaboradores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxmnuColaboradores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuCadastrarColaboradores,
            this.submnuListColaboradores});
            this.ctxmnuColaboradores.Name = "ctxmnuColaboradores";
            this.ctxmnuColaboradores.OwnerItem = this.mnuColaboradores;
            this.ctxmnuColaboradores.Size = new System.Drawing.Size(205, 48);
            // 
            // submnuCadastrarColaboradores
            // 
            this.submnuCadastrarColaboradores.Name = "submnuCadastrarColaboradores";
            this.submnuCadastrarColaboradores.Size = new System.Drawing.Size(204, 22);
            this.submnuCadastrarColaboradores.Text = "Cadastrar Colaboradores";
            this.submnuCadastrarColaboradores.Click += new System.EventHandler(this.submnuCadastrarColaboradores_Click);
            // 
            // submnuListColaboradores
            // 
            this.submnuListColaboradores.Name = "submnuListColaboradores";
            this.submnuListColaboradores.Size = new System.Drawing.Size(204, 22);
            this.submnuListColaboradores.Text = "Listar Colaboradores";
            this.submnuListColaboradores.Click += new System.EventHandler(this.submnuListColaboradores_Click);
            // 
            // matériasToolStripMenuItem
            // 
            this.matériasToolStripMenuItem.DropDown = this.ctxmnuMaterias;
            this.matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            this.matériasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.matériasToolStripMenuItem.Text = "Matérias";
            // 
            // ctxmnuMaterias
            // 
            this.ctxmnuMaterias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxmnuMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuCadastrarMaterias,
            this.submnuListMaterias,
            this.submnuListTurmas,
            this.submnuCadastrarNotas});
            this.ctxmnuMaterias.Name = "ctxmnuMaterias";
            this.ctxmnuMaterias.OwnerItem = this.matériasToolStripMenuItem;
            this.ctxmnuMaterias.Size = new System.Drawing.Size(173, 114);
            // 
            // submnuCadastrarMaterias
            // 
            this.submnuCadastrarMaterias.Name = "submnuCadastrarMaterias";
            this.submnuCadastrarMaterias.Size = new System.Drawing.Size(172, 22);
            this.submnuCadastrarMaterias.Text = "Cadastrar Matérias";
            this.submnuCadastrarMaterias.Click += new System.EventHandler(this.submnuCadastrarMaterias_Click);
            // 
            // submnuListMaterias
            // 
            this.submnuListMaterias.Name = "submnuListMaterias";
            this.submnuListMaterias.Size = new System.Drawing.Size(172, 22);
            this.submnuListMaterias.Text = "Listar Matérias";
            this.submnuListMaterias.Click += new System.EventHandler(this.submnuListMaterias_Click);
            // 
            // submnuListTurmas
            // 
            this.submnuListTurmas.Name = "submnuListTurmas";
            this.submnuListTurmas.Size = new System.Drawing.Size(172, 22);
            this.submnuListTurmas.Text = "Listar Turmas";
            this.submnuListTurmas.Click += new System.EventHandler(this.submnuListTurmas_Click);
            // 
            // submnuCadastrarNotas
            // 
            this.submnuCadastrarNotas.Name = "submnuCadastrarNotas";
            this.submnuCadastrarNotas.Size = new System.Drawing.Size(172, 22);
            this.submnuCadastrarNotas.Text = "Cadastrar Notas";
            this.submnuCadastrarNotas.Click += new System.EventHandler(this.submnuCadastrarNotas_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDown = this.ctxmnuRelatorios;
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "Relatórios";
            // 
            // ctxmnuRelatorios
            // 
            this.ctxmnuRelatorios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxmnuRelatorios.Name = "ctxmnuRelatorios";
            this.ctxmnuRelatorios.OwnerItem = this.mnuRelatorios;
            this.ctxmnuRelatorios.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnuSistema;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Aulas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mnuSair_Click);
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.ctxmnuColaboradores.ResumeLayout(false);
            this.ctxmnuMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuColaboradores;
        private System.Windows.Forms.ToolStripMenuItem matériasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxmnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem submnuCadastrarMaterias;
        private System.Windows.Forms.ToolStripMenuItem submnuListMaterias;
        private System.Windows.Forms.ToolStripMenuItem submnuListTurmas;
        private System.Windows.Forms.ToolStripMenuItem submnuCadastrarNotas;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ContextMenuStrip ctxmnuColaboradores;
        private System.Windows.Forms.ToolStripMenuItem submnuCadastrarColaboradores;
        private System.Windows.Forms.ToolStripMenuItem submnuListColaboradores;
        private System.Windows.Forms.ContextMenuStrip ctxmnuRelatorios;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
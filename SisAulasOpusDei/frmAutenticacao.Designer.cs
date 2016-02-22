namespace SisAulasOpusDei
{
    partial class frmAutenticacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutenticacao));
            this.grbCredenciais = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pbAcessoRestrito = new System.Windows.Forms.PictureBox();
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.tbAutenticacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAutenticacaoTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbAutenticacaoTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager();
            this.grbCredenciais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcessoRestrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCredenciais
            // 
            this.grbCredenciais.Controls.Add(this.txtSenha);
            this.grbCredenciais.Controls.Add(this.txtUsuario);
            this.grbCredenciais.Controls.Add(this.btnSair);
            this.grbCredenciais.Controls.Add(this.btnEntrar);
            this.grbCredenciais.Controls.Add(this.lblSenha);
            this.grbCredenciais.Controls.Add(this.lblUsuario);
            this.grbCredenciais.Controls.Add(this.pbAcessoRestrito);
            this.grbCredenciais.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCredenciais.Location = new System.Drawing.Point(4, 6);
            this.grbCredenciais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCredenciais.Name = "grbCredenciais";
            this.grbCredenciais.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbCredenciais.Size = new System.Drawing.Size(517, 240);
            this.grbCredenciais.TabIndex = 0;
            this.grbCredenciais.TabStop = false;
            this.grbCredenciais.Text = "Acesso ao sistema";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(303, 107);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(196, 28);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(303, 63);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 28);
            this.txtUsuario.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(325, 204);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(424, 204);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 30);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(225, 110);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(78, 22);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(213, 66);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 22);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // pbAcessoRestrito
            // 
            this.pbAcessoRestrito.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbAcessoRestrito.Image = ((System.Drawing.Image)(resources.GetObject("pbAcessoRestrito.Image")));
            this.pbAcessoRestrito.Location = new System.Drawing.Point(5, 31);
            this.pbAcessoRestrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAcessoRestrito.Name = "pbAcessoRestrito";
            this.pbAcessoRestrito.Size = new System.Drawing.Size(201, 198);
            this.pbAcessoRestrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcessoRestrito.TabIndex = 0;
            this.pbAcessoRestrito.TabStop = false;
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAutenticacaoBindingSource
            // 
            this.tbAutenticacaoBindingSource.DataMember = "tbAutenticacao";
            this.tbAutenticacaoBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // tbAutenticacaoTableAdapter
            // 
            this.tbAutenticacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbAutenticacaoTableAdapter = this.tbAutenticacaoTableAdapter;
            this.tableAdapterManager.tbColaboradorTableAdapter = null;
            this.tableAdapterManager.tbCurriculoTableAdapter = null;
            this.tableAdapterManager.tbMateriaTableAdapter = null;
            this.tableAdapterManager.tbNotaTableAdapter = null;
            this.tableAdapterManager.tbSisAuditTableAdapter = null;
            this.tableAdapterManager.tbTipoColaboradorTableAdapter = null;
            this.tableAdapterManager.tbTipoMateriaTableAdapter = null;
            this.tableAdapterManager.tbTituloTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(528, 251);
            this.Controls.Add(this.grbCredenciais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutenticacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Autenticação";
            this.Load += new System.EventHandler(this.frmAutenticacao_Load_1);
            this.grbCredenciais.ResumeLayout(false);
            this.grbCredenciais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcessoRestrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutenticacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCredenciais;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pbAcessoRestrito;
        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbAutenticacaoBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbAutenticacaoTableAdapter tbAutenticacaoTableAdapter;
        private SisAulasPiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
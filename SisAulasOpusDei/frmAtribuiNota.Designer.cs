namespace SisAulasOpusDei
{
    partial class frmAtribuiNota
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
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbNotas = new System.Windows.Forms.GroupBox();
            this.chkConcluida = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotaFinal = new System.Windows.Forms.MaskedTextBox();
            this.cbGrauHonra = new System.Windows.Forms.ComboBox();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblGrauHonra = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.tbNotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbNotaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbNotaTableAdapter();
            this.gpbDados.SuspendLayout();
            this.gpbNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtTipo);
            this.gpbDados.Controls.Add(this.lblTipo);
            this.gpbDados.Controls.Add(this.txtAno);
            this.gpbDados.Controls.Add(this.lblAno);
            this.gpbDados.Controls.Add(this.txtMateria);
            this.gpbDados.Controls.Add(this.lblMateria);
            this.gpbDados.Controls.Add(this.txtTurma);
            this.gpbDados.Controls.Add(this.lblTurma);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.lblNome);
            this.gpbDados.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gpbDados.Location = new System.Drawing.Point(13, 13);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(504, 97);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Aluno";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtTipo.Location = new System.Drawing.Point(363, 51);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(48, 18);
            this.txtTipo.TabIndex = 9;
            this.txtTipo.Text = "label9";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTipo.Location = new System.Drawing.Point(245, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(112, 18);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo Matéria:";
            // 
            // txtAno
            // 
            this.txtAno.AutoSize = true;
            this.txtAno.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtAno.Location = new System.Drawing.Point(363, 69);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(48, 18);
            this.txtAno.TabIndex = 7;
            this.txtAno.Text = "label7";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAno.Location = new System.Drawing.Point(248, 69);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(109, 18);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano Matéria:";
            // 
            // txtMateria
            // 
            this.txtMateria.AutoSize = true;
            this.txtMateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtMateria.Location = new System.Drawing.Point(363, 33);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(48, 18);
            this.txtMateria.TabIndex = 5;
            this.txtMateria.Text = "label5";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMateria.Location = new System.Drawing.Point(235, 33);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(122, 18);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Nome Matéria:";
            // 
            // txtTurma
            // 
            this.txtTurma.AutoSize = true;
            this.txtTurma.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtTurma.Location = new System.Drawing.Point(85, 51);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(48, 18);
            this.txtTurma.TabIndex = 3;
            this.txtTurma.Text = "label3";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTurma.Location = new System.Drawing.Point(14, 51);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(65, 18);
            this.lblTurma.TabIndex = 2;
            this.lblTurma.Text = "Turma:";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtNome.Location = new System.Drawing.Point(85, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(48, 18);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "label2";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNome.Location = new System.Drawing.Point(20, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // gpbNotas
            // 
            this.gpbNotas.Controls.Add(this.chkConcluida);
            this.gpbNotas.Controls.Add(this.label1);
            this.gpbNotas.Controls.Add(this.txtNotaFinal);
            this.gpbNotas.Controls.Add(this.cbGrauHonra);
            this.gpbNotas.Controls.Add(this.lblNotaFinal);
            this.gpbNotas.Controls.Add(this.lblGrauHonra);
            this.gpbNotas.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.gpbNotas.Location = new System.Drawing.Point(13, 117);
            this.gpbNotas.Name = "gpbNotas";
            this.gpbNotas.Size = new System.Drawing.Size(506, 83);
            this.gpbNotas.TabIndex = 1;
            this.gpbNotas.TabStop = false;
            this.gpbNotas.Text = "Notas";
            // 
            // chkConcluida
            // 
            this.chkConcluida.AutoSize = true;
            this.chkConcluida.Location = new System.Drawing.Point(130, 57);
            this.chkConcluida.Name = "chkConcluida";
            this.chkConcluida.Size = new System.Drawing.Size(15, 14);
            this.chkConcluida.TabIndex = 16;
            this.chkConcluida.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Concluida:";
            // 
            // txtNotaFinal
            // 
            this.txtNotaFinal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.txtNotaFinal.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtNotaFinal.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.txtNotaFinal.Location = new System.Drawing.Point(424, 26);
            this.txtNotaFinal.Mask = "00.00";
            this.txtNotaFinal.Name = "txtNotaFinal";
            this.txtNotaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNotaFinal.Size = new System.Drawing.Size(48, 24);
            this.txtNotaFinal.TabIndex = 14;
            this.txtNotaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbGrauHonra
            // 
            this.cbGrauHonra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrauHonra.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.cbGrauHonra.FormattingEnabled = true;
            this.cbGrauHonra.Location = new System.Drawing.Point(130, 25);
            this.cbGrauHonra.Name = "cbGrauHonra";
            this.cbGrauHonra.Size = new System.Drawing.Size(178, 26);
            this.cbGrauHonra.TabIndex = 13;
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNotaFinal.Location = new System.Drawing.Point(334, 28);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(91, 18);
            this.lblNotaFinal.TabIndex = 11;
            this.lblNotaFinal.Text = "Nota final:";
            // 
            // lblGrauHonra
            // 
            this.lblGrauHonra.AutoSize = true;
            this.lblGrauHonra.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblGrauHonra.Location = new System.Drawing.Point(6, 28);
            this.lblGrauHonra.Name = "lblGrauHonra";
            this.lblGrauHonra.Size = new System.Drawing.Size(131, 18);
            this.lblGrauHonra.TabIndex = 10;
            this.lblGrauHonra.Text = "Grau de Honra:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Location = new System.Drawing.Point(436, 206);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(83, 23);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(13, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNotaBindingSource
            // 
            this.tbNotaBindingSource.DataMember = "tbNota";
            this.tbNotaBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // tbNotaTableAdapter
            // 
            this.tbNotaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAtribuiNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 241);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gpbNotas);
            this.Controls.Add(this.gpbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAtribuiNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atribui Nota";
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbNotas.ResumeLayout(false);
            this.gpbNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label txtMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label txtTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.GroupBox gpbNotas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblGrauHonra;
        private System.Windows.Forms.ComboBox cbGrauHonra;
        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbNotaBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbNotaTableAdapter tbNotaTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtNotaFinal;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkConcluida;
    }
}
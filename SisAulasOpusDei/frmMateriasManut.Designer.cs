namespace SisAulasOpusDei
{
    partial class frmMateriasManut
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHrAulas60 = new System.Windows.Forms.TextBox();
            this.tbMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.txtHrAulas45 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.MaskedTextBox();
            this.txtEcts = new System.Windows.Forms.TextBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.chkOpcional = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMat = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.rdInativo = new System.Windows.Forms.RadioButton();
            this.rdAtivo = new System.Windows.Forms.RadioButton();
            this.cmbTipoMat = new System.Windows.Forms.ComboBox();
            this.tbTipoMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionarTurma = new System.Windows.Forms.Button();
            this.tbTipoMateriaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbTipoMateriaTableAdapter();
            this.tableAdapterManager = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager();
            this.tbMateriaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbMateriaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMateriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtHrAulas60);
            this.groupBox1.Controls.Add(this.txtHrAulas45);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCreditos);
            this.groupBox1.Controls.Add(this.txtEcts);
            this.groupBox1.Controls.Add(this.cmbAno);
            this.groupBox1.Controls.Add(this.chkOpcional);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeMat);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.rdInativo);
            this.groupBox1.Controls.Add(this.rdAtivo);
            this.groupBox1.Controls.Add(this.cmbTipoMat);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matéria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(295, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nº Horas Aulas (60\'):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(295, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nº Horas Aulas (45\'):";
            // 
            // txtHrAulas60
            // 
            this.txtHrAulas60.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "strHoraAula60", true));
            this.txtHrAulas60.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtHrAulas60.Location = new System.Drawing.Point(482, 216);
            this.txtHrAulas60.Name = "txtHrAulas60";
            this.txtHrAulas60.Size = new System.Drawing.Size(104, 20);
            this.txtHrAulas60.TabIndex = 10;
            // 
            // tbMateriaBindingSource
            // 
            this.tbMateriaBindingSource.DataMember = "tbMateria";
            this.tbMateriaBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHrAulas45
            // 
            this.txtHrAulas45.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "strHoraAula45", true));
            this.txtHrAulas45.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtHrAulas45.Location = new System.Drawing.Point(482, 187);
            this.txtHrAulas45.Name = "txtHrAulas45";
            this.txtHrAulas45.Size = new System.Drawing.Size(104, 20);
            this.txtHrAulas45.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(6, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nº de Créditos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(83, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "ECTS:";
            // 
            // txtCreditos
            // 
            this.txtCreditos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "dcCreditos", true));
            this.txtCreditos.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtCreditos.Location = new System.Drawing.Point(145, 216);
            this.txtCreditos.Mask = "0,0";
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(144, 20);
            this.txtCreditos.TabIndex = 8;
            // 
            // txtEcts
            // 
            this.txtEcts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "strEcts", true));
            this.txtEcts.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtEcts.Location = new System.Drawing.Point(145, 190);
            this.txtEcts.MaxLength = 7;
            this.txtEcts.Name = "txtEcts";
            this.txtEcts.Size = new System.Drawing.Size(144, 20);
            this.txtEcts.TabIndex = 7;
            // 
            // cmbAno
            // 
            this.cmbAno.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbMateriaBindingSource, "strAno", true));
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(434, 125);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(152, 21);
            this.cmbAno.TabIndex = 3;
            // 
            // chkOpcional
            // 
            this.chkOpcional.AutoSize = true;
            this.chkOpcional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkOpcional.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbMateriaBindingSource, "flgOpcional", true));
            this.chkOpcional.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tbMateriaBindingSource, "flgOpcional", true));
            this.chkOpcional.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chkOpcional.Location = new System.Drawing.Point(434, 154);
            this.chkOpcional.Name = "chkOpcional";
            this.chkOpcional.Size = new System.Drawing.Size(101, 22);
            this.chkOpcional.TabIndex = 6;
            this.chkOpcional.Text = "Opcional:";
            this.chkOpcional.UseVisualStyleBackColor = true;
            this.chkOpcional.CheckedChanged += new System.EventHandler(this.chkOpcional_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(38, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(489, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(48, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Matéria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(441, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo da Matéria:";
            // 
            // txtNomeMat
            // 
            this.txtNomeMat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "strNomeMateria", true));
            this.txtNomeMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtNomeMat.Location = new System.Drawing.Point(145, 32);
            this.txtNomeMat.MaxLength = 200;
            this.txtNomeMat.Name = "txtNomeMat";
            this.txtNomeMat.Size = new System.Drawing.Size(441, 20);
            this.txtNomeMat.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbMateriaBindingSource, "strDescricao", true));
            this.txtDescricao.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.txtDescricao.Location = new System.Drawing.Point(145, 60);
            this.txtDescricao.MaxLength = 1000;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(283, 123);
            this.txtDescricao.TabIndex = 1;
            // 
            // rdInativo
            // 
            this.rdInativo.AutoSize = true;
            this.rdInativo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.rdInativo.Location = new System.Drawing.Point(74, 145);
            this.rdInativo.Name = "rdInativo";
            this.rdInativo.Size = new System.Drawing.Size(65, 19);
            this.rdInativo.TabIndex = 5;
            this.rdInativo.TabStop = true;
            this.rdInativo.Tag = "False";
            this.rdInativo.Text = "Inativo";
            this.rdInativo.UseVisualStyleBackColor = true;
            // 
            // rdAtivo
            // 
            this.rdAtivo.AutoSize = true;
            this.rdAtivo.Checked = true;
            this.rdAtivo.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.rdAtivo.Location = new System.Drawing.Point(10, 145);
            this.rdAtivo.Name = "rdAtivo";
            this.rdAtivo.Size = new System.Drawing.Size(54, 19);
            this.rdAtivo.TabIndex = 4;
            this.rdAtivo.TabStop = true;
            this.rdAtivo.Tag = "True";
            this.rdAtivo.Text = "Ativo";
            this.rdAtivo.UseVisualStyleBackColor = true;
            this.rdAtivo.CheckedChanged += new System.EventHandler(this.rdAtivo_CheckedChanged);
            // 
            // cmbTipoMat
            // 
            this.cmbTipoMat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbMateriaBindingSource, "fkIdTipoMateria", true));
            this.cmbTipoMat.DisplayMember = "IdTipoMateria";
            this.cmbTipoMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.cmbTipoMat.FormattingEnabled = true;
            this.cmbTipoMat.Location = new System.Drawing.Point(434, 80);
            this.cmbTipoMat.Name = "cmbTipoMat";
            this.cmbTipoMat.Size = new System.Drawing.Size(152, 21);
            this.cmbTipoMat.TabIndex = 2;
            this.cmbTipoMat.ValueMember = "IdTipoMateria";
            this.cmbTipoMat.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMat_SelectedIndexChanged);
            // 
            // tbTipoMateriaBindingSource
            // 
            this.tbTipoMateriaBindingSource.DataMember = "tbTipoMateria";
            this.tbTipoMateriaBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(534, 271);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(453, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionarTurma
            // 
            this.btnAdicionarTurma.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarTurma.Enabled = false;
            this.btnAdicionarTurma.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTurma.Location = new System.Drawing.Point(12, 271);
            this.btnAdicionarTurma.Name = "btnAdicionarTurma";
            this.btnAdicionarTurma.Size = new System.Drawing.Size(162, 23);
            this.btnAdicionarTurma.TabIndex = 11;
            this.btnAdicionarTurma.Text = "Adicionar Turma";
            this.btnAdicionarTurma.UseVisualStyleBackColor = false;
            this.btnAdicionarTurma.Click += new System.EventHandler(this.btnAdicionarTurma_Click);
            // 
            // tbTipoMateriaTableAdapter
            // 
            this.tbTipoMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbAutenticacaoTableAdapter = null;
            this.tableAdapterManager.tbColaboradorTableAdapter = null;
            this.tableAdapterManager.tbCurriculoTableAdapter = null;
            this.tableAdapterManager.tbMateriaTableAdapter = null;
            this.tableAdapterManager.tbNotaTableAdapter = null;
            this.tableAdapterManager.tbSisAuditTableAdapter = null;
            this.tableAdapterManager.tbTipoColaboradorTableAdapter = null;
            this.tableAdapterManager.tbTipoMateriaTableAdapter = this.tbTipoMateriaTableAdapter;
            this.tableAdapterManager.tbTituloTableAdapter = null;
            this.tableAdapterManager.tbTurmaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbMateriaTableAdapter
            // 
            this.tbMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmMateriasManut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 303);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdicionarTurma);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMateriasManut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Matéria";
            this.Load += new System.EventHandler(this.frmMateriasManut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMateriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMat;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.RadioButton rdInativo;
        private System.Windows.Forms.RadioButton rdAtivo;
        private System.Windows.Forms.ComboBox cmbTipoMat;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionarTurma;
        private System.Windows.Forms.CheckBox chkOpcional;
        private System.Windows.Forms.Label label5;
        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbTipoMateriaBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbTipoMateriaTableAdapter tbTipoMateriaTableAdapter;
        private SisAulasPiteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tbMateriaBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbMateriaTableAdapter tbMateriaTableAdapter;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHrAulas60;
        private System.Windows.Forms.TextBox txtHrAulas45;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCreditos;
        private System.Windows.Forms.TextBox txtEcts;

    }
}
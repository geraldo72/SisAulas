using System.Windows.Forms;
namespace SisAulasOpusDei
{
    partial class frmTurmasList
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
            this.sisAulasPiteDataSet = new SisAulasOpusDei.SisAulasPiteDataSet();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.flgEncerrada = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeTipoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.strAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spSelecionaTurmasParamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.sp_SelecionaTurmas_ParamTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTurmas_ParamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaTurmasParamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.AllowUserToResizeColumns = false;
            this.dgvTurmas.AllowUserToResizeRows = false;
            this.dgvTurmas.AutoGenerateColumns = false;
            this.dgvTurmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTurmas.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvTurmas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flgEncerrada,
            this.IdMateria,
            this.IdTurma,
            this.strNomeTurma,
            this.strNomeMateria,
            this.strNomeTipoMateria,
            this.colEdit,
            this.strAno});
            this.dgvTurmas.DataSource = this.spSelecionaTurmasParamBindingSource;
            this.dgvTurmas.Location = new System.Drawing.Point(4, 91);
            this.dgvTurmas.MultiSelect = false;
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.ReadOnly = true;
            this.dgvTurmas.RowHeadersVisible = false;
            this.dgvTurmas.RowHeadersWidth = 4;
            this.dgvTurmas.Size = new System.Drawing.Size(813, 401);
            this.dgvTurmas.TabIndex = 0;
            this.dgvTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvTurmas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dgvTurmas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGritView1_CellPainting);
            // 
            // flgEncerrada
            // 
            this.flgEncerrada.DataPropertyName = "flgEncerrada";
            this.flgEncerrada.HeaderText = "Encerrada";
            this.flgEncerrada.Name = "flgEncerrada";
            this.flgEncerrada.ReadOnly = true;
            this.flgEncerrada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flgEncerrada.Width = 62;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Visible = false;
            this.IdMateria.Width = 76;
            // 
            // IdTurma
            // 
            this.IdTurma.DataPropertyName = "IdTurma";
            this.IdTurma.HeaderText = "IdTurma";
            this.IdTurma.Name = "IdTurma";
            this.IdTurma.ReadOnly = true;
            this.IdTurma.Visible = false;
            this.IdTurma.Width = 71;
            // 
            // strNomeTurma
            // 
            this.strNomeTurma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strNomeTurma.DataPropertyName = "strNomeTurma";
            this.strNomeTurma.HeaderText = "Nome da Turma";
            this.strNomeTurma.Name = "strNomeTurma";
            this.strNomeTurma.ReadOnly = true;
            // 
            // strNomeMateria
            // 
            this.strNomeMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strNomeMateria.DataPropertyName = "strNomeMateria";
            this.strNomeMateria.HeaderText = "Nome da Matéria";
            this.strNomeMateria.Name = "strNomeMateria";
            this.strNomeMateria.ReadOnly = true;
            // 
            // strNomeTipoMateria
            // 
            this.strNomeTipoMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.strNomeTipoMateria.DataPropertyName = "strNomeTipoMateria";
            this.strNomeTipoMateria.HeaderText = "Tipo da Matéria";
            this.strNomeTipoMateria.Name = "strNomeTipoMateria";
            this.strNomeTipoMateria.ReadOnly = true;
            this.strNomeTipoMateria.Width = 97;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Editar";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 40;
            // 
            // strAno
            // 
            this.strAno.DataPropertyName = "strAno";
            this.strAno.HeaderText = "strAno";
            this.strAno.Name = "strAno";
            this.strAno.ReadOnly = true;
            this.strAno.Visible = false;
            this.strAno.Width = 62;
            // 
            // spSelecionaTurmasParamBindingSource
            // 
            this.spSelecionaTurmasParamBindingSource.DataMember = "sp_SelecionaTurmas_Param";
            this.spSelecionaTurmasParamBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
            // 
            // sisAulasPiteDataSetProcs
            // 
            this.sisAulasPiteDataSetProcs.DataSetName = "SisAulasPiteDataSetProcs";
            this.sisAulasPiteDataSetProcs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(722, 34);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 26);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turma:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(328, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matéria:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.cmbMateria);
            this.groupBox1.Controls.Add(this.txtTurma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DisplayMember = "IdMateria";
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(406, 34);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(310, 26);
            this.cmbMateria.TabIndex = 5;
            this.cmbMateria.ValueMember = "IdMateria";
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTurma.Location = new System.Drawing.Point(77, 34);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(245, 24);
            this.txtTurma.TabIndex = 4;
            // 
            // sp_SelecionaTurmas_ParamTableAdapter
            // 
            this.sp_SelecionaTurmas_ParamTableAdapter.ClearBeforeFill = true;
            // 
            // frmTurmasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTurmasList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.frmTurmasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaTurmasParamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtTurma;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private BindingSource spSelecionaTurmasParamBindingSource;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTurmas_ParamTableAdapter sp_SelecionaTurmas_ParamTableAdapter;
        private DataGridViewImageColumn flgEncerrada;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn IdTurma;
        private DataGridViewTextBoxColumn strNomeTurma;
        private DataGridViewTextBoxColumn strNomeMateria;
        private DataGridViewTextBoxColumn strNomeTipoMateria;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewTextBoxColumn strAno;

    }
}
using System.Windows.Forms;
namespace SisAulasOpusDei
{
    partial class frmMateriasList
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
            this.tbMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbMateriaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbMateriaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flgStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNomeMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strAnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flgOpcionalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.datInsercaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.spSelecionaTodasMateriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisAulasPiteDataSetProcs = new SisAulasOpusDei.SisAulasPiteDataSetProcs();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cmbTipoMat = new System.Windows.Forms.ComboBox();
            this.tbTipoMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMateria = new System.Windows.Forms.Button();
            this.tbTipoMateriaTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetTableAdapters.tbTipoMateriaTableAdapter();
            this.sp_SelecionaTodasMateriasTableAdapter = new SisAulasOpusDei.SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTodasMateriasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaTodasMateriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMateriaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sisAulasPiteDataSet
            // 
            this.sisAulasPiteDataSet.DataSetName = "SisAulasPiteDataSet";
            this.sisAulasPiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMateriaBindingSource
            // 
            this.tbMateriaBindingSource.DataMember = "tbMateria";
            this.tbMateriaBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // tbMateriaTableAdapter
            // 
            this.tbMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flgStatusDataGridViewCheckBoxColumn,
            this.IdMateria,
            this.strNomeMateriaDataGridViewTextBoxColumn,
            this.strAnoDataGridViewTextBoxColumn,
            this.tpMateria,
            this.flgOpcionalDataGridViewCheckBoxColumn,
            this.datInsercaoDataGridViewTextBoxColumn,
            this.colEdit});
            this.dataGridView1.DataSource = this.spSelecionaTodasMateriasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGritView1_CellPainting);
            // 
            // flgStatusDataGridViewCheckBoxColumn
            // 
            this.flgStatusDataGridViewCheckBoxColumn.DataPropertyName = "flgStatus";
            this.flgStatusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.flgStatusDataGridViewCheckBoxColumn.Name = "flgStatusDataGridViewCheckBoxColumn";
            this.flgStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.flgStatusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flgStatusDataGridViewCheckBoxColumn.Width = 54;
            // 
            // IdMateria
            // 
            this.IdMateria.DataPropertyName = "IdMateria";
            this.IdMateria.HeaderText = "IdMateria";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            this.IdMateria.Visible = false;
            this.IdMateria.Width = 91;
            // 
            // strNomeMateriaDataGridViewTextBoxColumn
            // 
            this.strNomeMateriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.strNomeMateriaDataGridViewTextBoxColumn.DataPropertyName = "strNomeMateria";
            this.strNomeMateriaDataGridViewTextBoxColumn.HeaderText = "Nome da Matéria";
            this.strNomeMateriaDataGridViewTextBoxColumn.Name = "strNomeMateriaDataGridViewTextBoxColumn";
            this.strNomeMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strAnoDataGridViewTextBoxColumn
            // 
            this.strAnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.strAnoDataGridViewTextBoxColumn.DataPropertyName = "strAno";
            this.strAnoDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.strAnoDataGridViewTextBoxColumn.Name = "strAnoDataGridViewTextBoxColumn";
            this.strAnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.strAnoDataGridViewTextBoxColumn.Width = 58;
            // 
            // tpMateria
            // 
            this.tpMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tpMateria.DataPropertyName = "strNomeTipoMateria";
            this.tpMateria.HeaderText = "Tipo da Matéria";
            this.tpMateria.Name = "tpMateria";
            this.tpMateria.ReadOnly = true;
            this.tpMateria.Width = 121;
            // 
            // flgOpcionalDataGridViewCheckBoxColumn
            // 
            this.flgOpcionalDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.flgOpcionalDataGridViewCheckBoxColumn.DataPropertyName = "flgOpcional";
            this.flgOpcionalDataGridViewCheckBoxColumn.HeaderText = "Opcional";
            this.flgOpcionalDataGridViewCheckBoxColumn.Name = "flgOpcionalDataGridViewCheckBoxColumn";
            this.flgOpcionalDataGridViewCheckBoxColumn.ReadOnly = true;
            this.flgOpcionalDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flgOpcionalDataGridViewCheckBoxColumn.Width = 70;
            // 
            // datInsercaoDataGridViewTextBoxColumn
            // 
            this.datInsercaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datInsercaoDataGridViewTextBoxColumn.DataPropertyName = "datInsercao";
            this.datInsercaoDataGridViewTextBoxColumn.HeaderText = "Data do Cadastro";
            this.datInsercaoDataGridViewTextBoxColumn.Name = "datInsercaoDataGridViewTextBoxColumn";
            this.datInsercaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datInsercaoDataGridViewTextBoxColumn.Width = 132;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Editar";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 51;
            // 
            // spSelecionaTodasMateriasBindingSource
            // 
            this.spSelecionaTodasMateriasBindingSource.DataMember = "sp_SelecionaTodasMaterias";
            this.spSelecionaTodasMateriasBindingSource.DataSource = this.sisAulasPiteDataSetProcs;
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
            this.btnPesquisar.Location = new System.Drawing.Point(981, 46);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(95, 26);
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
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matéria:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(368, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(677, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.cmbAno);
            this.groupBox1.Controls.Add(this.cmbTipoMat);
            this.groupBox1.Controls.Add(this.txtMateria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1084, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(728, 43);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(245, 30);
            this.cmbAno.TabIndex = 6;
            // 
            // cmbTipoMat
            // 
            this.cmbTipoMat.DataSource = this.tbTipoMateriaBindingSource;
            this.cmbTipoMat.DisplayMember = "strNomeTipoMateria";
            this.cmbTipoMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbTipoMat.FormattingEnabled = true;
            this.cmbTipoMat.Location = new System.Drawing.Point(424, 43);
            this.cmbTipoMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoMat.Name = "cmbTipoMat";
            this.cmbTipoMat.Size = new System.Drawing.Size(251, 30);
            this.cmbTipoMat.TabIndex = 5;
            this.cmbTipoMat.ValueMember = "IdTipoMateria";
            // 
            // tbTipoMateriaBindingSource
            // 
            this.tbTipoMateriaBindingSource.DataMember = "tbTipoMateria";
            this.tbTipoMateriaBindingSource.DataSource = this.sisAulasPiteDataSet;
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtMateria.Location = new System.Drawing.Point(96, 43);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(272, 28);
            this.txtMateria.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAddMateria);
            this.groupBox2.Location = new System.Drawing.Point(5, 613);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1084, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Matéria";
            // 
            // btnAddMateria
            // 
            this.btnAddMateria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMateria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMateria.Image = global::SisAulasOpusDei.Properties.Resources.ico_add;
            this.btnAddMateria.Location = new System.Drawing.Point(8, 12);
            this.btnAddMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMateria.Name = "btnAddMateria";
            this.btnAddMateria.Size = new System.Drawing.Size(31, 28);
            this.btnAddMateria.TabIndex = 0;
            this.btnAddMateria.UseVisualStyleBackColor = true;
            this.btnAddMateria.Click += new System.EventHandler(this.btnAddMateria_Click);
            // 
            // tbTipoMateriaTableAdapter
            // 
            this.tbTipoMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_SelecionaTodasMateriasTableAdapter
            // 
            this.sp_SelecionaTodasMateriasTableAdapter.ClearBeforeFill = true;
            // 
            // frmMateriasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::SisAulasOpusDei.Properties.Resources.img_sjme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMateriasList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matérias";
            this.Load += new System.EventHandler(this.frmMateriasList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelecionaTodasMateriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisAulasPiteDataSetProcs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTipoMateriaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SisAulasPiteDataSet sisAulasPiteDataSet;
        private System.Windows.Forms.BindingSource tbMateriaBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbMateriaTableAdapter tbMateriaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbTipoMat;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMateria;
        private System.Windows.Forms.BindingSource tbTipoMateriaBindingSource;
        private SisAulasPiteDataSetTableAdapters.tbTipoMateriaTableAdapter tbTipoMateriaTableAdapter;
        private SisAulasPiteDataSetProcs sisAulasPiteDataSetProcs;
        private BindingSource spSelecionaTodasMateriasBindingSource;
        private SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaTodasMateriasTableAdapter sp_SelecionaTodasMateriasTableAdapter;
        private DataGridViewImageColumn flgStatusDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn IdMateria;
        private DataGridViewTextBoxColumn strNomeMateriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn strAnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tpMateria;
        private DataGridViewImageColumn flgOpcionalDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn datInsercaoDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn colEdit;

    }
}
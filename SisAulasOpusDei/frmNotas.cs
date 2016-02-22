using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmNotas : Form
    {
        private int _idTurma;
        public string _nomeTurma;
        public string _nomeMateria;
        public string _tipoMateria;
        public string _anoMateria;
        frmAtribuiNota _frmAtribuiNotas = null;

        public frmNotas()
        {
            InitializeComponent();
        }

        public frmNotas( int idTurma ,string nomeTurma, string nomeMateria, string tipoMateria, string anoMateria)
        {
            this._idTurma = idTurma;
            InitializeComponent();

            this.txtNome.Text = nomeTurma;
            this._nomeTurma = nomeTurma;
            this.txtNomeMat.Text = nomeMateria;
            this._nomeMateria = nomeMateria;
            this.txtTipoMat.Text = tipoMateria;
            this._tipoMateria = tipoMateria;
            this.txtAnoMat.Text = anoMateria;
            this._anoMateria = anoMateria;

        }
       

        private void frmNotas_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            // TODO: This line of code loads data into the 'sisAulasPiteDataSetProcs.sp_SelecionaTodasMaterias' table. You can move, or remove it, as needed.
            this.sp_SelecionaAlunosTurmaTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaAlunosTurma, "A", null, _idTurma);
        }

        private void frmNotas_Shown(object sender, EventArgs e)
        {
            if (this.sisAulasPiteDataSetProcs.sp_SelecionaAlunosTurma.Count < 1)
            {
                MessageBox.Show("Turma não possui nenhum aluno associado.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvListaMateria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvListaMaterias.Columns[e.ColumnIndex].Name == "coldgvAtribuir")
            {
                if (!(bool)this.dgvListaMaterias["coldgvConcluida", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_edit_nota));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }

            }
        }

        private void dgvListaMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                bool _concluido = (bool)this.dgvListaMaterias["coldgvConcluida", e.RowIndex].Value;

                //Botao Atribuir
                if (e.ColumnIndex == dgvListaMaterias.Columns["coldgvAtribuir"].Index && !_concluido)
                {
                    string nomeAluno = this.dgvListaMaterias["strNomeCol", e.RowIndex].Value.ToString();
                    string idCurr = this.dgvListaMaterias["coldgvIdCurriculo", e.RowIndex].Value.ToString();
                    string idNota = this.dgvListaMaterias["coldgvIdNota", e.RowIndex].Value.ToString();
                    string nota = this.dgvListaMaterias["coldgvNotaFinal", e.RowIndex].Value.ToString();
                    nota = String.Format("{0,5:N0}",nota);

                    _frmAtribuiNotas = new frmAtribuiNota(idCurr, nomeAluno, this._idTurma, this._nomeTurma, this._nomeMateria, this._anoMateria, this._tipoMateria, idNota, nota);
                    _frmAtribuiNotas.ShowDialog();
                    this.RefreshList();
                }
            }
        }


    }
}

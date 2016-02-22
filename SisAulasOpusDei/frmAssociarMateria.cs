using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisAulasOpusDei
{
    public partial class frmAssociarMateria : Form
    {
        private int _intIdColaborador = -1;
        private string _strNomeColaborador = "";
        private string _strApelidoColaborador = "";
        private int _intIdMateria = -1;
        private int _intIdCurriculo = -1;

        public frmAssociarMateria()
        {
            InitializeComponent();
            RefreshScreen();
        }

        public frmAssociarMateria(int intId, string strNome, string strApelido)
        {
            InitializeComponent();
            
            this._intIdColaborador =  intId;
            this._strNomeColaborador = strNome;
            this._strApelidoColaborador = strApelido;
            
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            try
            {
                this.sp_SelecionaMateriasCurriculoTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaMateriasCurriculo, "A", _intIdColaborador);
                this.sp_SelecionaMateriasCurriculoTableAdapter1.Fill(this.sisAulasPiteDataSetProcs1.sp_SelecionaMateriasCurriculo, "N", _intIdColaborador);

                this.lblNomeColaborador.Text = _strNomeColaborador;
                this.lblApelidoColaborador.Text = _strApelidoColaborador;

                // Zerando as variáveis;
                this._intIdMateria = -1;
                this._intIdCurriculo = -1;

                // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
                this.dgvMateriasAssociadas.CurrentCell = null;
                this.dgvMateriasNAssociadas.CurrentCell = null;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvMateriasNAssociadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMateriasNAssociadas.Columns[e.ColumnIndex].Name == "coldgvflgOpcionalN")
            {
                if ((bool)this.dgvMateriasNAssociadas["coldgvflgOpcionalN", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_optional));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }
            }
        }

        private void dgvMateriasAssociadas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMateriasAssociadas.Columns[e.ColumnIndex].Name == "coldgvflgOpcional")
            {
                if ((bool)this.dgvMateriasAssociadas["coldgvflgOpcional", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_optional));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }
            }

        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {

            if (_intIdMateria == -1 || dgvMateriasNAssociadas.CurrentCell == null)
            {
                MessageBox.Show("Favor selecionar uma matéria para realizar a associação!", "Associação de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlCommand sqlComm = new SqlCommand("dbo.sp_InserirMateriaCurriculo", new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString)))
            {
                if (sqlComm.Connection.State != ConnectionState.Open)
                {
                    sqlComm.Connection.Open();
                }
                try
                {

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    sqlComm.Parameters.AddWithValue("@IdColaborador", this._intIdColaborador);
                    if (this._intIdMateria == -1)
                        throw new Exception("Matéria não selecionada!");

                    sqlComm.Parameters.AddWithValue("@IdMateria", this._intIdMateria);

                    SqlDataReader reader = sqlComm.ExecuteReader();
                    reader.Read();

                    int intStatus = -1;
                    int.TryParse(reader["STATUS"].ToString(), out intStatus);

                    if ( intStatus == 0 )
                        MessageBox.Show("Não foi possível associar essa matéria pois já está associada para esse colaborador!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        this.RefreshScreen();

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Não foi possível associar a matéria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_intIdMateria == -1 || dgvMateriasAssociadas.CurrentCell == null)
            {
                MessageBox.Show("Favor selecionar uma matéria para remover a associação!", "Associação de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlCommand sqlComm = new SqlCommand("dbo.sp_RemoverMateriaCurriculo", new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString)))
            {
                if (sqlComm.Connection.State != ConnectionState.Open)
                {
                    sqlComm.Connection.Open();
                }

                try
                {

                    sqlComm.CommandType = CommandType.StoredProcedure;

                    sqlComm.Parameters.AddWithValue("@IdColaborador", this._intIdColaborador);

                    if (this._intIdCurriculo == -1)
                        throw new Exception("Matéria não selecionada!");

                    sqlComm.Parameters.AddWithValue("@IdCurriculo", this._intIdCurriculo);

                    if (this._intIdMateria == -1)
                        throw new Exception("Matéria não selecionada!");

                    sqlComm.Parameters.AddWithValue("@IdMateria", this._intIdMateria);

                    SqlDataReader reader = sqlComm.ExecuteReader();
                    reader.Read();
                    
                    int intStatus = -1;
                    int.TryParse(reader["STATUS"].ToString(), out intStatus);
                    string strMessage = reader["Mensagem"].ToString();

                    if (intStatus == 0)
                        MessageBox.Show("Não foi possível remover a associação dessa matéria pois não foi encontrada no currículo desse colaborador!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (intStatus == 2)
                        MessageBox.Show(strMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        this.RefreshScreen();
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Não foi possível remover a matéria: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvMateriasAssociadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _intIdMateria = -1;
            _intIdCurriculo = -1;

            if (e.RowIndex < 0)
                return;

            dgvMateriasNAssociadas.CurrentCell = null;

            if (this.dgvMateriasAssociadas["coldgvidMateria", e.RowIndex].Value != null)
            {
                int.TryParse(this.dgvMateriasAssociadas["coldgvidMateria", e.RowIndex].Value.ToString(), out _intIdMateria);
                int.TryParse(this.dgvMateriasAssociadas["coldgvidCurriculo", e.RowIndex].Value.ToString(), out _intIdCurriculo);
            }

        }

        private void dgvMateriasNAssociadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            _intIdMateria = -1;

            if (e.RowIndex < 0)
                return;

            dgvMateriasAssociadas.CurrentCell = null;

            if (this.dgvMateriasNAssociadas["coldgvidMateriaN", e.RowIndex].Value != null)
            {
                int.TryParse(this.dgvMateriasNAssociadas["coldgvidMateriaN", e.RowIndex].Value.ToString(), out _intIdMateria);
            }

        }

        private void frmAssociarMateria_Shown(object sender, EventArgs e)
        {
            // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
            this.dgvMateriasAssociadas.CurrentCell = null;
            this.dgvMateriasNAssociadas.CurrentCell = null;
        }

        private void btnAssociarTurma_Click(object sender, EventArgs e)
        {
            frmAssociarTurmas _frmAssociarTurmas = new frmAssociarTurmas();
            _frmAssociarTurmas.ShowDialog();
            //lblTurma.Text = _frmAssociarTurmas.RetornaTurma();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            //frmNotas _frmNotas = new frmNotas(_intIdColaborador, _strNomeColaborador, _strApelidoColaborador);
           // _frmNotas.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

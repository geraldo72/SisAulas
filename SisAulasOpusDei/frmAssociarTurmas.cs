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
    public partial class frmAssociarTurmas: Form
    {
        private int _intIdTurma = -1;
        private int _intIdMateria = -1;
        private string _strNomeMateria = "";
        private string _strTipoMateria = "";
        private string _strNomeTurma = "";
        private string _strAnoMateria = "";
        
        private frmReportAta _frmReportAta;
        //Teste par   
        public frmAssociarTurmas()
        {
            InitializeComponent();
            RefreshScreen(); 
        }

        public frmAssociarTurmas(int intId, string strNome, string strTipo, string anoMat, int idTurma, string strNomeTurma)
        {
            InitializeComponent();

            this._intIdMateria = intId;
            this._strNomeMateria = strNome;
            this._strTipoMateria = strTipo;
            this._strAnoMateria = anoMat;
            this._intIdTurma = idTurma;
            this._strNomeTurma = strNomeTurma;

            this.txtNomeMateria.Text = this._strNomeMateria;
            this.txtNomeTurma.Text = this._strNomeTurma;
            this.txtTipoMateria.Text = this._strTipoMateria;
            this.txtAno.Text = this._strAnoMateria;

            if (idTurma != -1)
            {
                this.txtNomeTurma.Visible = true;
                this.txtMateria.Visible = false;
                this.btnNotas.Enabled = true;
            }
            
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            try
            {
                if (_intIdTurma != -1) {
                    this.sp_SelecionaAlunosTurmaTableAdapter.Fill(this.sisAulasPiteDataSetProcs.sp_SelecionaAlunosTurma, "A", null, _intIdTurma);
                    verificaMateriaEncerrada();
                }
                
                this.sp_SelecionaAlunosTurmaTableAdapter1.Fill(this.sisAulasPiteDataSetProcs1.sp_SelecionaAlunosTurma, "N", _intIdMateria, null);

                //Inicializa rows
                dgvAlunosAssociados.Rows.Clear();
                dgvAlunosNAssociados.Rows.Clear();

                DataRowCollection alunosAssociados = this.sisAulasPiteDataSetProcs.sp_SelecionaAlunosTurma.Rows;
                foreach (DataRow item in alunosAssociados)
                {
                    dgvAlunosAssociados.Rows.Add(item["IdColaborador"], item["strNome"], item["temNota"], item["flgConcluida"], item["IdCurriculo"]);
                }

                DataRowCollection alunosNAssociados = this.sisAulasPiteDataSetProcs1.sp_SelecionaAlunosTurma.Rows;
                foreach(DataRow item in alunosNAssociados){
                    //Somente adiciona se o aluno nao estiver na turma
                    //Ex: aluno concluiu a materia mas nao obteve a nota necessaria, entao ele pode ser adicionado a uma outra turma dessa materia mas nao pode ser à mesma turma
                    if (!alunosAssociados.Contains(item["IdColaborador"]))
                    {
                        dgvAlunosNAssociados.Rows.Add(item["IdColaborador"], item["strNome"], item["temNota"], item["flgConcluida"], item["IdCurriculo"]);
                    }
                }

                this.txtNomeMateria.Text = _strNomeMateria;
                this.txtTipoMateria.Text = _strTipoMateria;

                // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
                this.dgvAlunosAssociados.CurrentCell = null;
                this.dgvAlunosNAssociados.CurrentCell = null;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void verificaMateriaEncerrada()
        {
            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select flgEncerrada from tbTurma where IdTurma = "+this._intIdTurma;
                    
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Se a turma esta encerrada, nao permite mais nenhuma modificacao apenas impressao da ata
                    if ((bool)cmd.ExecuteScalar())
                    {
                        this.btnAssociar.Enabled = false;
                        this.btnRemover.Enabled = false;
                        this.btnConfirmar.Enabled = false;
                        this.btnNotas.Enabled = false;

                        this.btnImprimirAta.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.ToString());
                }
            }
        }

        private void btnAssociar_Click(object sender, EventArgs e)
        {



            if (dgvAlunosNAssociados.SelectedRows.Count < 1)
            {
                MessageBox.Show("Favor selecionar ao menos um aluno para realizar a associação!", "Associação de turma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataGridViewRow[] selectedRows = new DataGridViewRow[dgvAlunosNAssociados.SelectedRows.Count];
            dgvAlunosNAssociados.SelectedRows.CopyTo(selectedRows, 0);
          
            foreach(DataGridViewRow row in selectedRows){
                dgvAlunosNAssociados.Rows.Remove(row);
                dgvAlunosAssociados.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            }
            
            // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
            this.dgvAlunosAssociados.CurrentCell = null;
            this.dgvAlunosNAssociados.CurrentCell = null;


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_intIdMateria == -1 || dgvAlunosAssociados.CurrentCell == null)
            {
                MessageBox.Show("Favor selecionar um aluno para remover a associação!", "Associação de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                
            DataGridViewRow[] selectedRows = new DataGridViewRow[dgvAlunosAssociados.SelectedRows.Count];
            dgvAlunosAssociados.SelectedRows.CopyTo(selectedRows, 0);

            String nomes = "";
            int count = 0;
            foreach (DataGridViewRow row in selectedRows)
            {
                var executa = true;
                if ((bool)row.Cells["flgConcluida1"].Value)
                {
                    nomes += row.Cells["nomeAlunoCol1"].Value +" ";
                    executa = false;
                    count++;
                }
                else
                {
                    if ((bool)row.Cells["temNota1"].Value)
                    {
                        executa = (MessageBox.Show("O aluno '" + row.Cells["nomeAlunoCol1"].Value + "' já possui nota.\nDeseja remover mesmo assim? A nota será removida ao confirmar.", "Confirma Turma", MessageBoxButtons.YesNo) == DialogResult.Yes);
                    }
                }
                
                if (executa) {

                    dgvAlunosAssociados.Rows.Remove(row);

                    dgvAlunosNAssociados.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
                }
            }
            if (!nomes.Equals("")) {
                var msg = "O aluno '" + nomes.ToString() + "' não pode sair da turma pois já concluiu a matéria.";
                if (count > 1)
                {
                    msg = "Os alunos '" + nomes.ToString() + "' não podem sair da turma pois já concluiram a matéria.";
                }
                MessageBox.Show(msg, "Associação de matéria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
            this.dgvAlunosAssociados.CurrentCell = null;
            this.dgvAlunosNAssociados.CurrentCell = null;
            
        }

        private void frmAssociarTurmas_Shown(object sender, EventArgs e)
        {
            // Zerando as colunas do DataGrid para forcar o usuário a selecionar uma linha;
            this.dgvAlunosAssociados.CurrentCell = null;
            this.dgvAlunosNAssociados.CurrentCell = null;
        }

        private void btnAssociarTurma_Click(object sender, EventArgs e)
        {
            frmAssociarTurmas _frmAssociarTurmas = new frmAssociarTurmas();
            _frmAssociarTurmas.ShowDialog();
           // lblAnoMateria.Text = _frmAssociarTurmas.RetornaTurma();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Ao sair desta tela todas alterações serão perdidas, deseja continuar?", "Associar notas", MessageBoxButtons.YesNo) == DialogResult.Yes){

                frmNotas _frmNotas = new frmNotas(_intIdTurma, _strNomeTurma, _strNomeMateria, _strTipoMateria, _strAnoMateria);
                 _frmNotas.ShowDialog();
                 RefreshScreen();
             }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var mensagem = "Deseja incluir a turma?";
            if (this._intIdTurma != -1)
            {
                mensagem = "Deseja alterar a turma?";
            }
            if (MessageBox.Show(mensagem, "Confirma Turma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                using (SqlConnection Conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
                {
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }

                    //Iniciando uma transação
                    SqlTransaction trans = Conn.BeginTransaction("myTransaction");
                    try
                    {
                        
                        //Cria turma
                        var inclusao = _intIdTurma == -1;
                        if (inclusao)
                        {
                            SqlCommand cmd = new SqlCommand("dbo.sp_IncluirTurma", Conn, trans);
                            cmd.Parameters.AddWithValue("@IdMateria", _intIdMateria);
                            if (this.txtMateria.Text == null || this.txtMateria.Text.Trim().Equals(""))
                            {
                                throw new Exception("Favor informar um nome para turma.");
                            }
                            cmd.Parameters.AddWithValue("@NomeTurma", this.txtMateria.Text);
                            cmd.CommandType = CommandType.StoredProcedure;
                            _intIdTurma = (int)cmd.ExecuteScalar();

                        }
                       
                        //Cria registro no curriculo
                        foreach (DataGridViewRow row in this.dgvAlunosAssociados.Rows)
                        {
                            if ((int)row.Cells["idCurriculo1"].Value == -1)
                            {
                                SqlCommand cmd = new SqlCommand("dbo.sp_InserirMateriaCurriculo", Conn, trans);
                                cmd.Parameters.AddWithValue("@IdColaborador", row.Cells["idAlunoCol1"].Value);
                                cmd.Parameters.AddWithValue("@IdTurma", this._intIdTurma);
                                cmd.CommandType = CommandType.StoredProcedure;
                                short intStatus = (short)cmd.ExecuteScalar();

                                if (intStatus == 0)
                                    throw new Exception("Não foi possível associar essa matéria pois já está associada para esse colaborador!");
                            }
                        }
                        foreach (DataGridViewRow row in this.dgvAlunosNAssociados.Rows)
                        {
                            if ((int)row.Cells["idCurriculo"].Value != -1)
                            {
                                SqlCommand cmd = new SqlCommand("dbo.sp_RemoverMateriaCurriculo", Conn, trans);
                                cmd.Parameters.AddWithValue("@IdColaborador", row.Cells["idAlunoCol"].Value);
                                cmd.Parameters.AddWithValue("@IdCurriculo", row.Cells["idCurriculo"].Value);
                                cmd.Parameters.AddWithValue("@IdTurma", this._intIdTurma);
                                cmd.CommandType = CommandType.StoredProcedure;

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int intStatus = -1;
                                        int.TryParse(reader["STATUS"].ToString(), out intStatus);
                                        string strMessage = reader["Mensagem"].ToString();

                                        if (intStatus == 0)
                                            throw new Exception("Não foi possível remover o aluno da turma pois ele não está associado!");
                                        else if (intStatus == 2)
                                            throw new Exception(strMessage);
                                    }
                                    
                                }
                                
                            }
                        }
                       

                        //Confirmando a transação.
                        trans.Commit();
                        if (inclusao)
                            MessageBox.Show("Turma incluida com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Turma altearda com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                       
                        //Reverte a transação (Rollback) se acontecer algum erro na transação
                        trans.Rollback("myTransaction");
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        trans.Dispose();
                        Conn.Close();
                    }
                }

            }

            
        }

        private void dgvAlunosAssociados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAlunosAssociados.Columns[e.ColumnIndex].Name == "temNota1")
            {
                if (this.dgvAlunosAssociados["temNota1", e.RowIndex].Value != null && (bool)this.dgvAlunosAssociados["temNota1", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_optional));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }

            }
            if (dgvAlunosAssociados.Columns[e.ColumnIndex].Name == "flgConcluida1")
            {
                if (this.dgvAlunosAssociados["flgConcluida1", e.RowIndex].Value != null && (bool)this.dgvAlunosAssociados["flgConcluida1", e.RowIndex].Value)
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_optional));
                }
                else
                {
                    e.Value = ((System.Drawing.Image)(Properties.Resources.ico_blank));
                }
            }
        }

        private void btnImprimirAta_Click(object sender, EventArgs e)
        {
            
            _frmReportAta = new frmReportAta(_intIdTurma, _strTipoMateria, _strNomeMateria, _strAnoMateria);
            _frmReportAta.ShowDialog();
        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisAulasOpusDei
{
    public partial class frmAtribuiNota : Form
    {
        private string _id;
        private int _idTurma;

        public frmAtribuiNota()
        {
            InitializeComponent();
            carregaCombos();
        }

        public frmAtribuiNota(string id, string nome, int idTurma, string turma, string materia, string ano, string tipo, string idNota, string nota)
            : this()
        {
            this._id = id;
            this._idTurma = idTurma;
            this.txtNome.Text = nome;
            this.txtTurma.Text = turma;
            this.txtMateria.Text = materia;
            this.txtAno.Text = ano;
            this.txtTipo.Text = tipo;
            this.txtNotaFinal.Text = nota;
            if (!"".Equals(idNota.Trim())) {
                int indexNota = 0;
                if (int.TryParse(idNota.Trim(), out indexNota))
                {
                    this.cbGrauHonra.SelectedIndex = indexNota;
                }
                
            }
        }

        private void carregaCombos()
        {
            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select 0 as IdNota, 'Selecione...' as strNome union " +
                                   "SELECT IdNota, strNome FROM tbNota order by 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbNota");

                    cbGrauHonra.DisplayMember = "strNome";
                    cbGrauHonra.ValueMember = "IdNota";
                    cbGrauHonra.DataSource = ds.Tables["tbNota"];

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.Message.ToString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var conclui = this.chkConcluida.Checked;
            var executa = false;
            //Se for concluir a matéria, exibe mensagem de confirmação
            if (conclui) { 
                var confirmResult = MessageBox.Show("Deseja incluir as notas?\nNão será possivel alterar após essa mensagem.","Confirma Notas",MessageBoxButtons.YesNo);
                executa = confirmResult == DialogResult.Yes;
            }
            else // Se nao, apenas inclui
            {
                executa = true;
            }
            if (executa)
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
                        using( SqlCommand sqlComm = new SqlCommand("dbo.sp_InserirNotaCurriculo", Conn,trans)) {
                        
                            sqlComm.CommandType = CommandType.StoredProcedure;
                        
                            sqlComm.Parameters.AddWithValue("@IdCurriculo", this._id);
                       
                            if ((int)this.cbGrauHonra.SelectedValue  == 0)
                            {
                                throw new Exception("Favor selecionar o grau de honra.");
                            }
                            sqlComm.Parameters.AddWithValue("@IdNota", this.cbGrauHonra.SelectedValue);
                        
                            sqlComm.Parameters.AddWithValue("@Concluida", conclui);

                            if (!",".Equals(this.txtNotaFinal.Text.Trim()))
                            {
                                decimal notaFinal = 0.0M;
                                if (!Decimal.TryParse(this.txtNotaFinal.Text.Trim(), out notaFinal))
                                {
                                    throw new Exception("Favor preencher a nota final com um valor válido.");
                                }
                                if (comparaNotaGrau((int)this.cbGrauHonra.SelectedValue, notaFinal))
                                {
                                    sqlComm.Parameters.AddWithValue("@NotaFinal", notaFinal);
                                }
                                else
                                {
                                    throw new Exception("Nota informada não pertence ao grau de honra.");
                                }

                            }

                            sqlComm.ExecuteScalar();
                        }

                        string mensagem = "Nota incluida com sucesso!";
                        
                        if (conclui)
                        {
                            //Tenta encerrar a turma


                            using (SqlCommand cmd = new SqlCommand("dbo.sp_EncerrarTurma", Conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@IdTurma", _idTurma);
                                cmd.CommandType = CommandType.StoredProcedure;
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                   int intStatus = -1;
                                   do
                                   {
                                       try
                                       {
                                           reader.Read();
                                           int.TryParse(reader["STATUS"].ToString(), out intStatus);

                                           if (intStatus != 99)
                                               mensagem += "\nTurma encerrada!";
                                       }
                                       catch (Exception ex)
                                       {
                                           reader.NextResult();
                                       }

                                   } while (intStatus == -1);


                                    
                                }
                            }
                            
                        }
                        trans.Commit();

                        MessageBox.Show(mensagem, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        // write exception info to log or anything else
                        trans.Rollback("myTransaction");
                        MessageBox.Show("Não foi possível incluir a nota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }finally{
                        
                        trans.Dispose();
                        Conn.Close();
                    }
                }
            }
        }

        private bool comparaNotaGrau(int index, decimal notaFinal)
        {
            switch (index)
            {
                case 1:
                    if (notaFinal.CompareTo(10.0M) > 0 || notaFinal.CompareTo(9.6M) < 0)
                    {
                        return false;
                    }
                    break;
                case 2:
                    if (notaFinal.CompareTo(9.6M) >= 0 || notaFinal.CompareTo(8.6M) < 0)
                    {
                        return false;
                    }
                    break;
                case 3:
                    if (notaFinal.CompareTo(8.6M) >= 0 || notaFinal.CompareTo(7.6M) < 0)
                    {
                        return false;
                    }
                    break;
                case 4:
                    if (notaFinal.CompareTo(7.6M) >= 0 || notaFinal.CompareTo(6.6M) < 0)
                    {
                        return false;
                    }
                    break;
                case 5:
                    if (notaFinal.CompareTo(6.6M) >= 0 || notaFinal.CompareTo(6.0M) < 0)
                    {
                        return false;
                    }
                    break;
                case 6:
                    if (notaFinal.CompareTo(6.0M) >= 0 )
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }
            return true;
        }

    }
}

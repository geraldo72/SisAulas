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
using Microsoft.Office.Interop;
using Microsoft.Office.Core;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;


namespace SisAulasOpusDei
{
    public partial class frmColaboradoresManut : Form
    {
        private int _intIdColaborador = -1;
        private frmAssociarMateria _frmAssociarMateria = null;

        public frmColaboradoresManut()
        {
            InitializeComponent();
            CarregaCombos();
            HabilitaDadosProf();
        }

        public frmColaboradoresManut(int IdColaborador)
        {
            _intIdColaborador = IdColaborador;
            InitializeComponent();
            CarregaCombos();
            HabilitaDadosProf();
        }

        private void CarregaCombos()
        {
            using (SqlConnection conn = new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString))
            {
                try
                {
                    string query = "select 0 as IdTitulo, 'Selecione...' as strTitulo union select IdTitulo, strTitulo from tbTitulo order by 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tbTitulo");

                    cmbTitulo.DisplayMember = "strTitulo";
                    cmbTitulo.ValueMember = "IdTitulo";
                    cmbTitulo.DataSource = ds.Tables["tbTitulo"];

                    //TODO: Verificar o que deve ser inserido no combo Categoria? Vamos utilizar essa informaçào?
                    //cmbCategoria.DisplayMember = "strTitulo";
                    //cmbCategoria.ValueMember = "IdTitulo";
                    //cmbCategoria.DataSource = ds.Tables["tbTitulo"];

                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.Message.ToString());
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlComm = new SqlCommand("dbo.sp_ModificarColaborador", new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString)))
            {
                if (sqlComm.Connection.State != ConnectionState.Open)
                {
                    sqlComm.Connection.Open();
                }

                try
                {
                    sqlComm.CommandType = CommandType.StoredProcedure;

                    if (-1 != _intIdColaborador)
                    {
                        sqlComm.Parameters.AddWithValue("@TipoManutencao", "A");
                        sqlComm.Parameters.AddWithValue("@IdColaborador", _intIdColaborador);
                    }
                    else
                    {
                        sqlComm.Parameters.AddWithValue("@TipoManutencao", "I");
                    }
                    sqlComm.Parameters.AddWithValue("@NomeColaborador", this.txtNomeColaborador.Text);
                    sqlComm.Parameters.AddWithValue("@Sobrenome", this.txtSobrenome.Text);
                    sqlComm.Parameters.AddWithValue("@Apelido", this.txtApelido.Text);
                    sqlComm.Parameters.AddWithValue("@LatimNominativo", this.txtLatimNomi.Text);
                    sqlComm.Parameters.AddWithValue("@LatimAcusativo", this.txtLatimAcusa.Text);
                    if (rbAluna.Checked)
                    {
                        sqlComm.Parameters.AddWithValue("@idTipoColaborador", 1);
                        sqlComm.Parameters.AddWithValue("@idTitulo", null);
                        sqlComm.Parameters.AddWithValue("@DataNomeacao", null);
                    }
                    else if (rbProfessora.Checked)
                    {
                        sqlComm.Parameters.AddWithValue("@idTipoColaborador", 2);
                        if (this.cmbTitulo.SelectedValue != null && !"0".Equals(this.cmbTitulo.SelectedValue.ToString()))
                        {
                            sqlComm.Parameters.AddWithValue("@idTitulo", (int)this.cmbTitulo.SelectedValue);
                        }
                        else
                        {
                            throw new Exception("Favor selecionar um título.");
                        }
                        sqlComm.Parameters.AddWithValue("@DataNomeacao", Convert.ToDateTime( this.txtDataNomeacao.Text.ToString()));
                    }
                    sqlComm.Parameters.AddWithValue("@LocalNascimento", this.txtLocalNasci.Text);
                    sqlComm.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime( this.txtDataNascimento.Text.ToString()));
                    sqlComm.Parameters.AddWithValue("@Categoria", (String)this.cmbCategoria.SelectedItem);
                    sqlComm.Parameters.AddWithValue("@Status", this.rbAtivo.Checked);
                    if (-1 == _intIdColaborador) { 
                        verificaDuplicidade();
                    }

                    SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
                    System.Data.DataTable dt = new System.Data.DataTable();

                    int rowsAffected = sda.Fill(dt);
                    
                    if (-1 != _intIdColaborador)
                    {
                        MessageBox.Show("Colaborador(a) alterado com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Colaborador(a) inserido com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Não foi possível incluir/alterar um colaborador(a): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void verificaDuplicidade()
        {
             using (SqlCommand sqlComm = new SqlCommand("select IdColaborador from tbColaborador where strNome = @Nome and strSobrenome = @Sobrenome and datNascimento = @Nascimento", new SqlConnection(SisAulasOpusDei.Properties.Settings.Default.SisAulasPiteConnectionString)))
            {
                
                    sqlComm.Parameters.AddWithValue("@Nome", this.txtNomeColaborador.Text);
                    sqlComm.Parameters.AddWithValue("@Sobrenome", this.txtSobrenome.Text);
                    sqlComm.Parameters.AddWithValue("@Nascimento", Convert.ToDateTime(this.txtDataNascimento.Text.ToString()));

                    SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
                    System.Data.DataTable dt = new System.Data.DataTable();

                    int rowsAffected = sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        throw new Exception("Já existe um colaborador com estes dados.");
                    }

             }
        }

        private void rbProfessora_CheckedChanged(object sender, EventArgs e)
        {
            HabilitaDadosProf();
        }

        private void HabilitaDadosProf()
        {
            txtDataNomeacao.Enabled = rbProfessora.Checked;
            cmbTitulo.Enabled  = rbProfessora.Checked;
            //Desabilita se for professora
            btnAssociarMaterias.Enabled = !rbProfessora.Checked;
        }

        private void frmColaboradoresManut_Load(object sender, EventArgs e)
        {
            chkMaterias.Visible = true;
            if (_intIdColaborador != -1){
                // TODO: This line of code loads data into the 'sisAulasPiteDataSet.tbColaborador' table. You can move, or remove it, as needed.
                this.tbColaboradorTableAdapter.SelectColaborador(this.sisAulasPiteDataSet.tbColaborador, _intIdColaborador);
                chkMaterias.Visible = false;
            }
        }

        private void rbAluna_CheckedChanged(object sender, EventArgs e)
        {
            rbProfessora.Checked = !rbAluna.Checked;
        }

        private void rbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            rbInativo.Checked = !rbAtivo.Checked;
        }

        private void btnAssociarMaterias_Click(object sender, EventArgs e)
        {
            if (_intIdColaborador != -1)
            {
                _frmAssociarMateria = new frmAssociarMateria(_intIdColaborador, txtNomeColaborador.Text, txtApelido.Text);
                _frmAssociarMateria.ShowDialog();
            }

        }

        private void btnCurriculum_Click(object sender, EventArgs e)
        {

            //Realiza busca das alunas na Procedure
            SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaCurriculo_ParamTableAdapter tableAdapter = new SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaCurriculo_ParamTableAdapter();
            SisAulasPiteDataSetProcs.sp_SelecionaCurriculo_ParamDataTable materiasDataTable = new SisAulasPiteDataSetProcs.sp_SelecionaCurriculo_ParamDataTable();
            tableAdapter.Fill(materiasDataTable, _intIdColaborador);

            saveCurriculo.FileName = "Curriculo" + txtNomeColaborador.Text;
            if (saveCurriculo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strSalvarComo = saveCurriculo.FileName.ToString();
                string fileName = criaArquivoTemporario(Properties.Resources.CurriculoPadrao);
                this.GerarCurriculo(fileName, strSalvarComo, materiasDataTable);
                removeArquivoTemporario(fileName);
            }
        }

        private string criaArquivoTemporario(byte[] fileAsByteArray)
        {
            // TODO: comentar endereço fixo e deixar o caminho relativo ao projeto
            //string nome = "ata.docx";
            string nome = "C:/SisAulas/Documentos/Temp/CurriculoPadrao.docx";
            FileStream stream = new FileStream(nome, FileMode.Create, FileAccess.Write);

            stream.Write(fileAsByteArray, 0, fileAsByteArray.Length);
            stream.Close();
            stream.Dispose();

            return nome;

        }
        private void removeArquivoTemporario(string nome)
        {
            if (File.Exists(nome))
            {
                File.Delete(nome);
            }

        }

        private void GerarCurriculo(object FileName, object saveAs, SisAulasPiteDataSetProcs.sp_SelecionaCurriculo_ParamDataTable objCurriculoDataTable)
        {

            object Missing = System.Reflection.Missing.Value;
            int qtdDiffRodapes = Math.Abs(Utils.Curriculo.linhasRodape - Utils.Curriculo.linhasRodapePagina); //+ lstProfessores.SelectedItems.Count;
            bool temPagina = false;

            Microsoft.Office.Interop.Word.Application objDocApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document objDocAta = null;
            try
            {
                if (File.Exists((string)FileName))
                {
                    object readOnly = false;
                    object isVisible = false;

                    //Abre o documento
                    objDocAta = objDocApp.Documents.Open(ref FileName, ref Missing, ref readOnly, ref Missing, ref Missing,
                                                         ref Missing, ref Missing, ref Missing, ref Missing, ref Missing,
                                                         ref Missing, ref isVisible, ref Missing, ref Missing, ref Missing, ref Missing);

                    //Ativa o documento
                    objDocAta.Activate();

                    //Salva o documento como novo (para nao alterar o documento base)
                    objDocAta.SaveAs2(ref saveAs, ref Missing, ref Missing, ref Missing, ref Missing,
                                        ref Missing, ref Missing, ref Missing, ref Missing, ref Missing,
                                        ref Missing, ref Missing, ref Missing, ref Missing, ref Missing, ref Missing);


                    //Constantes para navegar no documento
                    object whatline = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToLine;
                    object whitchLineFirst = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToFirst;

                    //Preenche os dados da matéria
                    this.FindAndReplace(objDocApp, "<NOME>", txtNomeColaborador.Text);
                    this.FindAndReplace(objDocApp, "<CIDADENASC>", txtLocalNasci.Text);
                    //<PAÍSNASC> --> falta
                    this.FindAndReplace(objDocApp, "<DIANASC>", DateTime.Parse(txtDataNascimento.Text).Day);
                    this.FindAndReplace(objDocApp, "<MESNASC>", Utils.Meses.get((DateTime.Parse(txtDataNascimento.Text).Month)).ToString(Utils.Meses.LATIM));
                    this.FindAndReplace(objDocApp, "<ANONASC>", DateTime.Parse(txtDataNascimento.Text).Year);

                    //Preenche a data
                    this.FindAndReplace(objDocApp, "<DIA>", DateTime.Now.Day);
                    this.FindAndReplace(objDocApp, "<MES>", Utils.Meses.get(DateTime.Now.Month).ToString(Utils.Meses.LATIM));
                    this.FindAndReplace(objDocApp, "<ANO>", DateTime.Now.Year);

                    //Range da rodapé
                    Microsoft.Office.Interop.Word.Range rodapeRange = objDocAta.GoTo(whatline, whitchLineFirst, 30, Missing);

                    //Range da linha antes do tribunal
                    Microsoft.Office.Interop.Word.Range linhaRange = objDocAta.GoTo(whatline, whitchLineFirst, 19, Missing);


                    //Seta o cursor na linha dos professores
                    /*Microsoft.Office.Interop.Word.Range professoresRange = objDocAta.GoTo(whatline, whitchLineFirst, 24, Missing);
                    professoresRange.Tables.Add(professoresRange, lstProfessores.SelectedItems.Count, 2, Missing, Missing);
                    Microsoft.Office.Interop.Word.Table tblProfessores = professoresRange.Tables[1];
                    tblProfessores.Range.Font.Size = 12;
                    tblProfessores.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                    tblProfessores.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                    tblProfessores.Columns[1].SetWidth(170, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustFirstColumn);
                    
                    int count = 1;
                    foreach (DataRowView professor in lstProfessores.SelectedItems)
                    {
                        tblProfessores.Cell(count, 2).Range.Text = professor["strNomeProfessor"].ToString();
                        count++;
                    }

                    //Seta o cursor na linha dos alunos
                    Microsoft.Office.Interop.Word.Range alunosRange = objDocAta.GoTo(whatline, whitchLineFirst, 18, Missing);
                    //Cria a tabela para inserir os alunos
                    //alunosRange.Tables.Add(alunosRange, alunosDataTable.Count, 2, Missing, Missing);
                    Microsoft.Office.Interop.Word.Table tblAlunos = alunosRange.Tables[1];
                    tblAlunos.Range.Font.Size = 12;
                    tblAlunos.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                    tblAlunos.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                    tblAlunos.Columns[1].SetWidth(350, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustFirstColumn);
                    */
                    //Contador para quebra de pagina
                    int quebraPagina = Utils.Ata.qtdAlunosPrimeiraPg;
                    //Contador de linhas
                    int count = 1;
                    int countOpcional = 1;
                    foreach (SisAulasPiteDataSetProcs.sp_SelecionaCurriculo_ParamRow materia in objCurriculoDataTable)
                    {

                        if (materia.Opcional)
                        {
                            if (countOpcional != 3)
                            {
                                this.FindAndReplace(objDocApp, "<Philo1Option" + countOpcional.ToString() + ">", materia.strNomeMateria);
                                this.FindAndReplace(objDocApp, "<NotaDescPhilo1opt" + countOpcional.ToString() + ">", ReplaceDBNull(materia["strNomeNota"]));
                                this.FindAndReplace(objDocApp, "<NotaValPhilo1opt" + countOpcional.ToString() + ">", ReplaceDBNull(materia["dcNotaFinal"]));
                            }
                            else
                            {
                                countOpcional = 1;

                                this.FindAndReplace(objDocApp, "<Philo2Option" + countOpcional.ToString() + ">", materia.strNomeMateria);
                                this.FindAndReplace(objDocApp, "<NotaDescPhilo2opt" + countOpcional.ToString() + ">", ReplaceDBNull(materia["strNomeNota"]));
                                this.FindAndReplace(objDocApp, "<NotaValPhilo2opt" + countOpcional.ToString() + ">", ReplaceDBNull(materia["dcNotaFinal"]));
                            }

                            countOpcional++;

                        }

                        this.FindAndReplace(objDocApp, "<Notadesc1>", ReplaceDBNull(materia["strNomeNota"]));
                        this.FindAndReplace(objDocApp, "<NOTAValor1>", ReplaceDBNull(materia["dcNotaFinal"]));


                        //Diminui o contador de quebra de pagina
                        quebraPagina--;
                        //Aumenta o contador de linhas
                        count++;

                        ////Se o contador de quebra estiver zerado, inclui o rodape de pagina
                        //if (quebraPagina == 0)
                        //{
                        //    temPagina = true;
                        //    //Seta o valor para o numero de linhas por pagina
                        //    quebraPagina = Utils.Ata.qtdAlunosPagina;
                        //    //se o contador de linhas for maior que o numero de registros, atribui -1 para incluir o rodape na ultima linha
                        //    if (count > objCurriculoDataTable.Count)
                        //    {
                        //        count = -1;
                        //    }
                        //    count = insereRodapePagina(Missing, tblAlunos, count);

                        //}

                    }
                    //Se as linhas faltantes for menor que as linhas para o rodape, joga o rodapé para baixo.
                    //if (quebraPagina < qtdDiffRodapes)
                    //{
                    //    temPagina = true;
                    //    //Empurra o rodape para proxima pagina
                    //    for (int i = 0; i < quebraPagina; i++)
                    //    {
                    //        tblAlunos.Rows.Add();
                    //    }
                    //    //Insere o rodapé de pagina
                    //    insereRodapePagina(Missing, tblAlunos, -1);

                    //    //Remove linha antes do tribunal
                    //    linhaRange.Rows.Delete();

                    //}
                    //else if (quebraPagina == Utils.Ata.qtdAlunosPagina)
                    //{
                    //    //Remove linha antes do tribunal
                    //    linhaRange.Rows.Delete();
                    //}

                    ////Remove ultimo rodape 
                    //if (temPagina)
                    //{
                    //    rodapeRange.Rows.Delete();
                    //}
                    //else//Empurra o rodape para ultima linha
                    //{
                    //    int qtdLinhas = 23 - objCurriculoDataTable.Count;
                    //    for (int i = 0; i < qtdLinhas; i++)
                    //    {
                    //        rodapeRange.Rows.Add(rodapeRange.Rows[1]);
                    //    }

                    //}

                    this.FindAndReplace(objDocApp, "<USUARIO>", "Luciana Ansanelli");

                    // Limpando informações

                    this.FindAndReplace(objDocApp, "<Philo1Option1>", "");
                    this.FindAndReplace(objDocApp, "<NotaDescPhilo1opt1>", "");
                    this.FindAndReplace(objDocApp, "<NotaValPhilo1opt1>", "");

                    this.FindAndReplace(objDocApp, "<Philo1Option2>", "");
                    this.FindAndReplace(objDocApp, "<NotaDescPhilo1opt2>", "");
                    this.FindAndReplace(objDocApp, "<NotaValPhilo1opt2>", "");

                    this.FindAndReplace(objDocApp, "<Philo2Option1>", "");
                    this.FindAndReplace(objDocApp, "<NotaDescPhilo2opt1>", "");
                    this.FindAndReplace(objDocApp, "<NotaValPhilo2opt1>", "");


                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!", "Imprimir Curriculo", MessageBoxButtons.OK);
                    return;
                }


                objDocAta.Save();

                MessageBox.Show("Curriculo gerado com sucesso!!", "Imprimir Curriculo", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "Imprimir Curriculo", MessageBoxButtons.OK);
            }
            finally
            {
                objDocAta.Close(ref Missing, ref Missing, ref Missing);
            }
        }

        private static int insereRodapePagina(object Missing, Microsoft.Office.Interop.Word.Table tbl, int count)
        {
            object row;
            if (count == -1)
            {
                row = Missing;
            }
            else
            {
                row = tbl.Rows[count];
            }

            //pula uma linhas
            row = tbl.Rows.Add(row);
            count++;

            Microsoft.Office.Interop.Word.Row rodape = tbl.Rows.Add(row);
            rodape.Range.Font.Position = 1;
            rodape.Cells[1].Range.Text = "Reg. Bf  lib  II  pag. 37 n. 25";
            rodape.Cells[2].Range.Text = "(N 23/13)";
            rodape.Cells[2].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            count++;
            //pula duas linhas
            rodape = tbl.Rows.Add(rodape);
            count++;
            rodape = tbl.Rows.Add(rodape);
            count++;

            Microsoft.Office.Interop.Word.Row pagina = tbl.Rows.Add(rodape);
            pagina.Cells.Merge();
            pagina.Range.Text = "(.../...)";
            pagina.Range.Font.Position = 1;
            pagina.Cells[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
            count++;
            //pula uma linhas
            pagina = tbl.Rows.Add(pagina);
            count++;


            Microsoft.Office.Interop.Word.Row quebraPg = tbl.Rows.Add(pagina);
            quebraPg.Cells.Merge();
            quebraPg.Range.Text = "______________________________________________________";
            quebraPg.Range.Font.Position = 1;
            quebraPg.Cells[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            count++;


            return count;
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application objWordApp,
                                      object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object nmatchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            if (replaceWithText == DBNull.Value)
                replaceWithText = "------------------";


            objWordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                 ref matchWildCards, ref matchSoundsLike, ref nmatchAllWordForms, ref forward,
                 ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida,
                 ref matchDiacritics, ref matchAlefHamza, ref matchControl);

        }

        private string ReplaceDBNull(object findText)
        {
            if (findText == DBNull.Value)
                return "----------------";
            else
                return findText.ToString();
        }
    }
}

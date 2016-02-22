using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Core;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;

namespace SisAulasOpusDei
{
    public partial class frmReportAta : Form
    {
        int _idTurma;
        string _tpMateria;
        string _nomeMateria;
        string _anoMateria;

        public frmReportAta()
        {
            this._idTurma = 1;
            this._tpMateria = "teologia";
            this._nomeMateria = "teste";
            this._anoMateria = "I";
            InitializeComponent();
        }

        public frmReportAta(int idTurma,string tpMateria, string nomeMateria, string anoMateria)
        {
            this._idTurma = idTurma;
            this._tpMateria = tpMateria;
            this._nomeMateria = nomeMateria;
            this._anoMateria = anoMateria;
            InitializeComponent();
        }

        private void frmReportAta_Load(object sender, EventArgs e)
        {
            if (-1 != _idTurma)
            {
                SisAulasPiteDataSetTableAdapters.tbColaboradorTableAdapter tableAdapter = new SisAulasPiteDataSetTableAdapters.tbColaboradorTableAdapter();
                SisAulasPiteDataSet.tbColaboradorDataTable professoresDataTable = new SisAulasPiteDataSet.tbColaboradorDataTable();
                tableAdapter.Fill(professoresDataTable);

                if (professoresDataTable.Count <= 0)
                {
                    MessageBox.Show("Não existem professoras para gerar a Ata!", "Imprimir Ata", MessageBoxButtons.OK);
                    this.Close();
                    return;
                }
                else
                {
                    SisAulasPiteDataSet.tbColaboradorRow row = professoresDataTable.NewtbColaboradorRow();
                    row.strLatimNominativo = "Selecione";
                    row.strNome = "";
                    row.strSobrenome = "";
                    row.fkIdTipoColaborador = 2;
                    row.flgStatus = true;
                    row.datInsercao = new DateTime();
                    professoresDataTable.Rows.InsertAt(row, 1);
                }

                cmbProfessor1.DisplayMember = "strLatimNominativo";
                cmbProfessor1.ValueMember = "IdColaborador";
                cmbProfessor1.DataSource = new DataView(professoresDataTable, "flgStatus = 1 and fkIdTipoColaborador = 2", "IdColaborador Asc", DataViewRowState.CurrentRows);

                cmbProfessor2.DisplayMember = "strLatimNominativo";
                cmbProfessor2.ValueMember = "IdColaborador";
                cmbProfessor2.DataSource = new DataView(professoresDataTable, "flgStatus = 1 and fkIdTipoColaborador = 2", "IdColaborador Asc", DataViewRowState.CurrentRows);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)cmbProfessor1.SelectedValue == -1 || (int)cmbProfessor2.SelectedValue == -1)
            {
                MessageBox.Show("Favor selecione os dois Professores", "Imprimir Ata", MessageBoxButtons.OK);
                return;
            }
            //Realiza busca das alunas na Procedure
            SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosAtaTableAdapter tableAdapter = new SisAulasPiteDataSetProcsTableAdapters.sp_SelecionaAlunosAtaTableAdapter();
            SisAulasPiteDataSetProcs.sp_SelecionaAlunosAtaDataTable alunosDataTable = new SisAulasPiteDataSetProcs.sp_SelecionaAlunosAtaDataTable();
            tableAdapter.Fill(alunosDataTable, _idTurma, 1, true);

            if (alunosDataTable.Count > 0)
            {
                saveFileDialog.FileName = "Ata" + _nomeMateria;
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string strSalvarComo = saveFileDialog.FileName.ToString();
                    string fileName = criaArquivoTemporario(Properties.Resources.ata);
                    this.AtualizaDadosAta(fileName, strSalvarComo, alunosDataTable);
                    removeArquivoTemporario(fileName);
                }
            }
            else
            {
                MessageBox.Show("Não existem aluno(a)s para gerar a Ata!", "Imprimir Ata", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private string criaArquivoTemporario(byte[] fileAsByteArray)
        {
            // TODO: comentar endereço fixo e deixar o caminho relativo ao projeto
            //string nome = "ata.docx";
            string nome = "C:/SisAulas/Documentos/Temp/ata.docx";
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

        private void AtualizaDadosAta(object FileName, object saveAs, SisAulasPiteDataSetProcs.sp_SelecionaAlunosAtaDataTable alunosDataTable)
        {

            object Missing = System.Reflection.Missing.Value;
            int qtdDiffRodapes = Math.Abs(Utils.Ata.linhasRodape - Utils.Ata.linhasRodapePagina) + 2;
            bool temPagina = false;

            Microsoft.Office.Interop.Word.Application objDocApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document objDocAta = null;
            try
            {
                if ( File.Exists((string) FileName))
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
                    this.FindAndReplace(objDocApp, "<TIPO_MATERIA>", Utils.TipoMateriaToLatin(_tpMateria));
                    this.FindAndReplace(objDocApp, "<ANO_MAT>", _anoMateria);
                    this.FindAndReplace(objDocApp, "<NOME_MATERIA>", _nomeMateria);
                   
                    //Preenche a data
                    this.FindAndReplace(objDocApp, "<DIA>", DateTime.Now.Day);
                    this.FindAndReplace(objDocApp, "<MES>", Utils.Meses.get(DateTime.Now.Month).ToString(Utils.Meses.LATIM));
                    this.FindAndReplace(objDocApp, "<ANO>", DateTime.Now.Year);

                    //Range da rodapé
                    Microsoft.Office.Interop.Word.Range rodapeRange = objDocAta.GoTo(whatline, whitchLineFirst, 30, Missing);

                    //Range da linha antes do tribunal
                    Microsoft.Office.Interop.Word.Range linhaRange = objDocAta.GoTo(whatline, whitchLineFirst, 19, Missing);


                    //Seta o cursor na linha dos professores
                    Microsoft.Office.Interop.Word.Range professoresRange = objDocAta.GoTo(whatline, whitchLineFirst, 24, Missing);
                    professoresRange.Tables.Add(professoresRange, 2, 2, Missing, Missing);
                    Microsoft.Office.Interop.Word.Table tblProfessores = professoresRange.Tables[1];
                    tblProfessores.Range.Font.Size = 12;
                    tblProfessores.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                    tblProfessores.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                    tblProfessores.Columns[1].SetWidth(170, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustFirstColumn);

                    
                    tblProfessores.Cell(1, 2).Range.Text = cmbProfessor1.Text;
                    tblProfessores.Cell(2, 2).Range.Text = cmbProfessor2.Text;
                    
                    
                    //Seta o cursor na linha dos alunos
                    Microsoft.Office.Interop.Word.Range alunosRange = objDocAta.GoTo(whatline, whitchLineFirst, 18, Missing);
                    //Cria a tabela para inserir os alunos
                    alunosRange.Tables.Add(alunosRange, alunosDataTable.Count, 2, Missing, Missing);
                    Microsoft.Office.Interop.Word.Table tblAlunos = alunosRange.Tables[1];
                    tblAlunos.Range.Font.Size = 12;
                    tblAlunos.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                    tblAlunos.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdAuto;
                    tblAlunos.Columns[1].SetWidth(350, Microsoft.Office.Interop.Word.WdRulerStyle.wdAdjustFirstColumn);

                    //Contador para quebra de pagina
                    int quebraPagina = Utils.Ata.qtdAlunosPrimeiraPg;
                    //Contador de linhas
                    int count = 1;
                    foreach (SisAulasPiteDataSetProcs.sp_SelecionaAlunosAtaRow aluno in alunosDataTable)
                    {
                        //Preenche os valores dos alunos
                        tblAlunos.Cell(count,1).Range.Text = aluno.strSobrenome.ToUpper() + ", " + aluno.strNome ;
                        tblAlunos.Cell(count,2).Range.Text = aluno.strNomeNota;
                        //Diminui o contador de quebra de pagina
                        quebraPagina--;
                        //Aumenta o contador de linhas
                        count++;

                        //Se o contador de quebra estiver zerado, inclui o rodape de pagina
                        if (quebraPagina == 0)
                        {
                            temPagina = true;
                            //Seta o valor para o numero de linhas por pagina
                            quebraPagina = Utils.Ata.qtdAlunosPagina;
                            //se o contador de linhas for maior que o numero de registros, atribui -1 para incluir o rodape na ultima linha
                            if (count > alunosDataTable.Count)
                            {
                                count = -1;
                            }
                            count = insereRodapePagina(Missing, tblAlunos, count);

                        }

                    }
                    //Se as linhas faltantes for menor que as linhas para o rodape, joga o rodapé para baixo.
                    if (quebraPagina < qtdDiffRodapes)
                    {
                        temPagina = true;
                        //Empurra o rodape para proxima pagina
                        for (int i = 0; i < quebraPagina; i++)
                        {
                            tblAlunos.Rows.Add();
                        }
                        //Insere o rodapé de pagina
                        insereRodapePagina(Missing, tblAlunos, -1);

                        //Remove linha antes do tribunal
                        linhaRange.Rows.Delete();

                    }
                    else if (quebraPagina == Utils.Ata.qtdAlunosPagina)
                    {
                        //Remove linha antes do tribunal
                        linhaRange.Rows.Delete();
                    }
                    
                    //Remove ultimo rodape 
                    if (temPagina)
                    {
                        rodapeRange.Rows.Delete();
                    }
                    else//Empurra o rodape para ultima linha
                    {
                        int qtdLinhas = 23 - alunosDataTable.Count;
                        for (int i = 0; i < qtdLinhas; i++)
                        {
                            rodapeRange.Rows.Add(rodapeRange.Rows[1]);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!", "Imprimir Ata", MessageBoxButtons.OK);
                    return;
                }


                objDocAta.Save();

                MessageBox.Show("Ata gerada com sucesso!!", "Imprimir Ata", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: "+ex.Message, "Imprimir Ata", MessageBoxButtons.OK);
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

        private void FindAndReplace ( Microsoft.Office.Interop.Word.Application objWordApp,
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

            objWordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                 ref matchWildCards, ref matchSoundsLike, ref nmatchAllWordForms, ref forward,
                 ref wrap, ref format, ref replaceWithText, ref replace, ref matchKashida,
                 ref matchDiacritics, ref matchAlefHamza, ref matchControl);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProfessor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfessor1.Focused && (int)cmbProfessor1.SelectedValue != -1)
            {
                DataView dv = (DataView)cmbProfessor2.DataSource;
                //cmbProfessor2.DataSource = new DataView(dv.Table,  "flgStatus = 1 and fkIdTipoColaborador = 2 and IdColaborador not in ("+ cmbProfessor1.SelectedValue+")", "IdColaborador Asc", DataViewRowState.CurrentRows);
                dv.RowFilter = "flgStatus = 1 and fkIdTipoColaborador = 2 and IdColaborador not in (" + cmbProfessor1.SelectedValue + ")";
            }
            else
            {
                DataView dv = (DataView)cmbProfessor2.DataSource;
                if (dv != null)
                {
                    dv.RowFilter = "flgStatus = 1 and fkIdTipoColaborador = 2";
                }
                
            }
            
        }

        private void cmbProfessor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfessor2.Focused && (int)cmbProfessor2.SelectedValue != -1)
            {
                DataView dv = (DataView)cmbProfessor1.DataSource;
                //cmbProfessor2.DataSource = new DataView(dv.Table,  "flgStatus = 1 and fkIdTipoColaborador = 2 and IdColaborador not in ("+ cmbProfessor1.SelectedValue+")", "IdColaborador Asc", DataViewRowState.CurrentRows);
                dv.RowFilter = "flgStatus = 1 and fkIdTipoColaborador = 2 and IdColaborador not in (" + cmbProfessor2.SelectedValue + ")";
            }
            else
            {
                DataView dv = (DataView)cmbProfessor1.DataSource;
                if (dv != null)
                {
                    dv.RowFilter = "flgStatus = 1 and fkIdTipoColaborador = 2";
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}

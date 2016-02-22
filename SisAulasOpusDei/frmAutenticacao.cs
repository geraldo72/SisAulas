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
    public partial class frmAutenticacao : Form
    {
        public frmAutenticacao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if ( txtUsuario.Text.Trim() == "" || txtSenha.Text.Trim() == ""){
                MessageBox.Show("Favor, preencher os campos de Usuário e Senha antes de acessar o sistema!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DataRow[] res = this.sisAulasPiteDataSet.tbAutenticacao.Select("strUsuario like '" + txtUsuario.Text.Trim() + "' and strSenha = '" + txtSenha.Text.Trim() + "'");
               //DataRow[] res = this.sisAulasPiteDataSet.tbAutenticacao.Select("");
               if (res.Length > 0)
                {
                   MessageBox.Show("Bem vindo(a), " + res[0]["strUsuario"]);
                   DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Usuário/Senha inválido");
                }
            }
        }
        
        private void tbAutenticacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbAutenticacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sisAulasPiteDataSet);

        }


        private void frmAutenticacao_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sisAulasPiteDataSet.tbAutenticacao' table. You can move, or remove it, as needed.
            this.tbAutenticacaoTableAdapter.Fill(this.sisAulasPiteDataSet.tbAutenticacao);

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnEntrar_Click(sender,e);
            }

        }

    }
}

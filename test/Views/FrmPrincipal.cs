using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Classes;
using test.Views;
using test.Views.Cadastros;

namespace test
{
    public partial class FrmPrincipal : Form
    {
        FrmCadastroClientes frmClientes;
        FrmCadastroUsuarios frmUsuarios;
        FrmCadastroFichas frmFichas;
        private Interfaces aInter;

        public FrmPrincipal()
        {
            InitializeComponent();

            aInter = new Interfaces();
        }

        // Cadastros
        private void toolCadUsuarios_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuarios frm = new FrmCadastroUsuarios();
            frm.ShowDialog();
        }

        private void toolCadClientes_Click(object sender, EventArgs e)
        {
            FrmCadastroClientes frm = new FrmCadastroClientes();
            frm.ShowDialog();
        }

        private void toolCadFichas_Click(object sender, EventArgs e)
        {
            FrmCadastroFichas frm = new FrmCadastroFichas();
            frm.ShowDialog();
        }

        // Consultas
        private void toolUsuarios_Click(object sender, EventArgs e)
        {
            aInter.pecaForm(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)); // Consultar Usuários TAG 0
        }

        private void toolClientes_Click(object sender, EventArgs e)
        {
            aInter.pecaForm(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)); // Consultar Clientes TAG 1
        }

        private void toolFichas_Click(object sender, EventArgs e)
        {
            aInter.pecaForm(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)); // Consultar Fichas TAG 2
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}

using CrystalDecisions.ReportAppServer.DataDefModel;
using Microsoft.Reporting.WinForms;
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
using test.Controllers;
using test.Model;
using test.Views;
using test.Views.Cadastros;
using test.Views.Consultas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle.Views.Relatorios.Forms
{
    public partial class FrmRelatoriosPai : FrmPai
    {
        public FrmRelatoriosPai()
        {
            InitializeComponent();
        }
        protected virtual void GerarRelatorio()
        {

        }
       
        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private void btnPatrimonios_Click(object sender, EventArgs e)
        {
            FrmRelPatrimonios frm = new FrmRelPatrimonios();
            frm.ShowDialog();
        }
    }
}

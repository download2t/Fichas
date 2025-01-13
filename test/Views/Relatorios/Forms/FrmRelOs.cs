using Controle.Views.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle.Views.Relatorios.Forms
{
    public partial class FrmRelOs : Controle.Views.Relatorios.Forms.FrmRelatoriosPai
    {

        FrmConsultaOrdemDeServico oFrmConsultaOs;
        public FrmRelOs()
        {
            InitializeComponent();
            oFrmConsultaOs = new FrmConsultaOrdemDeServico();
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

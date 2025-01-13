using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle.Views.Relatorios
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent(); 
            this.SizeChanged += new EventHandler(Relatorios_SizeChanged);
        }
        private void Relatorios_SizeChanged(object sender, EventArgs e)
        {
            CentralizarReportViewer();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        private void CentralizarReportViewer()
        {
            // Centraliza o ReportViewer no formulário
            reportViewer1.Left = (this.ClientSize.Width - reportViewer1.Width) / 2;
            reportViewer1.Top = (this.ClientSize.Height - reportViewer1.Height) / 2;
        }

        private void FrmRelatorio_SizeChanged(object sender, EventArgs e)
        {
            CentralizarReportViewer();
        }
    }
}

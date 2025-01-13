using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace test.Views.Cadastros
{
    public partial class FrmCadastro : test.Views.FrmPai
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        protected virtual void Verificar()
        {

        }        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Verificar();
        }
    }
}

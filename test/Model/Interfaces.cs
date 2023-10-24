using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Views;
using test.Views.Cadastros;
using test.Views.Consultas;

namespace test.Classes
{
    class Interfaces
    {
        // Cadastros
        FrmCadastroUsuarios oFormCadUsuarios;
        FrmCadastroClientes oFormCadClientes;
        FrmCadastroFichas oFormCadFichas;

        // Consultas
        FrmConsultaUsuarios oFormConsUsuarios;
        FrmConsultaClientes oFormConsClientes;
        FrmConsultaFichas oFormConsFichas;


        // Classes
        Usuarios oUsuarios;
        Clientes oCliente;
        Fichas aFicha;

        public Interfaces()
        {
            //Classes
            oUsuarios = new Usuarios();
            oCliente = new Clientes();
            aFicha = new Fichas();
            
            //Cadastros
            oFormCadUsuarios = new FrmCadastroUsuarios();
            oFormCadClientes = new FrmCadastroClientes();
            oFormCadFichas = new FrmCadastroFichas();

            //Consultas
            oFormConsUsuarios = new FrmConsultaUsuarios();
            oFormConsClientes = new FrmConsultaClientes();
            oFormConsFichas = new FrmConsultaFichas();

            //Metodos
            oFormConsUsuarios.SetFrmCadastro(oFormCadUsuarios);
            oFormConsClientes.SetFrmCadastro(oFormCadClientes);
            oFormConsFichas.SetFrmCadastro(oFormCadFichas);

            oFormCadFichas.SetConsultaClientes(oFormConsClientes);

        }
        public void pecaForm(int id)
        {
            void PecaFormulario(Form mostra, object consultado)
            {
                if (mostra is FrmConsulta consulta)
                {
                    consulta.ConhecaObj(consultado);
                    consulta.ShowDialog();
                }
            }

            switch (id)
            {
                case 0: PecaFormulario(oFormConsUsuarios, oUsuarios); break;
                case 1: PecaFormulario(oFormConsClientes, oCliente); break;
                case 2: PecaFormulario(oFormConsFichas, aFicha); break;
            }
        }
    }
}

using Controle.Model;
using Controle.Views;
using Controle.Views.Cadastros;
using Controle.Views.Consultas;
using Controle.Views.Relatorios.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using test.Controllers;
using test.DAL;
using test.Data;
using test.Model;
using test.Views;
using test.Views.Cadastros;
using test.Views.Consultas;
using test.Views.Painel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test.Classes
{
    class Interfaces
    {
        private AuthContext authContext;
        // Cadastros
        FrmCadastroUsuarios oFormCadUsuarios;
        FrmCadastroClientes oFormCadClientes;
        FrmCadastroFichas oFormCadFichas;
        FrmCadastroCategoria oFormCadCategoria;
        FrmCadastroSubCategoria oFormCadCategoriaSub;
        FrmCadastroSetores oFormCadSetores;
        FrmCadastroPatrimonios oFormCadPatrimonios;
        FrmCadastroManutencao oFormCadManutencao;
        FrmCadastroSenhas oFormCadSenha;
        FrmCadastroMensagens oFormCadMensagem;
        FrmCadastroContatos oFormCadContatos;
        FrmCadastroControleGov oFormCadControleGov;
        FrmCadastroFuncionarios oFormCadFuncionarios;
        FrmCadastroCofres oFormCadCofres;
        FrmCadastroCargos oFormCadCargos;
        FrmCadastroOrdemDeServico oFormCadOS;


        // Consultas
        FrmConsultaUsuarios oFormConsUsuarios;
        FrmConsultaClientes oFormConsClientes;
        FrmConsultaFichas oFormConsFichas;
        FrmConsultaCategorias oFormConsCategorias;
        FrmConsultaSubCategorias oFormConsSubCategorias;
        FrmConsultaSetores oFormConsSetores;
        FrmConsultaPatrimonios oFormConsPatrimonios;
        FrmConsultaBaixaPatrimonios oFormConsBaixasPatrimonios;
        FrmConsultaManutencao oFormConsManutencao;
        FrmConsultaCategoriaSenhas oFormConsCategoriaSenhas;
        FrmConsultaSenhas oFormConsSenhas;
        FrmConsultaMensagens oFormConsMensagens;
        FrmConsultaContatos oFormConsContatos;
        FrmRelPatrimonios oFormRelPatrimonios;
        FrmRelManutencao oFormRelManutencao;
        FrmConsultaControleGov oFormConsControleGov;
        FrmConsultaFuncionarios oFormConsFuncionarios;
        FrmConsultaControleGovFunc oFormConsControleGovFunc;
        FrmConsultaCofres oFormConsCofres;
        FrmConsultaCargos oFormConsCargos;
        FrmConsultaOrdemDeServico oFormConsOS;



        // Classes
        Usuarios oUsuarios;
        Clientes oCliente;
        Fichas aFicha;
        Categoria aCategoria;
        Subcategoria aSubcategoria;
        Setores oSetor;
        Patrimonios oPatrimonio;
        Manutencao aManutencao;
        Senhas aSenha;
        Mensagens aMensagem;
        Contatos oContato;
        ControleGov aControleGov;
        Funcionario oFuncionario;
        Cofres oCofre;
        Cargo oCargo;
        OrdemDeServico aOS;

        public Interfaces()
        {
            //Classes
            oUsuarios = new Usuarios();
            oCliente = new Clientes();
            aFicha = new Fichas();
            aCategoria = new Categoria();
            aSubcategoria = new Subcategoria();
            oSetor = new Setores();
            oPatrimonio = new Patrimonios();
            aManutencao = new Manutencao();
            aSenha = new Senhas();
            aMensagem = new Mensagens();
            oContato = new Contatos();
            aControleGov = new ControleGov();
            oFuncionario = new Funcionario();
            oCofre = new Cofres();
            oCargo = new Cargo();
            aOS = new OrdemDeServico();

            //Cadastros
            oFormCadUsuarios = new FrmCadastroUsuarios();
            oFormCadClientes = new FrmCadastroClientes();
            oFormCadFichas = new FrmCadastroFichas();
            oFormCadCategoria = new FrmCadastroCategoria();
            oFormCadCategoriaSub = new FrmCadastroSubCategoria();
            oFormConsCategorias = new FrmConsultaCategorias();
            oFormCadSetores = new FrmCadastroSetores();
            oFormCadPatrimonios = new FrmCadastroPatrimonios();
            oFormCadManutencao = new FrmCadastroManutencao();
            oFormCadSenha = new FrmCadastroSenhas();
            oFormCadMensagem = new FrmCadastroMensagens();
            oFormCadContatos = new FrmCadastroContatos();
            oFormRelPatrimonios = new FrmRelPatrimonios();
            oFormCadControleGov = new FrmCadastroControleGov();
            oFormCadFuncionarios = new FrmCadastroFuncionarios();
            oFormCadCofres = new FrmCadastroCofres();
            oFormCadCargos = new FrmCadastroCargos();
            oFormCadOS = new FrmCadastroOrdemDeServico();



            //Consultas
            oFormConsUsuarios = new FrmConsultaUsuarios();
            oFormConsClientes = new FrmConsultaClientes();
            oFormConsFichas = new FrmConsultaFichas();
            oFormConsCategorias = new FrmConsultaCategorias();
            oFormConsSubCategorias = new FrmConsultaSubCategorias(0);
            oFormConsSetores = new FrmConsultaSetores();
            oFormConsPatrimonios = new FrmConsultaPatrimonios();
            oFormConsBaixasPatrimonios = new FrmConsultaBaixaPatrimonios();
            oFormConsManutencao = new FrmConsultaManutencao();
            oFormConsCategoriaSenhas = new FrmConsultaCategoriaSenhas();
            oFormConsSenhas = new FrmConsultaSenhas();
            oFormConsMensagens = new FrmConsultaMensagens();
            oFormConsContatos = new FrmConsultaContatos();
            oFormRelManutencao = new FrmRelManutencao();
            oFormConsControleGov = new FrmConsultaControleGov();
            oFormConsFuncionarios = new FrmConsultaFuncionarios();
            oFormConsControleGovFunc = new FrmConsultaControleGovFunc();
            oFormConsCofres = new FrmConsultaCofres();
            oFormConsCargos = new FrmConsultaCargos();
            oFormConsOS = new FrmConsultaOrdemDeServico();

            //Metodos
            oFormConsUsuarios.SetFrmCadastro(oFormCadUsuarios);
            oFormConsClientes.SetFrmCadastro(oFormCadClientes);
            oFormConsFichas.SetFrmCadastro(oFormCadFichas);
            oFormConsCategorias.SetFrmCadastro(oFormCadCategoria);
            oFormConsSetores.SetFrmCadastro(oFormCadSetores);
            oFormConsPatrimonios.SetFrmCadastro(oFormCadPatrimonios);
            oFormConsBaixasPatrimonios.SetFrmCadastro(oFormCadPatrimonios);
            oFormConsManutencao.SetFrmCadastro(oFormCadManutencao);
            oFormConsSenhas.SetFrmCadastro(oFormCadSenha);
            oFormConsMensagens.SetFrmCadastro(oFormCadMensagem);
            oFormConsContatos.SetFrmCadastro(oFormCadContatos);
            oFormConsControleGov.SetFrmCadastro(oFormCadControleGov);
            oFormConsFuncionarios.SetFrmCadastro(oFormCadFuncionarios);
            oFormConsControleGovFunc.SetFrmCadastro(oFormCadControleGov);
            oFormConsCofres.SetFrmCadastro(oFormCadCofres);
            oFormConsCargos.SetFrmCadastro(oFormCadCargos);
            oFormConsOS.SetFrmCadastro(oFormCadOS);




            // Botões de consulta dentro dos forms (FORM DO BOTÃO / Consulta desejada.)
            oFormCadFichas.SetConsultaClientes(oFormConsClientes);
            oFormCadCategoriaSub.SetConsultaCategoria(oFormConsCategorias);
            oFormCadPatrimonios.SetConsultaSetores(oFormConsSetores);
            oFormCadPatrimonios.SetConsultaCategorias(oFormConsCategorias);
            oFormCadPatrimonios.SetConsultaSubCategorias(oFormConsSubCategorias);
            oFormCadManutencao.SetConsultaPatrimonios(oFormConsPatrimonios);
            oFormCadSenha.SetConsultaCategorias(oFormConsCategoriaSenhas);
            oFormCadMensagem.SetConsultaContatos(oFormConsContatos);
            oFormRelPatrimonios.SetConsultaCategorias(oFormConsCategorias);
            oFormRelPatrimonios.SetConsultaSubCategorias(oFormConsSubCategorias);
            oFormRelManutencao.SetConsultaPatrimonio(oFormConsPatrimonios);
            oFormCadControleGov.SetConsultaFuncionariosGov(oFormConsFuncionarios);

        }
        public void pecaForm(string tag)
        {
            void PecaFormulario(Form mostra, object consultado)
            {
                if (mostra is FrmConsulta consulta)
                {
                    consulta.ConhecaObj(consultado);
                    consulta.ShowDialog();
                }
            }

            switch (tag) // colocar todos os forms todos.
            {
                ///PÂTRIMÔNIOS
                case "CATEGORIA": PecaFormulario(oFormConsCategorias, aCategoria); break;
                case "SUB CATEGORIA": PecaFormulario(oFormConsSubCategorias, aSubcategoria); break;
                case "SETORES": PecaFormulario(oFormConsSetores, oSetor); break;
                case "PATRIMÔNIOS": PecaFormulario(oFormConsPatrimonios, oPatrimonio); break;
                case "MANUTENÇÃO": PecaFormulario(oFormConsManutencao, aManutencao); break;
                case "BAIXAS PATRIMÔNIAIS": PecaFormulario(oFormConsBaixasPatrimonios, oPatrimonio); break;

                // RECURSOS HUMANOS
                case "FUNCIONÁRIOS": PecaFormulario(oFormConsFuncionarios, oFuncionario); break;
                case "FUNÇÃO / CARGOS": PecaFormulario(oFormConsCargos, oCargo); break;
                case "FOLHA DE PAGAMENTO": Outros("FOLHA DE PAGAMENTO"); break;
                case "TAXA DE SERVIÇO": Outros("TAXA DE SERVIÇO"); break;
                case "LANÇAMENTO DE PONTOS": Outros("LANÇAMENTO DE PONTOS"); break;

                //FICHAS
                case "FICHAS": PecaFormulario(oFormConsFichas, aFicha); break;
                case "CLIENTES": PecaFormulario(oFormConsClientes, oCliente); break;

                // ORDEM DE SERVIÇO
                case "ORDEM DE SERVIÇO": PecaFormulario(oFormConsOS, aOS); break;

                //SENHAS
                case "SENHAS": PecaFormulario(oFormConsSenhas, aSenha); break;
                case "CATEGORIA DE SENHAS": PecaFormulario(oFormConsCategoriaSenhas, aCategoria); break;

                //COFRES
                case "COFRES": PecaFormulario(oFormConsCofres, oCofre); break;

                //GOVERNANÇA
                case "GOVERNANÇA": PecaFormulario(oFormConsControleGovFunc, aControleGov); break;

                //AGENDA
                case "CONTATOS": PecaFormulario(oFormConsContatos, oContato); break;
                case "MENSAGENS": PecaFormulario(oFormConsMensagens, aMensagem); break;

                //RELATORIOS
                case "REL. PATRIMONIOS": Outros("REL. PATRIMONIOS"); break;
                case "REL. MANUTENÇÃO": Outros("REL. MANUTENÇÃO"); break;
                case "REL. FICHAS": Outros("REL. FICHAS"); break;
                case "REL. FUNCIONARIOS": Outros("REL. FUNCIONARIOS"); break;
                case "REL. ORDEM DE SERVIÇO": Outros("REL. ORDEM DE SERVIÇO"); break;

                //SISTEMA
                case "ALTERAR SENHA": AlterarSenha(); break;
                case "USUARIOS DO SISTEMA": PecaFormulario(oFormConsUsuarios, oUsuarios); break;
                case "SAIR": Sair(); break;
            }
        }
        private void Outros(string Tipo)
        {
            switch (Tipo) // colocar todos os forms todos.
            {
                // RELATORIOS
                case "REL. PATRIMONIOS":
                    FrmRelPatrimonios frmPat = new FrmRelPatrimonios();
                    frmPat.Show();
                    break;
                case "REL. MANUTENÇÃO":
                    FrmRelManutencao frmManu = new FrmRelManutencao();
                    frmManu.Show();
                    break;
                case "REL. FICHAS":
                    FrmRelFichas frmFicha = new FrmRelFichas();
                    frmFicha.Show();
                    break;
                case "REL. FUNCIONARIOS":
                    MessageBox.Show("AINDA NÃO IMPLEMENTADO");
                    break;
                case "REL. ORDEM DE SERVIÇO":
                    MessageBox.Show("AINDA NÃO IMPLEMENTADO");
                    break;
                case "FOLHA DE PAGAMENTO":
                    MessageBox.Show("AINDA NÃO IMPLEMENTADO");
                    break;
                case "TAXA DE SERVIÇO":
                    FrmConsultaFolhaTaxa frmFolhaTaxa = new FrmConsultaFolhaTaxa();
                    frmFolhaTaxa.ShowDialog();
                    break;
                case "LANÇAMENTO DE PONTOS":
                    FrmConsultaLancamentos frmPontos = new FrmConsultaLancamentos();
                    frmPontos.ShowDialog();
                    break;

            }
        }

        private void AlterarSenha()
        {
            FrmAlterarSenha frm = new FrmAlterarSenha();
            frm.ShowDialog();
        }

        private void Sair()
        {
            DialogResult result = MessageBox.Show("Deseja encerrar a aplicação ?", "confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {/*não fazer nada*/ };
        }

    }
}

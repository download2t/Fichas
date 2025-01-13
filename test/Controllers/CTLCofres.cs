using System.Collections.Generic;
using test.Data;
using test.Model;
using test.Views.Cadastros;

public class CTLCofres
{
    private DALCofres cofresDAL = new DALCofres();

    public void AdicionarCofre(Cofres cofre)
    {
        cofresDAL.AdicionarCofre(cofre);
    }

    public void AtualizarCofre(Cofres cofre)
    {
        cofresDAL.AtualizarCofre(cofre);
    }

    public void ExcluirCofre(int cofreId)
    {
        cofresDAL.ExcluirCofre(cofreId);
    }

    public Cofres BuscarCofrePorId(int id)
    {
        return cofresDAL.BuscarCofrePorId(id);
    }

    public List<Cofres> ListarCofres()
    {
        return cofresDAL.ListarCofres();
    }

    public List<Cofres> PesquisarCofres(string valor)
    {
        return cofresDAL.PesquisarCofres(valor);
    }

    public void Incluir()
    {
        FrmCadastroCofres frmCadastroCofres = new FrmCadastroCofres();
        frmCadastroCofres.Text = "Incluir Cofre";
        frmCadastroCofres.ShowDialog();
    }

    public void Alterar(Cofres cofre)
    {
        if (cofre != null)
        {
            FrmCadastroCofres frmCadastroCofres = new FrmCadastroCofres();
            frmCadastroCofres.ConhecaObj(cofre);
            frmCadastroCofres.Text = "Alterar Cofre";
            frmCadastroCofres.CarregarCampos();
            frmCadastroCofres.ShowDialog();
        }
    }

    public void Excluir(Cofres cofre)
    {
        if (cofre != null)
        {
            FrmCadastroCofres frmCadastroCofres = new FrmCadastroCofres();
            frmCadastroCofres.ConhecaObj(cofre);
            frmCadastroCofres.Text = "Excluir Cofre";
            frmCadastroCofres.CarregarCampos();
            frmCadastroCofres.BloquearCampos();
            frmCadastroCofres.btnSalvar.Text = "Excluir";
            frmCadastroCofres.ShowDialog();
        }
    }

    public void Visualizar(Cofres cofre)
    {
        if (cofre != null)
        {
            FrmCadastroCofres frmCadastroCofres = new FrmCadastroCofres();
            frmCadastroCofres.ConhecaObj(cofre);
            frmCadastroCofres.Text = "Consultar Cofre";
            frmCadastroCofres.CarregarCampos();
            frmCadastroCofres.BloquearCampos();
            frmCadastroCofres.btnSalvar.Enabled = false;
            frmCadastroCofres.ShowDialog();
        }
    }
}

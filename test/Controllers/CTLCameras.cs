using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Controle.Models;
using Controle.DAL;
using Controle.Views.Cadastros;
using Controle.Model;

namespace Controle.Controllers
{
    public class CTLCameras
    {
        private DALCameras camerasDAL = new DALCameras();

        public void AdicionarCamera(Cameras camera)
        {
            camerasDAL.AdicionarCamera(camera);
        }

        public void AtualizarCamera(Cameras camera)
        {
            camerasDAL.AtualizarCamera(camera);
        }

        public void ExcluirCamera(int cameraId)
        {
            camerasDAL.ExcluirCamera(cameraId);
        }

        public Cameras BuscarCameraPorId(int id)
        {
            return camerasDAL.BuscarCameraPorId(id);
        }

        public List<Cameras> ListarCameras()
        {
            return camerasDAL.ListarCameras();
        }
        public List<Cameras> PesquisarCameras (string valorPesquisa)
        {
            List<Cameras> camerasEncontradas = camerasDAL.PesquisarCamera(valorPesquisa);
            return camerasEncontradas;
        }
     
        public void Incluir()
        {
            FrmCadastroCameras frmCadastroCameras = new FrmCadastroCameras();
            frmCadastroCameras.Text = "Incluir Câmera";
            frmCadastroCameras.ShowDialog();
        }

        public void Alterar(Cameras camera)
        {
            if (camera != null)
            {
                FrmCadastroCameras frmCadastroCameras = new FrmCadastroCameras();
                frmCadastroCameras.ConhecaObj(camera);
                frmCadastroCameras.Text = "Alterar Câmera";
                frmCadastroCameras.CarregarCampos();
                frmCadastroCameras.ShowDialog();
            }
        }

        public void Excluir(Cameras camera)
        {
            if (camera != null)
            {
                FrmCadastroCameras frmCadastroCameras = new FrmCadastroCameras();
                frmCadastroCameras.ConhecaObj(camera);
                frmCadastroCameras.Text = "Excluir Câmera";
                frmCadastroCameras.CarregarCampos();
                frmCadastroCameras.BloquearCampos();
                frmCadastroCameras.btnSalvar.Text = "Excluir";
                frmCadastroCameras.ShowDialog();
            }
        }

        public void Visualizar(Cameras camera)
        {
            if (camera != null)
            {
                FrmCadastroCameras frmCadastroCameras = new FrmCadastroCameras();
                frmCadastroCameras.ConhecaObj(camera);
                frmCadastroCameras.Text = "Consultar Câmera";
                frmCadastroCameras.CarregarCampos();
                frmCadastroCameras.BloquearCampos();
                frmCadastroCameras.btnSalvar.Enabled = false;
                frmCadastroCameras.ShowDialog();
            }
        }
     

    }
}

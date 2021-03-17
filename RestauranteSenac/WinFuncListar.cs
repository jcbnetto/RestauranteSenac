using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSenac
{
    public partial class WinFuncListar : Form
    {
        public WinFuncListar()
        {
            InitializeComponent();
        }
        private void atualizardados()
        {
            // Puxar os dados provindos da FuncionarioDAO.listar():

            // Modo 1 (mais legível):
            //   DataTable tabela = new DataTable();
            //   tabela = db.FuncionarioDAO.listar();
            //   dgvFuncionarios.DataSource = tabela;
            // Modo 2 (mais simples):
            dgvFuncionarios.DataSource = db.FuncionarioDAO.listar();
        }
        //oq será executado quando a janela for exibida:
        private void WinFuncListar_Load(object sender, EventArgs e)
        {
            atualizardados();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Criar um obj do tipo Funcionario:
            Funcionario func = new Funcionario();
            func.Nome = txbNomeCad.Text;
            func.Email = txbEmailCad.Text;
            func.Funcao = txbFuncaoCad.Text;
            func.Setor = int.Parse(txbSetorCad.Text);
            func.Telefone = txbTelCad.Text;
            // Passar o funcionário pro cadastro:
            var resultado = db.FuncionarioDAO.cadastrar(func);
            if (resultado == true)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                // Limpar os campos do formulário:
                txbNomeCad.Clear();
                txbSetorCad.Clear();
                txbEmailCad.Clear();
                txbTelCad.Clear();
                txbFuncaoCad.Clear();
            }
            else
            {
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }
    }
}

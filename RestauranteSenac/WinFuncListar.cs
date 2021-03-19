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
        // Variáveis globais: 
        int idUsuario = 0;
        // bandeira para sinalizar quando o editar ou o apagar podem ser invocados:
        bool podeEditarApagar = false;
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
            // Passar o funcionário pro .cadastrar e obter o resultado (true ou false):
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
                atualizardados();
                
            }
            else
            {
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            // Garantir que a pessoa selecionou alguma linha:
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();
                // Obter o id do usuário selecionado:
                idUsuario = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.FuncionarioDAO.buscarUsuario(idUsuario);
                // obter linha 0:
                var linha = dt.Rows[0];
                // Preencher os campos do editar:
                txbNomeEd.Text = linha.Field<string>("Nome").ToString();
                txbEmailEd.Text = linha.Field<string>("Email").ToString();
                txbTelEd.Text = linha.Field<string>("Telefone").ToString();
                txbFuncaoEd.Text = linha.Field<string>("Funcao").ToString();
                txbSetorEd.Text = linha.Field<Int64>("Setor").ToString();
                // Atribuir true na podeEditar:
                podeEditarApagar = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (podeEditarApagar)
            {
                // Instanciar o objeto Funcionario:
                Funcionario func = new Funcionario();
                // Inserir os dados dos campos nos atributos do obj:
                func.Nome = txbNomeEd.Text;
                func.Email = txbEmailEd.Text;
                func.Setor = int.Parse(txbSetorEd.Text);
                func.Telefone = txbTelEd.Text;
                func.Funcao = txbFuncaoEd.Text;
                // Sabemos que o ID a editar está no iUsuario global!
                var resultado = db.FuncionarioDAO.editar(func, idUsuario);
                if (resultado)
                {
                    MessageBox.Show("Informações modificadas!");
                    txbNomeEd.Clear();
                    txbSetorEd.Clear();
                    txbEmailEd.Clear();
                    txbTelEd.Clear();
                    txbFuncaoEd.Clear();
                    atualizardados();
                    podeEditarApagar = false;
                }
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            }
            else
            {
                MessageBox.Show("Erro! Não existem dados a serem editados!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (podeEditarApagar)
            {

            }
            else
            {
                MessageBox.Show("Erro! Não existem dados a serem removidos!");
            }
        }
    }
}

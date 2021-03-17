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
            // Instanciar o classe de conexão com o bd:
            db.Banco objBanco = new db.Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com o banco:
            objBanco.Conectar();
            // Criar um objeto do tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios";
            // Executar e obter os dados da consulta em um obj SQLiteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma "tabela" com os dados retornados do BD:
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Definir a fonte do DGV para a tabela que foi anteriormente preenchida:
            dgvFuncionarios.DataSource = tabela;
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
            // Instanciar e conectar ao banco:
            db.Banco banco = new db.Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "INSERT INTO Funcionarios (Nome, Setor, Email, Telefone, Funcao) values (@nome, @setor, @email, @telefone, @funcao)";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", txbNomeCad.Text);
                cmd.Parameters.AddWithValue("@setor", txbSetorCad.Text);
                cmd.Parameters.AddWithValue("@email", txbEmailCad.Text);
                cmd.Parameters.AddWithValue("@telefone", txbTelCad.Text);
                cmd.Parameters.AddWithValue("@funcao", txbFuncaoCad.Text);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Mostrar mensagem confirmando o cadastro:
                MessageBox.Show("Dados cadastrados com sucesso!");
                // Atualizar os dados da tabela:
                atualizardados();
                // Limpar os campos do formulário:
                txbNomeCad.Clear();
                txbSetorCad.Clear();
                txbEmailCad.Clear();
                txbTelCad.Clear();
                txbFuncaoCad.Clear();
            }
            catch
            {
                MessageBox.Show("Erro! Verifique os dados informados!");
                // Desconectar
                banco.Desconectar();
            }
        }
    }
}

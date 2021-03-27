using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteSenac.db
{
    static class FuncionarioDAO
    {
<<<<<<< HEAD
        // Métodos de manipulação de dados: listar, cadastrar, apagar ...
        public static DataTable listar()
        {
            // Instanciar a classe de conexão com o bd:
            Banco objBanco = new Banco();
            // Criar a "tabela" que será preenchida com os dados do BD:
            DataTable tabela = new DataTable();
            // Conectar com a tabela:
            objBanco.Conectar();
            //Criar um objeto de tipo SQLiteCommand:
            var cmd = objBanco.conexao.CreateCommand();
            // Qual comando SQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios";
            // Executar e obter os dados da consulta em um obj SQLIteDA:
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, objBanco.conexao);
            // Preencher uma " tabela" com os dados retornados do BD:
=======

        // Métodos de manipulação de dados: listar, cadastrar, apagar...
        public static DataTable listar()
        {
            // Instanciar o classe de conexão com o bd:
            Banco objBanco = new Banco();
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
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            da.Fill(tabela);
            // Desconectar:
            objBanco.Desconectar();
            // Devolver a tabela preenchida para quem chamar este método:
            return tabela;
        }
        public static bool cadastrar(Funcionario func)
        {
            // Instanciar e conectar ao banco:
<<<<<<< HEAD
            db.Banco banco = new db.Banco();
=======
            Banco banco = new Banco();
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
<<<<<<< HEAD
                cmd.CommandText = "INSERT INTO Funcionarios(Nome, Email, Telefone, Setor, Funcao) values(@nome, @email, @telefone, @setor, @funcao)";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
=======
                cmd.CommandText = "INSERT INTO Funcionarios (Nome, Setor, Email, Telefone, Funcao) values (@nome, @setor, @email, @telefone, @funcao)";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                cmd.Parameters.AddWithValue("@funcao", func.Funcao);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
<<<<<<< HEAD
                // Se chegou ate aqui pq de certo:
                // retornar true:
=======
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                return true;
            }
            catch
            {
<<<<<<< HEAD
=======
                // Desconectar
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }
<<<<<<< HEAD
            public static DataTable buscarUsuario(int id)
            {
                // Definir o objeto de "tabela" que será preenchido com a consulta:
                DataTable tabela = new DataTable();
                // Instanciar e conectar ao banco:
                Banco banco = new Banco();

                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DQL será executado:
                cmd.CommandText = "SELECT * FROM Funcionarios WHERE id = " + id;
                // Executar e "atribuir" o resultado em um objeto SQLiteDA
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
                // Definir qual "tabela" será preenchida com o resultado da consulta:
                da.Fill(tabela);
                // Desconectar:
                banco.Desconectar();
                return tabela;
            }
            public static bool excluir(int id)
            {
=======
        public static DataTable buscarUsuario(int id)
        {
            // Definir o objeto de "tabela" que será preenchido com a consulta:
            DataTable tabela = new DataTable();
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            banco.Conectar();
            // Criar o objeto SQLiteCommand:
            var cmd = banco.conexao.CreateCommand();
            // Definir qual comando DQL será executado:
            cmd.CommandText = "SELECT * FROM Funcionarios WHERE id = " + id;
            // Executar e "atribuir" o resultado em um objeto SQLiteDA
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, banco.conexao);
            // Definir qual "tabela" será preenchida com o resultado da consulta:
            da.Fill(tabela);
            // Desconectar:
            banco.Desconectar();
            return tabela;
        }
        public static bool excluir(int id)
        {
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.CommandText = "DELETE FROM Funcionarios WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
        }
<<<<<<< HEAD
            public static bool editar( Funcionario func, int id)
        {
            db.Banco banco = new db.Banco();
=======

        public static bool editar(Funcionario func, int id)
        {
            // comandos para manipulação:
            // Instanciar e conectar ao banco:
            Banco banco = new Banco();
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            try
            {
                banco.Conectar();
                // Criar o objeto SQLiteCommand:
                var cmd = banco.conexao.CreateCommand();
                // Definir qual comando DML (Insert - Delete - Update) será executado:
<<<<<<< HEAD
                cmd.CommandText = "UPDATE Funcionarios SET Nome = @nome, Email = @email, Telefone = @telefone, Setor = @setor, Funcao = @funcao WHERE id= @id";
                // Definir qual comando DML (Insert - Delete - Update) será executado:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
=======
                cmd.CommandText = "UPDATE Funcionarios SET Nome = @nome, Setor = @setor, Email = @email, Telefone = @telefone, Funcao = @funcao WHERE id = @id";
                // Definir a substituição dos parametros:
                cmd.Parameters.AddWithValue("@nome", func.Nome);
                cmd.Parameters.AddWithValue("@setor", func.Setor);
                cmd.Parameters.AddWithValue("@email", func.Email);
                cmd.Parameters.AddWithValue("@telefone", func.Telefone);
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                cmd.Parameters.AddWithValue("@funcao", func.Funcao);
                cmd.Parameters.AddWithValue("@id", id);
                // Executar:
                cmd.ExecuteNonQuery();
                // Desconectar
                banco.Desconectar();
<<<<<<< HEAD
                // Se chegou ate aqui pq de certo:
                // retornar true:
=======
                // Se chegou até aqui é pq deu certo!
                // Retornar true:
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                return true;
            }
            catch
            {
                // Desconectar
                banco.Desconectar();
                // Se chegou aqui é pq deu algum erro!
                // Retornar false:
                return false;
            }
<<<<<<< HEAD
          }
        }
=======
        }
    }
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
}

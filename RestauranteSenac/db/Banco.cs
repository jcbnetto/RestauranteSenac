using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace RestauranteSenac.db
{
    class Banco
    {
        // Objeto de conexão SQL:
        public SQLiteConnection conexao;

<<<<<<< HEAD
        // Construtor de conexão :
        public Banco()
        {
            // Apontar onde estará nosso arquivo de banco de dados:
            conexao = new SQLiteConnection("Data Source=banco.sqlite3");
            // Definir o caminho
            string caminhoLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string caminho = caminhoLocalAppData + "/Restaurante Senac";
            // Verificar se o arquivo banco.sqlite3 existe:
            if (!File.Exists("./banco.sqlite3"))
            {
                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile("banco.sqlite3");


                // Comandos SQL para a estrutura padrão do banco:
=======
        // Contrutor de conexão:
        public Banco()
        {
            string caminhoLocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string caminho = caminhoLocalAppData + "/Restaurante Senac";
            // Apontar onde estará nosso arquivo de banco de dados:
            conexao = new SQLiteConnection("Data Source= " +caminho + "/banco.sqlite3");
            
            // Definir o caminho
            

            // Verificar se o arquivo banco.sqlite3 NÃO existe:
            if (!File.Exists(caminho + "/banco.sqlite3"))
            {
                // Criar a pasta no caminho
                Directory.CreateDirectory(caminho);

                // Criar o arquivo de banco de dados:
                SQLiteConnection.CreateFile(caminho + "/banco.sqlite3");

                // COMANDOS SQL PARA CRIAR A ESTRUTURA PADRÃO DO BANCO:
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
                // Será executado apenas na primeira vez que o código rodar:
                // Conectar com o banco:
                this.Conectar();
                var cmd = this.conexao.CreateCommand();
                // Comando SQL:
                cmd.CommandText = "CREATE TABLE 'Funcionarios' (" +
                 "'id'    INTEGER NOT NULL UNIQUE," +
                "'Nome'  TEXT NOT NULL," +
                "'Setor' INTEGER NOT NULL," +
                "'Email' TEXT NOT NULL UNIQUE," +
                "'Telefone'  TEXT NOT NULL UNIQUE," +
                "'Funcao'    TEXT NOT NULL," +
                "PRIMARY KEY('id' AUTOINCREMENT));";
                // Executar o comando:
                cmd.ExecuteNonQuery();
                // Desconectar:
                this.Desconectar();
            }
        }
<<<<<<< HEAD
    
        
         // Método para conectar:
        public void Conectar()
        {
            // Verificar se a conexão não está aberta:
            if (conexao.State != ConnectionState.Open)
=======
        // Método para conectar:
        public void Conectar()
        {
            // Verificar se a conexão não está aberta:
            if(conexao.State != ConnectionState.Open)
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            {
                // Abrir a conexão:
                conexao.Open();
            }
        }

        // Método para desconectar:
        public void Desconectar()
        {
            // Verificar se a conexão não está fechada:
<<<<<<< HEAD
            if (conexao.State != ConnectionState.Closed)
=======
            if(conexao.State != ConnectionState.Closed)
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            {
                // Fechar a conexão:
                conexao.Close();
            }
<<<<<<< HEAD
               
=======
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
        }
    }
}

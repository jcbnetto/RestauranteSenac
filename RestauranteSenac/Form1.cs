﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteSenac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarFunc_Click(object sender, EventArgs e)
        {
            // Instanciar a 'classe da janela':
            WinFuncListar janelaListarFuncionario = new WinFuncListar();
<<<<<<< HEAD
            // esconder a janela atual:
            this.Hide();
            // Método .ShowDialog serve para exibir a janela:
            janelaListarFuncionario.ShowDialog();
            // reexibir a janela principal:
=======
            //esconder a janela atual:
            this.Hide();
            // Método .ShowDialog serve para exibir a janela:
            janelaListarFuncionario.ShowDialog();
            //reexibir a janela principal:
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            this.Show();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        { 
            // Instanciar a 'classe da janela' WinFuncCadastrar:
            WinFuncCadastrar janelaFuncionarioCadastrar = new WinFuncCadastrar();
            //esconder a janela atual:
            this.Hide();
            // Mostrar a janela:
            janelaFuncionarioCadastrar.ShowDialog();
            // reexibir a janela principal:
            this.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            //Instanciar a 'classe da janela' WinFuncCadastrar:
            WinFuncCadastrar funcCadastrar = new WinFuncCadastrar();
            //esconder a janela atual:
            this.Hide();
            //Mostrar a janela:
            funcCadastrar.ShowDialog();
            //reexibir a janela principal:
            this.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
            btnListarFunc.PerformClick();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCadFunc.PerformClick();
<<<<<<< HEAD
=======
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            MessageBox.Show(caminho);
>>>>>>> b4842471decdf08dcf86e58ce6f415a50cfbd188
        }
    }
}

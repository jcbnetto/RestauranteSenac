using System;
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
            // Método .ShowDialog serve para exibir a janela:
            janelaListarFuncionario.ShowDialog();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {

        }
    }
}

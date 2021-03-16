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
    public partial class WinFuncListar : Form
    {
        public WinFuncListar()
        {
            InitializeComponent();
        }
        //oq será executado quando a janela for exibida:
        private void WinFuncListar_Load(object sender, EventArgs e)
        {
            // Instanciar o classe de conexão com o bd:
            db.Banco objBanco = new db.Banco();

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Peluqueria
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            frm_clientes frmclientes = (new frm_clientes());
            frmclientes.Show();
        }

        private void btn_nuevo_corte_Click(object sender, EventArgs e)
        {
            frm_cortes cortes = new frm_cortes();
            cortes.Show();
        }

        private void btn_salirMP_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Desea Salir?", "Peluqueria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
                Application.Exit();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

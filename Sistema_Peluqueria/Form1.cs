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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = txt_usuario.Text;
                String pass = txt_password.Text;
                controlSesion control = new controlSesion();
                String respuestaControlador = control.ctrlLogin(usuario, pass);
                if (respuestaControlador == "¡Bienvenido!")
                {
                    MessageBox.Show(control.ctrlLogin(usuario, pass), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu_Principal p = new Menu_Principal ();
                    this.Visible = false; //Oculta el formulario de inicio de sesión.
                    p.Show();
                }
                else
                {
                    MessageBox.Show(respuestaControlador, "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txt_usuario.Text == "")
                        txt_password.Focus();
                    else
                        txt_password.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Desea Salir?", "Peluqueria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_password.Clear();
            txt_usuario.Focus();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registrar = new frmRegistrar();
            registrar.Show();
        }
    }
}
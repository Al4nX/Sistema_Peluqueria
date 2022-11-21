using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_guardar_usuario.Clear();
            txt_guardar_pass.Clear();
            txt_guardar_confirmarpass.Clear();
            txt_guardar_nombre.Clear();
            txt_guardar_usuario.Focus();
        }

        private void btn_salirR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cargarUsuarios()
        {
            comboTipos.DataSource = null;
            comboTipos.Items.Clear();
            MySqlConnection con = conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from tipoUsuarios";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                comboTipos.ValueMember = "idTipo";
                comboTipos.DisplayMember = "Nombre";
                comboTipos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_registarU_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarioo user = new Usuarioo();
                user.Usuario = txt_guardar_usuario.Text;
                user.Password = txt_guardar_pass.Text;
                user.PasswordConfirma = txt_guardar_confirmarpass.Text;
                user.Nombre = txt_guardar_nombre.Text;
                user.IdTipo = int.Parse(comboTipos.SelectedValue.ToString());
                controlUsuarios control = new controlUsuarios();
                MessageBox.Show(control.ctrlRegistroUsuarios(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

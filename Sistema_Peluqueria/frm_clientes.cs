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
using System.Globalization;
using System.Threading;

namespace Sistema_Peluqueria
{
    public partial class frm_clientes : Form
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_salirRC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = new Clientes();
                DateTime f = date_clientes.Value;
                cliente.DNI = txt_dni.Text;
                cliente.Apellido = txt_apellido.Text;
                cliente.Nombre = txt_nombre.Text;
                cliente.Domicilio = txt_domicilio.Text;
                cliente.CP = txt_cp.Text;
                cliente.Sexo = txt_sexo.Text;
                cliente.FechaN = f;
                cliente.Telefono = txt_telefono.Text;
                cliente.Correo = txt_correo_electronico.Text;
                controlCliente control = new controlCliente();
                MessageBox.Show(control.ctrlRegistroClientes(cliente), "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frm_clientes_Load(object sender, EventArgs e)
        {
            miConexion.Open();
            DataTable dt = new DataTable();
            frm_clientes f = new frm_clientes();
            dataGridView1.Size = f.Size;
            sql = "Select * from clientes";
            comando = new MySqlCommand(sql, miConexion);
            dt = new DataTable();
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            miConexion.Close();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_dni.Clear();
            txt_apellido.Clear();
            txt_nombre.Clear();
            txt_domicilio.Clear();
            txt_cp.Clear();
            txt_sexo.Clear();
            txt_correo_electronico.Clear();
            txt_telefono.Clear();
            txt_dni.Enabled = true;
            txt_dni.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Equals(""))
                MessageBox.Show("Para Eliminar Ingrese algun DNI en el TextBox DNI", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                miConexion.Open();
                string dni = txt_dni.Text;
                string borrarCliente = ("delete from clientes where dni = " + txt_dni.Text);
                string borrarCorte = ("delete from cortes where dniC = " + txt_dni.Text);
                MySqlCommand cmd = new MySqlCommand(borrarCliente, miConexion);
                MySqlCommand cmdCortes = new MySqlCommand(borrarCorte, miConexion);

                cmd.ExecuteNonQuery();
                cmdCortes.ExecuteNonQuery();
                MessageBox.Show("El Cliente Fue eliminado Correctamente, clickee en actualizar", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miConexion.Close();
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Clientes cliente = new Clientes();

            CultureInfo customCulture = new CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Thread.CurrentThread.CurrentCulture = customCulture;
            Thread.CurrentThread.CurrentUICulture = customCulture;
            DateTime newDate = Convert.ToDateTime(date_clientes.Value.ToString("yyyy-MM-dd"));
            cliente.FechaN = newDate;

            string update = "update clientes set ape = '" + this.txt_apellido.Text + "',nom ='" + this.txt_nombre.Text + "',dom ='" + this.txt_domicilio.Text + "',cp ='" + this.txt_cp.Text + "',sexo ='" + this.txt_sexo.Text + "',fechaN = '" +  newDate + "',tel ='" + this.txt_telefono.Text + "',mail ='" + this.txt_correo_electronico.Text + "' where dni = " + this.txt_dni.Text.ToString() + "";

            MySqlCommand comando = new MySqlCommand(update, miConexion);

            if (txt_dni.Text.Equals(""))
                MessageBox.Show("Para Modificar Seleccione un cliente, clickee en mostrar y haga su modificacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                miConexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("El Registro Fue Actualizado, clickee en actualizar", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miConexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_dni.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_apellido.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_domicilio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_cp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sexo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            date_clientes.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            txt_telefono.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_correo_electronico.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            txt_dni.Enabled = false;
        }

        private void date_clientes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            miConexion.Open();
            DataTable dt = new DataTable();
            frm_clientes f = new frm_clientes();
            dataGridView1.Size = f.Size;
            sql = "Select * from clientes";
            comando = new MySqlCommand(sql, miConexion);
            dt = new DataTable();
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            miConexion.Close();
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>=32 && e.KeyChar<=47)|| (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por Favor Ingrese Solo Numeros.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
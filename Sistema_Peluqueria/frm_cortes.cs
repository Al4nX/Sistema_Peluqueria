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
    public partial class frm_cortes : Form
    {
        static MySqlConnection miConexion = conexion.getConexion();
        DataTable datos = new DataTable();
        static string sql = "";
        static MySqlCommand comando;
        public frm_cortes()
        {
            InitializeComponent();
            cargarClientes();
            cargarCortes();
            cargarPeluqueros();
        }

        private void btn_hacercorte_Click(object sender, EventArgs e)
        {
            modeloCortes corte = new modeloCortes();
        }

        private void cargarClientes()
        {
            combo_Clientes.DataSource = null;
            combo_Clientes.Items.Clear();
            MySqlConnection con = conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select dni, concat_ws (' - ', dni, ape) as dato, nom from clientes";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                combo_Clientes.ValueMember = "dni";
                combo_Clientes.DisplayMember = "dato";
                combo_Clientes.DataSource = dt;
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
        private void cargarCortes()
        {
            combo_Cortes.DataSource = null;
            combo_Cortes.Items.Clear();
            MySqlConnection con = conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from tipocorte";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                combo_Cortes.ValueMember = "idCorte";
                combo_Cortes.DisplayMember = "nombre";
                combo_Cortes.DataSource = dt;
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
        private void cargarPeluqueros()
        {
            combo_Peluqueros.DataSource = null;
            combo_Peluqueros.Items.Clear();
            MySqlConnection con = conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select id, concat_ws (' - ', id, ape) as dato, nom from peluqueros";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                combo_Peluqueros.ValueMember = "id";
                combo_Peluqueros.DisplayMember = "dato";
                combo_Peluqueros.DataSource = dt;
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
        private void frm_cortes_hombres_Load(object sender, EventArgs e)
        {
            miConexion.Open();
            DataTable dt = new DataTable();
            frm_clientes f = new frm_clientes();
            dataGridView1.Size = f.Size;
            sql = "Select * from cortes";
            comando = new MySqlCommand(sql, miConexion);
            dt = new DataTable();
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            miConexion.Close();
        }
        private void rb_chad_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void combo_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Cortes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_salirRC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combo_Peluqueros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_corte_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime f1 = fecha.Value;
                Cortes corte = new Cortes();
                corte.IdP = int.Parse(combo_Peluqueros.SelectedValue.ToString());
                corte.TipoC = combo_Cortes.Text;
                corte.DniC = (combo_Clientes.SelectedValue.ToString());
                corte.Fecha = f1;
                controlCortes control = new controlCortes();
                MessageBox.Show(control.ctrlCortes(corte), "Control Cortes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            miConexion.Open();
            string sql = "Select id,idP,tipoC,dniC,fecha from cortes WHERE dniC = '" + (combo_Clientes.SelectedValue.ToString()) + "' ORDER BY fecha = '" + fecha + "' ASC;";
            MySqlCommand cmd = new MySqlCommand(sql, miConexion);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            miConexion.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            miConexion.Open();
            DataTable dt = new DataTable();
            frm_clientes f = new frm_clientes();
            dataGridView1.Size = f.Size;
            sql = "Select * from cortes";
            comando = new MySqlCommand(sql, miConexion);
            dt = new DataTable();
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            data.Fill(dt);
            dataGridView1.DataSource = dt;
            miConexion.Close();
        }
    }
}

using LibreriaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms
{
    public partial class frmIncidenciasAsignadas : Form
    {
        string correo;
        string id;
        public frmIncidenciasAsignadas(string correo)
        {
            InitializeComponent();
            this.correo = correo;
            cargar();
        }

        public void cargar()
        {
            string strCon = Utileria.GetConnectionString();
            SqlConnection con = LibreriaBD.UsoBD.ConectaBD(strCon);
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in LibreriaBD.UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
            SqlDataReader Lector = null;
            string strComando = "Select id from Empleado where Correo='" + correo + "'";
            SqlCommand cmd = new SqlCommand(strComando, con);
            try
            {
                Lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al realizar consulta");
                foreach (SqlError item in ex.Errors)
                {
                    MessageBox.Show(item.Message);
                }
                con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    id = Lector.GetValue(0).ToString();
                }
            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO");
            }
            Lector.Close();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIncidenciasAsignadas_Load(object sender, EventArgs e)
        {
            cmbPieza.SelectedIndex = 0;
            cambiar();
        }


        public void cambiar()
        {
            cmbIncidencia.Items.Clear();
            string strCon = Utileria.GetConnectionString();
            SqlConnection con = LibreriaBD.UsoBD.ConectaBD(strCon);
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in LibreriaBD.UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            SqlDataReader Lector = null;
            string strComando = "select A.Id_Incidencia from asignaIncidencias A,Incidencia I where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado =" + id + ") and A.Id_Incidencia=I.Id and I.Estatus!='Terminada' and I.Estatus!='Solicitud'";
            SqlCommand cmd = new SqlCommand(strComando, con);
            try
            {
                Lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al realizar consultap");
                foreach (SqlError item in ex.Errors)
                {
                    MessageBox.Show(item.Message);
                }
                con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                //Lleno combo box
                cmbIncidencia.Items.Clear();
                while (Lector.Read())
                {
                    cmbIncidencia.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();

            con.Close();
        }

        private void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvIncidencia.Rows.Clear();
            string idIncidencia = cmbIncidencia.Text.ToString();
            string strCon = Utileria.GetConnectionString();
            SqlConnection con = LibreriaBD.UsoBD.ConectaBD(strCon);
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            SqlDataReader Lector = null;
            string strComando = "select * from Incidencia where Id= " + idIncidencia;
            SqlCommand cmd = new SqlCommand(strComando, con);
            try
            {
                Lector = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Error al realizar consulta");
                foreach (SqlError item in ex.Errors)
                {
                    // MessageBox.Show(item.Message);
                }
                con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    dgvIncidencia.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10), Lector.GetValue(11), Lector.GetValue(12), Lector.GetValue(13), Lector.GetValue(14), Lector.GetValue(15));
                }
            }
            Lector.Close();

            SqlDataReader Lector2 = null;
            string strComando2 = "select Descripcion from equipo where Id = (select id_equipo from Incidencia where id="+ idIncidencia + ")";
            SqlCommand cmd2 = new SqlCommand(strComando2, con);
            try
            {
                Lector2 = cmd2.ExecuteReader();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Error al realizar consulta");
                foreach (SqlError item in ex.Errors)
                {
                    // MessageBox.Show(item.Message);
                }
                con.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                {
                    txtEquipo.Text = Lector2.GetValue(0).ToString();
                }
            }
            Lector2.Close();
            con.Close();

        }

        public void limpiaDatos()
        {
            cmbIncidencia.SelectedIndex = -1;
            cmbIncidencia.Text = "-Seleccionar-";
            txtEquipo.Text = "";
            txtServicio.Text = "";
            dgvIncidencia.Rows.Clear();
            cmbPieza.SelectedIndex = 0;
            txtPieza.Text = "";
        }

        public bool validaDato()
        {
            bool re = false;
            string descripcion=txtEquipo.Text;
            string solucion = txtServicio.Text;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO PUEDE DEJAR VACIA LA DESCRIPCION DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(solucion))
            {
                DialogResult kk = MessageBox.Show("ERROR: DEBE INGRESAR LA SOLUCION DE LA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }

            if (cmbIncidencia.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO NINGUNA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbPieza.SelectedIndex == 0)
            {
                DialogResult kk = MessageBox.Show("ERROR: SELECCIONE SI HABRA ALGUN CAMBIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }

            return re;
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            string incidencia = cmbIncidencia.Text.ToString();
            string servicio = txtServicio.Text;
            string Descripcion = txtEquipo.Text;
            string cambio = cmbPieza.Text;
            string detalleCambio = txtPieza.Text;
            DateTime fecha = datetimeFecha.Value;

            string strCon = Utileria.GetConnectionString();
            SqlConnection con = LibreriaBD.UsoBD.ConectaBD(strCon);
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in LibreriaBD.UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }

            if (validaDato() == false)
            {
                SqlCommand cmd = new SqlCommand("DetalleSolucion");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@idincidencia", incidencia);
                cmd.Parameters.AddWithValue("@Servicio", servicio);
                cmd.Parameters.AddWithValue("@Cambio", cambio);
                cmd.Parameters.AddWithValue("@DetalleCambio", detalleCambio);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@fechaterminacion", fecha);
                cmd.Parameters.AddWithValue("@idEmpleado", id);

                cmd = UsoBD.procInsert(cmd, con);

                if (cmd == null)
                {
                    MessageBox.Show("ERROR EN EL INSERTAR");
                    foreach (SqlError er in UsoBD.ESalida.Errors)
                    {
                        MessageBox.Show(er.Message);
                    }
                    con.Close();
                    return;
                }
                MessageBox.Show("SE HA TERMINADO ESTA INCIDENCIA");
                limpiaDatos();
                cambiar();
            }
        }

        private void dgvIncidencia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvIncidencia.Rows)
            {
                if (row.Cells["Prioridad"].Value == null)
                {
                    row.Cells["Prioridad"].Style.BackColor = Color.White;
                    return;
                }
                if (row.Cells["Estatus"].Value.ToString() == "Terminada")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(0, 176, 246);
                }
                else if (row.Cells["Prioridad"].Value.Equals("ALTA"))
                {
                    row.Cells["Prioridad"].Style.BackColor = Color.OrangeRed;
                }
                else if (row.Cells["Prioridad"].Value.Equals("MEDIA"))
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row 

                    row.Cells["Prioridad"].Style.BackColor = Color.Yellow;
                }
                else if (row.Cells["Prioridad"].Value.Equals("BAJA"))
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row 

                    row.Cells["Prioridad"].Style.BackColor = Color.Lime;
                }
            }
        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPieza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComboBox = cmbPieza.SelectedItem.ToString();
            if (ComboBox != "Si")
            {
                txtPieza.Visible = false;
                labelPieza.Visible = false;
            }
            else
            {
                txtPieza.Visible = true;
                labelPieza.Visible = true;
            }
        }
    }
}


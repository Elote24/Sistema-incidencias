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
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            cmbIncidencia.Items.Clear();
            cmbSolicitud.SelectedIndex = 0;
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
            string strComando = "select *from Incidencia where Estatus='Solicitud'";
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
            if (cmbIncidencia.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                string idIncidencia = cmbIncidencia.Text;
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
                string strComando = "select * from Incidencia where id=" + idIncidencia;
                SqlCommand cmd = new SqlCommand(strComando, con);
                try
                {
                    Lector = cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {

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
                    while (Lector.Read())
                    {
                        dataGridView1.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10), Lector.GetValue(11), Lector.GetValue(12), Lector.GetValue(13), Lector.GetValue(14), Lector.GetValue(15));
                    }
                }
                Lector.Close();

                SqlDataReader Lector2 = null;
                string strComando2 = "select Descripcion from equipo where Id = (select id_equipo from Incidencia where id=" + idIncidencia + ")";
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

        }

        private void cmbSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComboBox = cmbSolicitud.SelectedItem.ToString();
            if (ComboBox != "Si")
            {
                txtEquipo.Visible = false;
                lblDetalles.Visible = false;
            }
            else
            {
                txtEquipo.Visible = true;
                lblDetalles.Visible = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
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


        public bool validaDato()
        {
            bool re = false;
            string descripcion = txtEquipo.Text;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO PUEDE DEJAR VACIA LA DESCRIPCION DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }


            if (cmbIncidencia.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO NINGUNA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbSolicitud.SelectedIndex == 0)
            {
                DialogResult kk = MessageBox.Show("ERROR: SELECCIONE SI ACEPTARA EL CAMBIO DE PIEZA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }

            return re;
        }
        public void limpiaDatos()
        {
            cmbIncidencia.Items.Clear();
            cmbIncidencia.SelectedIndex = -1;
            cmbIncidencia.Text = "-Seleccionar-";
            txtEquipo.Text = "";
            cmbSolicitud.SelectedIndex = 0;
            dataGridView1.Rows.Clear();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            string incidencia = cmbIncidencia.Text.ToString();
            string solicitud = cmbSolicitud.Text;
            string Descripcion = txtEquipo.Text;

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
                SqlCommand cmd = new SqlCommand("Solicitudes");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@idincidencia", incidencia);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Solicitud", solicitud);


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
            }
        }
    }
}

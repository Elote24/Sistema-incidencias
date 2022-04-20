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
    public partial class frmVerIncidenciasXEmpleado : Form
    {
        string id;
        public frmVerIncidenciasXEmpleado()
        {
            InitializeComponent();
        }

        private void frmVerIncidenciasXEmpleado_Load(object sender, EventArgs e)
        {
            limpiar();
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
            string strComando = "select Id from Empleado";
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
                //Lleno combo box
                cmbEmpleado.Items.Clear();
                while (Lector.Read())
                {
                    cmbEmpleado.Items.Add(Lector.GetValue(0).ToString());
                    id = Lector.GetValue(0).ToString() ;
                }
            }
            Lector.Close();
            con.Close();
        }

        public void limpiar()
        {
            cmbEmpleado.SelectedIndex = -1;
            cmbEmpleado.Text = "-Seleccionar-";
            dtIncidencia.Rows.Clear();
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtDepartamento.Text = "";
            txtNombre.Text = "";
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex != -1)
            {
                string idEmpleado = cmbEmpleado.Text.ToString();
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

                dtIncidencia.Rows.Clear();
                SqlDataReader Lectorincidencia = null;
                string strComandoincidencia = "select * from Incidencia where Id_Empleado=" + idEmpleado;
                SqlCommand cmdIncidencia = new SqlCommand(strComandoincidencia, con);
                try
                {
                    Lectorincidencia = cmdIncidencia.ExecuteReader();
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
                if (Lectorincidencia.HasRows)
                {

                    while (Lectorincidencia.Read())
                    {
                        dtIncidencia.Rows.Add(Lectorincidencia.GetValue(0), Lectorincidencia.GetValue(1), Lectorincidencia.GetValue(2), Lectorincidencia.GetValue(3), Lectorincidencia.GetValue(4), Lectorincidencia.GetValue(5), Lectorincidencia.GetValue(6), Lectorincidencia.GetValue(7), Lectorincidencia.GetValue(8), Lectorincidencia.GetValue(9), Lectorincidencia.GetValue(10), Lectorincidencia.GetValue(11), Lectorincidencia.GetValue(12), Lectorincidencia.GetValue(13), Lectorincidencia.GetValue(14), Lectorincidencia.GetValue(15));
                    }
                }
                Lectorincidencia.Close();

                SqlDataReader Lector = null;
                string strComando = "select E.*,D.Nombre from Empleado E,Departamento D where E.Id="+idEmpleado+"  and D.Id=E.Departamento";
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
                        txtNombre.Text = Lector.GetValue(1).ToString()+" "+ Lector.GetValue(2).ToString()+" "+ Lector.GetValue(3).ToString();
                        txtCorreo.Text = Lector.GetValue(4).ToString();
                        txtCelular.Text = Lector.GetValue(6).ToString();
                        txtDepartamento.Text= Lector.GetValue(9).ToString();
                    }
                }
                Lector.Close();

                con.Close();
            }
        }

        private void dtIncidencia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dtIncidencia.Rows)
            {
                if (row.Cells["Prioridad"].Value == null)
                {
                    row.Cells["Prioridad"].Style.BackColor = Color.White;
                    return;
                }
                if (row.Cells["Estatus"].Value.ToString() == "Terminada" && row.Cells["EstatusCam"].Value.ToString() == "Rechazada")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells["Estatus"].Value.ToString() == "Terminada")
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

        private void dtIncidencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

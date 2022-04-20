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

namespace Gestion
{
    public partial class AltaIncidencia : Form
    {
        string strCon;
        string correo;
        string idEmpleado;
        string idDepartamento;
        string idEquipo;
        public AltaIncidencia(string con, string Correo)
        {
            InitializeComponent();
            strCon = con;
            correo = Correo;
            cargar();
        }
        private void AltaIncidencia_Load(object sender, EventArgs e)
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
            string strComando = "select Equipo from Equipo E where Id_Empleado="+idEmpleado;
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
                cmbEquipo.Items.Clear();
                while (Lector.Read())
                {
                    cmbEquipo.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            else
            {
                MessageBox.Show("USTED NO TIENE EQUIPOS");
                button1.Enabled = false;
            }
            Lector.Close();
            con.Close();
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
            string strComando1 = "Select Id,Departamento from Empleado where Correo='" + correo + "'";
            SqlCommand cmd = new SqlCommand(strComando1, con);
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
                    idEmpleado = Lector.GetValue(0).ToString();
                    idDepartamento = Lector.GetValue(1).ToString();
                }
            }
            else
            {
            }
            Lector.Close();

         
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {
                string strComando = "INSERT INTO Incidencia (Descripcion,Fecha_Levantamiento,Id_Empleado,Estatus,Id_Equipo,Id_Departamento)" +
                    "values (@des,@fecha,@idEmpl,@estatus,@equipo,@idDep)";

                string Descripcion = txtDESCRIPCION.Text.ToString();
                DateTime fecha = dtFECHA.Value;
                if (validaDato() == false )
                {
                    Manejadora.Command.Parameters.AddWithValue("@des", Descripcion);
                    Manejadora.Command.Parameters.AddWithValue("@fecha", fecha);
                    Manejadora.Command.Parameters.AddWithValue("@idEmpl", idEmpleado);
                    Manejadora.Command.Parameters.AddWithValue("@estatus", "No asignada");
                    Manejadora.Command.Parameters.AddWithValue("@equipo", idEquipo);
                    Manejadora.Command.Parameters.AddWithValue("@idDep", idDepartamento);


                    if (Manejadora.executeCommand(strComando) == true)
                    {
                        Manejadora.Command.Parameters.Clear();
                        MessageBox.Show("INCIDENCIA CAPTURADA CORRECTAMENTE");
                        limpiar();
                    }
                }
                
            }
        }


        public void limpiar()
        {
            txtDESCRIPCION.Text = "";
            cmbEquipo.SelectedIndex = -1;
            cmbEquipo.Text = "-Seleccionar-";
        }

        public bool validaDato()
        {
            bool re = false;
            string descripcion = txtDESCRIPCION.Text;
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO LA DESCRIPCION DEL PROBLEMA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbEquipo.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL EQUIPO DONDE TIENE LA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEquipo = cmbEquipo.Text.ToString();
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
            string strComando = "select Id from Equipo where Equipo= '" + nombreEquipo + "'";
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
                    idEquipo = Lector.GetValue(0).ToString();
                }
            }
            Lector.Close();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtFECHA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

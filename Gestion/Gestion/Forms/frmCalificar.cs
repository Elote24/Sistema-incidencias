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
    public partial class frmCalificar : Form
    {
        string correo;
        string id;
        public frmCalificar(string correo)
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

        public void cargarcombo()
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
            string strComando = "select id from incidencia where Calificacion is null and Estatus='Terminada' and Id_Empleado=" + id;
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
                cmbIncidencia.Items.Clear();
                while (Lector.Read())
                {
                    cmbIncidencia.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
        }

        private void frmCalificar_Load(object sender, EventArgs e)
        {

            cargarcombo();
            
        }

        public bool validaDato()
        {
            bool re = false;


            if (cmbIncidencia.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO NINGUNA INCIDENCIA PARA CALIFICAR", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }

            return re;
        }

        public void limpiaDatos()
        {
            cmbIncidencia.SelectedIndex = -1;
            cmbIncidencia.Text = "-Seleccionar-";
            Numeric.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string incidencia = cmbIncidencia.Text.ToString();
            string calificacion = Numeric.Value.ToString();

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
                SqlCommand cmd = new SqlCommand("CalificaIncidencia");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@idincidencia", incidencia);
                cmd.Parameters.AddWithValue("@calificacion", calificacion);


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
                MessageBox.Show("SE HA CALIFICADO ESTA INCIDENCIA");
                limpiaDatos();
                cmbIncidencia.Items.Clear();
                dataGridView1.Rows.Clear();
                cargarcombo();
                con.Close();
            }
        }

        private void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidencia.SelectedIndex != -1)
            {
                string idIncidencia = cmbIncidencia.Text.ToString();
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

                dataGridView1.Rows.Clear();
                SqlDataReader Lectorincidencia = null;
                string strComandoincidencia = "select * from Incidencia where Id_Empleado=" + id + " and id=" + idIncidencia;
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
                        dataGridView1.Rows.Add(Lectorincidencia.GetValue(0), Lectorincidencia.GetValue(1), Lectorincidencia.GetValue(2), Lectorincidencia.GetValue(3), Lectorincidencia.GetValue(4), Lectorincidencia.GetValue(5), Lectorincidencia.GetValue(6), Lectorincidencia.GetValue(7), Lectorincidencia.GetValue(8), Lectorincidencia.GetValue(9), Lectorincidencia.GetValue(10), Lectorincidencia.GetValue(11), Lectorincidencia.GetValue(12), Lectorincidencia.GetValue(13), Lectorincidencia.GetValue(14), Lectorincidencia.GetValue(15));
                    }
                }
                Lectorincidencia.Close();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

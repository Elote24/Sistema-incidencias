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
    public partial class frmAsignaIncidencias : Form
    {
        public frmAsignaIncidencias()
        {
            InitializeComponent();
        }

        private void frmAsignaIncidencias_Load(object sender, EventArgs e)
        {
            LlenaCmb();
        }

        public void LlenaCmb()
        {
            cbTIPO.SelectedIndex = 0;
            cmbPrioridad.SelectedIndex = 0;
            cargardtgv();
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

            SqlDataReader LectorTecnico2 = null;
            string strComandoTecnico2 = "select id from Tecnico";
            SqlCommand cmdTecnico2 = new SqlCommand(strComandoTecnico2, con);
            try
            {
                LectorTecnico2 = cmdTecnico2.ExecuteReader();
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
            if (LectorTecnico2.HasRows)
            {
                //Lleno combo box
                cmbTecnico.Items.Clear();
                while (LectorTecnico2.Read())
                {
                    cmbTecnico.Items.Add(LectorTecnico2.GetValue(0).ToString());
                }
            }
            LectorTecnico2.Close();

            con.Close();
        }

        public void cargardtgv()
        {
            dataGridView1.Rows.Clear();
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
            string strComando = "select * from Incidencia where Estatus='No asignada'";
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
                    dataGridView1.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10), Lector.GetValue(11), Lector.GetValue(12), Lector.GetValue(13), Lector.GetValue(14),Lector.GetValue(15));
                }
            }
            Lector.Close();

            //
            dgvTecnico.Rows.Clear();
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in LibreriaBD.UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
            SqlDataReader LectorTecnico = null;
            string strComandoTecnico = "select T.id,E.nombre+' '+E.Apellido_Paterno+' '+E.Apellido_Materno ,T.Especializacion,T.certificaciones,T.Incidencias_Asignadas from Tecnico T,Empleado E where T.Id_Empleado=E.Id";
            SqlCommand cmdTecnico = new SqlCommand(strComandoTecnico, con);
            try
            {
                LectorTecnico = cmdTecnico.ExecuteReader();
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
            if (LectorTecnico.HasRows)
            {

                while (LectorTecnico.Read())
                {
                    dgvTecnico.Rows.Add(LectorTecnico.GetValue(0), LectorTecnico.GetValue(1), LectorTecnico.GetValue(2), LectorTecnico.GetValue(3), LectorTecnico.GetValue(4));
                }
            }
            LectorTecnico.Close();
            SqlDataReader LectorId = null;
            string strComandoIncidencia = "select ID from Incidencia where Estatus='No asignada'";
            SqlCommand cmdIncidencia = new SqlCommand(strComandoIncidencia, con);
            try
            {
                LectorId = cmdIncidencia.ExecuteReader();
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
            if (LectorId.HasRows)
            {
                //Lleno combo box
                cmbIncidencia.Items.Clear();
                while (LectorId.Read())
                {
                    cmbIncidencia.Items.Add(LectorId.GetValue(0).ToString());
                }
            }
            LectorId.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string incidencia = cmbIncidencia.Text.ToString();
            string Tecnico = cmbTecnico.Text.ToString();
            DateTime fecha = dateTimePicker2.Value.Date;
            string prioridad = cmbPrioridad.Text.ToString();
            string tipo = cbTIPO.Text.ToString();

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
                SqlCommand cmd = new SqlCommand("AsignarIncidencias");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@IdTecnico", Tecnico);
                cmd.Parameters.AddWithValue("@Idincidencia", incidencia);
                cmd.Parameters.AddWithValue("@FechaInicio", fecha);
                cmd.Parameters.AddWithValue("@prioridad", prioridad);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
               


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
                MessageBox.Show("SE HA ASIGNADO ESTA INCIDENCIA");
                cargardtgv();
                limpiaDatos();
            }
        }



        public void limpiaDatos()
        {
            cmbIncidencia.Items.Clear();
            cmbIncidencia.SelectedIndex = -1;
            cmbIncidencia.Text = "-Seleccionar-";
            cbTIPO.SelectedIndex = 0;
            cmbPrioridad.SelectedIndex = 0;
            cmbTecnico.SelectedIndex = -1;
            cmbTecnico.Text = "-Seleccionar-";
            LlenaCmb();
        }

        public bool validaDato()
        {
            bool re = false;


            if (cbTIPO.SelectedIndex == 0)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO EL TIPO DE LA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbPrioridad.SelectedIndex == 0)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO LA PRIORIDAD DE LA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbIncidencia.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO NINGUNA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbTecnico.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO SELECCIONO EL TECNICO QUE REALIZARA LA INCIDENCIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void cmbIncidencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


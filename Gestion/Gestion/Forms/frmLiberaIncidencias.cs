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
    public partial class frmLiberaIncidencias : Form
    {
        string idIncidencia;
        public frmLiberaIncidencias()
        {
            InitializeComponent();
        }

        private void frmLiberaIncidencias_Load(object sender, EventArgs e)
        {
            string strCon = Utileria.GetConnectionString();
            SqlConnection con = LibreriaBD.UsoBD.ConectaBD(strCon);
            SqlDataReader LectorId = null;
            string strComandoIncidencia = "select Id_Incidencia from asignaIncidencias";
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
                    idIncidencia = LectorId.GetValue(0).ToString();
                }
            }
            LectorId.Close();

            dataGridView1.Rows.Clear();
            
            if (con == null)
            {
                MessageBox.Show("Imposible conectar en bd");
                foreach (SqlError err in LibreriaBD.UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(err.Message);
                }
            }
            SqlDataReader Lector = null;
            string strComando = "select * from Incidencia where id="+idIncidencia;
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
                    dataGridView1.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10), Lector.GetValue(11), Lector.GetValue(12), Lector.GetValue(13), Lector.GetValue(14), Lector.GetValue(15));
                }
            }
            Lector.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string incidencia = cmbIncidencia.SelectedItem.ToString();
            DateTime fecha = dtFecha.Value.Date;

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

            SqlCommand cmd = new SqlCommand("LiberaIncidencia");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@idincidencia", incidencia);
            cmd.Parameters.AddWithValue("@fechaterminacion", fecha);


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
            MessageBox.Show("SE HA LIBERADO ESTA INCIDENCIA");
        }
    }
    }


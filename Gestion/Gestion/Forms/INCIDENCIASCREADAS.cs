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
    public partial class INCIDENCIASCREADAS : Form
    {
        string Correo;
        string id;
        public INCIDENCIASCREADAS(string Correo)
        {
            InitializeComponent();
            this.Correo = Correo;
            cargar();
        }

        private void INCIDENCIASCREADAS_Load(object sender, EventArgs e)
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


            dataGridView1.Rows.Clear();
            SqlDataReader Lectorincidencia = null;
            string strComandoincidencia = "select * from Incidencia where Id_Empleado=" + id;
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
            string strComando = "Select id from Empleado where Correo='" + Correo + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

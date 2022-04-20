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
    public partial class VerIncidencias : Form
    {
        public VerIncidencias()
        {
            InitializeComponent();
        }

        private void VerIncidencias_Load(object sender, EventArgs e)
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
            string strComando = "select * from Incidencia";
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
    }
}

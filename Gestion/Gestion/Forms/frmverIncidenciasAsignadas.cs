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
    public partial class frmverIncidenciasAsignadas : Form
    {
        string correo;
        string id;
        public frmverIncidenciasAsignadas(string correo)
        {
            InitializeComponent();
            this.correo = correo;
           
        }

        private void frmverIncidenciasAsignadas_Load(object sender, EventArgs e)
        {
            cargar();
            dgvIncidencia.Rows.Clear();
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
            string strComando = "select I.*,(select D.Nombre from Departamento D where D.Id=I.Id_Departamento),(select E.Nombre+' '+E.Apellido_Paterno+' '+E.Apellido_Materno from Empleado E where E.Id=I.Id_Empleado),(select (select ed.Nombre from Edificio ed where ed.Id = eq.Edificio) from Equipo eq where i.Id_Equipo = eq.Id),(select (select cu.Nombre from Cubiculo cu where cu.Id = eq2.Cubiculo) from Equipo eq2 where i.Id_Equipo = eq2.Id) from Incidencia I where I.Id in (select A.Id_Incidencia from asignaIncidencias A where A.Id_Tecnico=(select T.id from Tecnico T where T.Id_Empleado ="+id+"))";
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
                    dgvIncidencia.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10), Lector.GetValue(11), Lector.GetValue(12), Lector.GetValue(13), Lector.GetValue(17), Lector.GetValue(14), Lector.GetValue(15), Lector.GetValue(16), Lector.GetValue(18), Lector.GetValue(19));
                }
            }
            Lector.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIncidencia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvIncidencia.Rows)
            {
                if (row.Cells["EstatusCam"].Value == null)
                {
                    row.Cells["EstatusCam"].Style.BackColor = Color.White;
                    return;
                }
                if (row.Cells["Estatus"].Value.ToString().Equals("Terminada") && row.Cells["EstatusCam"].Value.ToString().Equals("Rechazada"))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (row.Cells["Estatus"].Value.ToString() == "Terminada")
                {
                    row.DefaultCellStyle.BackColor = Color.Cyan;
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

        private void dgvIncidencia_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

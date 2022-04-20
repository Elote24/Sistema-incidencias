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
    public partial class frmConsultaEmpleados : Form
    {
        public frmConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void frmConsultaEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
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
            string strComando = "select e.Id,e.Nombre,e.Apellido_Paterno,e.Apellido_Materno,e.Correo,e.Contraseña,e.Celular,e.Puesto,d.Nombre from Empleado e,Departamento d where  e.Departamento=d.id";
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
                    dgvEmpleados.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8));
                }
            }
            Lector.Close();
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

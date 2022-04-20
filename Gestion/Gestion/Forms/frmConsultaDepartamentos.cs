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
    public partial class frmConsultaDepartamentos : Form
    {
        public frmConsultaDepartamentos()
        {
            InitializeComponent();
        }

        private void frmConsultaDepartamentos_Load(object sender, EventArgs e)
        {
            dgvDepartamentos.Rows.Clear();
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
            string strComando = "select * from Departamento";
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
                    dgvDepartamentos.Rows.Add(Lector.GetValue(0), Lector.GetValue(1));
                }
            }
            Lector.Close();
            con.Close();
        }
    }
}

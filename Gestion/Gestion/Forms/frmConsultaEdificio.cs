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
    public partial class frmConsultaEdificio : Form
    {
        public frmConsultaEdificio()
        {
            InitializeComponent();
        }

        private void frmConsultaEdificio_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            dgvEdificio.Rows.Clear();
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
            string strComando = "select Id from Departamento";
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
                cmbDepartamento.Items.Clear();
                while (Lector.Read())
                {
                    cmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEdificio.Rows.Clear();
            string idDepartamento = cmbDepartamento.Text.ToString();
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
            string strComando = "select * from Edificio where Id_Departamento= " + idDepartamento;
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
                    dgvEdificio.Rows.Add(Lector.GetValue(0), Lector.GetValue(1));
                }
            }
            Lector.Close();

            SqlDataReader LectorDepartamento = null;
            string strComandoDepartamento = "select Nombre from Departamento  where id=" + idDepartamento ;
            SqlCommand cmdDepartamento = new SqlCommand(strComandoDepartamento, con);
            try
            {
                LectorDepartamento = cmdDepartamento.ExecuteReader();
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
            if (LectorDepartamento.HasRows)
            {

                while (LectorDepartamento.Read())
                {
                    txtNombre.Text = LectorDepartamento.GetValue(0).ToString() ;
                    
                }
            }
            LectorDepartamento.Close();

            con.Close();

        }
    }
}

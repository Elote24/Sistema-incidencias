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
    public partial class frmConsultaCubiculo : Form
    {
        public frmConsultaCubiculo()
        {
            InitializeComponent();
        }

        private void frmConsultaCubiculo_Load(object sender, EventArgs e)
        {
            LimpiarDepartamento();
            dgvCubiculo.Rows.Clear();
            LimpiarEdificio();
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
            string strComando = "select id from Departamento";
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
                    cmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }



        public void LimpiarDepartamento()
        {
            cmbDepartamento.Items.Clear();
            cmbDepartamento.Text = "-Seleccionar-";
        }

        public void LimpiarEdificio()
        {
            cmbEdificio.Items.Clear();
            cmbEdificio.Text = "-Seleccionar-";
        }

        private void cmbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCubiculo.Rows.Clear();
            string idEdificio = cmbEdificio.Text.ToString();
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
            string strComando = "select * from Cubiculo where Id_Edificio= " + idEdificio;
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
                    dgvCubiculo.Rows.Add(Lector.GetValue(0), Lector.GetValue(1));
                }
            }
            Lector.Close();


            SqlDataReader LectorDepartamento = null;
            string strComandoDepartamento = "select Nombre from Edificio  where id=" + idEdificio;
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
                    txtNombre.Text = LectorDepartamento.GetValue(0).ToString();

                }
            }
            LectorDepartamento.Close();

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDepartamento = cmbDepartamento.Text;
            LimpiarEdificio();
            txtDepartamento.Text = "";
            txtNombre.Text = "";
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
                    cmbEdificio.Items.Add(Lector.GetValue(0).ToString());

                }
            }
            else
            {
            }
            Lector.Close();


            Lector = null;
            strComando = "select * from Departamento where id= " + idDepartamento;
            cmd = new SqlCommand(strComando, con);
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
                    txtDepartamento.Text = Lector.GetValue(1).ToString();

                }
            }
            else
            {
            }
            Lector.Close();




            con.Close();
        }
    }
}

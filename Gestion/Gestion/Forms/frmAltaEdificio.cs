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
    public partial class frmAltaEdificio : Form
    {
        string con;
        public frmAltaEdificio(string con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {
                string strComando = "INSERT INTO Edificio (Nombre,Id_Departamento)" +
                    "values (@nom,@idDep)";
                if (validaDato() == false && validaDuplicados() == false)
                {
                    string nombre = txtNombre.Text;
                    string idDep = CmbDepartamento.Text;
                    Manejadora.Command.Parameters.AddWithValue("@nom", nombre);
                    Manejadora.Command.Parameters.AddWithValue("@idDep", idDep);

                    if (Manejadora.executeCommand(strComando) == true)
                    {
                        Manejadora.Command.Parameters.Clear();
                        MessageBox.Show("SE HA REGISTRADO EL EDIFICIO");
                        limpiaDatos();
                    }
                }
            }
        }


        public void limpiaDatos()
        {
            txtNombreDep.Text = "";
            txtNombre.Text = "";
            CmbDepartamento.SelectedIndex = -1;
            CmbDepartamento.Text = "-Seleccionar-";
        }



        public bool validaDuplicados()
        {
            bool RES = false;
            string nombre = txtNombre.Text;
            string consultaNombre = "select Nombre FROM Edificio WHERE nombre ='" + nombre + "'";
            if (Manejadora.existe(consultaNombre))
            {
                MessageBox.Show("EL EDIFICO YA EXISTE", "Error");
                RES = true;
            }
            return RES;
        }

        public bool validaDato()
        {
            bool re = false;
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL NOMBRE DEL EDIFICIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (CmbDepartamento.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL DEPARTAMENTO DEL EDIFICIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void frmAltaEdificio_Load(object sender, EventArgs e)
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
                CmbDepartamento.Items.Clear();
                while (Lector.Read())
                {
                    CmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDepartamento = CmbDepartamento.Text.ToString();
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
            string strComando = "select Nombre from Departamento where Id= " + idDepartamento;
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
                    txtNombreDep.Text = Lector.GetValue(0).ToString();
                }
            }
            Lector.Close();
        }
    }
}

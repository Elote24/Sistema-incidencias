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
    public partial class frmAltaCubiculo : Form
    {
        string con;
        public frmAltaCubiculo(string con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {
                string strComando = "INSERT INTO Cubiculo (Nombre,Id_Edificio)" +
                    "values (@nom,@idEdif)";
                if (validaDato() == false && validaDuplicados() == false)
                {
                    string nombre = txtNombre.Text;
                    string idEdif = CmbEdificio.Text;
                    Manejadora.Command.Parameters.AddWithValue("@nom", nombre);
                    Manejadora.Command.Parameters.AddWithValue("@idEdif", idEdif);

                    if (Manejadora.executeCommand(strComando) == true)
                    {
                        Manejadora.Command.Parameters.Clear();
                        MessageBox.Show("SE HA REGISTRADO EL CUBICULO");
                        limpiaDatos();
                    }
                }
            }
        }


        public void limpiaDatos()
        {
            txtNombre.Text = "";
            txtNombreEdi.Text = "";
            CmbEdificio.SelectedIndex = -1;
            CmbEdificio.Text = "-Seleccionar-";
        }



        public bool validaDuplicados()
        {
            bool RES = false;
            string nombre = txtNombre.Text;
            string consultaNombre = "select Nombre FROM Cubiculo WHERE nombre ='" + nombre + "'";
            if (Manejadora.existe(consultaNombre))
            {
                MessageBox.Show("EL CUBICULO YA EXISTE", "Error");
                RES = true;
            }
            if (CmbEdificio.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL EDIFICIO DEL CUBICULO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL NOMBRE DEL CUBICULO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void frmAltaCubiculo_Load(object sender, EventArgs e)
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
            string strComando = "select Id from Edificio";
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
                CmbEdificio.Items.Clear();
                while (Lector.Read())
                {
                    CmbEdificio.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }

        private void CmbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idEdif = CmbEdificio.Text.ToString();
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
            string strComando = "select Nombre from Edificio where Id= " + idEdif;
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
                    txtNombreEdi.Text = Lector.GetValue(0).ToString();
                }
            }
            Lector.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion.Forms
{
    public partial class FrmAltaDepartamento : Form
    {
        string con;
        public FrmAltaDepartamento(String con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {
                string strComando = "INSERT INTO Departamento (Nombre)" +
                    "values (@nom)";
                if (validaDato() == false && validaDuplicados() == false)
                {
                    string nombre = txtNombre.Text;
                    Manejadora.Command.Parameters.AddWithValue("@nom", nombre);

                    if (Manejadora.executeCommand(strComando) == true)
                    {
                        Manejadora.Command.Parameters.Clear();
                        MessageBox.Show("SE HA REGISTRADO EL DEPARTAMENTO");
                        limpiaDatos();
                    }
                }
            }
        }
        public void limpiaDatos()
        {
            txtNombre.Text = "";
        }



        public bool validaDuplicados()
        {
            bool RES = false;
            string nombre = txtNombre.Text;
            string consultaNombre = "select Nombre FROM Departamento WHERE nombre ='" + nombre + "'";
            if (Manejadora.existe(consultaNombre))
            {
                MessageBox.Show("EL DEPARTAMENTO YA EXISTE", "Error");
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
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL NOMBRE DEL DEPARTAMENTO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void FrmAltaDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}

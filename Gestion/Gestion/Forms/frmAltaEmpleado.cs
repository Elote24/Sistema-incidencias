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
    public partial class frmAltaEmpleado : Form
    {
        string strCon;
        public frmAltaEmpleado(string con)
        {
            InitializeComponent();
            cmbPuesto.SelectedIndex = 0;
            cmbDepartamento.SelectedIndex = 0;
            strCon = con;
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
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
                cmbDepartamento.Items.Clear();
                while (Lector.Read())
                {
                    cmbDepartamento.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {
                if (validaDato() == false && validaDuplicados() == false)
                {
                    string nombre = txtNombre.Text;
                    string apPaterno = txtApaterno.Text;
                    string apMaterno = txtAMaterno.Text;
                    string correo = txtCorreo.Text;
                    string contraseña = txtContraseña.Text;
                    string telefono = txtCelular.Text;
                    string puesto = cmbPuesto.Text.ToString();
                    string certificacion = txtCertificacion.Text;
                    string especializacion = txtEspecializacion.Text;
                    string departamento = cmbDepartamento.Text.ToString();
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

                    SqlCommand cmd = new SqlCommand("AltaEmpleado");
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@ApellidoPat", apPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMat", apMaterno);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Celular", telefono);
                    cmd.Parameters.AddWithValue("@Puesto", puesto);
                    cmd.Parameters.AddWithValue("@Departamento", departamento);
                    cmd.Parameters.AddWithValue("@Especializacion", especializacion);
                    cmd.Parameters.AddWithValue("@Certificaciones", certificacion);


                    cmd = UsoBD.procInsert(cmd, con);
                    
                    MessageBox.Show("SE HA REGISTRADO EL EMPLEADO");
                    limpiaDatos();
                    con.Close();
                }
            }
        }

        public void limpiaDatos()
        {
            txtNombre.Text = "";
            txtAMaterno.Text = "";
            txtApaterno.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            cmbDepartamento.SelectedIndex = -1;
            cmbDepartamento.Text = "-Seleccionar-";
            txtnomDepa.Text = "";
            cmbPuesto.SelectedIndex = 0;
        }



        public bool validaDuplicados()
        {
            bool RES = false;
            string nombre = txtNombre.Text;
            string apPaterno = txtApaterno.Text;
            string apMaterno = txtAMaterno.Text;
            string consultaNombre = "select Nombre FROM Empleado WHERE nombre ='" + nombre+ "' and  Apellido_Paterno='" + apPaterno + "' and Apellido_Materno='"+apMaterno+"'";
            if (Manejadora.existe(consultaNombre))
            {
                MessageBox.Show("EL EMPLEADO YA EXISTE", "Error");
                RES = true;
            }
            string correo = txtCorreo.Text;
            string consultaCorreo = "select Correo FROM Empleado WHERE Correo ='" + correo + "'";
            if (Manejadora.existe(consultaCorreo))
            {
                MessageBox.Show("ESTE CORREO YA ESTA REGISTRADO A UN EMPLEADO", "Error");
                RES = true;
            }
            string telefono = txtCelular.Text;
            string consultaCEL = "select Celular FROM Empleado WHERE Celular ='" + telefono + "'";
            if (Manejadora.existe(consultaCEL))
            {
                MessageBox.Show("ESTE CELULAR YA ESTA REGISTRADO A UN EMPLEADO", "Error");
                RES = true;
            }

            return RES;
        }

        public bool validaDato()
        {
            bool re = false;
            string nombre = txtNombre.Text;
            string apPaterno = txtApaterno.Text;
            string apMaterno = txtAMaterno.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;
            string telefono = txtCelular.Text;
            int puesto = cmbPuesto.SelectedIndex;
            int departamento = cmbDepartamento.SelectedIndex;
            

            if (string.IsNullOrWhiteSpace(nombre))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL NOMBRE DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(apPaterno))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL APELLIDO PATERNO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(apMaterno))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL APELLIDO MATERNO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(correo))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL CORREO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO LA CONTRASEÑA DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL TELEFONO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (telefono.Length > 10)
            {
                DialogResult resultado = MessageBox.Show("ERROR EL  MAXIMO DE NUMEROS SON 10", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbPuesto.SelectedIndex == 0)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL PUESTO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbDepartamento.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL DEPARTAMENTO DEL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    txtnomDepa.Text = Lector.GetValue(0).ToString();
                }
            }
            Lector.Close();
            con.Close();
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ComboBox = cmbPuesto.SelectedItem.ToString();
            if (ComboBox != "Tecnico")
            {
                txtEspecializacion.Visible = false;
                txtCertificacion.Visible = false;
                lblEspecializacion.Visible = false;
                lblCertificaciones.Visible = false;
            }
            else
            {
                txtEspecializacion.Visible = true;
                txtCertificacion.Visible = true;
                lblEspecializacion.Visible = true;
                lblCertificaciones.Visible = true;
            }

        }

        private void lblEspecializacion_Click(object sender, EventArgs e)
        {

        }
    }
}

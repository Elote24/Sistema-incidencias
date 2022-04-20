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
    public partial class frmEditarPerfil : Form
    {
        string Correo;
        MenuPro menu;
        Login L = new Login();
        public frmEditarPerfil(string correo, MenuPro M)
        {
            MessageBox.Show("SI EDITA EL PERFIL SE CERRARA SU SESION");
            InitializeComponent();
            Correo = correo;
            cargar();
            this.menu = M;
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
            string strComando = "Select Nombre,Apellido_Paterno,Apellido_Materno,Correo,Contraseña,Celular from Empleado where Correo='" + Correo + "'";
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
                    txtNombre.Text = Lector.GetValue(0).ToString();
                    txtApaterno.Text = Lector.GetValue(1).ToString();
                    txtAMaterno.Text = Lector.GetValue(2).ToString();
                    txtCorreo.Text = Lector.GetValue(3).ToString();
                    txtContraseña.Text = Lector.GetValue(4).ToString();
                    txtCelular.Text = Lector.GetValue(5).ToString();
                }
            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO");
            }
            Lector.Close();
            con.Close();
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string apPaterno = txtApaterno.Text;
            string apMaterno = txtAMaterno.Text;
            string correo = txtCorreo.Text;
            string contraseña = txtContraseña.Text;
            string celular = txtCelular.Text;

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

            SqlCommand cmd = new SqlCommand("CambiaPerfil");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPat", apPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMat", apMaterno);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);
            cmd.Parameters.AddWithValue("@celular", celular);


            cmd = UsoBD.procInsert(cmd, con);

            if (cmd == null)
            {
                MessageBox.Show("ERROR EN EL INSERTAR");
                foreach (SqlError er in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(er.Message);
                }
                con.Close();
                return;
            }
            MessageBox.Show("SE HA MODIFICADO EL PERFIL,SE CERRARA SU SESION");
            con.Close();
            menu.Close();
            this.Close();
            L.Show();
        }
    }
}

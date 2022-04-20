using Gestion.Forms;
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

namespace Gestion
{
    public partial class Login : Form
    {
        MenuPro frmMenu;
        public string correo;
        public string contraseña;
        public Login()
        {
            InitializeComponent();
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bINGRESAR_Click(object sender, EventArgs e)
        {
            String Correo = txtCorreo.Text;
            String Contraseña = txtCONTRASEÑA.Text;
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
            string strComando = "Select Correo,Contraseña from Empleado where Correo='"+Correo+ "'and Contraseña='"+Contraseña+"'";
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
                MessageBox.Show("INICIO DE SESION CORRECTAMENTE");
                this.correo = Correo;
                this.contraseña = Contraseña;
                frmMenu = new MenuPro(correo, contraseña);
                frmMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO");
            }
            Lector.Close();
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }
    }
}

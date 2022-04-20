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
    public partial class Menu : Form
    {
        AltaIncidencia frmAltaIncidencia;
        VerIncidencias frmConsultaIncidencias;
        frmAltaEmpleado frmAltaEmpleado;
        frmConsultaEmpleados frmConsultaEmpleados;
        FrmAltaDepartamento frmaltaDepartamento;
        frmConsultaDepartamentos frmConsultaDepartamentos;
        frmAltaEquipo frmAltaEquipo;
        frmConsultaEquipos frmConsultaEquipos;
        frmEditarPerfil frmEditarPerfil;
        frmAsignaIncidencias frmAsignaIncidencia;
        frmLiberaIncidencias FrmLiberaIncidencias;
        frmCalificar frmCalificar;
        INCIDENCIASCREADAS iNCIDENCIASCREADAS;
        frmIncidenciasAsignadas frmIncidenciasAsignadas;
        frmverIncidenciasAsignadas frmVerIncidenciasAsignadas;
        frmVerIncidenciasXEmpleado frmVerIncidenciasXEmpleado;
        string correo;
        string contraseña;

        public Menu(String Correo,String Contraseña)
        {
            InitializeComponent();
            frmConsultaIncidencias = new VerIncidencias();
            frmAltaEmpleado = new frmAltaEmpleado(con);
            frmConsultaEmpleados = new frmConsultaEmpleados();
            frmaltaDepartamento = new FrmAltaDepartamento(con);
            frmConsultaDepartamentos = new frmConsultaDepartamentos();
            frmAltaEquipo = new frmAltaEquipo(con);
            frmConsultaEquipos = new frmConsultaEquipos();
            correo = Correo;
            frmAltaIncidencia = new AltaIncidencia(con,correo);
            contraseña = Contraseña;
            bloquear();
        }
        string con = Utileria.GetConnectionString();

        private void aLTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaIncidencia.ShowDialog();
        }

        private void vERINCIDENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidencias.ShowDialog();
        }

        private void aLTAEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Manejadora.inicializar(Utileria.GetConnectionString());

            
        }

        private void bloquear()
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
            string strComando = "Select Puesto from Empleado where Correo='" + correo + "'and Contraseña='" + contraseña + "'"; 
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
                    if (!Lector.GetValue(0).Equals("Administrador"))
                    {
                        eMPLEADOSToolStripMenuItem.Enabled = false;
                        dEPARTAMENTOSToolStripMenuItem.Enabled = false;
                        eQUIPOSToolStripMenuItem.Enabled = false;
                        aSIGNARINCIDENCIASToolStripMenuItem.Enabled = false;
                        vERINCIDENCIASToolStripMenuItem.Enabled = false;
                    }
                    if (!Lector.GetValue(0).Equals("Tecnico"))
                    {
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTO");
            }
            Lector.Close();
            con.Close();
        }

        

        private void vEREMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleados.ShowDialog();
        }

        private void aLTADEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaltaDepartamento.ShowDialog();
        }

        private void vERDEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamentos.ShowDialog();
        }

        private void aLTAEQUIPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaEquipo.ShowDialog();
        }

        private void cONSULTAEQUIPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEquipos.ShowDialog();
        }

        private void iNCIDENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aSIGNARINCIDENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaIncidencia = new frmAsignaIncidencias();
            frmAsignaIncidencia.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eQUIPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lIBERARINCIDENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLiberaIncidencias = new frmLiberaIncidencias();
            FrmLiberaIncidencias.Show();

        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            
        }

        private void cALIFICAINCIDENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalificar = new frmCalificar(correo);
            frmCalificar.Show();
        }

        private void vERINCIDENCIASINDIVIDUALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iNCIDENCIASCREADAS = new INCIDENCIASCREADAS(correo);
            iNCIDENCIASCREADAS.Show();
        }

        private void vERINCIDENCIASASIGNADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sOLUCIONARINCIDENCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIncidenciasAsignadas = new frmIncidenciasAsignadas(correo);
            frmIncidenciasAsignadas.Show();
        }

        private void vERINCIDENCIASASIGNADASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerIncidenciasAsignadas= new frmverIncidenciasAsignadas(correo);
            frmVerIncidenciasAsignadas.Show();
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login();
            L.Show();
        }

        private void vERINCIDENCIASDEEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerIncidenciasXEmpleado = new frmVerIncidenciasXEmpleado();
            frmVerIncidenciasXEmpleado.ShowDialog();
        }
    }
}

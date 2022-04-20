using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion.Forms
{
    public partial class MenuPro : Form
    {
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
        string tipoE;
        string con = Utileria.GetConnectionString();

        public MenuPro(String Correo, String Contraseña)
        {
            InitializeComponent();
            personalizarDiseño();    
            correo = Correo;
            contraseña = Contraseña;
        }

        private void personalizarDiseño()
        {
            panelsubmenuDepartamento.Visible = false;
            panelsubmenuEmpleado.Visible = false;
            panelsubmenuEquipo.Visible = false;
            panelsubMenuIncidencias.Visible = false;
            panelsubMenuTecnicos.Visible = false;
        }

        private void hidesubMenu()
        {
            if (panelsubmenuDepartamento.Visible == true)
                panelsubmenuDepartamento.Visible = false;
            if (panelsubmenuEmpleado.Visible == true)
                panelsubmenuEmpleado.Visible = false;
            if (panelsubmenuEquipo.Visible == true)
                panelsubmenuEquipo.Visible = false;
            if (panelsubMenuIncidencias.Visible == true)
                panelsubMenuIncidencias.Visible = false;
            if (panelsubmenuDepartamento.Visible == true)
                panelsubMenuTecnicos.Visible = false;
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmEditarPerfil = new frmEditarPerfil(correo, this);;
            abrirFormulario(frmEditarPerfil);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubmenuEmpleado);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado frmAltaEmpleado = new frmAltaEmpleado(con);
            abrirFormulario(frmAltaEmpleado);
            hidesubMenu();
        }



        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            frmConsultaEmpleados frmConsultaEmpleados = new frmConsultaEmpleados();
            abrirFormulario(frmConsultaEmpleados);
            hidesubMenu();
        }

        private void btnAltaDepartamento_Click(object sender, EventArgs e)
        {
            FrmAltaDepartamento frmaltaDepartamento = new FrmAltaDepartamento(con);
            abrirFormulario(frmaltaDepartamento);
            hidesubMenu();
        }

        private void btnVerDepartamentos_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamentos frmConsultaDepartamentos = new frmConsultaDepartamentos();
            abrirFormulario(frmConsultaDepartamentos);
            hidesubMenu();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubmenuEquipo);
        }

        private void btnAltaEquipos_Click(object sender, EventArgs e)
        {
            frmAltaEquipo frmAltaEquipo = new frmAltaEquipo(con);
            abrirFormulario(frmAltaEquipo);
            hidesubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsultaEquipos frmConsultaEquipos = new frmConsultaEquipos();
            abrirFormulario(frmConsultaEquipos);
            hidesubMenu();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubMenuIncidencias);
        }

        private void btnAltaIncidencias_Click(object sender, EventArgs e)
        {
            AltaIncidencia frmAltaIncidencia = new AltaIncidencia(con, correo);
            abrirFormulario(frmAltaIncidencia);
            hidesubMenu();
        }

        private void btnAsignaIncidencias_Click(object sender, EventArgs e)
        {
            frmAsignaIncidencia = new frmAsignaIncidencias();
            abrirFormulario(frmAsignaIncidencia);
            hidesubMenu();
        }

        private void btnVerIncidencias_Click(object sender, EventArgs e)
        {
            VerIncidencias frmConsultaIncidencias = new VerIncidencias();
            abrirFormulario(frmConsultaIncidencias);
            hidesubMenu();
        }

        private void btnCalificaIncidencia_Click(object sender, EventArgs e)
        {
            frmCalificar = new frmCalificar(correo);
            abrirFormulario(frmCalificar);
            hidesubMenu();
        }

        private void btnVermisIncidencias_Click(object sender, EventArgs e)
        {
            iNCIDENCIASCREADAS = new INCIDENCIASCREADAS(correo);
            abrirFormulario(iNCIDENCIASCREADAS);
            hidesubMenu();
        }

        private void btnVerIncidenciasXEmpleado_Click(object sender, EventArgs e)
        {
            frmVerIncidenciasXEmpleado = new frmVerIncidenciasXEmpleado();
            abrirFormulario(frmVerIncidenciasXEmpleado);
            hidesubMenu();
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubMenuTecnicos);
        }

        private void btnVerIncidenciasasignadas_Click(object sender, EventArgs e)
        {
            frmVerIncidenciasAsignadas = new frmverIncidenciasAsignadas(correo);
            abrirFormulario(frmVerIncidenciasAsignadas);
            hidesubMenu();
        }

        private void btnSolucionIncidencia_Click(object sender, EventArgs e)
        {
            frmIncidenciasAsignadas = new frmIncidenciasAsignadas(correo);
            abrirFormulario(frmIncidenciasAsignadas);
            hidesubMenu();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login L = new Login();
            L.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelsubmenuDepartamento);
        }

        private Form activo = null;
        private void abrirFormulario(Form Formulariohijo)
        {
            if (activo != null)
                activo.Close();
            activo = Formulariohijo;
            Formulariohijo.TopLevel = false;
            Formulariohijo.FormBorderStyle = FormBorderStyle.None;
            Formulariohijo.Dock = DockStyle.Fill;
            panelFormularioFijo.Controls.Add(Formulariohijo);
            panelFormularioFijo.Tag = Formulariohijo;
            Formulariohijo.BringToFront();
            Formulariohijo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPro_Load(object sender, EventArgs e)
        {
            Manejadora.inicializar(Utileria.GetConnectionString());
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
                    tipoE = Lector.GetValue(0).ToString();
                }
            }
            DesactivaCar();
        }

        public void DesactivaCar()
        {
            if(tipoE.Equals("Usuario"))
            {
                btnEmpleado.Enabled = false;
                btnDepartamentos.Enabled = false;
                btnAsignaIncidencias.Enabled = false;
                btnTecnico.Enabled = false;
                btnEquipos.Enabled = false;
                btnVerIncidencias.Enabled = false;
                btnVerIncidenciasXEmpleado.Enabled = false;
                button3.Enabled = false;
            }
            if (tipoE.Equals("Tecnico"))
            {
                btnAlta.Enabled = false;
                btnDepartamentos.Enabled = false;
                btnAltaEquipos.Enabled = false;
                btnAsignaIncidencias.Enabled = false;
                button3.Enabled = false;
            }
            if (tipoE.Equals("Administrador"))
            {
                btnTecnico.Enabled = false;
            }
        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFormularioFijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAltaEdificio_Click(object sender, EventArgs e)
        {
            frmAltaEdificio frmaltaEdificio = new frmAltaEdificio(con);
            abrirFormulario(frmaltaEdificio);
            hidesubMenu();
        }

        private void btnAltaCubiculo_Click(object sender, EventArgs e)
        {
            frmAltaCubiculo frmaltaCubiculo = new frmAltaCubiculo(con);
            abrirFormulario(frmaltaCubiculo);
            hidesubMenu();
        }

        private void btnVerEdificio_Click(object sender, EventArgs e)
        {
            frmConsultaEdificio frmConsultaEdificio = new frmConsultaEdificio();
            abrirFormulario(frmConsultaEdificio);
            hidesubMenu();
        }

        private void btnConsultaCubiculo_Click(object sender, EventArgs e)
        {
            frmConsultaCubiculo frmConsultaCubiculo = new frmConsultaCubiculo();
            abrirFormulario(frmConsultaCubiculo);
            hidesubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerIncidenciasXEquipo frmVerIncidenciasXEquipo = new frmVerIncidenciasXEquipo();
            abrirFormulario(frmVerIncidenciasXEquipo);
            hidesubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSolicitudes frmSolicitudes = new frmSolicitudes();
            abrirFormulario(frmSolicitudes);
            hidesubMenu();
        }
    }
}

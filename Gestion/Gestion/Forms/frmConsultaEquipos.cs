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
    public partial class frmConsultaEquipos : Form
    {
        public frmConsultaEquipos()
        {
            InitializeComponent();
        }

        private void frmConsultaEquipos_Load(object sender, EventArgs e)
        {
            dgvEquipos.Rows.Clear();
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
            string strComando = "select e.Id,e.Equipo,e.Marca,e.Modelo,e.Descripcion,e.Años_Garantia,e.FechaCompra,e.Id_Empleado,d.Nombre,ED.Nombre,c.Nombre from Equipo e,Departamento d,Edificio ED,Cubiculo C where  e.Departamento=d.id and d.id=ED.Id_Departamento and ED.id=C.Id_Edificio";
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
                    dgvEquipos.Rows.Add(Lector.GetValue(0), Lector.GetValue(1), Lector.GetValue(2), Lector.GetValue(3), Lector.GetValue(4), Lector.GetValue(5), Lector.GetValue(6), Lector.GetValue(7), Lector.GetValue(8), Lector.GetValue(9), Lector.GetValue(10));
                }
            }
            Lector.Close();
            con.Close();
        }
    }
}

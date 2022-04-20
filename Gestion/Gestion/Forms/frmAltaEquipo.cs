using LibreriaBD;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion.Forms
{
    public partial class frmAltaEquipo : Form
    {
        String con;
        string dep;
        string idEdificio;
        string idCubiculo;
        public frmAltaEquipo(String con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void frmAltaEquipo_Load(object sender, EventArgs e)
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
            string strComando = "select Id from Empleado";
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
                cmbEmpleado.Items.Clear();
                while (Lector.Read())
                {
                    cmbEmpleado.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Lector.Close();
            con.Close();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCubiculo();
            LimpiarEdificio();
            string idEmpleado = cmbEmpleado.Text.ToString();
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
            string strComando = "select Nombre from Empleado where Id= " + idEmpleado;
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
                    txtnomEmpleado.Text = Lector.GetValue(0).ToString();
                }
            }
            Lector.Close();


            Lector = null;
            strComando = "Select Departamento from Empleado where Id=" + idEmpleado;
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
                    dep = Lector.GetValue(0).ToString();

                }
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
            Lector.Close();


            Lector = null;
            strComando = "Select Nombre from Departamento where id=" + dep;
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
                txtDepartamento.Text = "";
                while (Lector.Read())
                {
                    txtDepartamento.Text = Lector.GetValue(0).ToString();

                }
            }
            else
            {

            }
            Lector.Close();


            Lector = null;
            strComando = "Select * from Edificio where Id_Departamento=" + dep;
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
                    cmbEdifico.Items.Add(Lector.GetValue(1).ToString());

                }
            }
            else
            {
                
            }
            Lector.Close();


            con.Close();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult kk = MessageBox.Show("DESEA GUARDAR LOS DATOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kk == DialogResult.Yes)
            {

                string strComando = "INSERT INTO Equipo (Equipo, Marca, Modelo,Descripcion,Años_Garantia,FechaCompra,Id_Empleado,Departamento,Edificio,Cubiculo)" +
                    "values (@Equipo,@Marca,@Modelo,@Descripcion,@AñosG,@Fecha,@empleado,@Dep,@Edif,@Cubiculo)";
                if (validaDato() == false && validaDuplicados() == false)
                {
                    string equipo = txtNombre.Text;
                    string Marca = txtMarca.Text;
                    string Modelo = txtModelo.Text;
                    string Descripcion = txtDescripcion.Text;
                    decimal garantia = numericGarantia.Value;
                    DateTime fecha = dateTimePicker.Value.Date;
                    int depa = cmbEmpleado.SelectedIndex;
                    string empleado = cmbEmpleado.Text.ToString();
                    Manejadora.Command.Parameters.AddWithValue("@Equipo", equipo);
                    Manejadora.Command.Parameters.AddWithValue("@Marca", Marca);
                    Manejadora.Command.Parameters.AddWithValue("@Modelo", Modelo);
                    Manejadora.Command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    Manejadora.Command.Parameters.AddWithValue("@AñosG", garantia);
                    Manejadora.Command.Parameters.AddWithValue("@Fecha", fecha);
                    Manejadora.Command.Parameters.AddWithValue("@empleado", empleado);
                    Manejadora.Command.Parameters.AddWithValue("@Dep", dep);
                    Manejadora.Command.Parameters.AddWithValue("@Edif", idEdificio);
                    Manejadora.Command.Parameters.AddWithValue("@Cubiculo", idCubiculo);

                    if (Manejadora.executeCommand(strComando) == true)
                    {
                        Manejadora.Command.Parameters.Clear();
                        MessageBox.Show("SE HA REGISTRADO EL NUEVO EQUIPO");
                        limpiaDatos();
                    }
                }
            }
        }
        public void limpiaDatos()
        {
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtnomEmpleado.Text = "";
            cmbEmpleado.SelectedIndex = -1;
            cmbEmpleado.Text = "-Seleccionar-";
            txtnomEmpleado.Text = "";
            txtDepartamento.Text = "";
            numericGarantia.Value = 0;
            LimpiarCubiculo();
            LimpiarEdificio();

        }

        public bool validaDuplicados()
        {
            bool RES = false;
            string nombre = txtNombre.Text;
            string consultaNombre = "select Equipo FROM Equipo WHERE Equipo ='" + nombre + "'";
            if (Manejadora.existe(consultaNombre))
            {
                MessageBox.Show("EL EQUIPO YA EXISTE", "Error");
                RES = true;
            }
            return RES;
        }




        public bool validaDato()
        {
            bool re = false;
            string equipo = txtNombre.Text;
            string Marca = txtMarca.Text;
            string Modelo = txtModelo.Text;
            string Descripcion = txtDescripcion.Text;
            int depa = cmbEmpleado.SelectedIndex;



            if (string.IsNullOrWhiteSpace(equipo))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL NOMBRE DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(Marca))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO LA MARCA DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL MODELO DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO LA DESCRIPCION DEL EQUIPO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbEmpleado.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL EMPLEADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbCubiculo.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL CUBICULO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            if (cmbEdifico.SelectedIndex == -1)
            {
                DialogResult kk = MessageBox.Show("ERROR: NO INGRESO EL EDIFICIO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                re = true;
            }
            return re;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnomEmpleado_TextChanged(object sender, EventArgs e)
        {

        }


        public void LimpiarCubiculo()
        {
            cmbCubiculo.Items.Clear();
            cmbCubiculo.Text = "-Seleccionar-";
        }

        public void LimpiarEdificio()
        {
            cmbEdifico.Items.Clear();
            cmbEdifico.Text = "-Seleccionar-";
        }



        private void cmbEdifico_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCubiculo();
            string nombre = cmbEdifico.Text;
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
            string strComando = "Select id from Edificio where Nombre= '" + nombre+"'";
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
                    idEdificio = Lector.GetValue(0).ToString();

                }
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
            Lector.Close();


           

             Lector = null;
             strComando = "select * from Cubiculo where Id_Edificio= " + idEdificio;
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
                    cmbCubiculo.Items.Add(Lector.GetValue(1).ToString());
                    idCubiculo = Lector.GetValue(0).ToString();

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


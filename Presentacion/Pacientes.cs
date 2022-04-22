using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using CapaComun.Cache;

namespace Presentacion
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        DominioPaciente objPaciente = new DominioPaciente();
        Cache_Datos_Pacientes Datos_Pacientes = new Cache_Datos_Pacientes();


        private void Listar_Pacientes()
        {
            DataTable dt = objPaciente.Listar_Pacientes();
            dgvPacientes.DataSource = dt;
        }

        private void buscar_Pacientes(string buscar)
        {
            DataTable dt = objPaciente.Buscar_Pacientes(buscar);
            dgvPacientes.DataSource = dt;
        }

        private void Limpiar()
        {
            txtIdaPaciente.Text = "";
            txtNombrePaciente.Text = "";
            txtApellidoPaciente.Text = "";
            txtTipoSangrePaciente.Text = "";
            txtCorreoPaciente.Text = "";
            txtTelefonoPaciente.Text = "";
            txtContactoEmergencia.Text = "";
            txtNombrePaciente.Focus();
        }

        private void insertar_Paciente()
        {
            try
            {

                Datos_Pacientes.Nombre_del_Paciente = txtNombrePaciente.Text;
                Datos_Pacientes.Apellido_del_Paciente = txtApellidoPaciente.Text;
                Datos_Pacientes.Tipo_Sangre = txtTipoSangrePaciente.Text;
                Datos_Pacientes.Fecha_Nacimiento = Convert.ToString(fechaNacimientoPaciente.Value);
                Datos_Pacientes.Correo_del_Paciente = txtCorreoPaciente.Text;
                Datos_Pacientes.Telefono_del_Paciente = txtTelefonoPaciente.Text;
                Datos_Pacientes.Contacto_Emergencia = txtContactoEmergencia.Text;

                int resultado = objPaciente.insertar_Nuevo_Paciente(Datos_Pacientes);

                if (resultado > 0)
                {
                    MessageBox.Show("Los datos fueron guardados");
                }
                else
                {
                    MessageBox.Show("Error al guardar Datos");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"ERROR: {Error.Message}");

            }

        }

        private void Validar_Guardado_Pacientes()
        {
            if (txtNombrePaciente.Text == "" || txtApellidoPaciente.Text == "" || txtTipoSangrePaciente.Text == "" ||
                txtCorreoPaciente.Text == "" || txtTelefonoPaciente.Text == "(   )   -" || 
                txtContactoEmergencia.Text == "(   )   -")
            {

                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                insertar_Paciente();
                Limpiar();
                Listar_Pacientes();
            }
        }

        private void Modificar_Paciente()
        {
            try
            {

                Datos_Pacientes.IdPaciente = Convert.ToInt32(txtIdaPaciente.Text);
                Datos_Pacientes.Nombre_del_Paciente = txtNombrePaciente.Text;
                Datos_Pacientes.Apellido_del_Paciente = txtApellidoPaciente.Text;
                Datos_Pacientes.Tipo_Sangre = txtTipoSangrePaciente.Text;
                Datos_Pacientes.Fecha_Nacimiento = Convert.ToString(fechaNacimientoPaciente.Value);
                Datos_Pacientes.Correo_del_Paciente = txtCorreoPaciente.Text;
                Datos_Pacientes.Telefono_del_Paciente = txtTelefonoPaciente.Text;
                Datos_Pacientes.Contacto_Emergencia = txtContactoEmergencia.Text;

                int resultado = objPaciente.Modificar_Paciente(Datos_Pacientes);

                if (resultado > 0)
                {
                    MessageBox.Show("Los datos fueron Modificados");
                }
                else
                {
                    MessageBox.Show("Error al Modificados");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"ERROR: {Error.Message}");

            }


        }

        private void Validar_Modificado_Paciente()
        {
            if (txtNombrePaciente.Text == "" || txtApellidoPaciente.Text == "" || txtTipoSangrePaciente.Text == "" ||
                txtCorreoPaciente.Text == "" || txtTelefonoPaciente.Text == "(   )   -" || txtIdaPaciente.Text == ""
                || txtContactoEmergencia.Text == "(   )   -")
            {

                MessageBox.Show("Por favor, Seleccione la fila a modificar");
            }
            else
            {
                Modificar_Paciente();
                Limpiar();
                Listar_Pacientes();
            }
        }

        private void Eliminar_Paciente()
        {
            try
            {

                int idPaciente = Convert.ToInt32(txtIdaPaciente.Text);


                int resultado = objPaciente.Eliminar_Paciente(idPaciente);

                if (resultado > 0)
                {
                    MessageBox.Show("Los datos fueron eliminados correctamente");
                }
                else
                {
                    MessageBox.Show("Error al elimimar los datos");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"ERROR: El dato esta siendo usado como referencia en otra tabla. {Error.Message}");

            }


        }

        private void Validar_Eliminado_Paciente()
        {
            if (txtIdaPaciente.Text != "")
            {
                if(MessageBox.Show("Esta Seguro que desea eliminar el dato Actual", "Eliminar dato",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Eliminar_Paciente();
                    Limpiar();
                    Listar_Pacientes();
                }
              
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione la fila a eliminar");
            }
        }

        private void Cargar_datos_filas()
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                txtIdaPaciente.Text = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                txtNombrePaciente.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPaciente.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
                fechaNacimientoPaciente.Value = Convert.ToDateTime (dgvPacientes.CurrentRow.Cells[3].Value);
                txtTipoSangrePaciente.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
                txtCorreoPaciente.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
                txtTelefonoPaciente.Text = dgvPacientes.CurrentRow.Cells[6].Value.ToString();
                txtContactoEmergencia.Text = dgvPacientes.CurrentRow.Cells[7].Value.ToString();
            }

        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            Listar_Pacientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_Pacientes(txtBuscar.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validar_Guardado_Pacientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Validar_Modificado_Paciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Validar_Eliminado_Paciente();
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar_datos_filas();
        }
    }
}

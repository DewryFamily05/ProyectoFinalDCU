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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        DominioConsulta objCosulta = new DominioConsulta();
        Cache_Datos_Consultas Datos_Consultas = new Cache_Datos_Consultas();


        public void Llenar_IdPacienteo()
        {
            try
            {
                objCosulta.Llenar_IdPaciente(txtIdPaciente);
            }
            catch (Exception Error)
            {
                MessageBox.Show($"ERROR: {Error.Message}");

            }

        }

        public void Llenar_IdMedico()
        {
            try
            {
                objCosulta.Llenar_IdMedico(txtIdMedico);
            }
            catch (Exception Error)
            {
                MessageBox.Show($"ERROR: {Error.Message}");

            }

        }


        private void Listar_Consultas()
        {
            DataTable dt = objCosulta.Listar_Consultas();
            dgvConsultas.DataSource = dt;
        }


        private void buscar_Consultas(string buscar)
        {
            DataTable dt = objCosulta.Buscar_Consultas(buscar);
            dgvConsultas.DataSource = dt;
        }

        private void Limpiar()
        {
            txtIdCunsulta.Text = "";
            txtIdMedico.Text = "";
            txtIdPaciente.Text = "";
            txtTemperatura.Text = "";
            txtPresionAlterial.Text = "";
            txtMotivoConsulta.Text = "";
            txtTratamiento.Text = "";
            txtDiagnostico.Text = "";
            txtsintomas.Text = "";
            
        }


        private void insertar_Consulta()
        {
            try
            {

                Datos_Consultas.IdPaciente = Convert.ToInt32( txtIdPaciente.Text);
                Datos_Consultas.IdMedico = Convert.ToInt32( txtIdMedico.Text);
                Datos_Consultas.Motivo = txtMotivoConsulta.Text;
                Datos_Consultas.Fecha = Convert.ToString(fechaConsulta.Value);
                Datos_Consultas.Sintomas = txtsintomas.Text;
                Datos_Consultas.Diagnostico = txtDiagnostico.Text;
                Datos_Consultas.Tratamiento = txtTratamiento.Text;
                Datos_Consultas.Presion_Arterial = txtPresionAlterial.Text;
                Datos_Consultas.Temperatura = Convert.ToDouble( txtTemperatura.Text);

                int resultado = objCosulta.insertar_Nueva_Consulta(Datos_Consultas);

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


        private void Validar_Guardado_Consulta()
        {
            if (txtIdMedico.Text == "" || txtIdPaciente.Text == "" || txtMotivoConsulta.Text == "" || txtTemperatura.Text == "" ||
                txtPresionAlterial.Text == "" || txtTratamiento.Text == "" || txtDiagnostico.Text == "" || txtsintomas.Text == "")
            {

                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                insertar_Consulta();
                Limpiar();
                Listar_Consultas();
            }
        }


        private void Modificar_Consulta()
        {
            try
            {
                Datos_Consultas.IdConsulta = Convert.ToInt32(txtIdCunsulta.Text);
                Datos_Consultas.IdPaciente = Convert.ToInt32(txtIdPaciente.Text);
                Datos_Consultas.IdMedico = Convert.ToInt32(txtIdMedico.Text);
                Datos_Consultas.Motivo = txtMotivoConsulta.Text;
                Datos_Consultas.Fecha = Convert.ToString(fechaConsulta.Value);
                Datos_Consultas.Sintomas = txtsintomas.Text;
                Datos_Consultas.Diagnostico = txtDiagnostico.Text;
                Datos_Consultas.Tratamiento = txtTratamiento.Text;
                Datos_Consultas.Presion_Arterial = txtPresionAlterial.Text;
                Datos_Consultas.Temperatura = Convert.ToDouble(txtTemperatura.Text);

                int resultado = objCosulta.Modificar_Paciente(Datos_Consultas);

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

        private void Validar_Modificado_Consulta()
        {
            if (txtIdMedico.Text == "" || txtIdPaciente.Text == "" || txtMotivoConsulta.Text == "" || txtTemperatura.Text == "" ||
                txtPresionAlterial.Text == "" || txtTratamiento.Text == "" || txtDiagnostico.Text == "" || txtsintomas.Text == "" 
                || txtIdCunsulta.Text == "")
            {

                MessageBox.Show("Por favor, Seleccione la fila a modificar");
            }
            else
            {
                Modificar_Consulta();
                Limpiar();
                Listar_Consultas();
            }
        }


        private void Eliminar_Consulta()
        {
            try
            {

                int idConsulta = Convert.ToInt32(txtIdCunsulta.Text);


                int resultado = objCosulta.Eliminar_Consulta(idConsulta);

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
                MessageBox.Show($"ERROR: {Error.Message}");

            }


        }

        private void Validar_Eliminado_Consulta()
        {
            if (txtIdCunsulta.Text != "")
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el dato Actual", "Eliminar dato",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Eliminar_Consulta();
                    Limpiar();
                    Listar_Consultas();
                } 
            }
            else
            {
                    MessageBox.Show("Por favor, Seleccione la fila a eliminar");
            }
        }

        private void Cargar_datos_filas()
        {
            if (dgvConsultas.SelectedRows.Count > 0)
            {
                txtIdCunsulta.Text = dgvConsultas.CurrentRow.Cells[0].Value.ToString();
                txtIdPaciente.Text = dgvConsultas.CurrentRow.Cells[1].Value.ToString();
                txtIdMedico.Text = dgvConsultas.CurrentRow.Cells[2].Value.ToString();
                txtMotivoConsulta.Text = dgvConsultas.CurrentRow.Cells[3].Value.ToString();
                fechaConsulta.Value = Convert.ToDateTime(dgvConsultas.CurrentRow.Cells[4].Value);
                txtsintomas.Text = dgvConsultas.CurrentRow.Cells[5].Value.ToString();
                txtDiagnostico.Text = dgvConsultas.CurrentRow.Cells[6].Value.ToString();
                txtTratamiento.Text = dgvConsultas.CurrentRow.Cells[7].Value.ToString();
                txtPresionAlterial.Text = dgvConsultas.CurrentRow.Cells[8].Value.ToString();
                txtTemperatura.Text = dgvConsultas.CurrentRow.Cells[9].Value.ToString();
            }

        }













        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Llenar_IdPacienteo();
            Llenar_IdMedico();
            Listar_Consultas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_Consultas(txtBuscar.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validar_Guardado_Consulta();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Validar_Modificado_Consulta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Validar_Eliminado_Consulta();
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar_datos_filas();
        }
    }
}

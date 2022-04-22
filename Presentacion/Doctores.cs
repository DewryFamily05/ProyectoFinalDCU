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
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
        }

        DominioUsuario ObjDominio = new DominioUsuario();
        Cache_Datos_medico Datos_Medico = new Cache_Datos_medico();
        
        private void Listar_Medicos()
        {
            DataTable dt = ObjDominio.Listar();
            dgvDoctores.DataSource = dt;
        }

        private void buscar_Medico(string buscar)
        {
            DataTable dt = ObjDominio.Buscar(buscar);
            dgvDoctores.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Doctores_Load(object sender, EventArgs e)
        {
            Listar_Medicos();
        }

        private void Limpiar()
        {
            txtIdMedico.Text = "";
            txtApellidoMedico.Text = "";
            txtCedulaMedico.Text = "";
            txtCorreoMedico.Text = "";
            txtEspecialidadMedico.Text = "";
            txtEstadoMedico.Text = "";
            txtTelefonoMedico.Text = "";
            txtNombreMedico.Text = "";
            txtNombreMedico.Focus();
        }

        private void insertar()
        {
            try
            {

                Datos_Medico.Nombre_del_Medico = txtNombreMedico.Text;
                Datos_Medico.Apellido_del_Medico = txtApellidoMedico.Text;
                Datos_Medico.Cedula_del_Medico = txtCedulaMedico.Text;
                Datos_Medico.Correo_del_Medico = txtCorreoMedico.Text;
                Datos_Medico.Especialidad_del_Medico = txtEspecialidadMedico.Text;
                Datos_Medico.Estado_del_Medico = txtEstadoMedico.Text;
                Datos_Medico.Telefono_del_Medico = txtTelefonoMedico.Text;

                int resultado = ObjDominio.insertar_Nuevo_Doctor(Datos_Medico);

                if(resultado > 0)
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

        private void Validar_Guardado()
        {
            if(txtApellidoMedico.Text == "" || txtCedulaMedico.Text == "   -       -" || 
                txtCorreoMedico.Text == "" ||txtEspecialidadMedico.Text == "" ||
                txtEstadoMedico.Text == "" ||txtTelefonoMedico.Text == "(   )   -" || 
                txtNombreMedico.Text == "")
            {

                MessageBox.Show("Porfavor rellene todos los campos");
            }
            else
            {
                insertar();
                Limpiar();
                Listar_Medicos();
            }
        }


        private void Modificar()
        {
            try
            {

                Datos_Medico.IdMedico = Convert.ToInt32(txtIdMedico.Text);
                Datos_Medico.Nombre_del_Medico = txtNombreMedico.Text;
                Datos_Medico.Apellido_del_Medico = txtApellidoMedico.Text;
                Datos_Medico.Cedula_del_Medico = txtCedulaMedico.Text;
                Datos_Medico.Correo_del_Medico = txtCorreoMedico.Text;
                Datos_Medico.Especialidad_del_Medico = txtEspecialidadMedico.Text;
                Datos_Medico.Estado_del_Medico = txtEstadoMedico.Text;
                Datos_Medico.Telefono_del_Medico = txtTelefonoMedico.Text;

                int resultado = ObjDominio.Modificar_Doctor(Datos_Medico);

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

        private void Validar_Modificado()
        {
            if (txtApellidoMedico.Text == "" || txtCedulaMedico.Text == "   -       -" ||
                txtCorreoMedico.Text == "" || txtEspecialidadMedico.Text == "" ||
                txtEstadoMedico.Text == "" || txtTelefonoMedico.Text == "(   )   -" ||
                txtNombreMedico.Text == "" || txtIdMedico.Text == "")
            {

                MessageBox.Show("Por favor, Seleccione la fila a modificar");
            }
            else
            {
                Modificar();
                Limpiar();
                Listar_Medicos();
            }
        }

        private void Eliminar()
        {
            try
            {

                int idMedico = Convert.ToInt32(txtIdMedico.Text);


                int resultado = ObjDominio.Eliminar_Doctor(idMedico);

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

        private void Validar_Eliminado()
        {
            if (txtIdMedico.Text != "")
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el dato Actual", "Eliminar dato",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Eliminar();
                    Limpiar();
                    Listar_Medicos();
                } 
            }
            else
            {
             MessageBox.Show("Por favor, Seleccione la fila a eliminar");
            }
        }

        private void Cargar_datos_filas()
        {
                if (dgvDoctores.SelectedRows.Count > 0)
                {
                    txtIdMedico.Text = dgvDoctores.CurrentRow.Cells[0].Value.ToString();
                    txtNombreMedico.Text = dgvDoctores.CurrentRow.Cells[1].Value.ToString();
                    txtApellidoMedico.Text = dgvDoctores.CurrentRow.Cells[2].Value.ToString();
                    txtCedulaMedico .Text = dgvDoctores.CurrentRow.Cells[3].Value.ToString();
                    txtEspecialidadMedico.Text = dgvDoctores.CurrentRow.Cells[4].Value.ToString();
                    txtTelefonoMedico.Text = dgvDoctores.CurrentRow.Cells[5].Value.ToString();
                    txtCorreoMedico.Text = dgvDoctores.CurrentRow.Cells[6].Value.ToString();
                    txtEstadoMedico.Text = dgvDoctores.CurrentRow.Cells[7].Value.ToString();
                }
            
        }



   


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Validar_Guardado();
        }

        private void dgvDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cargar_datos_filas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Validar_Modificado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Validar_Eliminado();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_Medico(txtBuscar.Text);
        }
    }
}
